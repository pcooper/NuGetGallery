﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34003
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NuCmd {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Strings {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Strings() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("NuCmd.Strings", typeof(Strings).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Received &apos;{0} {1}&apos; response from server. TODO: Decode error details.
        /// </summary>
        internal static string Commands_HttpError {
            get {
                return ResourceManager.GetString("Commands_HttpError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Using service at: {0}.
        /// </summary>
        internal static string Commands_UsingServiceUri {
            get {
                return ResourceManager.GetString("Commands_UsingServiceUri", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Fatal Error: Command type &apos;{0}&apos; is not convertable to &apos;{1}&apos;..
        /// </summary>
        internal static string Program_CommandNotConvertible {
            get {
                return ResourceManager.GetString("Program_CommandNotConvertible", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Missing command..
        /// </summary>
        internal static string Program_MissingCommand {
            get {
                return ResourceManager.GetString("Program_MissingCommand", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Command not found: &apos;{0}&apos;..
        /// </summary>
        internal static string Program_NoSuchCommand {
            get {
                return ResourceManager.GetString("Program_NoSuchCommand", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Command &apos;{0}&apos; not found in &apos;{1}&apos; group..
        /// </summary>
        internal static string Program_NoSuchCommandInGroup {
            get {
                return ResourceManager.GetString("Program_NoSuchCommandInGroup", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to NuCmd Usage:
        ///  nucmd &lt;command&gt;
        ///  nucmd &lt;group&gt; &lt;command&gt;
        ///
        ///For a list of commands and groups, type &apos;nucmd help&apos;.
        /// </summary>
        internal static string Usage {
            get {
                return ResourceManager.GetString("Usage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Created Invocation: {0}.
        /// </summary>
        internal static string Work_InvokeCommand_CreatedInvocation {
            get {
                return ResourceManager.GetString("Work_InvokeCommand_CreatedInvocation", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Creating Invocation of {0} with payload {1}.
        /// </summary>
        internal static string Work_InvokeCommand_CreatingInvocation {
            get {
                return ResourceManager.GetString("Work_InvokeCommand_CreatingInvocation", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Error deserializing payload: {0}.
        /// </summary>
        internal static string Work_InvokeCommand_PayloadInvalid {
            get {
                return ResourceManager.GetString("Work_InvokeCommand_PayloadInvalid", resourceCulture);
            }
        }
    }
}