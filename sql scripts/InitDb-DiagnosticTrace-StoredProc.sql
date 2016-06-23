CREATE PROCEDURE dbo.diagnostics_Trace_AddEntry
    @ApplicationName nvarchar(256),
	@Source nvarchar(64),
	@Id int,
	@EventType nvarchar(32),
	@UtcDateTime datetime,
	@MachineName nvarchar(32),
	@AppDomainFriendlyName nvarchar(512),
	@ProcessId int,
	@ThreadName nvarchar(512),
	@Message nvarchar(1500),
	@ActivityId uniqueidentifier,
	@RelatedActivityId uniqueidentifier,
	@LogicalOperationStack nvarchar(512),
	@Data ntext
AS
BEGIN
    DECLARE @ErrorCode int
    SET @ErrorCode = 0

    INSERT INTO dbo.diagnostics_Trace
                ( ApplicationName,
                  [Source],
                  Id,
                  EventType,
                  [UtcDateTime],
                  MachineName,
                  AppDomainFriendlyName,
                  ProcessId,
                  ThreadName,
                  [Message],
                  ActivityId,
                  RelatedActivityId,
                  LogicalOperationStack,
                  Data )
         VALUES ( @ApplicationName,
                  @Source,
                  @Id,
                  @EventType,
                  @UtcDateTime,
                  @MachineName,
                  @AppDomainFriendlyName,
                  @ProcessId,
                  @ThreadName,
                  @Message,
                  @ActivityId,
                  @RelatedActivityId,
                  @LogicalOperationStack,
                  @Data )

    IF( @@ERROR <> 0 )
    BEGIN
        SET @ErrorCode = -1
        GOTO Cleanup
    END

    RETURN 0

Cleanup:

    RETURN @ErrorCode

END
