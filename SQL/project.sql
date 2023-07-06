
/*CREATING THE TABLES*/
create table SAILOR(sailorid int not null primary key , sname nvarchar(20)not null,rating int not null, age int not null)
create table BOATS(bid int not null primary key,bname nvarchar(25) not null, colour nvarchar(20) not null)
create table RESERVES(  sailorid int FOREIGN KEY REFERENCES SAILOR(sailorid),bid int FOREIGN KEY REFERENCES BOATS(bid),day date)

/*INSERTING THE VALUES*/
insert SAILOR values(101,'Raja',4,35);
insert SAILOR values(102,'mathi',3,30);
insert SAILOR values(103,'Rajeesh',2,20);
insert SAILOR values(104,'Rajnesh',5,21);
insert SAILOR values(105,'Laxmeesh',4,18);

insert into BOATS values(1001,'Thousand sunny','red'),(1002,'blackpearl','black'),(1003,'Thrilling bark','Blue'),(1004,'Going Merry','White'),(1005,'Oro Jackson','Green');

insert into RESERVES values(101,1001,'2022/10/16'),(102,1002,'2022/08/12'),(103,1003,'2022/12/04'),(104,1004,'2022/11/17'),(105,1005,'2022/01/08') ;



select * from SAILOR;
SELECT * FROM BOATS;
select * from RESERVES;

/*Qn 1*/
select sname from SAILOR order by rating desc;

/*Qn 2*/
create view ratingsofsailor as select sname,rating from SAILOR where rating>3;
select * from ratingsofsailor;

/*Qn 3*/
	exec blucolboat;

/*Qn 4*/
select colour, count(bid) as numberofboats from BOATS group by colour;

/*Qn 5*/
select dbo.nameofsailor(101) as nameofsailor;
select dbo.nameofsailor(102) as nameofsailor;
select dbo.nameofsailor(103) as nameofsailor;
select dbo.nameofsailor(104) as nameofsailor;
select dbo.nameofsailor(105) as nameofsailor;

/*Qn 6*/
select day from RESERVES inner join BOATS
ON RESERVES.bid = BOATS.bid where colour='Green';
