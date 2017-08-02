CREATE PROCEDURE [dbo].[InsertBilling]
(
	@Purchases_Order_Id int,
	@Date datetime,
	@Bill_No nvarchar(20)
)
AS
	SET NOCOUNT OFF;
	
	INSERT INTO [M_BILLING]
			   ([Purchases_Order_Id]
			   ,[Date]
			   ,[Bill_No])
		 VALUES
			   (@Purchases_Order_Id
			   ,@Date
			   ,@Bill_No)
							
	Declare @Bill_Id int
	set @Bill_Id = SCOPE_IDENTITY()
	select @Bill_Id