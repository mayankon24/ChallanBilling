CREATE PROCEDURE [dbo].[SelectBillAll]

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




/****** Object:  StoredProcedure [dbo].[SelectBillById]    Script Date: 12/22/2011 01:44:05 ******/
SET ANSI_NULLS ON