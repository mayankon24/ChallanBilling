CREATE PROCEDURE [dbo].[DeletePackagingDetails_By_DeliveryDetailId ]
(
	@Delivery_Detail_Id int
)
AS
	SET NOCOUNT OFF;
DELETE FROM [M_Packaging_Detail] WHERE ((Delivery_Detail_Id = @Delivery_Detail_Id))