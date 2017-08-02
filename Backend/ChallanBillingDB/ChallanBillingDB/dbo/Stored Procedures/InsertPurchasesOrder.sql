CREATE PROCEDURE [dbo].[InsertPurchasesOrder]
(
	@Company_id int,
	@Date datetime,
	@Purchases_Order_No VARCHAR(100)
)
AS
	SET NOCOUNT OFF;
INSERT INTO [M_PURCHASES_ORDER] 
			( [Company_id]
			, [Date]
			, [Purchases_Order_No]
			) 
	VALUES (  @Company_id
			, @Date
			, @Purchases_Order_No
			);
	
SELECT (SCOPE_IDENTITY())



SET ANSI_NULLS ON