
create PROCEDURE [dbo].[SaveItemPrice]
(
	@Company_id int
	,@udt_Company_Item_Price udt_Company_Item_Price readonly
)
AS
	SET NOCOUNT ON;



MERGE M_Company_Item_Price AS T
USING @udt_Company_Item_Price AS S
ON (T.Company_Item_Id = S.Company_Item_Id and T.Company_id = @Company_id) 
WHEN NOT MATCHED BY TARGET 
    THEN INSERT(Company_Id ,Item_Id ,Item_Price) VALUES(@Company_id, S.Item_Id, S.Item_Price)
WHEN MATCHED 
    THEN UPDATE SET T.Item_Price = S.Item_Price;