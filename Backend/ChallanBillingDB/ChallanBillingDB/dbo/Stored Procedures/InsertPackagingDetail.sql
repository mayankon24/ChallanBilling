CREATE PROCEDURE [dbo].[InsertPackagingDetail]
(
	@Delivery_Detail_Id int,
	@Packaging_Description nvarchar(500)
)
AS
	SET NOCOUNT OFF;
INSERT INTO [M_Packaging_Detail](  
						 [Delivery_Detail_Id]
						, [Packaging_Description]
																					
					  )
			 VALUES 
					( @Delivery_Detail_Id
					, @Packaging_Description
					
					 );
						
Declare @Packaging_Id int
set @Packaging_Id = SCOPE_IDENTITY()
select  @Packaging_Id