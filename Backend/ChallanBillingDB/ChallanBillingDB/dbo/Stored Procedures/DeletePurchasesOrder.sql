CREATE PROCEDURE [dbo].[DeletePurchasesOrder]
(
	@Purchases_Order_Id int
)
AS
	SET NOCOUNT OFF;
DELETE FROM [M_PURCHASES_ORDER] 
WHERE ([Purchases_Order_Id] = @Purchases_Order_Id)