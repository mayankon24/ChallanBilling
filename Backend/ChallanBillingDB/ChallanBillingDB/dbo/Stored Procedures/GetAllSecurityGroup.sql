
create procedure [dbo].[GetAllSecurityGroup]

as 
SELECT [Role_Id]
      ,[SecurityGroup_Id]
      ,[SecurityGroup_Name]     
  FROM [dbo].[Lk_Role]
  where [IsActive] =1