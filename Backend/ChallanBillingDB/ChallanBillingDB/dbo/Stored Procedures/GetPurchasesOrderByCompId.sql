CREATE PROCEDURE [dbo].[GetPurchasesOrderByCompId]
(
	@Company_id int
)
AS
	SET NOCOUNT ON;
	SELECT   Purchases_Order_Id
		   , Company_id
		   , Date
		   , Purchases_Order_No
	 FROM M_PURCHASES_ORDER
	Where Company_id = @Company_id
   ORDER BY Date desc