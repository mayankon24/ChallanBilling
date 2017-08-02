create PROCEDURE [dbo].[SelectItemNameById]
(
	@Item_id int
)
AS
	SET NOCOUNT OFF;
SELECT [Item_Id]
      ,[Item_Name]
  FROM [Item]
  where Item_id = @Item_id