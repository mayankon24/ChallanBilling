CREATE PROCEDURE [dbo].[DeleteDelivery]
(
	@Delivery_Id int
)
AS
	SET NOCOUNT OFF;
DELETE FROM [M_Delivery] WHERE (([Delivery_Id] = @Delivery_Id))