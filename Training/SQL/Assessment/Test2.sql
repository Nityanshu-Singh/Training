use Assignment2

--Query 1. Write a query to display your birthday( day of week)

 begin
 declare @DOB Date = '2002-07-03'

 Select DateName (WeekDay,@DOB) as DayOfWeek
 end
-----------------------------------------------------------------------------

--Query 2. Write a query to display your age in days

begin
Declare @D_O_B Date = '2002-07-03'
Select DATEDIFF(Day, @D_O_B, GETDATE()) as AgeInDays
end
------------------------------------------------------------------------------
--Query 3. Write a query to display all employees information those who joined before 5 years in the current month
--         (Hint : If required update some HireDates in your EMP table of the assignment)
Update Employee  set Hire_Date = '2019-03-28'  where Emp_no= 7521
Update Employee  set Hire_Date = '2019-03-19'  where Emp_no= 7844

Select * from Employee
where DATEADD (year, 5, Hire_DAte) <= GETDATE() and
MONTH(Hire_Date)= Month(GetDAte()) and Year(Hire_DAte) = Year(GetDAte()) - 5
--------------------------------------------------------------------------------------

--Query 4. Create table Employee with empno, ename, sal, doj columns and perform the following operations in a single transaction
--	a. First insert 3 rows 
--	b. Update the second row sal with 15% increment  
--  c. Delete first row.
--     After completing above all actions how to recall the deleted row without losing increment of second row.

Create Table Employees (empno int, ename varchar(15),sal int,DOJ date)
-- Start the transaction
Begin Transaction
 
-- Insert 3 rows into the Employee table
Insert into Employees(empno, ename, sal, doj) VALUES
(1, 'Avi', 6000, '2024-02-15'),
(2, 'Nitya', 6500, '2024-02-15'),
(3, 'Satya', 8000, '2023-01-01')
-- Update the second row salary with a 15% increment
update Employees SET sal = sal * 1.15 where empno = 2
 
-- Delete the first row from the Employee table
DELETE FROM Employees where empno = 1
 
 select * from Employees

-- Commit the transaction
Commit
 
-- Retrieve the deleted row without losing the increment of the second row
SELECT * FROM Employees WHERE empno = 1 -- Empno. 1 but Record is deleted
SELECT * FROM Employees WHERE empno = 2 -- Empno. 2 will updated records

-------------------------------------------------------------------------------------------------------------
-- Query 5. Create a user defined function calculate Bonus for all employees of a  given job using 	following conditions
	--a.     For Deptno 10 employees 15% of sal as bonus.
	--b.     For Deptno 20 employees  20% of sal as bonus
	--c      For Others employees 5%of sal as bonus

	select * from Employee
	Select * from Department

CREATE FUNCTION dbo.CalculateBonus (@Dept_No INT, @Salary DECIMAL(10, 2))
RETURNS DECIMAL(10, 2)
AS
BEGIN
    DECLARE @Bonus DECIMAL(10, 2);
 
    IF @Dept_No = 10
        SET @Bonus = @Salary * 0.15; -- 15% bonus for Deptno 10 employees
    ELSE IF @Dept_No = 20
        SET @Bonus = @Salary * 0.20; -- 20% bonus for Deptno 20 employees
    ELSE
        SET @Bonus = @Salary * 0.05; -- 5% bonus for other employees
 
    RETURN @Bonus;
END;
-- calling the function
declare @Salary int = 960
declare @Dept_no INT = 20
 
select @Salary as salary,@Dept_no as DepartmentNO, dbo.CalculateBonus(@Dept_no, @Salary) as Bonus

