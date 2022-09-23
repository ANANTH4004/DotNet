use Shopping

create table Member_C
(
Member_Id int primary key,
Acc_Open_Date date default sysdatetime(),
Max_allowed_books int,
penalty money
)
select*from Member_C

alter table Member_C
add constraint chk_book check(Max_allowed_books < 100)

alter table Member_C
add constraint chk_penalty check(penalty <= 1000)

create table Book_C
(
Book_No int primary key,
Book_name varchar(20) not null,
Category varchar(20) ,
constraint chk check(Category in ('Database', 'Science','Fiction','Rdbms','other'))
)

create table Issue_C
(
Lib_Issue_Id int primary key,
Member_Id int constraint fk_memfk foreign key references Member_C(Member_id),
Book_No int constraint fk_bfk foreign key references Book_C(Book_no),
Issue_date date,
Return_date date,
constraint chk_date check(Issue_date < return_date)
)

alter table Book_C
add price int constraint chk_price check(price < 2500)

create view v_issues
as
select Lib_Issue_Id,book_no,member_id  from Issue_C

select * from v_issues


alter table issue_c
drop constraint chk_date

insert into Book_C values (1,'life','database',700)

create view v_book
as
select * from Book_C
where price >500

select * from v_book

insert into v_book
values (3,'dreamboy','fiction',300)

insert into v_book
values (5,'mom','fiction',800)

 update v_book
 set price = 900
 where Book_No=5

 delete v_book
 where book_no=5

 
create nonclustered index bname
on Book_C(book_name)

create index c_idandbookno
on Issue_c(member_id,book_no)


