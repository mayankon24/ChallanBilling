CREATE PROCEDURE [dbo].[GetCompletePurchasesOrder]
(
	@Company_id int
)
AS
	SET NOCOUNT ON;
	
	Select M_PURCHASES_ORDER.Purchases_Order_Id 	         
	  FROM M_COMPANY INNER JOIN
	       M_PURCHASES_ORDER ON M_COMPANY.Company_id = M_PURCHASES_ORDER.Company_id       
      WHERE  M_PURCHASES_ORDER.Purchases_Order_Id  NOT IN (
															Select DISTINCT Purchases_Order_Id 
															 from(
																   SELECT M_PURCHASES_ORDER.Purchases_Order_Id					
																		 ,Item_Quantity
																		 ,ISNULL(SUM(M_DELIVERY_DETAIL.Deliver_Quantity),0) AS Total_Deliver_Quantity 
																		 ,Item_Quantity - ISNULL(SUM(M_DELIVERY_DETAIL.Deliver_Quantity),0) AS Total_Balance																		
																	 FROM M_COMPANY INNER JOIN 
																		  M_PURCHASES_ORDER ON M_COMPANY.Company_id = M_PURCHASES_ORDER.Company_id INNER JOIN
																		  M_PURCHASES_ORDER_DETAIL ON  M_PURCHASES_ORDER.Purchases_Order_Id = M_PURCHASES_ORDER_DETAIL.Purchases_Order_Id LEFT JOIN
																		  M_DELIVERY_DETAIL ON M_PURCHASES_ORDER_DETAIL.Purchase_Order_Detail_Id = M_DELIVERY_DETAIL.Purchase_Order_Detail_Id
																	Where M_COMPANY.Company_id = @Company_id	  
																	GROUP BY M_PURCHASES_ORDER.Purchases_Order_Id					
																			,Item_Quantity
																			,Item_Rate
																			,Total_Amount
																	
																  ) AS TAb1
															WHERE Total_Balance >0
															
														 )AND
           
		M_COMPANY.Company_id = @Company_id