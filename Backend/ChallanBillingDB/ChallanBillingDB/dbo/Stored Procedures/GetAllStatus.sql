
create procedure [dbo].[GetAllStatus]

as 
SELECT [Status_Id]
      ,[Status_Name]      
  FROM [dbo].[Lk_Status]
  where [IsActive] =1