CREATE PROCEDURE [dbo].[UpdateBillDetail]
(
	 @Bill_Item_Id INT	
	,@Delivery_Detail_Id INT	
	,@Quantity float	
    ,@Bill_Detail_Id INT
)
AS
	SET NOCOUNT OFF;
	
	UPDATE [B_BILL_DETAIL]
   SET [Delivery_Detail_Id] = @Delivery_Detail_Id
      ,[Quantity] = @Quantity   
 WHERE Bill_Detail_Id = @Bill_Detail_Id