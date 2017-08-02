
CREATE PROCEDURE [dbo].[InsertItemName]
(
	@Item_Name nvarchar(max)
	,@HSN_Code nvarchar(50)
)
AS
	SET NOCOUNT OFF;
INSERT INTO [BillingChallan].[dbo].[Item]
           ([Item_Name]
		   ,HSN_Code)
     VALUES
           (@Item_Name
		   ,@HSN_Code)	
           				
Declare @Item_Id int
set @Item_Id = SCOPE_IDENTITY()
select @Item_Id