CREATE TABLE Products(
	Id INT  PRIMARY KEY,
	Name VARCHAR(255) NOT NULL
);

INSERT INTO Products
VALUES
	(1, 'Гарри Поттер и кубок огня'),
	(2, 'Гарфилд'),
	(3, 'Дэдпул'),
	(4, 'Пила 6');

CREATE TABLE Categories(
	Id INT  PRIMARY KEY,
	Name VARCHAR(255) NOT NULL
);

INSERT INTO Categories
VALUES
	(1, 'Фэнтези'),
	(2, 'Комедия'),
	(3, 'Боевик');

CREATE TABLE ProductsCategories(
    ProductId INT,
    CategoryId INT,
	FOREIGN KEY (ProductId)  REFERENCES Products (Id),
	FOREIGN KEY (CategoryId)  REFERENCES Categories (Id),
	PRIMARY KEY (ProductId, CategoryId)
);

INSERT INTO ProductsCategories
VALUES
    (1,1),
    (2,2),
    (3,2),
    (3,3);

SELECT Products.Name, Categories.Name
FROM Products
LEFT JOIN ProductsCategories
	ON Products.Id = ProductsCategories.ProductId
LEFT JOIN Categories
	ON ProductsCategories.CategoryId = Categories.Id;
