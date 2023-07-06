use sample;
CREATE TABLE EmpLog (
	LogID int IDENTITY(1,1) NOT NULL,
	EmpID int NOT NULL,
	Operation nvarchar(10) NOT NULL,
	UpdatedDate Datetime NOT NULL	
)
create or alter trigger dbo.trgEmpInsert
on dbo.student
for insert
as
insert into dbo.EmpLog(EMpId, Operation, UpdatedDate)
select rno ,'INSERT',GETDATE() FROM inserted;
select * from student;
select * from dbo.EmpLog;
insert into student (rno,sname,ph) values (111,'Rajnesh',78945613)


-- DDL Trigggers

create table dbo.TableLog
(
LogID int identity(1,1) Primary key,
EventVal xml not null,
EventDate datetime NOT null,
ChangedBy sysname not null
)

create trigger trgTablechanges
ON DATABASE
FOR
	CREATE_TABLE, ALTER_TABLE, DROP_TABLE
AS
BEGIN
	INSERT INTO TableLog(EventVal, EventDate, ChangedBy)
	VALUES(EVENTDATA(), GETDATE(), USER);
END;

create table Dummy(testid int identity(1, 1) PRIMARY KEY, testname SYSNAME NOT NULL);



--LOGIN

create trigger tryloginCon
on all server
for logon
as
begin
if (ORIGINAL_LOGIN()=N'sa' AND
	(select COUNT(*) from sys.dm_exec_sessions
	where is_user_process=1 AND
	original_login_name=N'sa')>2)
	ROLLBACK;
	END