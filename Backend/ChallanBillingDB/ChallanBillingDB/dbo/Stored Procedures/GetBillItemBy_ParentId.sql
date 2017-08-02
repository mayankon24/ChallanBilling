CREATE PROCEDURE [dbo].[GetBillItemBy_ParentId]
(	 
    @Parent_Id INT
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
		  M_PURCHASES_ORDER_DETAIL  POD ON BI.Purchase_Order_Detail_Id = POD.Purchase_Order_Detail_Id 
		  left join Item I on POD.Item_Id = I.Item_Id
		  left join Item IB on BI.Item_Id = IB.Item_Id 
    WHERE Parent_Id = @Parent_Id AND
		  BI.Purchase_Order_Detail_Id is NULL