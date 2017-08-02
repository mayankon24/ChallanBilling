CREATE PROCEDURE [dbo].[SelectTaxAmountAll]
AS
	SET NOCOUNT ON;
SELECT  Tax_Amout_Id
      , Tax_Amout
      , Tax_Name
  FROM B_TAX_AMOUNT


/****** Object:  StoredProcedure [dbo].[SelectTaxAmountAll]    Script Date: 12/22/2011 01:40:53 ******/
SET ANSI_NULLS ON