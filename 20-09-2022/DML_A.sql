--use pubs
select * from titles
where type like 'business';

select * from titles
where  pubdate >'1991-06-12' and type <> 'business'

select * from titles
where pub_id != 1389
order by pub_id desc , title_id asc;

select * from titles
where pub_id != 1389
order by pub_id desc , advance asc;


--Grouped Data:

select COUNT(employee.emp_id)as Emp_Count from employee

select COUNT(titles.title) as Book_Count from titles
where type like 'business'

select sum(advance) from titles
where advance = 5000;

select min(advance) from titles
select max(advance) from titles

select AVG(advance) from titles

--minimum advance for each type
select min(advance) as minimum_Advance,type  from titles
group by type

