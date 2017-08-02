
CREATE PROCEDURE [dbo].[SelectItemNameAll]

AS
	SET NOCOUNT OFF;
SELECT [Item_Id]
      ,[Item_Name]
	  ,[HSN_Code]
  FROM [Item]
  order by Item_Name