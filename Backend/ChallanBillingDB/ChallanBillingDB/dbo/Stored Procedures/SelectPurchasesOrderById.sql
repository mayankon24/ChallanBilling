CREATE PROCEDURE [dbo].[SelectPurchasesOrderById]
(
	@Purchases_Order_Id int
)
AS
	SET NOCOUNT ON;
	SELECT Purchases_Order_Id
		   , Company_id
		   , Date
		   , Purchases_Order_No
		FROM M_PURCHASES_ORDER
	Where Purchases_Order_Id = @Purchases_Order_Id