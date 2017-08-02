

CREATE PROCEDURE [dbo].[AddRequest] (
	@IP nvarchar(50),
    @Name nvarchar(50),
	@NetMask nvarchar(50) NULL,
	@Description nvarchar(500) NULL,
    @WinChange_DeviceID nvarchar(50),
    @WinChange_DeviceName nvarchar(50),
   
    @NCM_Host_Id int,
	@NCM_Group_Id int,
    @NCM_Object_SubType nvarchar(50),
    @NCM_SNMP_Version_Id int,
	@NCM_Community nvarchar(50),

    @CiscoACS_Host_Id int NULL,
	@CiscoACS_Device_Id int NULL,
	@CiscoACS_Location nvarchar(50) NULL,
	@CiscoACS_DeviceType nvarchar(50) NULL,
	@CiscoACS_SharedSecret nvarchar(150) NULL,
	@CiscoACS_LegacyTACACS bit NULL,
	@CiscoACS_SingleConnect bit NULL,


    @PRTG_Host_Id int,
	@PRTG_Group_Id int,
	@PRTG_Device_Id int,
    @Hostmonitor_Port nvarchar(50),
    @Request_Type_Id int,
	@Source_Id int,
	@Tool_Ids dbo.udt_Ids readonly,
    @LastModifiedBy nvarchar(100),  
	@return_Status INT OUTPUT
)
AS
BEGIN TRY
BEGIN TRANSACTION


declare @Request_Id bigint
declare @Current_date datetime = getutcdate()
declare @Request_Guid uniqueidentifier = newId()

INSERT INTO [dbo].[M_Request] (
	[IP]
	,[Name]
	,[NetMask]
	,[Description]
	,[WinChange_DeviceID]
	,[WinChange_DeviceName]
	,NCM_Host_Id
	,NCM_Group_Id
	,NCM_Object_SubType
	,NCM_SNMP_Version_Id
	,NCM_Community
	,CiscoACS_Host_Id
	,CiscoACS_Device_Id
	,CiscoACS_Location
	,CiscoACS_DeviceType
	,CiscoACS_SharedSecret
	,CiscoACS_LegacyTACACS
	,CiscoACS_SingleConnect
	,[PRTG_Group_Id]
	,PRTG_Device_Id
	,[PRTG_Host_Id]
	,[Hostmonitor_Port]
	,[Request_Type_Id]
	,[Source_Id]
	,[Request_Guid]
	,[CreatedBy]
	,[CreatedUTCDate]
	,[LastModifiedBy]
	,[LastModifiedUTCDate]
	,[IsActive]
	)
VALUES (
	@IP
	,@Name
	,@NetMask
	,@Description
	,@WinChange_DeviceID
	,@WinChange_DeviceName
	,@NCM_Host_Id
	,@NCM_Group_Id
	,@NCM_Object_SubType
	,@NCM_SNMP_Version_Id
	,@NCM_Community
	,@CiscoACS_Host_Id
	,@CiscoACS_Device_Id
	,@CiscoACS_Location
	,@CiscoACS_DeviceType
	,@CiscoACS_SharedSecret
	,@CiscoACS_LegacyTACACS
	,@CiscoACS_SingleConnect
	,@PRTG_Group_Id
	,@PRTG_Device_Id
	,@PRTG_Host_Id
	,@Hostmonitor_Port
	,@Request_Type_Id
	,@Source_Id
	,@Request_Guid
	,@LastModifiedBy
	,@Current_date
	,@LastModifiedBy
	,@Current_date
	,1
	)

         

            SELECT @Request_Id = SCOPE_IdENTITY() 

	INSERT INTO [dbo].[M_Process]
           ([Request_Id]
           ,[Tool_Id]
		   ,[Request_Type_Id]
		   ,[Action_By]
		   ,[Action_Time] 
           ,[Request]
           ,[Response]
           ,[Status_Id]
           ,[CreatedBy]
           ,[CreatedUTCDate]
           ,[LastModifiedBy]
           ,[LastModifiedUTCDate]
           ,[IsActive])
     select
           @Request_Id
           ,Id
		   ,@Request_Type_Id
		   ,@LastModifiedBy
		   ,getutcdate()
           ,null
           ,null
           ,1 -- Awaiting
           ,@LastModifiedBy
           ,@Current_date
           ,@LastModifiedBy
           ,@Current_date
           ,1
	from @Tool_Ids

     select @Request_Id

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
        exec InsertErrorLog null, 'Database', 'AddRequest', @error_message

END CATCH