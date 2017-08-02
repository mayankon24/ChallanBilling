CREATE PROCEDURE [dbo].[InsertCompany]
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
	@Company_Type_Id INT,
	@delivery_at nvarchar(2000)
	
)
AS
	SET NOCOUNT OFF;
INSERT INTO [M_COMPANY](  [Company_Type_Id]
						, [tin_no]
						, [company_name]
						, [address1]
						, [pan_no]
						, [city]
						, [state]
						, [pincode]
						, [email]
						, [phone]
						, Fax_No
					    ,delivery_at
					  )
			 VALUES 
					( @Company_Type_Id
					, @tin_no
					, @company_name
					, @address1
					, @pan_no
					, @city
					, @state
					, @pincode
					, @email
					, @phone
					, @Fax_No
					,@delivery_at
				   );
						
Declare @CompanyId int
set @CompanyId = SCOPE_IDENTITY()
select @CompanyId