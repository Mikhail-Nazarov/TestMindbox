CREATE TABLE Products(
	Id INT  PRIMARY KEY,
	"Name" VARCHAR(255) NOT NULL
);

INSERT INTO Products
VALUES
	(1, '����� ������ � ����� ����'),
	(2, '�������'),
	(3, '������'),
	(4, '����');

CREATE TABLE Ctegories(
	Id INT  PRIMARY KEY,
	"Name" VARCHAR(255) NOT NULL
);

INSERT INTO Products
VALUES
	(1, '�������'),
	(2, '�������'),
	(3, '������');

CREATE TABLE ProductsCtegories(
	ProductId INT FOREIGN KEY REFERENCES Products(Id) NOT NULL,
	CategoryId INT FOREIGN KEY REFERENCES Categories(Id),
	PRIMARY KEY (ProductId, CategoryId)
);


