CREATE PROCEDURE [dbo].[DeleteBilllItem]
(	 
    @Bill_Item_Id INT
)
AS
	SET NOCOUNT OFF;
	
	DELETE FROM [B_BILL_ITEM]
      WHERE Bill_Item_Id = @Bill_Item_Id