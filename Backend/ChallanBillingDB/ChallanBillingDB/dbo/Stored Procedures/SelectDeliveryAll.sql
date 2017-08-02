create PROCEDURE [dbo].[SelectDeliveryAll]

AS
	SET NOCOUNT ON;
SELECT        Delivery_Id
            , company_id AS [Company ID] 
			, Purchases_Order_Id AS [Purchase Order Id]		
			, Delivery_no as [Delivery No]
			, Delivery_Date	As [Delivery Date]		
			, Future1 as [Future 1]
			, Future2 as [Future 2]
			
FROM M_Delivery
order by company_Id