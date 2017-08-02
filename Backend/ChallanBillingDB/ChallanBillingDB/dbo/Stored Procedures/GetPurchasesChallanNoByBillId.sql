CREATE PROCEDURE [dbo].[GetPurchasesChallanNoByBillId]
(	 
    @Bill_Id INT
)
AS
	SET NOCOUNT OFF;
	
	SELECT Distinct  M_PURCHASES_ORDER.Purchases_Order_No
		   ,M_PURCHASES_ORDER.Date as Purchases_Order_Date
		   ,M_DELIVERY.Delivery_No	
           ,M_DELIVERY.Delivery_Date 
	  FROM B_BILL_DETAIL INNER JOIN 
		   B_BILL_ITEM ON B_BILL_DETAIL.Bill_Item_Id = B_BILL_ITEM.Bill_Item_Id INNER JOIN
		   M_DELIVERY_DETAIL ON B_BILL_DETAIL.Delivery_Detail_Id = M_DELIVERY_DETAIL.Delivery_Detail_Id INNER JOIN
		   M_DELIVERY ON M_DELIVERY_DETAIL.Delivery_Id = M_DELIVERY.Delivery_Id INNER JOIN 
           M_PURCHASES_ORDER_DETAIL ON B_BILL_ITEM.Purchase_Order_Detail_Id = M_PURCHASES_ORDER_DETAIL.Purchase_Order_Detail_Id INNER JOIN
           M_PURCHASES_ORDER ON  M_PURCHASES_ORDER_DETAIL.Purchases_Order_Id =  M_PURCHASES_ORDER.Purchases_Order_Id
	 WHERE B_BILL_ITEM.Bill_Id = @Bill_Id