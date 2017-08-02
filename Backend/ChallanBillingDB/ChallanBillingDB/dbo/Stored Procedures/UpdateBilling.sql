CREATE PROCEDURE [dbo].[UpdateBilling]
(
	@Bill_Id int,
	@Date datetime,
	@Bill_No nvarchar(20)
)
AS
	SET NOCOUNT OFF;
	
	UPDATE [M_BILLING]
	   SET [Date] = @Date
		  ,[Bill_No] = @Bill_No
	 WHERE Bill_Id = @Bill_Id
	 
	 Select 1