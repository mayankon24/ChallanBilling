CREATE PROCEDURE [dbo].[InsertDelivery]
(
	@company_id int,
	@Company_Type_Id int,
	@purchases_order_id int,
	@delivery_no nvarchar(50),
	@delivery_date datetime
)
AS
	SET NOCOUNT OFF;
	
	DECLARE @Delivery_No_Code Nvarchar(50) 
	Declare @StartFinancial_Year datetime
	Declare @EndFinancial_Year datetime
	

	set @StartFinancial_Year = case 
						  when month(@delivery_date) >= 4	then DATEADD(YEAR, year(@delivery_date)-1900, DATEADD(MONTH, 3, 0))
						  when month(@delivery_date) < 4	then DATEADD(YEAR, year(@delivery_date)-1900 -1, DATEADD(MONTH, 3, 0))
					    end 

	set @EndFinancial_Year = case 
						when month(@delivery_date) >= 4	then DATEADD(YEAR, year(@delivery_date)-1900 +1, DATEADD(MONTH, 3, -1)) 
						when month(@delivery_date) < 4	then DATEADD(YEAR, year(@delivery_date)-1900, DATEADD(MONTH, 3, -1))
					 end




	Select @Delivery_No_Code = ISNULL(MAX(Delivery_No_Code),1000)	    
	  FROM M_DELIVERY INNER JOIN
	       M_COMPANY ON M_DELIVERY.Company_id = M_COMPANY.Company_id
	 WHERE M_COMPANY.Company_Type_Id = @Company_Type_Id
	AND delivery_date >= @StartFinancial_Year 
	AND delivery_date <= @EndFinancial_Year


	if (@Delivery_No_Code is null or @Delivery_No_Code = '' or @Delivery_No_Code < 0)	
	begin
		set @Delivery_No_Code =0
	end

	SET @Delivery_No_Code = @Delivery_No_Code + 1

	
	
	if (@delivery_no is not null AND @delivery_no <> ''  AND @delivery_no <> 0)
	begin
		set @Delivery_No_Code = @delivery_no
	end
	
	
	INSERT INTO [M_Delivery]( [company_id]
					, [purchases_order_id]
					, [delivery_no]
					, [delivery_date]
					, Delivery_No_Code
					,Book_no
					)
				VALUES 
					( @company_id
					, @purchases_order_id
					, @Delivery_No_Code
					, @delivery_date
					, @Delivery_No_Code
					, 0
					);
								
Declare @Delivery_Id int
set @Delivery_Id = SCOPE_IDENTITY()
select  @Delivery_Id