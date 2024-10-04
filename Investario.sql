-- Crear la base de datos
CREATE DATABASE InventarioProductos;  
GO

-- Cambiar el contexto a la nueva base de datos
USE InventarioProductos;  
GO

-- Crear la tabla Muebles
CREATE TABLE Muebles (
    id INT PRIMARY KEY IDENTITY(1,1),  -- Clave primaria autoincremental
    nombre NVARCHAR(100) NOT NULL,     -- Nombre del mueble
    precio FLOAT NOT NULL,              -- Precio del mueble
    cantidad INT NOT NULL               -- Cantidad en inventario
);
GO

-- Crear la tabla Productos Electrónicos
CREATE TABLE ProductosElectronics (
    id INT PRIMARY KEY IDENTITY(1,1),   -- Clave primaria autoincremental
    nombre NVARCHAR(100) NOT NULL,      -- Nombre del producto electrónico
    precio FLOAT NOT NULL,               -- Precio del producto electrónico
    cantidad INT NOT NULL                -- Cantidad en inventario
);
GO

-- Crear la tabla Alimentos
CREATE TABLE Alimentos (
    id INT PRIMARY KEY IDENTITY(1,1),    -- Clave primaria autoincremental
    nombre NVARCHAR(100) NOT NULL,       -- Nombre del alimento
    precio FLOAT NOT NULL,                -- Precio del alimento
    cantidad INT NOT NULL                 -- Cantidad en inventario
);
GO
