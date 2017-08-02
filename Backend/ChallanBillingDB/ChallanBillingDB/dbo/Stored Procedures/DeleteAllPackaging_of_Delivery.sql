CREATE PROCEDURE [dbo].[DeleteAllPackaging_of_Delivery]
(
	@Delivery_Id int
)
AS
	SET NOCOUNT OFF;

	
	DELETE FROM [M_PACKAGING_DETAIL] 
	WHERE Packaging_Id IN ( select M_PACKAGING_DETAIL.Packaging_Id 
							  from M_DELIVERY INNER JOIN 
								   M_DELIVERY_DETAIL ON M_DELIVERY.Delivery_Id = M_DELIVERY_DETAIL.Delivery_Id INNER JOIN
								   M_PACKAGING_DETAIL ON M_DELIVERY_DETAIL.Delivery_Detail_Id = M_PACKAGING_DETAIL.Delivery_Detail_Id 
							 WHERE M_DELIVERY.Delivery_Id = @Delivery_Id   
						  )