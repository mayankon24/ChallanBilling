CREATE PROCEDURE [dbo].[DeleteCompany]
(
	@Company_Id int
)
AS
	SET NOCOUNT OFF;
DELETE FROM [M_COMPANY] WHERE (([Company_Id] = @Company_Id))