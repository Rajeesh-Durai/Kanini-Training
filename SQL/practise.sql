create table team1(rno int primary key,
sname nvarchar(20),
ph int);
select * from team1
insert team1 values (1,'raja',78945)
insert team1 values (2,'mathi',15963)
insert team1 values (3,'rajeesh',45682)
insert team1 values (4,'rajnesh',124587)

create table team2(rno int not null foreign key references team1(rno),
attendance nvarchar(5),
mail nvarchar(50)
);
select * from team2;
insert team2 values (1,'p','afduvbuvbds')
insert team2 values (2,'A','afduvbuvbds')
insert team2 values (3,'p','afduvbuvbds')
insert team2 values (4,'A','afduvbuvbds')

select team1.sname, team2.attendance from team1
FULL OUTER JOIN team2 ON team1.rno=team2.rno
ORDER BY team1.rno


update team1
set sname='laxmeesh'
where rno=3
