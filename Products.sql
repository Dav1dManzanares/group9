-- Crear la base de datos
CREATE DATABASE InventarioDB;  
GO

-- Cambiar el contexto a la nueva base de datos
USE InventarioDB;  
GO

-- Crear la tabla Categorías
CREATE TABLE Categorias (
    id INT PRIMARY KEY IDENTITY(1,1),  -- Clave primaria autoincremental
    nombre NVARCHAR(100) NOT NULL       -- Nombre de la categoría
);
GO

-- Crear la tabla Proveedores
CREATE TABLE Proveedores (
    id INT PRIMARY KEY IDENTITY(1,1),   -- Clave primaria autoincremental
    nombre NVARCHAR(100) NOT NULL,       -- Nombre del proveedor
    correo NVARCHAR(100),                 -- Correo electrónico del proveedor
    telefono NVARCHAR(15),                -- Número de teléfono del proveedor
    direccion NVARCHAR(255)               -- Dirección del proveedor
);
GO

-- Crear la tabla Productos
CREATE TABLE Productos (
    id INT PRIMARY KEY IDENTITY(1,1),      -- Clave primaria autoincremental
    nombre NVARCHAR(100) NOT NULL,         -- Nombre del producto
    precio FLOAT NOT NULL,                  -- Precio del producto
    cantidad INT NOT NULL,                  -- Cantidad en inventario
    categoriaId INT NOT NULL,               -- Llave foránea referencia a Categoría
    proveedorId INT NOT NULL,               -- Llave foránea referencia a Proveedor
    FOREIGN KEY (categoriaId) REFERENCES Categorias(id),  -- Relación con Categorías
    FOREIGN KEY (proveedorId) REFERENCES Proveedores(id)   -- Relación con Proveedores
);
GO
