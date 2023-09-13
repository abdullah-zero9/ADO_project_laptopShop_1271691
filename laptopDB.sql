create database laptopDB
go
use laptopDB
go
CREATE TABLE laptops
(
	laptop_id INT PRIMARY KEY IDENTITY,
	name VARCHAR(50) NOT NULL,
	brand VARCHAR(20) NOT NULL
)
GO
CREATE TABLE laptop_details
(
	laptop_id INT,
    hard_disk VARCHAR(10) ,
    display_size VARCHAR(10) ,
    release_date DATE,
	available BIT null,
	price money,
	unit_stock INT null,
	picture varbinary(max) NULL,
    FOREIGN KEY (laptop_id) REFERENCES laptops(laptop_id)
)
go

CREATE TABLE processor
(
	processor_id INT PRIMARY KEY IDENTITY,
	name VARCHAR(50) NOT NULL
)
GO
CREATE TABLE Ram
(
	laptop_id INT,
	processor_id INT,    
	RamSize NVARCHAR(10),
	PRIMARY KEY(laptop_id,processor_id) 
)
go
CREATE TABLE users
(
	userId INT PRIMARY KEY IDENTITY,
	userName NVARCHAR(50) NOT NULL UNIQUE,
	fullName NVARCHAR(50) NOT NULL,
	email NVARCHAR(30) NOT NULL,
	contactNo NVARCHAR(30) NOT NULL,
	userPassword NVARCHAR(50) NOT NULL
)
GO
SELECT processor_id,name FROM processor
GO
SELECT * FROM laptops
INSERT INTO laptops (name, brand) VALUES ('Pavilion 15', 'HP')
SELECT * FROM Ram
INSERT INTO Ram (laptop_id, processor_id, RamSize)
VALUES (1, 1, '8GB');

SELECT * FROM laptops WHERE laptop_id = 3

SELECT l.laptop_id, l.name, l.brand, ld.hard_disk, ld.display_size, ld.release_date, ld.available, ld.price, ld.unit_stock
FROM laptops l
JOIN laptop_details ld ON l.laptop_id = ld.laptop_id
WHERE l.laptop_id = 4;

SELECT *
FROM laptops
INNER JOIN laptop_details ON laptops.laptop_id = laptop_details.laptop_id
INNER JOIN Ram ON laptops.laptop_id = Ram.laptop_id
INNER JOIN processor ON Ram.processor_id = processor.processor_id
WHERE laptops.laptop_id = 4

select * from processor
