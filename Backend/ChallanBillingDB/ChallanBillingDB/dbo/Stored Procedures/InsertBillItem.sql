CREATE PROCEDURE [dbo].[InsertBillItem]
(
	 @Bill_Id INT
	,@Item_Name nvarchar(150)
	,@Item_Id int
    ,@Purchase_Order_Detail_Id INT
	,@Quantity float
	,@Form DECIMAL(10,4)
	,@Color INT
	,@Rate DECIMAL(10,4)
	,@parent_Id INt
)
AS
	SET NOCOUNT OFF;
	
	INSERT INTO [B_BILL_ITEM]
			   ([Bill_Id]
			   ,[Item_Name]
			   ,Item_Id
			   ,[Purchase_Order_Detail_Id]
			   ,[Quantity]
			   ,[Form]
			   ,[Rate]
			   ,[Color]
			   ,[parent_Id])
		 VALUES
			   (@Bill_Id
			   ,@Item_Name
			   ,@Item_Id
			   ,@Purchase_Order_Detail_Id
			   ,@Quantity
			   ,@Form
			   ,@Rate
			   ,@Color
			   ,@parent_Id)
		
	Declare @Id int
	set @Id = SCOPE_IDENTITY()
	select @Id