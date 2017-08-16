	
	

CREATE PROCEDURE [dbo].[UpdateBill]
(  
    @Bill_Type_Id INT
   ,@Bill_Date datetime
   ,@Tax_Name NVARCHAR(50) 
   ,@Central_Tax_Name nvarchar(50)
   ,@Tax_Percentage decimal(10,4)
   ,@Central_Tax_Percentage decimal(10,4)
   ,@Is_Tax_Inclusive INT
   ,@Bill_Id INT
   ,@Cartage decimal(10,4)
   ,@Discount decimal(10,4)
)
AS
	SET NOCOUNT OFF;
	
	UPDATE [B_BILL]
   SET [Bill_Type_Id] = @Bill_Type_Id
      ,[Bill_Date] = @Bill_Date
      ,[Tax_Name] = @Tax_Name
	  ,[Central_Tax_Name] = @Central_Tax_Name
      ,[Tax_Percentage] = @Tax_Percentage
	  ,[central_Tax_Percentage] = @Central_Tax_Percentage
      ,[Is_Tax_Inclusive] = @Is_Tax_Inclusive
      ,Cartage = @Cartage
      ,Discount = @Discount
 WHERE Bill_Id = @Bill_Id



/****** Object:  StoredProcedure [dbo].[SelectBillAll]    Script Date: 12/22/2011 01:43:36 ******/
SET ANSI_NULLS ON