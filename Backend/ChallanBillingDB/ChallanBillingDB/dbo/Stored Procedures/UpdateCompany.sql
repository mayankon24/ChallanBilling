CREATE PROCEDURE [dbo].[UpdateCompany]
(
	@tin_no nvarchar(50),
	@company_name nvarchar(50),
	@address1 nvarchar(150),
	@pan_no nvarchar(150),
	@city nvarchar(50),
	@state nvarchar(50),
	@pincode nvarchar(50),
	@email nvarchar(150),
	@phone nvarchar(50),
	@Fax_No  nvarchar(50),
	@company_id BIGINT,
	@Company_Type_Id INT,
	@delivery_at nvarchar(2000)	
)
AS
	SET NOCOUNT OFF;
UPDATE [M_COMPANY] 
  SET  [Company_Type_Id] = @Company_Type_Id
     , [tin_no] = @tin_no
	 , [company_name] = @company_name
	 , [address1] = @address1
	 , [pan_no] = @pan_no
	 , [city] = @city
	 , [state] = @state
	 , [pincode] = @pincode
	 , [email] = @email
	 , [phone] = @phone	
	 , Fax_No = @Fax_No	
	 , delivery_at = @delivery_at	
 WHERE [company_id] = @company_id;