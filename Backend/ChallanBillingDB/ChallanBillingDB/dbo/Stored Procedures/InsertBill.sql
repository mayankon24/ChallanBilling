CREATE PROCEDURE [dbo].[InsertBill]
(
    @Company_id INT
   ,@Bill_No nvarchar(50)
   ,@Bill_Type_Id INT
   ,@Bill_Date datetime 
   ,@Tax_Percentage decimal(10,4)
   ,@Central_Tax_Percentage decimal(10,4)
   ,@Tax_Name nvarchar(50)
   ,@Central_Tax_Name nvarchar(50)
   ,@Is_Tax_Inclusive INT
   ,@Cartage decimal(10,4)
   ,@Discount decimal(10,4)
)
AS
	SET NOCOUNT OFF;
	
	Declare @Financial_Year NVARCHAR(50)
	Declare @StartFinancial_Year datetime
	Declare @EndFinancial_Year datetime
	Declare @Company_Type int
	Declare @BillNo_Code int
		
	Select @Company_Type = Company_Type_Id from M_COMPANY where Company_id = @Company_id

	set @StartFinancial_Year = case 
						  when month(@Bill_Date) >= 4	then DATEADD(YEAR, year(@Bill_Date)-1900, DATEADD(MONTH, 3, 0))
						  when month(@Bill_Date) < 4	then DATEADD(YEAR, year(@Bill_Date)-1900 -1, DATEADD(MONTH, 3, 0))
					    end 

	set @EndFinancial_Year = case 
						when month(@Bill_Date) >= 4	then DATEADD(YEAR, year(@Bill_Date)-1900 +1, DATEADD(MONTH, 3, -1)) 
						when month(@Bill_Date) < 4	then DATEADD(YEAR, year(@Bill_Date)-1900, DATEADD(MONTH, 3, -1))
					 end
	-- Get Financial Year
	set @Financial_Year = case
						when month(@Bill_Date) >= 4 then CONVERT(nvarchar, year(@Bill_Date)) +'-' +  CONVERT(nvarchar,  year(@Bill_Date)  + 1 ) + '/ '
						else  CONVERT(nvarchar, year(@Bill_Date) - 1 ) +'-' +  CONVERT(nvarchar,  year(@Bill_Date) ) + '/ '
					end 
	
	
	
	SELECT @BillNo_Code = case 
						WHEN @Bill_Type_Id = 1 THEN ISNULL(max(BillNo_Code), 0) 
						WHEN @Bill_Type_Id = 2 THEN ISNULL(max(BillNo_Code), 0) 
						WHEN @Bill_Type_Id = 3 THEN ISNULL(max(BillNo_Code), 0) 
						WHEN @Bill_Type_Id = 4 THEN ISNULL(max(BillNo_Code), 0)
					END
	FROM B_BILL	INNER JOIN 
	M_COMPANY ON  B_BILL.Company_id = M_COMPANY.Company_id
	Where		
	(
		((@Bill_Type_Id = 1 or @Bill_Type_Id = 3 ) AND (Bill_Type_Id = 1 or Bill_Type_Id = 3))
		OR ((@Bill_Type_Id = 4 or @Bill_Type_Id = 2 ) AND (Bill_Type_Id = 4 or Bill_Type_Id = 2))
	)
	And M_COMPANY.Company_Type_Id =@Company_Type
	AND Bill_Date >= @StartFinancial_Year 
	AND Bill_Date <= @EndFinancial_Year
	
	if (@BillNo_Code is null or @BillNo_Code = '' or @BillNo_Code < 0)	
	begin
		set @BillNo_Code =0
	end

	SET @BillNo_Code = @BillNo_Code + 1


	

	--get Bill No 
	Declare @BillNo  NVARCHAR(50)
	select @BillNo = CONVERT(nvarchar,  @BillNo_Code)
	--SELECT @BillNo = case 
	--						 WHEN @Bill_Type_Id = 1 THEN 'RIS ' + @Financial_Year + CONVERT(nvarchar,  @BillNo_Code)
	--					       WHEN @Bill_Type_Id = 2 THEN 'TIS ' + @Financial_Year + CONVERT(nvarchar,  @BillNo_Code)
	--						 WHEN @Bill_Type_Id = 3 THEN 'RIJ ' + @Financial_Year + CONVERT(nvarchar,  @BillNo_Code)
	--						 WHEN @Bill_Type_Id = 4 THEN 'TIJ ' + @Financial_Year + CONVERT(nvarchar,  @BillNo_Code)
	--					  END



    if(@Bill_No is not null AND @Bill_No  <> '' and @Bill_No  <> 0)		
	begin
		set @BillNo = @Bill_No
		set @BillNo_Code = @Bill_No
	end

	INSERT INTO [B_BILL]
           ([Company_id]
           ,[Bill_No]
           ,[Bill_Type_Id]
           ,[Bill_Date]
           ,[Tax_Name]
		   ,[Central_Tax_Name]
           ,[Tax_Percentage]  
		   ,Central_Tax_Percentage
           ,[Is_Tax_Inclusive]
		   ,BillNo_Code
		   ,Cartage
		   ,Discount)
     VALUES
           (@Company_id
           ,@BillNo
           ,@Bill_Type_Id
           ,@Bill_Date
           ,@Tax_Name
		   ,@Central_Tax_Name
           ,@Tax_Percentage
		   ,@Central_Tax_Percentage
           ,@Is_Tax_Inclusive
		   ,@BillNo_Code
		   ,@Cartage
		   ,@Discount)
	
	Declare @Id int
	set @Id = SCOPE_IDENTITY()
	select @Id
	
	
	
	
/****** Object:  StoredProcedure [dbo].[UpdateBill]    Script Date: 12/22/2011 01:43:00 ******/
SET ANSI_NULLS ON