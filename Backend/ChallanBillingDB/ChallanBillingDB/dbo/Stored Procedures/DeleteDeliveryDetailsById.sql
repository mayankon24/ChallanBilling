CREATE PROCEDURE [dbo].[DeleteDeliveryDetailsById]
(
	@Delivery_Detail_Id int
)
AS
	SET NOCOUNT OFF;
DELETE FROM [M_Delivery_Detail] WHERE Delivery_Detail_Id = @Delivery_Detail_Id