create PROCEDURE [dbo].[DeleteTaxAmount]
(
	@Tax_Amout_Id int	
)
AS
	SET NOCOUNT OFF;
DELETE FROM [B_TAX_AMOUNT] 
  WHERE Tax_Amout_Id = @Tax_Amout_Id