CREATE PROCEDURE [dbo].[InsertBillItemNarration]
(
	 @Bill_Item_Id INT
    ,@Narration NVARCHAR(1000)
)
AS
	SET NOCOUNT OFF;
	
	INSERT INTO [B_BillItem_Narration]
			   ([Bill_Item_Id]
			   ,[Narration])
		 VALUES
			   (@Bill_Item_Id
			   ,@Narration)
		
	Declare @Id int
	set @Id = SCOPE_IDENTITY()
	select @Id