CREATE PROCEDURE [dbo].[GetBalanceSheet]
(
	@Purchases_Order_Id int
)
AS
	SET NOCOUNT ON;
SELECT M_PURCHASES_ORDER_DETAIL.Purchase_Order_Detail_Id
	, I.Item_Name
	, Item_Quantity
	, Item_Rate
	, Total_Amount
	, SUM(M_DELIVERY_DETAIL.Deliver_Quantity) AS Total_Deliver_Quantity 
	, Item_Quantity - SUM(M_DELIVERY_DETAIL.Deliver_Quantity) AS Total_Balance
 FROM M_PURCHASES_ORDER_DETAIL inner join 
      Item I on M_PURCHASES_ORDER_DETAIL.Item_Id = I.Item_Id  LEFT JOIN
	  M_DELIVERY_DETAIL ON M_PURCHASES_ORDER_DETAIL.Purchase_Order_Detail_Id = M_DELIVERY_DETAIL.Purchase_Order_Detail_Id
WHERE Purchases_Order_Id = @Purchases_Order_Id
GROUP BY M_PURCHASES_ORDER_DETAIL.Purchase_Order_Detail_Id
		,I.Item_Name
		,Item_Quantity
		,Item_Rate
		,Total_Amount
ORDER BY I.Item_Name