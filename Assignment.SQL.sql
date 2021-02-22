CREATE SCHEMA CustomerApp;
GO

CREATE TABLE CustomerApp.Customer
(
    CustomerID INT IDENTITY NOT NULL,
    FirstName NVARCHAR(120),
	LastName NVARCHAR(120),
	CardNumber BIGINT UNIQUE NOT NULL,
    CONSTRAINT PK_Customer PRIMARY KEY CLUSTERED (CustomerID)
);
GO

CREATE TABLE CustomerApp.Product
(
    ProductID INT IDENTITY NOT NULL,
    Name NVARCHAR(50) NOT NULL,
	Price NUMERIC(10,2) NOT NULL,
    CONSTRAINT PK_Product PRIMARY KEY CLUSTERED (ProductID)
);
GO

CREATE TABLE CustomerApp.[Order]
(
    Id INT IDENTITY NOT NULL,
	ProductID INT NOT NULL,
	CustomerID INT NOT NULL,
    CONSTRAINT PK_Inventory PRIMARY KEY CLUSTERED (Id)
);

ALTER TABLE CustomerApp.[Order] ADD
	CONSTRAINT FK_Order_Customer
		FOREIGN KEY (CustomerID) REFERENCES CustomerApp.Customer(CustomerID)
		ON DELETE CASCADE;
GO

ALTER TABLE CustomerApp.[Order] ADD
	CONSTRAINT FK_Order_Product
		FOREIGN KEY (ProductID) REFERENCES CustomerApp.Product(ProductID)
		ON DELETE CASCADE;
GO

INSERT INTO CustomerApp.Product VALUES ('Pizza', 8.99);
INSERT INTO CustomerApp.Product VALUES ('Burger', 5.99);
INSERT INTO CustomerApp.Product VALUES ('Fries', 2.99);
INSERT INTO CustomerApp.Customer VALUES ('Jonathan','DeLaCruz', 1234567890);
INSERT INTO CustomerApp.Customer VALUES ('Junior','DeLaCruz', 2345678901);
INSERT INTO CustomerApp.Customer VALUES ('Joel','DeLaCruz', 3456789021);
INSERT INTO CustomerApp.[Order] VALUES (1,1);
INSERT INTO CustomerApp.[Order] VALUES (2,2);
INSERT INTO CustomerApp.[Order] VALUES (1,3);
INSERT INTO CustomerApp.Product VALUES ('Phone', 200.00);
INSERT INTO CustomerApp.Customer VALUES ('Tina','Smith', 4567890123);
INSERT INTO CustomerApp.[Order] VALUES (4,4);

SELECT c.FirstName, c.LastName, o.* 
	FROM CustomerApp.[Order] AS o
	LEFT JOIN CustomerApp.Customer AS c on o.CustomerID = c.CustomerID
	WHERE o.CustomerID = 4;

SELECT p.Name, SUM(p.Price)
	FROM CustomerApp.Product AS p
	LEFT JOIN CustomerApp.[Order] as o on p.ProductID = o.ProductID
	GROUP BY p.Price;

UPDATE CustomerApp.Product 
	SET Price = 250.00
	WHERE ProductID = 4;

