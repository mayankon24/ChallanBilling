CREATE PROCEDURE [dbo].[InsertTaxAmount]
(
	@Tax_Amout decimal(10, 4)
	,@Tax_Name nvarchar(50)
)
AS
	SET NOCOUNT OFF;
INSERT INTO [B_TAX_AMOUNT]
			([Tax_Amout]
			 ,Tax_Name
			)
	 VALUES (@Tax_Amout
			,@Tax_Name
			);
	
select ( SCOPE_IDENTITY())




/****** Object:  StoredProcedure [dbo].[UpdateTaxAmount]    Script Date: 12/22/2011 01:40:20 ******/
SET ANSI_NULLS ON