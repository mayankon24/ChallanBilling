
Create PROCEDURE [dbo].[SelectTaxAmountById]
(
	@Tax_Amout_Id INT
)
AS
	SET NOCOUNT ON;
SELECT  Tax_Amout_Id
      , Tax_Amout
      , Tax_Name
  FROM B_TAX_AMOUNT
  WHERE Tax_Amout_Id = @Tax_Amout_Id
  
  
  
  
/****** Object:  StoredProcedure [dbo].[InsertBill]    Script Date: 12/22/2011 01:42:32 ******/
SET ANSI_NULLS ON