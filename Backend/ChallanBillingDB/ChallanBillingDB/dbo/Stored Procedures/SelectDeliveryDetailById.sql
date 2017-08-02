create PROCEDURE [dbo].[SelectDeliveryDetailById]
(
@Delivery_Detail_Id int
)

AS
	SET NOCOUNT ON;
SELECT        Delivery_Detail_Id 
            , Delivery_id AS [Delivery ID] 
			, Purchase_Order_Detail_Id AS [Purchase Order Detail Id]		
			, Deliver_Quantity as [Deliver Quantity]
			
			
FROM M_Delivery_Detail
where ( Delivery_Detail_Id  = @Delivery_Detail_Id  )