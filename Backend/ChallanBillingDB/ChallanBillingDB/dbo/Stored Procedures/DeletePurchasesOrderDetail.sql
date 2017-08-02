CREATE PROCEDURE [dbo].[DeletePurchasesOrderDetail]
(
	@Purchases_Order_Id int
)
AS
	SET NOCOUNT OFF;
DELETE FROM [M_PURCHASES_ORDER_DETAIL]
 WHERE ((Purchases_Order_Id = @Purchases_Order_Id))