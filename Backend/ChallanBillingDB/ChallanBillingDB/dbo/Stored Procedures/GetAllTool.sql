
create procedure [dbo].[GetAllTool]

as 
SELECT [Tool_Id]
      ,[Tool_Name]    
  FROM [Lk_Tool]
  where [IsActive] =1