CREATE PROCEDURE [dbo].[UpdateDelivery]
(
	@company_id int,
	@purchases_order_id int,
	@delivery_no nvarchar(50),
	@delivery_date datetime,
	@future1 nvarchar(10),
	@future2 nvarchar(10),
    @Delivery_id int
		
)
AS
	SET NOCOUNT OFF;
UPDATE [M_Delivery] 
  SET  [company_id] = @company_id
	 , [purchases_order_id] = @purchases_order_id
	 , [delivery_no] = @delivery_no
	 , [delivery_date] = @delivery_date
	 , [future1] = @future1
	 , [future2] = @future2
	 			
 WHERE [Delivery_id] = @Delivery_id;