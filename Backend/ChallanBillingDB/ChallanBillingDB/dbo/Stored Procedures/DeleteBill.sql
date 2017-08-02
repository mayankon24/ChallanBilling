Create PROCEDURE [dbo].[DeleteBill]
(	
   @Bill_Id INT
)
AS
	SET NOCOUNT OFF;
	
	DELETE B_BILL 
 WHERE Bill_Id = @Bill_Id