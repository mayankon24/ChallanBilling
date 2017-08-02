create PROCEDURE [dbo].[GetLastBilldate] --57,1, '03/30/2012'
(   
    @Company_id INT   
   ,@Bill_Type_Id INT
   ,@Bill_Date datetime 
)
AS
	SET NOCOUNT OFF;	
	Declare @Company_Type int	
	Select 	@Company_Type = Company_Type_Id from M_COMPANY where Company_id = @Company_id



	select Bill_Date
	from
	(
		SELECT RANK() over( ORDER BY BillNo_Code desc) as r, --ISNULL(max(BillNo_Code), 0),
		       Bill_Date 
		FROM B_BILL	INNER JOIN 
			 M_COMPANY ON B_BILL.Company_id = M_COMPANY.Company_id
		Where
		(
			((@Bill_Type_Id = 1 or @Bill_Type_Id = 3 ) AND (Bill_Type_Id = 1 or Bill_Type_Id = 3))
			OR ((@Bill_Type_Id = 4 or @Bill_Type_Id = 2 ) AND (Bill_Type_Id = 4 or Bill_Type_Id = 2))
		)
		And M_COMPANY.Company_Type_Id = @Company_Type
		AND Bill_Date >= case 
								when month(@Bill_Date) >= 4	then DATEADD(YEAR, year(@Bill_Date)-1900, DATEADD(MONTH, 3, 0))
								when month(@Bill_Date) < 4	then DATEADD(YEAR, year(@Bill_Date)-1900 -1, DATEADD(MONTH, 3, 0))
					     end  
		AND Bill_Date <= case 
								when month(@Bill_Date) >= 4	then DATEADD(YEAR, year(@Bill_Date)-1900 +1, DATEADD(MONTH, 3, -1)) 
								when month(@Bill_Date) < 4	then DATEADD(YEAR, year(@Bill_Date)-1900, DATEADD(MONTH, 3, -1))
						 end
	)bill
	where R = 1



/****** Object:  StoredProcedure [dbo].[UpdateBill]    Script Date: 12/22/2011 01:43:00 ******/
SET ANSI_NULLS ON