CREATE  PROCEDURE [dbo].[GetReportHeader]
(
	@Delivery_Id int,
	@Company_id int 
)
AS
	SET NOCOUNT ON;
	SELECT M_DELIVERY.Delivery_No
		  ,M_DELIVERY.Delivery_Date
		  ,M_PURCHASES_ORDER.Purchases_Order_No
		  ,M_PURCHASES_ORDER.Date as Purchases_Order_Date
		  ,c.company_name
		  ,c.address1 + ' ' + c.city + ' ' + c.state + ' ' + c.pincode  as address1
		  ,c.pan_no
		  ,c.tin_no
		  ,c.delivery_at
		  ,M_DELIVERY.book_no
	FROM M_DELIVERY	INNER JOIN 
	     M_PURCHASES_ORDER ON M_DELIVERY.Purchases_Order_Id = M_PURCHASES_ORDER.Purchases_Order_Id INNER JOIN 
	     M_COMPANY c ON M_DELIVERY.Company_id = c.Company_id
   WHERE M_DELIVERY.Delivery_Id = @Delivery_Id AND
	     M_DELIVERY.Company_id = @Company_id