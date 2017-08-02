CREATE PROCEDURE [dbo].[GetItemPriceList]
(
	@Company_id int
)
AS
	SET NOCOUNT ON;

select I.Item_Id
       ,I.Item_Name 
	   ,isnull(Company_Item_Id, 0) as Company_Item_Id
	   ,isnull(Item_Price, 0) as Item_Price
from Item I left join 
M_Company_Item_Price CIP on I.Item_Id = CIP.Item_Id and Company_id = @Company_Id
order by I.Item_Name