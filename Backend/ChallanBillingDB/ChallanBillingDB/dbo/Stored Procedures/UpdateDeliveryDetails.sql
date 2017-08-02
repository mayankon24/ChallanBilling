CREATE PROCEDURE [dbo].[UpdateDeliveryDetails]
(
	@Deliver_Quantity float,
	@Delivery_Detail_Id int		
)
AS
	SET NOCOUNT OFF;
UPDATE [M_DELIVERY_DETAIL] 
  SET  [Deliver_Quantity] = @Deliver_Quantity
 WHERE [Delivery_Detail_Id] = @Delivery_Detail_Id;