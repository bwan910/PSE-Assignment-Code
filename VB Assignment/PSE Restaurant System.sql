--CREATE TABLE Employee(
--emp_id int NOT NULL IDENTITY(1,1) PRIMARY KEY, 
--emp_name varchar(255),
--emp_phone varchar(10),
--emp_password varchar(255)
--);

Select * FROM Employee
--Drop Table Employee

--CREATE TABLE Member(
--member_id int NOT NULL IDENTITY(1,1) PRIMARY KEY,
--member_name varchar(255),
--member_phone varchar(10)
--);

Select * FROM Member


--CREATE TABLE Menu(
--item_id int NOT NULL PRIMARY KEY,
--item_name varchar(255),
--item_price decimal,
--item_type  char(20)
--);

Select * FROM Menu
--INSERT INTO Menu VALUES('1','Cake',3,'Food');
--INSERT INTO Menu VALUES('2','Juice',2, 'Beverage');
--INSERT INTO Menu VALUES('3','Latte',3,'Beverage');
--INSERT INTO Menu VALUES('4','Lemonade',2,'Beverage');
--INSERT INTO Menu VALUES('5','Pizza',5,'Food');
--INSERT INTO Menu VALUES('6','Ramen',6,'Food');



--CREATE TABLE Ordering (
--order_id int IDENTITY(1,1) PRIMARY KEY,
--order_num int NOT NULL,
--item_id Varchar(255),
----DrinkID int,
--quantity int,
--total_price decimal,
--emp_id int,
--member_id int,
----FOREIGN KEY (DrinkID) REFERENCES Drink,
--FOREIGN KEY (emp_id) REFERENCES Employee,
--FOREIGN KEY (member_id) REFERENCES Member
--);

Select * From Ordering
--Drop Table Ordering

--SELECT * FROM Ordering
INSERT INTO Ordering([order_num],[item_id],[quantity]) VALUES('100','1','1');
--INSERT INTO OrderD([OrderNum],[DrinkID],[Quantity]) VALUES('101','02','1');
--INSERT INTO OrderD([OrderNum],[DrinkID],[Quantity]) VALUES('101','01','1');
--INSERT INTO OrderD([OrderNum],[DrinkID],[Quantity]) VALUES('102','01','1');
--INSERT INTO OrderD([OrderNum],[DrinkID],[Quantity]) VALUES('103','01','1');
SELECT MAX(order_num) AS Latest From Ordering

SELECT emp_id AS EMPID From Employee Where emp_name = 'Brand'

SELECT Menu.item_id,Menu.item_name,Ordering.quantity,Ordering.total_price
FROM Ordering 
JOIN Menu ON Ordering.item_id = Menu.item_id
WHERE order_num = 107