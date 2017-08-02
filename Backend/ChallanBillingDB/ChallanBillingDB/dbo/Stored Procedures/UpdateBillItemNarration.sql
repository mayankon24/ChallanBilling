CREATE PROCEDURE [dbo].[UpdateBillItemNarration]
(
	 @Bill_Item_Id INT
    ,@Narration NVARCHAR(1000)
	,@BillItem_Narration_Id INt
)
AS
	SET NOCOUNT OFF;
	
	UPDATE [B_BillItem_Narration]
	   SET [Narration] = @Narration
	 WHERE BillItem_Narration_Id = @BillItem_Narration_Id
	
	select 1