use Assignment2

select * from Department
select * from Employee

--1. Retrieve a list of MANAGERS.
select Emp_name,job from employee where job='Manager'
-----------------------------------------------------------------------------------------

--2. Find out the names and salaries of all employees earning more than 1000 per month. 
select Emp_Name,salary from employee where Salary>1000
------------------------------------------------------------------------------------------

--3. Display the names and salaries of all employees except JAMES. 
select Emp_name,salary from employee where emp_name!='JAMES'
-------------------------------------------------------------------------------------------

--4. Find out the details of employees whose names begin with ‘S’. 
select * from Employee where emp_name like 'S%'
--------------------------------------------------------------------------------------------

--5. Find out the names of all employees that have ‘A’ anywhere in their name.\
select * from Employee where Emp_Name like '%A%'
--------------------------------------------------------------------------------------------

--6. Find out the names of all employees that have ‘L’ as their third character in their name. 
select * from Employee where Emp_Name like '__L%'
--------------------------------------------------------------------------------------------

--7. Compute daily salary of JONES.
select *, (salary/30) as 'Per Day Salary' from Employee where emp_no=7566
--------------------------------------------------------------------------------------------

--8. Calculate the total monthly salary of all employees. 
select sum(salary) as 'Total Salary' from Employee
--------------------------------------------------------------------------------------------

--9. Print the average annual salary .
begin
declare @res int 
select @res = avg(salary*12) from Employee
print 'Average Annual Salary of All Employees: ' + cast(@res as varchar(10))
end
--------------------------------------------------------------------------------------------

--10. Select the name, job, salary, department number of all employees except SALESMAN from department number 30. 
select emp_name,job,salary,Dept_no from Employee where job!='SALESMAN' and dept_no!=30
--------------------------------------------------------------------------------------------

--11. List unique departments of the EMP table. -> 
select Distinct dept_no from Employee
--------------------------------------------------------------------------------------------

--12. List the name and salary of employees who earn more than 1500 and are in department 10 or 30. 
--Label the columns Employee and Monthly Salary respectively.
select emp_name as Employee,Salary as Monthly_Salary, dept_no from Employee where salary>1500 and Dept_no in(10,30)
--------------------------------------------------------------------------------------------

--13. Display the name, job, and salary of all the employees whose job is MANAGER or 
--ANALYST and their salary is not equal to 1000, 3000, or 5000. 
select Emp_name,job,salary from Employee where job in ('MANAGER','ANALYST') and Salary not in(1000,3000,5000)
--------------------------------------------------------------------------------------------

--14. Display the name, salary and commission for all employees whose commission amount is greater than their 
--salary increased by 10%.
select Emp_name,salary 'Old Salary',[comm], (Salary*1.1) as 'New Salary' from Employee where Salary<[comm]
--------------------------------------------------------------------------------------------

--15. Display the name of all employees who have two Ls in their name and are in department 30 or their manager is 7782.
select Emp_name from Employee where Emp_name like '%L%L%' and Dept_no=30 or [Mgr_id] like 7782 
--------------------------------------------------------------------------------------------

--16. Display the names of employees with experience of over 30 years and under 40 yrs.
--Count the total number of employees.

select Emp_name,count(*) as Total_Employee  from Employee where datediff(yy,Hire_date,getdate()) between 30 and 40 group by (Emp_Name) 
--------------------------------------------------------------------------------------------

--17. Retrieve the names of departments in ascending order and their employees in descending order. 
select d.dept_name as Department,e.emp_name from Department d join Employee e on d.dept_no=e.Dept_no order by d.Dept_Name, e.Emp_Name desc
--------------------------------------------------------------------------------------------

-- 18. Find out experience of MILLER. 
begin
declare @exp date
select @exp = hire_date from Employee where Emp_Name='MILLER'
select DATEDIFF(yy,@exp,getdate()) as Experience
end
--------------------------------------------------------------------------------------------