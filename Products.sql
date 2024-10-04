-- Crear la base de datos
CREATE DATABASE InventarioDB;  
GO

-- Cambiar el contexto a la nueva base de datos
USE InventarioDB;  
GO

-- Crear la tabla Categor�as
CREATE TABLE Categorias (
    id INT PRIMARY KEY IDENTITY(1,1),  -- Clave primaria autoincremental
    nombre NVARCHAR(100) NOT NULL       -- Nombre de la categor�a
);
GO

-- Crear la tabla Proveedores
CREATE TABLE Proveedores (
    id INT PRIMARY KEY IDENTITY(1,1),   -- Clave primaria autoincremental
    nombre NVARCHAR(100) NOT NULL,       -- Nombre del proveedor
    correo NVARCHAR(100),                 -- Correo electr�nico del proveedor
    telefono NVARCHAR(15),                -- N�mero de tel�fono del proveedor
    direccion NVARCHAR(255)               -- Direcci�n del proveedor
);
GO

-- Crear la tabla Productos
CREATE TABLE Productos (
    id INT PRIMARY KEY IDENTITY(1,1),      -- Clave primaria autoincremental
    nombre NVARCHAR(100) NOT NULL,         -- Nombre del producto
    precio FLOAT NOT NULL,                  -- Precio del producto
    cantidad INT NOT NULL,                  -- Cantidad en inventario
    categoriaId INT NOT NULL,               -- Llave for�nea referencia a Categor�a
    proveedorId INT NOT NULL,               -- Llave for�nea referencia a Proveedor
    FOREIGN KEY (categoriaId) REFERENCES Categorias(id),  -- Relaci�n con Categor�as
    FOREIGN KEY (proveedorId) REFERENCES Proveedores(id)   -- Relaci�n con Proveedores
);
GO
