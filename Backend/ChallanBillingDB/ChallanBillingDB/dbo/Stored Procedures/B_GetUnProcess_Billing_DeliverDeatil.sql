create PROCEDURE [dbo].[B_GetUnProcess_Billing_DeliverDeatil]
(
	@Company_id INt
)
AS
	SET NOCOUNT ON;

  SELECT  M_PURCHASES_ORDER.Purchases_Order_Id
		,M_PURCHASES_ORDER.Purchases_Order_No
		,M_PURCHASES_ORDER.Date as PURCHASES_ORDER_Date
        ,M_PURCHASES_ORDER_DETAIL.Purchase_Order_Detail_Id
		,Vw_Total_Order_Deliver_BillingQuantity.Item_Quantity		
        ,Vw_Total_Deliver_BillingQuantity.Delivery_Id
        ,M_DELIVERY.Delivery_No
		,M_DELIVERY.Delivery_Date
        ,Vw_Total_Deliver_BillingQuantity.Delivery_Detail_Id
		,Vw_Total_Deliver_BillingQuantity.Deliver_Quantity
		,Vw_Total_Deliver_BillingQuantity.Challan_Billing_Quantity
        ,Vw_Total_Order_Deliver_BillingQuantity.Total_Deliver_Quantity
		,Vw_Total_Order_Deliver_BillingQuantity.Total_Billing_Quantity 
		
  FROM  M_COMPANY INNER JOIN
        M_PURCHASES_ORDER ON M_COMPANY.Company_id = M_PURCHASES_ORDER.Company_id INNER JOIN
        M_PURCHASES_ORDER_DETAIL ON M_PURCHASES_ORDER.Purchases_Order_Id = M_PURCHASES_ORDER_DETAIL.Purchases_Order_Id INNER JOIN
        Vw_Total_Order_Deliver_BillingQuantity ON M_PURCHASES_ORDER_DETAIL.Purchase_Order_Detail_Id = Vw_Total_Order_Deliver_BillingQuantity.Purchase_Order_Detail_Id INNER JOIN
        Vw_Total_Deliver_BillingQuantity ON Vw_Total_Order_Deliver_BillingQuantity.Purchase_Order_Detail_Id = Vw_Total_Deliver_BillingQuantity.Purchase_Order_Detail_Id INNER JOIn
	    M_DELIVERY ON Vw_Total_Deliver_BillingQuantity.Delivery_Id  = M_DELIVERY.Delivery_Id
	 
WHERE M_COMPANY.Company_id = @Company_id 
	  AND NOT(Vw_Total_Deliver_BillingQuantity.Deliver_Quantity <= Vw_Total_Deliver_BillingQuantity.Challan_Billing_Quantity)

ORDER BY M_PURCHASES_ORDER.Purchases_Order_Id 
        ,M_PURCHASES_ORDER_DETAIL.Purchase_Order_Detail_Id
         ,Vw_Total_Deliver_BillingQuantity.Delivery_Detail_Id