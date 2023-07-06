create table Customer(
Custid int primary key, Custname nvarchar(20),Age int,Phone bigint);

create table Loan(
Loanid int primary key,Amount bigint,Custid int foreign key references Customer(Custid),EMI bigint);

create table Account (Acno int primary key,Custid int foreign key references Customer(Custid),Balance bigint);


insert into Customer values(100,'Smith',26,9496296848)
insert into Customer values(101,'Dhoni',29,9948991382)
insert into Customer values(102,'kholi',43,9296245748)
insert into Customer values(103,'ABD',36,87165686126)
insert into Customer values(104,'sachin',34,9172926848)

insert into loan values(1001,625000,100,35000)
insert into loan values(1002,455000,101,65000)
insert into loan values(1003,925000,102,25000)
insert into loan values(1004,750000,103,75000)
insert into loan values(1005,800000,104,45000)

insert into Account values(894512,100,800)
insert into Account values(894513,101,1800)
insert into Account values(894514,102,7800)
insert into Account values(894515,103,1000)
insert into Account values(894516,104,80)


select * from Customer;
select * from Loan
select * from Account

select Loanid from Loan
where EMI>=50000


select EMI , count(Amount) as "Number of loans" from Loan group by EMI

select EMI from Loan inner join Customer
ON Loan.Custid = Customer.Custid where Custname='Smith'

select count(Loanid) as total from Loan

