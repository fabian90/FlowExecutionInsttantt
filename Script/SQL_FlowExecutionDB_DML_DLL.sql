-- Validar si la base de datos ya existe
IF DB_ID('FlowExecutionDB') IS NOT NULL
    PRINT 'La base de datos ya existe.'
ELSE
BEGIN
    -- Crear la base de datos
    CREATE DATABASE FlowExecutionDB;
    PRINT 'La base de datos ha sido creada correctamente.'
END

--Usar base datos
USE FlowExecutionDB

IF OBJECT_ID('Steps', 'U') IS NOT NULL
    PRINT 'La tabla Steps ya existe en la base de datos.'
ELSE
BEGIN
    -- Crear la tabla con ID 
    CREATE TABLE Steps (
	Id INT PRIMARY KEY,
    Code NVARCHAR(50) NOT NULL
	);

    PRINT 'La tabla Steps ha sido creada correctamente.'
END

-- Insertar registros de ejemplo
INSERT INTO Steps (Id, Code) VALUES
    (1, 'STP-0001'),
    (2, 'STP-0002'),
    (3, 'STP-0003'),
    (4, 'STP-0004'),
	(5,'STP-0005');

IF OBJECT_ID('Fields', 'U') IS NOT NULL
    PRINT 'La tabla Fields ya existe en la base de datos.'
ELSE
BEGIN
    -- Crear la tabla con ID 
   CREATE TABLE Fields (
    Id INT PRIMARY KEY,
    Code VARCHAR(50) NOT NULL,
    Name VARCHAR(100) NOT NULL,
    Type VARCHAR(10)
);

    PRINT 'La tabla Fields ha sido creada correctamente.'
END

INSERT INTO Fields (Id, Code, Name,Type) VALUES
    (1, 'F-0001', 'Primer nombre', NULL),
    (2, 'F-0002', 'Segundo nombre', NULL),
    (3, 'F-0003', 'Primer apellido', NULL),
    (4, 'F-0004', 'Segundo apellido', NULL),
    (5, 'F-0005', 'Tipo de documento', NULL),
    (6, 'F-0006', 'Número de documento', NULL);

	IF OBJECT_ID('StepInputRelations', 'U') IS NOT NULL
    PRINT 'La tabla StepInputRelations ya existe en la base de datos.'
ELSE
BEGIN

	CREATE TABLE StepInputRelations (
	Id INT PRIMARY KEY,
    StepId INT NOT NULL,
    FieldId INT NOT NULL,
    CONSTRAINT FK_StepsInputRelations FOREIGN KEY  (StepId) REFERENCES Steps(Id),
    CONSTRAINT FK_FieldsInputRelations  FOREIGN KEY (FieldId) REFERENCES Fields(Id)
);
END

INSERT INTO StepInputRelations (Id, StepId, FieldId) VALUES
    (1, 1, 1),
    (2, 1, 2),
    (3, 2, 1),
    (4, 2, 2),
	(5, 3, 1),
	(6, 3, 2),
	(7, 4, 1),
	(8, 4, 2),
	(9, 5, 1),
	(10,5, 2),
	(11,5, 3),
	(12,5, 4),
	(13,5, 6);

--Crear table Monitoreo
IF OBJECT_ID('ErrorLog', 'U') IS NOT NULL
    PRINT 'La tabla ErrorLog ya existe en la base de datos.'
ELSE
BEGIN
CREATE TABLE ErrorLog (
    Id INT PRIMARY KEY IDENTITY(1,1),
    FechaRegistro DATETIME DEFAULT GETDATE(),
    Mensaje NVARCHAR(MAX),
    Detalles NVARCHAR(MAX)
);
    PRINT 'La tabla ErrorLog ha sido creada correctamente.'
END