use Hospital
GO

CREATE PROCEDURE Add_Patient (
@Passport AS NCHAR(10), 
@Name AS VARCHAR(20),
@LastName AS VARCHAR(20),
@Patronymic AS VARCHAR(20),
@DateOfBirth AS DATE,
@Phone AS VARCHAR(12),
@Email AS VARCHAR(30),
@Address AS VARCHAR(50),
@Password AS VARCHAR(20)
)
AS
BEGIN
if @Passport in (SELECT a.passport_num FROM Accounts AS a) RETURN -1
INSERT INTO Accounts(passport_num, password, role_id) VALUES (@Passport, @Password, 1)
-- > 50 years = pension discount
if  @DateOfBirth != '' AND GETDATE() > DATEADD(year, 50, @DateOfBirth) INSERT INTO Patients(passport_num, first_name, last_name, patronymic, date_of_birth, phone, email, address, disc_id) 
VALUES (@Passport, @Name, @LastName, 
CASE WHEN @Patronymic = '' THEN NULL ELSE @Patronymic END, 
CASE WHEN @DateOfBirth = '' THEN NULL ELSE @DateOfBirth END, 
CASE WHEN @Phone = '' THEN NULL ELSE @Phone END, 
CASE WHEN @Email = '' THEN NULL ELSE @Email END, 
CASE WHEN @Address = '' THEN NULL ELSE @Address END, 3)

else INSERT INTO Patients(passport_num, first_name, last_name, patronymic, date_of_birth, phone, email, address, disc_id) 
VALUES (@Passport, @Name, @LastName, 
CASE WHEN @Patronymic = '' THEN NULL ELSE @Patronymic END, 
CASE WHEN @DateOfBirth = '' THEN NULL ELSE @DateOfBirth END, 
CASE WHEN @Phone = '' THEN NULL ELSE @Phone END, 
CASE WHEN @Email = '' THEN NULL ELSE @Email END, 
CASE WHEN @Address = '' THEN NULL ELSE @Address END, NULL)
END
GO

CREATE PROCEDURE AddItemToStorage (
@supID AS INT,
@medID AS INT,
@unit_price AS INT,
@quantity AS INT
)
AS
BEGIN
INSERT INTO SupplierMedicines (sup_id, med_id, unit_price, quantity) VALUES (@supID, @medID, @unit_price, @quantity)
END
GO


CREATE PROCEDURE Add_Doctor (
@Passport AS NCHAR(10), 
@Name AS VARCHAR(20),
@LastName AS VARCHAR(20),
@Patronymic AS VARCHAR(20),
@Phone AS VARCHAR(12),
@Password AS VARCHAR(70),
@PosID AS INT
)
AS
BEGIN
if @Passport in (SELECT a.passport_num FROM Accounts AS a) RETURN -1
INSERT INTO Accounts(passport_num, password, role_id) VALUES (@Passport, @Password, 1)

INSERT INTO Doctors(passport_num, first_name, last_name, patronymic, phone, pos_id) 
VALUES (
@Passport, @Name, @LastName,
CASE WHEN @Patronymic = '' THEN NULL ELSE @Patronymic END, 
CASE WHEN @Phone = '' THEN NULL ELSE @Phone END,
@PosID
)
END
GO

CREATE PROCEDURE Add_Supplier (
@Passport AS NCHAR(10), 
@Name AS VARCHAR(20),
@Password AS VARCHAR(70)
)
AS
BEGIN
if @Passport in (SELECT a.passport_num FROM Accounts AS a) RETURN -1
INSERT INTO Accounts(passport_num, password, role_id) VALUES (@Passport, @Password, 1)

INSERT INTO Suppliers(passport_num, sup_name) 
VALUES (@Passport, @Name)
END
GO

CREATE PROCEDURE Delete_Supplier (
@Passport AS NCHAR(10) 
)
AS
BEGIN
DECLARE @CountOrders AS INT
SET @CountOrders = 
(SELECT COUNT(ots.sup_id) 
FROM OrdersToSuppliers AS ots
INNER JOIN Suppliers AS s on s.sup_id = ots.sup_id
WHERE s.passport_num = @Passport AND (ots.status_id = 2 OR ots.status_id = 3 OR ots.status_id = 4))

if @CountOrders > 0 RETURN -1

DELETE FROM Suppliers WHERE passport_num = @Passport
END
GO

CREATE PROCEDURE AddItemToStorage (
@supID AS INT,
@medID AS INT,
@unit_price AS INT,
@quantity AS INT
)
AS
BEGIN
INSERT INTO SupplierMedicines (sup_id, med_id, unit_price, quantity) VALUES (@supID, @medID, @unit_price, @quantity)
END
GO

USE [Hospital]
GO

CREATE TRIGGER Delete_Doctor_Trigger
ON Doctors
AFTER DELETE
AS
EXEC AddNewLog @type = 1, @role = 3;
GO
	
CREATE PROCEDURE AddNewLog(
@type AS INT,
@role AS INT
)
AS
BEGIN 
INSERT INTO Logs (type_id, date, role_id) VALUES (@type, GETDATE(), @role)
END
GO