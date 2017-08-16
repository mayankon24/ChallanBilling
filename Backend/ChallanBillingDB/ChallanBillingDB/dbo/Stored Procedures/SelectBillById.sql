
  CREATE PROCEDURE [dbo].[SelectBillById]
(
	@Bill_Id int
)

AS
	SET NOCOUNT ON;
SELECT [Bill_Id]
      ,[Company_id]
      ,[Bill_No]
      ,[Bill_Type_Id]
      ,[Bill_Date]
      ,[Tax_Name]
	  ,[Central_Tax_Name]
      ,[Central_Tax_Percentage]
	  ,[Tax_Percentage]
      ,[Is_Tax_Inclusive]
     ,isnull(Cartage, 0) AS Cartage 
      ,isnull(Discount, 0) as Discount
  FROM [B_BILL]
 WHERE Bill_Id = @Bill_Id