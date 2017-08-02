CREATE PROCEDURE [dbo].[SelectCompanyAll]
(
	@Company_Type_Id INT
)

AS
	SET NOCOUNT ON;
      SELECT  company_Id
            , company_name
			, tin_no 
			, pan_no
			, phone
			, address1
			, city
			, state
			, pincode
			, email
			, phone
			, Fax_No
			, delivery_at
       FROM M_COMPANY
      WHERE Company_Type_Id = @Company_Type_Id
order by company_name