CREATE PROCEDURE [dbo].[SelectBillItemNarration_ByBillitemId]
(
	@Bill_Item_Id INt
)
AS
	SET NOCOUNT OFF;
	
	SELECT [BillItem_Narration_Id]
		  ,[Bill_Item_Id]
		  ,[Narration]
	  FROM [B_BillItem_Narration]
	WHERE Bill_Item_Id = @Bill_Item_Id