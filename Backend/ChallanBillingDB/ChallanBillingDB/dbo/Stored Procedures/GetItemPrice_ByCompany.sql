
create PROCEDURE [dbo].[GetItemPrice_ByCompany]
(
	@Company_id int
	,@item_Id int
)
AS
	SET NOCOUNT ON;

select isnull(Item_Price, 0) as Item_Price
from M_Company_Item_Price 
where Item_Id = @item_Id and Company_id = @Company_Id