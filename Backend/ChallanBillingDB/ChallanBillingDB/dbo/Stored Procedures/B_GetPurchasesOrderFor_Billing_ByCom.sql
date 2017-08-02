CREATE PROCEDURE [dbo].[B_GetPurchasesOrderFor_Billing_ByCom]
(
	@Company_id int
)
AS
	SET NOCOUNT ON;
SELECT  M_PURCHASES_ORDER.Purchases_Order_Id
		,M_PURCHASES_ORDER.Purchases_Order_No
		,M_PURCHASES_ORDER.Date
        ,M_PURCHASES_ORDER_DETAIL.Purchase_Order_Detail_Id
		,Vw_Total_Order_Deliver_BillingQuantity.Item_Quantity
 		,Vw_Total_Order_Deliver_BillingQuantity.Total_Deliver_Quantity
  FROM  M_COMPANY INNER JOIN
        M_PURCHASES_ORDER ON M_COMPANY.Company_id = M_PURCHASES_ORDER.Company_id INNER JOIN
        M_PURCHASES_ORDER_DETAIL ON M_PURCHASES_ORDER.Purchases_Order_Id = M_PURCHASES_ORDER_DETAIL.Purchases_Order_Id INNER JOIN
        Vw_Total_Order_Deliver_BillingQuantity ON M_PURCHASES_ORDER_DETAIL.Purchase_Order_Detail_Id = Vw_Total_Order_Deliver_BillingQuantity.Purchase_Order_Detail_Id
	 
WHERE M_COMPANY.Company_id = @Company_id AND
      Vw_Total_Order_Deliver_BillingQuantity.Total_Deliver_Quantity > Vw_Total_Order_Deliver_BillingQuantity.Total_Billing_Quantity 

ORDER BY M_PURCHASES_ORDER.Purchases_Order_Id