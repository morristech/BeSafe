﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BeSafe.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("BeSafe.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to BeSafe.
        /// </summary>
        internal static string ApplicationName {
            get {
                return ResourceManager.GetString("ApplicationName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to \??\.
        /// </summary>
        internal static string DriveMapMustEscapeChars {
            get {
                return ResourceManager.GetString("DriveMapMustEscapeChars", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT ExecutablePath FROM Win32_Process WHERE ProcessID = {0}.
        /// </summary>
        internal static string ExecutablaPathQuery {
            get {
                return ResourceManager.GetString("ExecutablaPathQuery", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ExecutablePath.
        /// </summary>
        internal static string ExecutablePathField {
            get {
                return ResourceManager.GetString("ExecutablePathField", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\DriveIcons.
        /// </summary>
        internal static string ExplorerDrivesRegistryPath {
            get {
                return ResourceManager.GetString("ExplorerDrivesRegistryPath", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to FileName.
        /// </summary>
        internal static string FileNameField {
            get {
                return ResourceManager.GetString("FileNameField", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT ProcessID, FileName FROM Win32_ModuleLoadTrace.
        /// </summary>
        internal static string ModuleWatcherQuery {
            get {
                return ResourceManager.GetString("ModuleWatcherQuery", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ParentProcessID.
        /// </summary>
        internal static string ParentProcessIDFiled {
            get {
                return ResourceManager.GetString("ParentProcessIDFiled", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to BeSafePipe.
        /// </summary>
        internal static string PipeName {
            get {
                return ResourceManager.GetString("PipeName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ProcessID.
        /// </summary>
        internal static string ProcessIDField {
            get {
                return ResourceManager.GetString("ProcessIDField", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ProcessName.
        /// </summary>
        internal static string ProcessNameField {
            get {
                return ResourceManager.GetString("ProcessNameField", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT ProcessID, ParentProcessID, ProcessName FROM Win32_ProcessStartTrace.
        /// </summary>
        internal static string ProcessWatcherQuery {
            get {
                return ResourceManager.GetString("ProcessWatcherQuery", resourceCulture);
            }
        }
    }
}
