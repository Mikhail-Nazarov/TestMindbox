CREATE TABLE Products(
	Id INT  PRIMARY KEY,
	"Name" VARCHAR(255) NOT NULL
);

INSERT INTO Products
VALUES
	(1, 'Гарри Поттер и кубок огня'),
	(2, 'Гарфилд'),
	(3, 'Дэдпул'),
	(4, 'Пила');

CREATE TABLE Ctegories(
	Id INT  PRIMARY KEY,
	"Name" VARCHAR(255) NOT NULL
);

INSERT INTO Products
VALUES
	(1, 'Фэнтези'),
	(2, 'Комедия'),
	(3, 'Боевик');

CREATE TABLE ProductsCtegories(
	ProductId INT FOREIGN KEY REFERENCES Products(Id) NOT NULL,
	CategoryId INT FOREIGN KEY REFERENCES Categories(Id),
	PRIMARY KEY (ProductId, CategoryId)
);


