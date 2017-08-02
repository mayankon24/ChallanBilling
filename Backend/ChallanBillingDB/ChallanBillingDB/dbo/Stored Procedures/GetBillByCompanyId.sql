CREATE PROCEDURE [dbo].[GetBillByCompanyId]
(
	@Company_id int
)

AS
	SET NOCOUNT ON;
SELECT [Bill_Id]
      ,[Company_id]
      ,[Bill_No]
      ,[Bill_Type_Id]
      ,[Bill_Date]
      ,[Tax_Name]
      ,[Tax_Percentage]
      ,[Is_Tax_Inclusive]
      ,isnull(Cartage, 0) AS Cartage 
      ,isnull(Discount, 0) as Discount
  FROM [B_BILL]
 WHERE Company_id = @Company_id




/****** Object:  StoredProcedure [dbo].[GetBillReportHeader]    Script Date: 12/22/2011 01:45:15 ******/
SET ANSI_NULLS ON