CREATE PROCEDURE [dbo].[UpdatePackagingDetails]
(
	@Packaging_Description nvarchar(500),
    @Packaging_id int

	)
AS
	SET NOCOUNT OFF;
UPDATE [M_PACKAGING_DETAIL] 
  SET  [Packaging_Description] = @Packaging_Description
			 			
 WHERE [Packaging_id] = @Packaging_id ;