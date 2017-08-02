CREATE PROCEDURE [dbo].[UpdatePurchasesOrder]
(
	@Date datetime,
	@Purchases_Order_No VARCHAR(100),
	@Purchases_Order_Id int
)
AS
	SET NOCOUNT OFF;
UPDATE [M_PURCHASES_ORDER]
   SET [Date] = @Date
     , [Purchases_Order_No] = @Purchases_Order_No 
 WHERE ([Purchases_Order_Id] = @Purchases_Order_Id)