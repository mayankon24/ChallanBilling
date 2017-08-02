CREATE PROCEDURE [dbo].[DeleteBillDetail]
(	 
    @Bill_Detail_Id INT
)
AS
	SET NOCOUNT OFF;
	
	DELETE [B_BILL_DETAIL]  
	WHERE Bill_Detail_Id = @Bill_Detail_Id