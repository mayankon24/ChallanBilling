CREATE PROCEDURE [dbo].[UpdatePurchasesOrderDetail]
(
	@Item_Name nvarchar(100),
	@Item_Id int,
	@Item_Quantity float,
	@Item_Rate float,
	@Purchase_Order_Detail_Id int
)
AS
	SET NOCOUNT OFF;
UPDATE [M_PURCHASES_ORDER_DETAIL]
   SET [Item_Name] = @Item_Name
     , Item_Id = @Item_Id
	 , [Item_Quantity] = @Item_Quantity
	 , [Item_Rate] = @Item_Rate
	 , [Total_Amount] = @Item_Quantity*@Item_Rate
WHERE ([Purchase_Order_Detail_Id] = @Purchase_Order_Detail_Id);