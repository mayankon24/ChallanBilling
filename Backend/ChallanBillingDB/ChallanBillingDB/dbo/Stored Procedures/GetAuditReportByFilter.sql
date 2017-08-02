
CREATE procedure [dbo].[GetAuditReportByFilter]
(

	 @Tool_Id int
	,@Status_Id int
	,@Request_Type_Id int
	,@LastModifiedBy nvarchar(100)
)
as 
SET FMTONLY OFF

--select val
--,seq
--into #ModifiedBy
--from dbo.f_split(@LastModifiedBy, ',')


SELECT [Process_Id]
      ,P.Request_Id
	  ,R.IP
	  ,R.Name
      ,T.Tool_Id
	  ,T.Tool_Name      
      ,S.Status_Id
	  ,S.Status_Name
	  ,RT.Request_Type_Id
	  ,RT.Request_Type_Name
      ,P.Action_By  
	  ,P.Action_Time       
  FROM [M_Process] P
  inner join [dbo].[M_Request] R on R.Request_Id= P.Request_Id
  left join Lk_Tool T On T.Tool_Id = P.Tool_Id and T.IsActive = 1
  left join Lk_Status S On S.Status_Id = P.Status_Id and T.IsActive = 1
  left join Lk_Request_Type RT on RT.Request_Type_Id = P.Request_Type_Id
  where P.IsActive = 1
  and (
		  @Tool_Id IS NULL
		OR P.Tool_Id = @Tool_Id
	  )
  and (
		  @Status_Id IS NULL
		OR P.Status_Id = @Status_Id
	  )
  and (
		  @LastModifiedBy IS NULL
		OR P.LastModifiedBy in ( @LastModifiedBy)
	  )