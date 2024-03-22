create database Assessment1
use Assessment1

-- create table book
create table books(id numeric(4),title varchar(25),Author varchar(20),
Isbn numeric(18), Published_Date Date)

--Insert Value in table book
Insert into books values
(1, 'My First SQL book', 'Mary Parker',981483029127,'2012-02-22'),
(2, 'My Second SQL book', 'John Mayer',857300923713,'1972-07-03'),
(3, 'My Third SQL book', 'Cary Flint',523120967812,'2015-10-18')
select * from books

create table reviews(id numeric(4), book_id numeric(4),reviewer_name varchar(20), 
content varchar(25),roting numeric(4),published_date date)

insert into reviews values
(1,1,'John Smith','My first review',4,'2017-12-10'),
(2,2,'John Smith','My second review',5,'2017-10-13'),
(3,3,'Alice Walker','Another review',1,'2017-10-22')
select * from reviews

--Query 1 :-
--Write a query to fetch the details of the books written by author whose name ends with er.

Select * from books where Author like '%er'

--Query 2 :-
--Display the Title ,Author and ReviewerName for all the books from the above table

select Title,Author,Reviewer_name from books b, reviews r  where b.id=r.id

--Query 3:-
--Display the reviewer name who reviewed more than one book.

select reviewer_name from reviews
group by reviewer_name having count(reviewer_name)>1  
-------------------------------------------------------------

create table customer(Id int identity,Name varchar (20),age int,
Address varchar(20),Salary float)
 
insert into customer values 
('Ramesh',32,'Ahmedabad',2000),
('Khilan',25,'Delhi',1500),
('Kaushik',23,'Kota',2000),
('Chaitali',25,'Mumbai',6500),
('Hardik',27,'Bhopal',8500),
('Komal',22,'MP',4500),
('Muffy',24,'Indore',10000)

--Query 4:-
--Display the Name for the customer from above customer table who live in
--same address which has character o anywhere in address

select name from customer where Address like '%o%'

create table orders(
OID int,
Date date,
Customer_id int,
Amount int)
 
insert into orders values 
(102,'2009-10-08',3,3000),
(100,'2009-10-08',3,1500),
(101,'2009-11-20',2,1560),
(103,'2008-05-20',4,2060)
select * from orders
select * from customer

--Query 5:-
-- Write a query to display the Date,Total no of customer placed order on same Date
SELECT Date, COUNT(Customer_id) AS TotalCustomers
From orders group by DATE;
----------------------------------------------------------------------------------
Create Table Employee
(ID int,Name varchar(15),Age int,Address varchar(20),Salary decimal)
INSERT INTO EMPLOYEE VALUES 
(1, 'Ramesh', 32, 'Ahmedabad', 2000.00),
(2, 'Khilan', 25, 'Delhi', 1500.00),
(3, 'Kaushik', 23, 'Kota', 2000.00),
(4, 'Chaitali', 25, 'Mumbai', 6500.00),
(5, 'Hardik', 27, 'Bhopal', 8500.00),
(6, 'Komal', 22, 'MP', NULL),
(7, 'Muffy', 24, 'Indore', NULL);
 
-- Query 6: Display names of employees in lowercase whose salary is null
Select lower(name) AS LowercaseName
from Employee where Salary IS NULL;
 
-- Create StudentDetails Table
CREATE TABLE StudentDetails
(RegisterNo INT Primary key,Name Varchar(20),Age INT,Qualification VARCHAR(20),
MobileNo numeric(12),Mail_id VARCHAR(50),Location VARCHAR(15),Gender varchar(1))
 
-- Insert data into StudentDetails Table
Insert into StudentDetails values
(1, 'Sai', 22, 'B.E', 9952836777, 'Sai@gmail.com', 'Chennai', 'M'),
(2, 'Kumar', 20, 'BSC', 7890125648, 'Kumar@gmail.com', 'Madurai', 'M'),
(3, 'Selvi', 22, 'B.TECH', 8904567342, 'selvi@gmail.com', 'Salem', 'F'),
(4, 'Nisha', 25, 'M.E', 7834672310, 'Nisha@gmail.com', 'Theni', 'F'),
(5, 'SaiSaran', 21, 'B.A', 7890345678, 'saran@gmail.com', 'Madurai', 'F'),
(6, 'Tom', 23, 'BCA', 8901234675, 'Tom@gmail.com', 'Pune', 'M');
 
-- Query 7: Display gender and total count of males and females from the StudentDetails table
Select Gender, COUNT(*) AS TotalCount
from StudentDetails group by Gender;