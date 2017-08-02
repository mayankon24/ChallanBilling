
CREATE PROCEDURE [dbo].[UpdateProcessStatus] (	
	@Request_Id bigint,
    @Tool_Id int,
    @Status_Id int,
	@Request nvarchar(max),  
	@Response nvarchar(max),  
    @LastModifiedBy nvarchar(100),  
	@return_Status INT OUTPUT
)
AS
BEGIN TRY
BEGIN TRANSACTION

UPDATE [dbo].[M_Process]
   SET [Request] = @Request
      ,[Response] = @Response
      ,[Status_Id] = @Status_Id
      ,[LastModifiedBy] = @LastModifiedBy
      ,[LastModifiedUTCDate] = getutcdate()     
 WHERE Request_Id = @Request_Id
 and Tool_Id = @Tool_Id
 
	 SET @return_status = 1
        COMMIT TRANSACTION
END TRY

BEGIN CATCH
        ROLLBACK TRANSACTION

        SET @return_status = - 1
        declare @error_message nvarchar(max)
        SELECT @error_message = 
            'ERROR_NUMBER=' +cast(isnull(ERROR_NUMBER(), '') as nvarchar(10))+ ' || '+
                        'ERROR_SEVERITY=' +cast(isnull(ERROR_SEVERITY(), '')as nvarchar(10))+ ' || '+
                        'ERROR_STATE=' +cast(isnull(ERROR_STATE(), '')as nvarchar(10))+ ' || '+
                        'ERROR_PROCEDURE=' +isnull(ERROR_PROCEDURE(), '')+ ' || '+
                        'ERROR_LINE=' +cast(isnull(ERROR_LINE(), '')as nvarchar(10))+ ' || '+
                        'ERROR_MESSAGE=' +isnull(ERROR_MESSAGE(), '')+ ' || '                                
        exec InsertErrorLog null, 'Database', 'UpdateProcessStatus', @error_message
END CATCH