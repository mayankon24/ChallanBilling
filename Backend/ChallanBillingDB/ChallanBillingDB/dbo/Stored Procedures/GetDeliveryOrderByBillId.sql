CREATE PROCEDURE [dbo].[GetDeliveryOrderByBillId]
(
	@Bill_Id int
)
AS
	SET NOCOUNT ON;
	SELECT M_DELIVERY.Delivery_Id
		  ,M_DELIVERY.Company_id
		  ,M_DELIVERY.Purchases_Order_Id
		  ,M_DELIVERY.Delivery_No
		  ,M_DELIVERY.Delivery_Date		
	  FROM B_BILL_DETAIL INNER JOIN 
	       B_BILL_ITEM ON B_BILL_DETAIL.Bill_Item_Id = B_BILL_ITEM.Bill_Item_Id INNER JOIN
	       B_BILL  ON B_BILL_ITEM.Bill_Id = B_BILL.Bill_Id INNER JOIN
	       M_DELIVERY_DETAIL ON B_BILL_DETAIL.Delivery_Detail_Id = M_DELIVERY_DETAIL.Delivery_Detail_Id INNER JOIN
	       M_DELIVERY ON M_DELIVERY_DETAIL.Delivery_Id = M_DELIVERY.Delivery_Id	
	Where B_BILL.Bill_Id = @Bill_Id