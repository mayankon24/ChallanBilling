CREATE PROCEDURE [dbo].[DeleteDeliveryDetails]
(
	@Delivery_Id int
)
AS
	SET NOCOUNT OFF;
DELETE FROM [M_Delivery_Detail] WHERE Delivery_Id = @Delivery_Id