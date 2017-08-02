CREATE PROCEDURE [dbo].[UpdateTaxAmount]
(
	@Tax_Amout decimal(10, 4),	
	@Tax_Name nvarchar(50),
	@Tax_Amout_Id int
)
AS
	SET NOCOUNT OFF;
UPDATE [B_TAX_AMOUNT] 
   SET [Tax_Amout] = @Tax_Amout 
       ,Tax_Name = @Tax_Name 
 WHERE Tax_Amout_Id = @Tax_Amout_Id
	
SELECT 1




/****** Object:  StoredProcedure [dbo].[SelectTaxAmountAll]    Script Date: 12/22/2011 01:40:53 ******/
SET ANSI_NULLS ON