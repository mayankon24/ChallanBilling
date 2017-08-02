
CREATE  PROCEDURE [dbo].[GetBillReportBody] 
(
	@Bill_Id int,
	@Company_id int 
)
AS
	SET NOCOUNT ON;	
	select *    
	from 
	(
		SELECT BI.Bill_Item_Id
			  ,BI.Purchase_Order_Detail_Id
			  ,Item_Name = CASE 
								WHEN BI.Purchase_Order_Detail_Id IS NULL THEN IB.Item_Name
								WHEN BI.Purchase_Order_Detail_Id IS NOT NULL THEN I.Item_Name
							END
			  ,I.HSN_Code
			  ,BI.Quantity
			  ,Form	 = Case 
										WHEN BI.Form = 0 then null
										else BI.Form
									 END	 
			  ,Color = Case 
										WHEN BI.Color = 0 then null
										else BI.Color
									 END	 
			  ,Rate   = Case 
										WHEN BI.Rate = 0 then null
										else BI.Rate
									 END 
			  ,Narration
			  --,Parent_Id 
			  ,Parent_Id = CASE 
								WHEN BI.Parent_Id IS NULL THEN BI.Bill_Item_Id
								WHEN BI.Parent_Id IS NOT NULL THEN  BI.Parent_Id
							END   

		FROM  B_BILL INNER JOIN
			  B_BILL_ITEM BI on B_BILL.Bill_Id = BI.Bill_Id LEFT JOIN         
			  M_PURCHASES_ORDER_DETAIL ON BI.Purchase_Order_Detail_Id = M_PURCHASES_ORDER_DETAIL.Purchase_Order_Detail_Id 	LEFT JOIN	               
			  B_BillItem_Narration ON BI.Bill_Item_Id = B_BillItem_Narration.Bill_Item_Id left join 
			  Item I on M_PURCHASES_ORDER_DETAIL.Item_Id = I.Item_Id      
			  left join Item IB on BI.Item_Id = IB.Item_Id
		WHERE B_BILL.Bill_Id = @Bill_Id
	    
    )temp 
   ORDER BY Item_Name