Create database ITFIRM
use ITFIRM

create table Client(
Client_ID numeric(4) Primary Key,
Cname varchar(40) Not null,
Address varchar(30),
Email varchar(30) UNIQUE,
Phone numeric(10),
Business varchar(20) NOT NULL
)

 
create table Department(
Deptno numeric(2) Primary Key,
Dname varchar(15) NOT NULL,
Loc varchar(20)
)

 
create table Emoployees(
Empno numeric(4) Primary Key,
Ename varchar(20),
Job varchar(15),
Salary numeric(7) Check (salary>0),
Deptno numeric(2) Foreign Key References Department(Deptno)
)
 
create table Projects(
Project_ID numeric(3) Primary Key,
Descr varchar (30) NOT NULL,
StartDate Date,
Planned_End_Date Date,
Actual_End_Date Date, 
check (Actual_End_Date > Planned_End_Date),  
budget numeric check (budget>0),

Client_ID numeric(4) Foreign key references Client(Client_ID)
) 

 
create table EmpProjectTasks(
Project_ID numeric(3),
Empno numeric (4),
Startdate date,
Enddate date,
Task varchar(25) NOT NULL,
Status varchar(15) not null,
primary key(Empno,Project_Id),
foreign key (Project_Id) references Projects(Project_Id),
foreign key (Empno) references Emoployees(Empno)
)
 
select * from EmpProjectTasks
 
insert into Client values(1001, 'ACME Utilities', 'Noida' ,'contact@acmeutil.com', 9567880032 ,'Manufacturing'),
(1002 ,'Trackon Consultants', 'Mumbai' ,'consult@trackon.com', 8734210090 ,'Consultant'),
(1003 ,'MoneySaver Distributors', 'Kolkata', 'save@moneysaver.com', 7799886655 ,'Reseller'),
(1004, 'Lawful Corp', 'Chennai', 'justice@lawful.com', 9210342219, 'Professional')
 
 select * from Client
 
insert into Department values(10, 'Design', 'Pune'),(20,'Development', 'Pune'),(30, 'Testing', 'Mumbai'),
(40, 'Document', 'Mumbai')
select * from Department
 
insert into Emoployees values(7001, 'Sandeep', 'Analyst', 25000, 10),(7002, 'Rajesh', 'Designer', 30000, 10),
(7003, 'Madhav', 'Developer', 40000, 20),(7004, 'Manoj', 'Developer', 40000, 20),(7005, 'Abhay','Designer', 35000, 10),
(7006, 'Uma', 'Tester', '30000', 30),(7007, 'Gita','Tech. Writer', 30000, 40),(7008, 'Priya', 'Tester', 35000, 30),
(7009, 'Nutan', 'Developer', 45000, 20),(7010, 'Smita', 'Analyst', 20000, 10),(7011, 'Anand', 'Project Mgr', 65000, 10)
select * from Employees 
 
insert into Projects values(401, 'Inventory', '01-Apr-11', '01-Oct-11', '31-Oct-11', 150000, 1001),
(402, 'Accounting', '01-Aug-11',NULL, '01-Jan-12' ,500000, 1002),
(403, 'Payroll', '01-Oct-11',NULL, '31-Dec-11', 75000, 1003),
(404, 'Contact Mgmt', '01-Nov-11',NULL, '31-Dec-11', 50000, 1004)
 select * from Projects

insert into EmpProjectTasks values(401, 7001, '01-Apr-11', '20-Apr-11', 'System Analysis', 'Completed'),
(401, 7002, '21-Apr-11', '30-May-11', 'System Design', 'Completed'),
(401, 7003, '01-Jun-11', '15-Jul-11', 'Coding', 'Completed'),
(401, 7004, '18-Jul-11', '01-Sep-11', 'Coding', 'Completed'),
(401, 7006, '03-Sep-11', '15-Sep-11', 'Testing', 'Completed'),
(401, 7009, '18-Sep-11', '05-Oct-11', 'Code Change', 'Completed'),
(401, 7008, '06-Oct-11', '16-Oct-11' ,'Testing', 'Completed'),
(401, 7007, '06-Oct-11', '22-Oct-11', 'Documentation', 'Completed'),
(401, 7011, '22-Oct-11', '31-Oct-11', 'Sign off', 'Completed'),
(402, 7010, '01-Aug-11', '20-Aug-11', 'System Analysis', 'Completed'),
(402, 7002, '22-Aug-11', '30-Sep-11', 'System Design', 'Completed'),
(402, 7004, '01-Oct-11',NULL, 'Coding', 'In Progress')
select * from EmpProjectTasks
