CREATE  PROCEDURE [dbo].[DeletePurchasesOrderDetail_ById]
(
	@Purchase_Order_Detail_Id int
)
AS
	SET NOCOUNT OFF;
DELETE FROM [M_PURCHASES_ORDER_DETAIL]
 WHERE ((Purchase_Order_Detail_Id = @Purchase_Order_Detail_Id))