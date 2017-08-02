CREATE PROCEDURE [dbo].[UpdateBilllItem]
(	
	 @Item_Name nvarchar(150)   
	,@Item_Id int    
	,@Quantity float
	,@Form DECIMAL(10,4)
	,@Color INT
	,@Rate DECIMAL(10,4)
	,@Bill_Item_Id INT	
)
AS
	SET NOCOUNT OFF;
	
	UPDATE [B_BILL_ITEM]
	   SET [Quantity] = @Quantity
		  ,[Form] = @Form
		  ,[Rate] = @Rate
		  ,[Color] =@Color
          ,Item_Name = @Item_Name 
          ,Item_Id = @Item_Id
	 WHERE Bill_Item_Id = @Bill_Item_Id
		
	select 1