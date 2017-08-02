Create PROCEDURE [dbo].[B_SelectDeliveryAll]

AS
	SET NOCOUNT ON;
SELECT        Delivery_Id
            , company_id  
			, Purchases_Order_Id 
			, Delivery_no 
			, Delivery_Date
			, Future1 
			, Future2
			
FROM M_Delivery
order by company_Id