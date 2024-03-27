
--1. Write a T-Sql based procedure to generate complete payslip of a given employee with respect to the following condition

--   a) HRA as 10% of Salary
--   b) DA as 20% of Salary
--   c) PF as 8% of Salary
--   d) IT as 5% of Salary
--   e) Deductions as sum of PF and IT
--   f) Gross Salary as sum of Salary,HRA,DA
--   g) Net Salary as Gross Salary - Deductions


use Assignment2
select * from Employee


create or alter procedure GeneratePayslip @Eno INT
as
begin
declare @Salary int
declare @HRA int
declare @DA int
declare @PF int
declare @IT int
declare @Deductions int
declare @GrossSalary int
declare @NetSalary int
 
 -- Fetch Salary
select @Salary = salary
from Employee
where emp_no = @Eno
 
set @HRA = @Salary * 0.10
set @DA = @Salary * 0.20
set @PF = @Salary * 0.08
set @IT = @Salary * 0.05
set @Deductions = @PF + @IT
set @GrossSalary = @Salary + @HRA + @DA
set @NetSalary = @GrossSalary - @Deductions
--
select
Emp_no,
@Salary as Salary,
@HRA as HRA,
@DA as DA,
@PF as PF,
@IT as IT,
@Deductions as Deductions,
@GrossSalary as GrossSalary,
@NetSalary as NetSalary
from Employee
Where Emp_no = @Eno
end

select * from Employee

-- executing procedure
execute GeneratePayslip 7900
execute GeneratePayslip 7782
execute GeneratePayslip 7876
