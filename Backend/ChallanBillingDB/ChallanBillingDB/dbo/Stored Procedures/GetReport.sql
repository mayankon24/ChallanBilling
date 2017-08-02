CREATE  PROCEDURE [dbo].[GetReport]
(
	@Delivery_No nvarchar(50),
	@Company_id int 
)
AS
	SET NOCOUNT ON;
	(SELECT M_DELIVERY.Delivery_No
		  ,M_DELIVERY.Delivery_Date
		  ,M_PURCHASES_ORDER.Purchases_Order_No
		  ,M_PURCHASES_ORDER.Date as Purchases_Order_Date
		  ,M_COMPANY.company_name
		  ,M_COMPANY.address1
		  ,M_COMPANY.city
		  ,M_COMPANY.state
		  ,M_COMPANY.pincode
		  ,M_COMPANY.pan_no
		  ,M_COMPANY.tin_no
		  --into GetReportHeader
	FROM M_DELIVERY	INNER JOIN 
	     M_PURCHASES_ORDER ON M_DELIVERY.Purchases_Order_Id = M_PURCHASES_ORDER.Purchases_Order_Id INNER JOIN 
	     M_COMPANY ON M_DELIVERY.Company_id = M_COMPANY.Company_id
   WHERE M_DELIVERY.Delivery_No = @Delivery_No AND
	     M_DELIVERY.Company_id = @Company_id)
	     
	     
	     
	          
    SELECT I.Item_Name    
		  ,M_PACKAGING_DETAIL.Packaging_Description
		  ,M_DELIVERY_DETAIL.Deliver_Quantity
	--INTO GetReportBody
	FROM M_DELIVERY	INNER JOIN	      
	     M_DELIVERY_DETAIL ON M_DELIVERY.Delivery_Id = M_DELIVERY_DETAIL.Delivery_Id INNER JOIN 
	     M_PURCHASES_ORDER_DETAIL ON M_DELIVERY_DETAIL.Purchase_Order_Detail_Id = M_PURCHASES_ORDER_DETAIL.Purchase_Order_Detail_Id INNER JOIN 
	     Item I on M_PURCHASES_ORDER_DETAIL.Item_Id = I.Item_Id inner join
	     M_COMPANY ON M_DELIVERY.Company_id = M_COMPANY.Company_id LEFT JOIN
	     M_PACKAGING_DETAIL ON M_DELIVERY_DETAIL.Delivery_Detail_Id = M_PACKAGING_DETAIL.Delivery_Detail_Id 
   WHERE M_DELIVERY.Delivery_No = @Delivery_No AND
	     M_DELIVERY.Company_id = @Company_id
	     
 --SELECT * FROM GetReportHeader
 --SELECT * FROM GetReportBody
 
 --drop table GetReportHeader
 --drop table GetReportBody