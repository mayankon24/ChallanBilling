CREATE PROCEDURE [dbo].[SelectPackagingDetail_By_DeliveryDetailId]
(
	@Delivery_Detail_Id int
)

AS
	SET NOCOUNT ON;
SELECT        Packaging_Id 
            , Delivery_Detail_id 
			, Packaging_Description
FROM M_PACKAGING_DETAIL
where ( Delivery_Detail_Id  = @Delivery_Detail_Id  )
ORDER BY Packaging_Description