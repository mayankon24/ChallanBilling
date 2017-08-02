create PROCEDURE [dbo].[DeleteItemName]
(
	@Item_id int
)
AS
	SET NOCOUNT OFF;
delete [Item]
 WHERE Item_id = @Item_id