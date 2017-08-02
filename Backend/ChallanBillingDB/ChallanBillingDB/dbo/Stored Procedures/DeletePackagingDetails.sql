CREATE PROCEDURE [dbo].[DeletePackagingDetails]
(
	@Packaging_Id int
)
AS
	SET NOCOUNT OFF;
DELETE FROM [M_Packaging_Detail] WHERE (([Packaging_Id] = @Packaging_Id))