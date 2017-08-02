create PROCEDURE [dbo].[Get_Previous_Next_Billdate] --523, 6,1, '06/21/2012'
(   
    @Bill_Id int 
   ,@Company_id INT   
   ,@Bill_Type_Id INT
   ,@Bill_Date datetime 
)
AS
	SET NOCOUNT OFF;	
	Declare @Company_Type int	
	Select 	@Company_Type = Company_Type_Id from M_COMPANY where Company_id = @Company_id

   
		DECLare @lowerDate datetime,
		        @higherDate datetime,
                @BillNo_Code int	
                
	    Select 	@BillNo_Code = BillNo_Code from B_BILL where Bill_Id = @Bill_Id
	    	    
		SELECT Bill_Id,
		       Bill_Date, 
		       BillNo_Code
		into #billdetail
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
	
	  select @lowerDate = Bill_Date
	  from #billdetail
	  where BillNo_Code < @BillNo_Code
	  
	  select @higherDate = Bill_Date
	  from #billdetail
	  where BillNo_Code > @BillNo_Code
	select @lowerDate, @higherDate
	
	Drop table #billdetail