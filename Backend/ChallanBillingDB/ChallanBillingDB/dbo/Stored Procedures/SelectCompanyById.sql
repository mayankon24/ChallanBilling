CREATE PROCEDURE [dbo].[SelectCompanyById]
(
	@Company_Id int
)
AS
	SET NOCOUNT ON;
SELECT        company_id
			, Company_Type_Id
			, tin_no
			, company_name
			, address1
			, pan_no
			, city
			, state
			, pincode
			, email
			, phone
			, Fax_No
			,delivery_at
			
FROM M_COMPANY
WHERE (Company_Id = @Company_Id)