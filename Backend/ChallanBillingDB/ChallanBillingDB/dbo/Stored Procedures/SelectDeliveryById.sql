CREATE PROCEDURE [dbo].[SelectDeliveryById]
(
	@Deliver_Id int
)

AS
	SET NOCOUNT ON;
SELECT        Delivery_Id
            , company_id
			, Purchases_Order_Id
			, Delivery_no
			, Delivery_Date	
			
			
FROM M_Delivery
where ( Delivery_Id = @Deliver_Id )