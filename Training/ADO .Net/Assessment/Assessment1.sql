-- Create a database called Employeemanagement----
create database EmployeeManagement

use EmployeeManagement

--Create a table in the database called Employee_Details
create table Employee_Details(
EmpNo int Primary Key,
EmpName varchar(50) NOT NULL, 
EmpSal numeric (10,2) check (EmpSal >= 2500),
Emptype char (1) check (Emptype in ('P' , 'C')))

--drop table Employee_Details

--1. Create a stored procedure that adds new rows to the 
--Employee_Details Table. The procedure should accept all 
--the details as input except empno. You need to write the
--code in the procedure to generate the empno and then insert---

create or alter procedure AddEmployee
@empname Varchar(50),
@empsal numeric(10,2),
@emptype char(1)

as
begin
-- generating empno...
declare @empno int =0;
select @empno = (count(EmpNo)) + 1 from Employee_Details
 
insert into Employee_Details (EmpNo,EmpName,EmpSal,Emptype) values(@empno,@empname,@empsal,@emptype)
end

--2. Check the procedure

AddEmployee 'Nitya', 35000, 'P'

AddEmployee 'Sam', 40000, 'C'

select * from Employee_Details
