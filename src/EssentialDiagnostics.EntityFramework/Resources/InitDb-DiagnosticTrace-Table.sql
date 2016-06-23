CREATE TABLE [dbo].[diagnostics_Trace](
  ApplicationName nvarchar(256) NOT NULL,
TraceId uniqueidentifier NOT NULL PRIMARY KEY NONCLUSTERED DEFAULT NEWID(),
[Source] nvarchar(64) NULL,
Id int NOT NULL default 0,
EventType nvarchar(32) NOT NULL,
[UtcDateTime] datetime NOT NULL,
MachineName nvarchar(32) NOT NULL,
AppDomainFriendlyName nvarchar(512) NOT NULL,
ProcessId int NOT NULL default 0,
ThreadName nvarchar(512) NULL,
[Message] nvarchar(1500) NULL,
ActivityId uniqueidentifier NULL,
RelatedActivityId uniqueidentifier NULL,
LogicalOperationStack nvarchar(512) NULL,
Data ntext NULL,
)
CREATE CLUSTERED INDEX diagnostics_Trace_index ON diagnostics_Trace(ApplicationName, [UtcDateTime])