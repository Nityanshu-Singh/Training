use Assignment2

--Query1:- Write a T-SQL Program to find the factorial of a given number
begin
declare @n int= 1
declare @result bigint
set @result = 1
declare @number numeric
set @number = 12
while @n <= @number 
begin
set @result = @result * @n
set @n = @n + 1
End
print 'Factorial of given number is:' + cast(@result as varchar(50))
End

--Query 2:- Create a stored procedure to generate multiplication tables up to a given number.
Create OR alter proc multiplication @num int
as
begin
    declare @count int = 1
    declare @res int
	declare @Tbl int  =1
 
while @Tbl <= @num   -- printing table from 1 to 5(given number)
begin
    while @count <= 10
    begin
        print cast(@Tbl as varchar(10)) + ' * ' + cast(@count as varchar(10)) + ' = ' + cast(@tbl*@count as varchar(10))
        set @count = @count + 1
    end
	set @count =1
	set @Tbl = @Tbl+1
	end
end
-- call the multiplication Procedure
exec multiplication 5

---------------------------------------------------------------------------------------
--Query 3:- Create a trigger to restrict data manipulation on EMP table during General holidays.
--          Display the error message like “Due to Independence day you cannot manipulate data” or "Due To Diwali", you cannot manupulate" etc
--Note:-    Create holiday table as (holiday_date,Holiday_name) store at least 4 holiday details. Try to match and stop manipulation 

create table holiday
(
holidayDate date,
HolidayName varchar (30)
)
insert into holiday values('2024-03-26','HOLI'),('2024-04-20','EID'),('2024-01-26','Republic Day'),('2024-10-31','Diwali'),
('2024-12-25','Christmas Day'),('2025-01-01','NEW YEAR')
select * from holiday
 drop table holiday
create table Employeetb(
Empname varchar(10),
loc varchar(10),
date date)
insert into Employeetb  values('Ram','NOIDA','2024-10-01'),('Sita','Delhi','2024-07-22'),('Rohan','Mumbai','2025-11-08')
select * from Employeetb
 
--create Trigger
create or alter trigger ManipualteTrig
on Employeetb
instead of insert,update,delete
as
begin
declare @count int
declare @holiday_name varchar(30)
select @count= count(* )from holiday where holidaydate = convert(date,getdate())
if @count>0 
  begin
		select @holiday_name=holidayname from holiday where holidaydate=convert(date,GETDATE())
		raiserror ('Due to %s, you cannot manipulate on date',12,1,@holiday_name)
  end
end
select * from Employeetb
insert into Employeetb values('Satyam','Chennai','2024-03-25')