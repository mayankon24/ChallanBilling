  CREATE  PROCEDURE [dbo].[GetReportBody]
(
	@Delivery_Id int,
	@Company_id int 
)
AS
	SET NOCOUNT ON;
	
	     
    SELECT I.Item_Name 	      
	      ,I.[HSN_Code]   
		  ,M_PACKAGING_DETAIL.Packaging_Description
		  ,M_PURCHASES_ORDER_DETAIL.Item_Rate
		  ,M_DELIVERY_DETAIL.Deliver_Quantity
	FROM M_DELIVERY	INNER JOIN
	     M_DELIVERY_DETAIL ON M_DELIVERY.Delivery_Id = M_DELIVERY_DETAIL.Delivery_Id INNER JOIN 
	     M_PURCHASES_ORDER_DETAIL ON M_DELIVERY_DETAIL.Purchase_Order_Detail_Id = M_PURCHASES_ORDER_DETAIL.Purchase_Order_Detail_Id INNER JOIN 
	     Item I on M_PURCHASES_ORDER_DETAIL.Item_Id = I.Item_Id  inner join 
	     M_COMPANY ON M_DELIVERY.Company_id = M_COMPANY.Company_id LEFT JOIN
	     M_PACKAGING_DETAIL ON M_DELIVERY_DETAIL.Delivery_Detail_Id = M_PACKAGING_DETAIL.Delivery_Detail_Id 
   WHERE M_DELIVERY.Delivery_Id = @Delivery_Id AND
	     M_DELIVERY.Company_id = @Company_id