CREATE PROCEDURE [dbo].[InsertDeliveryDetail]
(
	@Delivery_Id int,
	@Purchase_Order_Detail_Id int,
	@Deliver_Quantity float
)
AS
	SET NOCOUNT OFF;
INSERT INTO [M_Delivery_Detail](  
						 [Delivery_Id]
						, [Purchase_Order_Detail_Id]
						, [Deliver_Quantity]
																
					  )
			 VALUES 
					( @Delivery_Id
					, @Purchase_Order_Detail_Id
					, @Deliver_Quantity
					
					 );
						
Declare @Delivery_Detail_Id int
set @Delivery_Detail_Id = SCOPE_IDENTITY()
select  @Delivery_Detail_Id