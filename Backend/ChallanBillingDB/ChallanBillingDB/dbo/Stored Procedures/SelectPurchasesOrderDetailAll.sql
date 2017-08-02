﻿CREATE PROCEDURE [dbo].[SelectPurchasesOrderDetailAll]
AS
	SET NOCOUNT ON;
SELECT Purchase_Order_Detail_Id
	, Purchases_Order_Id
	, I.Item_Name
	,I.Item_Id
	, Item_Quantity
	, Item_Rate
	, Total_Amount
FROM M_PURCHASES_ORDER_DETAIL inner join
     Item I on M_PURCHASES_ORDER_DETAIL.Item_Id = I.Item_Id 
oRDER BY I.Item_Name