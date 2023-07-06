use sample;
select [dbo].[udf_EmpNameDisp] (100,
(select staff_sal from staff_Master where Staff_Code=3)) newsal;
use sample;
select [dbo].[udf_EmpName](101);
select eno,ename from [dbo].[udf_Emp]();
select 