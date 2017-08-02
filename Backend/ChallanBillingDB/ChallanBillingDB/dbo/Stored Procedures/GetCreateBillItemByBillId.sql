CREATE PROCEDURE [dbo].[GetCreateBillItemByBillId]
(
	@Bill_Id int
)
AS
	SET NOCOUNT ON;
	SELECT distinct M_PURCHASES_ORDER_DETAIL.Purchase_Order_Detail_Id
		  ,B_BILL_ITEM.Bill_Item_Id	
		  ,M_PURCHASES_ORDER.Purchases_Order_No
		  ,I.Item_Name
		  ,M_PURCHASES_ORDER_DETAIL.Item_Quantity as Item_Quantity
		  ,M_PURCHASES_ORDER_DETAIL.Item_Rate AS Item_Rate
		  ,M_PURCHASES_ORDER_DETAIL.Item_Rate AS order_ItemRate
	      ,(M_PURCHASES_ORDER_DETAIL.Item_Rate)* (M_PURCHASES_ORDER_DETAIL.Item_Rate) AS Total_Amount
		  ,B_BILL_ITEM.Form
		  ,B_BILL_ITEM.Color
		  ,B_BILL_ITEM.Rate
		  ,B_BILL_ITEM.Quantity	as Bill_Quantity	 
	  FROM B_BILL INNER JOIN
		   B_BILL_ITEM ON B_BILL.Bill_Id = B_BILL_ITEM.Bill_Id INNER JOIN
		   B_BILL_DETAIL ON B_BILL_ITEM.Bill_Item_Id = B_BILL_DETAIL.Bill_Item_Id INNER JOIN 
		   M_PURCHASES_ORDER_DETAIL ON B_BILL_ITEM.Purchase_Order_Detail_Id = M_PURCHASES_ORDER_DETAIL.Purchase_Order_Detail_Id INNER JOIN
		   M_PURCHASES_ORDER ON M_PURCHASES_ORDER_DETAIL.Purchases_Order_Id = M_PURCHASES_ORDER.Purchases_Order_Id	Inner join
		   Item I on M_PURCHASES_ORDER_DETAIL.Item_Id = I.Item_Id    
	Where B_BILL.Bill_Id = @Bill_Id
	
	
	SELECT 
			--Sum( M_DELIVERY_DETAIL.Deliver_Quantity), 
			M_DELIVERY_DETAIL.Deliver_Quantity
		   ,B_BILL_ITEM.Bill_Item_Id	
		   ,M_DELIVERY.Delivery_No
	  FROM B_BILL INNER JOIN
		   B_BILL_ITEM ON B_BILL.Bill_Id = B_BILL_ITEM.Bill_Id INNER JOIN
		   B_BILL_DETAIL ON B_BILL_ITEM.Bill_Item_Id = B_BILL_DETAIL.Bill_Item_Id INNER JOIN
		   M_DELIVERY_DETAIL ON B_BILL_DETAIL.Delivery_Detail_Id = M_DELIVERY_DETAIL.Delivery_Detail_Id INNER JOIN
		   M_DELIVERY ON M_DELIVERY_DETAIL.Delivery_Id = M_DELIVERY.Delivery_Id
 	 Where B_BILL.Bill_Id = @Bill_Id
  --Group By B_BILL_ITEM.Bill_Item_Id, M_DELIVERY.Delivery_No