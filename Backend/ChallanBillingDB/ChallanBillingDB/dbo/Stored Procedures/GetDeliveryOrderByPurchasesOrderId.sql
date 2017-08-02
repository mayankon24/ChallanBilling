CREATE PROCEDURE [dbo].[GetDeliveryOrderByPurchasesOrderId]
(
	@Company_id int,
	@Purchases_Order_Id int
)
AS
	SET NOCOUNT ON;
	SELECT   Delivery_Id
		   , Delivery_No
		   , Delivery_Date		 
	 FROM M_DELIVERY
	Where Company_id = @Company_id AND
		  Purchases_Order_Id = @Purchases_Order_Id	
  ORDER BY Delivery_No