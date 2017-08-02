

CREATE procedure [dbo].[GetAllTool_Host]

as 
SELECT [Host_Id]
      ,[Host_Name]
	  ,Tool_Id      
  FROM [Lk_Tool_Host]
  where [IsActive] =1