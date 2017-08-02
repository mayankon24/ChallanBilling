CREATE PROCEDURE [dbo].[SelectPurchasesOrderDetailById]
(
	@Purchase_Order_Detail_Id int
)
AS
	SET NOCOUNT ON;
SELECT Purchase_Order_Detail_Id
	, Purchases_Order_Id
	, I.Item_Name
	, Item_Quantity
	, Item_Rate
	, Total_Amount
FROM M_PURCHASES_ORDER_DETAIL Inner join
 Item I on M_PURCHASES_ORDER_DETAIL.Item_Id = I.Item_Id 
WHERE Purchase_Order_Detail_Id = @Purchase_Order_Detail_Id