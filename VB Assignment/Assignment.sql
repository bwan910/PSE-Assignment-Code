--CREATE TABLE Employee (
--EmpID int NOT NULL PRIMARY KEY,
--EmpName varchar(255),
--EmpAge int,
--EmpPhone varchar(10),
--EmpPassword int
--);


--CREATE TABLE Customer (
--CustomerID int NOT NULL PRIMARY KEY,
--CustomerName varchar(255),
--CustomerPhone varchar(10),
--MemberID int
--);

--CREATE TABLE Food (
--FoodID int NOT NULL PRIMARY KEY,
--FoodName varchar(255),
--FoodPrice decimal
--);

--CREATE TABLE Drink (
--DrinkID int NOT NULL PRIMARY KEY,
--DrinkName varchar(255),
--DrinkPrice decimal
--);

--CREATE TABLE FoodOrder (
--FoodOrderID int IDENTITY(1,1) PRIMARY KEY,
--OrderID int NOT NULL,
--CustomerID int,
--EmpID int,
--FoodID int,
--Quantity int,
--totalFood decimal,
--FOREIGN KEY (FoodID) REFERENCES Food,
--FOREIGN KEY (CustomerID) REFERENCES Customer,
--FOREIGN KEY (EmpID) REFERENCES Employee
--);


--CREATE TABLE DrinkOrder (
--DrinkOrderID int IDENTITY(1,1) PRIMARY KEY,
--OrderID int NOT NULL,
--CustomerID int,
--EmpID int,
--DrinkID int,
--Quantity int,
--totalDrink decimal,
--FOREIGN KEY (DrinkID) REFERENCES Drink,
--FOREIGN KEY (CustomerID) REFERENCES Customer,
--FOREIGN KEY (EmpID) REFERENCES Employee
--);


--INSERT INTO Employee VALUES('01','Hui Ni','19','0127995838','1111');
--INSERT INTO Employee VALUES('02','WeiWei','19','0135875260','2222');
--INSERT INTO Customer VALUES('01','Brandon','0125505048','1');
--INSERT INTO Customer VALUES('02','Yong Chiek','0123456789',null);

--INSERT INTO Food VALUES('01','Pizza',5);
--INSERT INTO Food VALUES('02','Ramen',6);
--INSERT INTO Food VALUES('03','Cake',3);

--INSERT INTO Drink VALUES('01','Lemonade',2);
--INSERT INTO Drink VALUES('02','Latte',3);
--INSERT INTO Drink VALUES('03','Juice',2);

--DELETE FROM DrinkOrder
--DELETE FROM FoodOrder

SELECT * FROM FoodOrder
Select * From DrinkOrder
Select * FROM Customer
Select * FROM Employee
Select * From Food
Select * From Drink

SELECT Top 8 FoodID, Quantity FROM FoodOrder
--SELECT * FROM FoodOrder order by FoodID, Quantity
--INSERT INTO FoodOrder VALUES('9','100','NULL','NULL','4','7','90');
--INSERT INTO FoodOrder VALUES('10','100','NULL','NULL','5','4','40');
--INSERT INTO FoodOrder VALUES('11','100','NULL','NULL','6','10','110');



--SELECT MemberID FROM Customer WHERE CustomerID = 2


--Drop Table FoodOrder, DrinkOrder, Customer, Employee, Food, Drink