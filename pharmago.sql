Create Database pharmago
use pharmago
CREATE TABLE Users
(
    ID INT IDENTITY(1,1) PRIMARY KEY,
    FirstName VARCHAR(50),
    LastName VARCHAR(50),
    Phone VARCHAR(20),
    BirthDate DATE,
    Username VARCHAR(50) UNIQUE,
    Password VARCHAR(50)
);
GO

INSERT INTO Users
(FirstName, LastName, Phone, BirthDate, Username, Password)
VALUES
('Ahmed', 'Ali', '01012345678', '2005-05-10', 'ahmed', '1234'),
('Omar', 'Mohamed', '01112345678', '2004-08-15', 'omar', '12345'),
('Youssef', 'Hassan', '01212345678', '2005-01-20', 'youssef', '1111');
GO

SELECT * FROM Users;


-- 2. Categories Table
CREATE TABLE Categories
(
    CategoryID INT IDENTITY(1,1) PRIMARY KEY,
    CategoryName VARCHAR(100)
);
GO

INSERT INTO Categories (CategoryName)
VALUES
('Painkillers'),
('Antibiotics'),
('Vitamins'),
('Cold and Flu'),
('Skin Care');
GO

-- 3. Products Table
CREATE TABLE Products
(
    ProductID INT IDENTITY(1,1) PRIMARY KEY,
    ProductName VARCHAR(100),
    CategoryID INT,
    Price DECIMAL(10,2),
    Quantity INT,
    ExpiryDate DATE,

    FOREIGN KEY (CategoryID) REFERENCES Categories(CategoryID)
);
GO

INSERT INTO Products
(ProductName, CategoryID, Price, Quantity, ExpiryDate)
VALUES
('Panadol', 1, 35, 100, '2027-05-10'),
('Augmentin', 2, 120, 50, '2027-08-15'),
('Vitamin C', 3, 60, 80, '2027-10-20'),
('Cataflam', 1, 45, 70, '2027-06-15'),
('Cold Free', 4, 30, 40, '2027-12-01'),
('Betadine', 5, 55, 60, '2027-09-10');
GO

-- 4. Customers Table
CREATE TABLE Customers
(
    CustomerID INT IDENTITY(1,1) PRIMARY KEY,
    CustomerName VARCHAR(100),
    Phone VARCHAR(20)
);
GO

INSERT INTO Customers
(CustomerName, Phone)
VALUES
('Mohamed Hassan', '01055555555'),
('Ali Ahmed', '01155555555'),
('Omar Samir', '01255555555'),
('Sara Mahmoud', '01066666666');
GO

-- Display All Data
SELECT * FROM Users;
SELECT * FROM Categories;
SELECT * FROM Products;
SELECT * FROM Customers;
GO

-- 5. Suppliers Table
CREATE TABLE Suppliers
(
    SupplierID INT IDENTITY(1,1) PRIMARY KEY,
    SupplierName VARCHAR(100),
    Phone VARCHAR(20),
    Address VARCHAR(200)
);
GO

INSERT INTO Suppliers
(SupplierName, Phone, Address)
VALUES
('Eva Pharma', '01011111111', 'Cairo'),
('EIPICO', '01022222222', '10th of Ramadan'),
('Amoun Pharma', '01033333333', 'Cairo'),
('Pharco', '01044444444', 'Alexandria');
GO

SELECT * FROM Suppliers;
GO
