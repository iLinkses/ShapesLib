CREATE TABLE Products (
	ID INT PRIMARY KEY,
    Name NVARCHAR(100) NOT NULL
);

CREATE TABLE Categories (
    ID INT PRIMARY KEY,
    Name NVARCHAR(100) NOT NULL
);

CREATE TABLE ProductCategory (
    ProductID INT,
    CategoryID INT,
    FOREIGN KEY (ProductID) REFERENCES Products(ID),
    FOREIGN KEY (CategoryID) REFERENCES Categories(ID),
    PRIMARY KEY (ProductID, CategoryID)
);
---------------------------------------------------------------------------------
INSERT INTO Products (ID, Name)
VALUES (1, 'Product 1'),
       (2, 'Product 2'),
       (3, 'Product 3'),
       (4, 'Product 4'),
       (5, 'Product 5');
INSERT INTO Categories (ID, Name)
VALUES (1, 'Category 1'),
       (2, 'Category 2'),
       (3, 'Category 3'),
       (4, 'Category 4'),
       (5, 'Category 5');
INSERT INTO ProductCategory (ProductID, CategoryID)
VALUES (1, 1),
       (1, 2),
       (2, 2),
       (2, 3),
       (3, 3),
       (4, 4),
       (5, 5);
---------------------------------------------------------------------------------
SELECT p.Name, C.Name
FROM Products p
LEFT JOIN ProductCategory pc ON p.ID = pc.ProductID
LEFT JOIN Categories c ON C.ID = pc.CategoryID;