﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NuGetGallery.Commands;

namespace NuGetGallery.Statistics
{
    public class AggregateStatsCommand : Command<AggregateStats> { }
    public class AggregateStatsCommandHandler : CommandHandler<AggregateStatsCommand, AggregateStats>
    {
        public static readonly string Sql = @"SELECT 
                (SELECT COUNT([Key]) FROM PackageRegistrations pr 
                        WHERE EXISTS (SELECT 1 FROM Packages p WHERE p.PackageRegistrationKey = pr.[Key] AND p.Listed = 1)) AS UniquePackages,
                (SELECT COUNT([Key]) FROM Packages WHERE Listed = 1) AS TotalPackages,
                (SELECT TotalDownloadCount FROM GallerySettings) AS DownloadCount";

        public IEntitiesContext DatabaseContext { get; private set; }

        public AggregateStatsCommandHandler(IEntitiesContext databaseContext)
        {
            DatabaseContext = databaseContext;
        }

        public override AggregateStats Execute(AggregateStatsCommand cmd)
        {
            return DatabaseContext.Sql(Sql, reader =>
                reader.Read() ?
                    new AggregateStats
                    {
                        UniquePackages = reader.IsDBNull(0) ? 0 : reader.GetInt32(0),
                        TotalPackages = reader.IsDBNull(1) ? 0 : reader.GetInt32(1),
                        Downloads = reader.IsDBNull(2) ? 0 : reader.GetInt64(2),
                    } : 
                    new AggregateStats(), 
                commandTimeout: 200, 
                behavior: CommandBehavior.CloseConnection | CommandBehavior.SingleRow);
        }
    }
}
