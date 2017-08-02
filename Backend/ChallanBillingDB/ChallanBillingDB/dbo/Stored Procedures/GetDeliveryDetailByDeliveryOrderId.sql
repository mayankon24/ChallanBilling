CREATE PROCEDURE [dbo].[GetDeliveryDetailByDeliveryOrderId]
(
	@Delivery_Id int
   ,@Purchases_Order_Id int 
)
AS
	SET NOCOUNT ON;
--SELECT Delivery_Detail_Id
--	, Item_Name
--	, Item_Quantity
--	, Item_Rate
--	, Total_Amount
--	, Deliver_Quantity
-- FROM M_PURCHASES_ORDER_DETAIL Left JOIN
--      M_DELIVERY_DETAIL ON M_PURCHASES_ORDER_DETAIL.Purchase_Order_Detail_Id = M_DELIVERY_DETAIL.Purchase_Order_Detail_Id and Delivery_Id = @Delivery_Id

SELECT M_PURCHASES_ORDER_DETAIL.Purchase_Order_Detail_Id
	  ,IS_Item_Deliver = CASE
							WHEN Delivery_Detail_Id IS null then 0
							else 1
						 END
						 	  
	  ,ISNULL(Delivery_Detail_Id,0) as Delivery_Detail_Id
	  ,I.Item_Name
	  ,Item_Quantity
	  ,Item_Rate
	  ,Total_Amount
	  ,ISNULL(Deliver_Quantity, 0) AS Deliver_Quantity
 FROM M_PURCHASES_ORDER_DETAIL inner join
       Item I on M_PURCHASES_ORDER_DETAIL.Item_Id = I.Item_Id  LEFT JOIN 
	  M_DELIVERY_DETAIL ON M_PURCHASES_ORDER_DETAIL.Purchase_Order_Detail_Id = M_DELIVERY_DETAIL.Purchase_Order_Detail_Id and Delivery_Id = @Delivery_Id
WHERE Purchases_Order_Id = @Purchases_Order_Id
ORDER BY I.Item_Name