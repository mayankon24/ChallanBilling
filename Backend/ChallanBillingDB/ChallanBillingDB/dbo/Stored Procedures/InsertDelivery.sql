

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
	DECLARE @Book_no int, @Book_count int
	
	Select @Delivery_No_Code = ISNULL(MAX(Delivery_No_Code),1000)
	      ,@Book_no = ISNULL( max(Book_no), 0)
	  FROM M_DELIVERY INNER JOIN
	       M_COMPANY ON M_DELIVERY.Company_id = M_COMPANY.Company_id
	 WHERE M_COMPANY.Company_Type_Id = @Company_Type_Id
	
	Select  @Book_count = count(1)
	  FROM M_DELIVERY (nolock) INNER JOIN
	       M_COMPANY ON M_DELIVERY.Company_id = M_COMPANY.Company_id
	 WHERE M_COMPANY.Company_Type_Id = @Company_Type_Id
	 and M_DELIVERY.book_no = @Book_no 


	if(@Book_count >= 50) set @Book_no = @Book_no +1

	Set @Delivery_No_Code = @Delivery_No_Code + 1	
	
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
					,@Book_no
					);
								
Declare @Delivery_Id int
set @Delivery_Id = SCOPE_IDENTITY()
select  @Delivery_Id