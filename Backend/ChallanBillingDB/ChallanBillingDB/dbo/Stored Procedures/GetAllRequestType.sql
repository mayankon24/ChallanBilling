
CREATE procedure [dbo].[GetAllRequestType]

as 
SELECT [Request_Type_Id]
      ,[Request_Type_Name]     
  FROM [Lk_Request_Type]
  where [IsActive] =1