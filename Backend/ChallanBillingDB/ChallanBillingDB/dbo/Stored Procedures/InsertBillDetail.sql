CREATE PROCEDURE [dbo].[InsertBillDetail]
(
	 @Bill_Item_Id INT
--	,@Color INT
	,@Delivery_Detail_Id INT
--	,@Form DECIMAL(10,2)
	,@Quantity float
--	,@Rate DECIMAL(10,2)
)
AS
	SET NOCOUNT OFF;
	
	INSERT INTO [B_BILL_DETAIL]
           ([Bill_Item_Id]
           ,[Delivery_Detail_Id]
           ,[Quantity]
--           ,[Form]
--           ,[Rate]
--           ,[Color]
			)
     VALUES
           (@Bill_Item_Id
           ,@Delivery_Detail_Id
           ,@Quantity
--           ,@Form
--           ,@Rate
--           ,@Color
			)
	
	Declare @Id int
	set @Id = SCOPE_IDENTITY()
	select @Id