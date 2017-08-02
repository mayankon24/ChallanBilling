CREATE PROCEDURE [dbo].[UpdateItemName]
(
	@Item_Name nvarchar(max)
	,@HSN_Code nvarchar(50)
	,@Item_id int
)
AS
	SET NOCOUNT OFF;
UPDATE [Item]
   SET [Item_Name] = @Item_Name
   ,HSN_Code = @HSN_Code
 WHERE Item_id = @Item_id