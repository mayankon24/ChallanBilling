CREATE PROCEDURE [dbo].[DeleteBillItemNarration]
(
	@BillItem_Narration_Id INt
)
AS
	SET NOCOUNT OFF;
	
	DELETE B_BillItem_Narration
	 WHERE BillItem_Narration_Id = @BillItem_Narration_Id
	
	select 1