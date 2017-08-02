--exec [GetUserPermission] '8c84c746-c5e3-44eb-aebd-478218300ab7'
CREATE procedure [dbo].[GetUserPermission] 
(
	@SecurityGroup_Id nvarchar(100)
)

as
SET FMTONLY OFF
if( object_id('tempdb..#RoleIds') is not null ) drop table #RoleIds
; with cte 
as
	(SELECT value as SecurityGroup_Id
	FROM STRING_SPLIT(@SecurityGroup_Id, ',')  
	WHERE RTRIM(value) <> ''
)
select Role_Id
into #RoleIds
from cte inner join 
Lk_Role R on R.SecurityGroup_Id = cte.SecurityGroup_Id and R.IsActive = 1

select distinct FRP.Feature_Id
from Feature_Role_Permission FRP inner join 
#RoleIds R on R.Role_Id = FRP.Role_Id and FRP.IsActive=1