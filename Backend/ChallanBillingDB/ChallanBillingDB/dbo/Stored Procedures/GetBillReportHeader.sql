CREATE PROCEDURE [dbo].[GetBillReportHeader]
(
	@Bill_Id int,
	@Company_id int 
)
AS
	SET NOCOUNT ON;
	SELECT c.company_name
		  ,c.address1 +  ' ' + c.city + ' ' + c.state + ' ' + c.pincode as 'address1'
		  ,c.pan_no
		  ,c.tin_no	  
		  ,c.Company_Type_Id
		  ,c.delivery_at
		  ,B_BILL.Bill_No
		  ,B_BILL.Bill_Type_Id
		  ,B_BILL.Bill_Date
		  ,B_BILL.Tax_Name
		  ,B_BILL.Tax_Percentage
		  ,B_BILL.Is_Tax_Inclusive as Is_Tax_Apllicable
		  ,B_BILL.Cartage
		  ,B_BILL.Discount
	FROM B_BILL INNER JOIN 	     
	     M_COMPANY c ON B_BILL.Company_id = c.Company_id
   WHERE B_BILL.Bill_Id = @Bill_Id AND
	     c.Company_id = @Company_id