CREATE PROCEDURE [dbo].[SelectBillItemByBillId]
(	 
    @Bill_Id INT
)
AS
	SET NOCOUNT OFF;
	
	SELECT [Bill_Item_Id]
		  ,[Bill_Id]
		  ,BI.Purchase_Order_Detail_Id
		  ,ItemName = case
							WHEN BI.Purchase_Order_Detail_Id IS NULL THEN IB.Item_Name
							WHEN BI.Purchase_Order_Detail_Id IS not NULL THEN I.Item_Name
					  END
          ,IB.Item_Id
		  ,[Quantity]
		  ,[Form]
		  ,[Rate]
		  ,[Color]	
		  ,[parent_Id]	 
     FROM B_BILL_ITEM BI LEFT JOIN
		  M_PURCHASES_ORDER_DETAIL ON BI.Purchase_Order_Detail_Id = M_PURCHASES_ORDER_DETAIL.Purchase_Order_Detail_Id left join 
		   Item I on M_PURCHASES_ORDER_DETAIL.Item_Id = I.Item_Id 
		   left join Item IB on BI.Item_Id = IB.Item_Id 
    WHERE Bill_Id = @Bill_Id