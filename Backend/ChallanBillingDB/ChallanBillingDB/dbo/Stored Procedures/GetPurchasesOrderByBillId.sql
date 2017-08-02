create PROCEDURE [dbo].[GetPurchasesOrderByBillId]
(
	@Bill_Id int
)
AS
	SET NOCOUNT ON;
	SELECT M_PURCHASES_ORDER.Purchases_Order_Id
		  ,M_PURCHASES_ORDER.Company_id
		  ,M_PURCHASES_ORDER.Date
		  ,M_PURCHASES_ORDER.Purchases_Order_No		
      FROM M_PURCHASES_ORDER INNER JOIN 
		   M_PURCHASES_ORDER_DETAIL ON M_PURCHASES_ORDER.Purchases_Order_Id = M_PURCHASES_ORDER_DETAIL.Purchases_Order_Id INNER JOIN
		   B_BILL_ITEM ON M_PURCHASES_ORDER_DETAIL.Purchase_Order_Detail_Id = B_BILL_ITEM.Purchase_Order_Detail_Id		   
	 Where Bill_Id = @Bill_Id
   ORDER BY Purchases_Order_No