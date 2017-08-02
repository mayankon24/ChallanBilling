CREATE PROCEDURE [dbo].[SelectPurchasesOrderAll]
AS
	SET NOCOUNT ON;
	SELECT Purchases_Order_Id
		   , Company_id
		   , Date
		   , Purchases_Order_No
		FROM M_PURCHASES_ORDER
	ORDER BY Date desc