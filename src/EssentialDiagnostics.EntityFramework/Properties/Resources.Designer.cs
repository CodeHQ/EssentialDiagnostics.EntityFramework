﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EssentialDiagnostics.EntityFramework.Properties {
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("EssentialDiagnostics.EntityFramework.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to GRANT EXECUTE ON dbo.diagnostics_Trace_AddEntry TO diagnostics_Trace_Writer
        ///GRANT SELECT ON dbo.diagnostics_Trace TO diagnostics_Trace_Reader
        ///.
        /// </summary>
        internal static string InitDb_DiagnosticTrace_Grants {
            get {
                return ResourceManager.GetString("InitDb_DiagnosticTrace_Grants", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to EXEC sp_addrole N&apos;diagnostics_Trace_Writer&apos;
        ///EXEC sp_addrole N&apos;diagnostics_Trace_Reader&apos;.
        /// </summary>
        internal static string InitDb_DiagnosticTrace_Roles {
            get {
                return ResourceManager.GetString("InitDb_DiagnosticTrace_Roles", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to CREATE PROCEDURE dbo.diagnostics_Trace_AddEntry
        ///    @ApplicationName nvarchar(256),
        ///	@Source nvarchar(64),
        ///	@Id int,
        ///	@EventType nvarchar(32),
        ///	@UtcDateTime datetime,
        ///	@MachineName nvarchar(32),
        ///	@AppDomainFriendlyName nvarchar(512),
        ///	@ProcessId int,
        ///	@ThreadName nvarchar(512),
        ///	@Message nvarchar(1500),
        ///	@ActivityId uniqueidentifier,
        ///	@RelatedActivityId uniqueidentifier,
        ///	@LogicalOperationStack nvarchar(512),
        ///	@Data ntext
        ///AS
        ///BEGIN
        ///    DECLARE @ErrorCode int
        ///    SET @ErrorCode = 0
        ///
        ///    INSERT INTO dbo.diagno [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string InitDb_DiagnosticTrace_StoredProc {
            get {
                return ResourceManager.GetString("InitDb_DiagnosticTrace_StoredProc", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to CREATE TABLE [dbo].[diagnostics_Trace](
        ///  ApplicationName nvarchar(256) NOT NULL,
        ///TraceId uniqueidentifier NOT NULL PRIMARY KEY NONCLUSTERED DEFAULT NEWID(),
        ///[Source] nvarchar(64) NULL,
        ///Id int NOT NULL default 0,
        ///EventType nvarchar(32) NOT NULL,
        ///[UtcDateTime] datetime NOT NULL,
        ///MachineName nvarchar(32) NOT NULL,
        ///AppDomainFriendlyName nvarchar(512) NOT NULL,
        ///ProcessId int NOT NULL default 0,
        ///ThreadName nvarchar(512) NULL,
        ///[Message] nvarchar(1500) NULL,
        ///ActivityId uniqueidentifier NULL,
        ///RelatedActivityId uniq [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string InitDb_DiagnosticTrace_Table {
            get {
                return ResourceManager.GetString("InitDb_DiagnosticTrace_Table", resourceCulture);
            }
        }
    }
}
