CREATE PROCEDURE [dbo].[InsertPurchasesOrderDetail]
(
	@Purchases_Order_Id int,
	@Item_Name nvarchar(100),
	@Item_Id int,
	@Item_Quantity float,
	@Item_Rate float	
)
AS
	SET NOCOUNT OFF;
   INSERT INTO [M_PURCHASES_ORDER_DETAIL]
			 ( [Purchases_Order_Id]
			 , [Item_Name]
			 , Item_Id
			 , [Item_Quantity]
			 , [Item_Rate]
			 , [Total_Amount]
			 )
	  VALUES 
			 ( @Purchases_Order_Id
			 , @Item_Name
			 , @Item_Id 
			 , @Item_Quantity
			 , @Item_Rate
			 , @Item_Quantity * @Item_Rate
			 );
	
SELECT ( SCOPE_IDENTITY())