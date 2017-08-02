CREATE PROCEDURE [dbo].[SelectBillDetailByBillId]
(	 
    @Bill_Id INT
)
AS
	SET NOCOUNT OFF;
	
	SELECT [Bill_Detail_Id]
      ,B_BILL_DETAIL.Bill_Item_Id
      ,[Delivery_Detail_Id]
      ,B_BILL_DETAIL.Quantity
  FROM B_BILL_DETAIL INNER JOIN 
	   B_BILL_ITEM ON B_BILL_DETAIL.Bill_Item_Id = B_BILL_ITEM.Bill_Item_Id 
 WHERE B_BILL_ITEM.Bill_Id = @Bill_Id