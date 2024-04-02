create database actividad34

CREATE TABLE CLIENTE (
IDCLIENTE INT IDENTITY (1,1) NOT NULL,
NOMBRE NVARCHAR (50) NOT NULL,
APELLIDO NVARCHAR (50) NOT NULL,
CORREO NVARCHAR (20) NULL,
TELEFONO NVARCHAR (50) NULL,
DIRECCION NVARCHAR (50) NOT NULL,
PRIMARY KEY (IDCLIENTE),
)

CREATE TABLE Pedidos (
    IDPedido INT PRIMARY KEY,
    IDCliente INT,
    Fecha DATE,
    Total DECIMAL(10, 2),
    Estado VARCHAR(50),
    FOREIGN KEY (IDCliente) REFERENCES Cliente(IDCliente)
);
-- Insertar datos en la tabla Cliente
INSERT INTO Cliente (NOMBRE, APELLIDO, CORREO, TELEFONO, DIRECCION)
VALUES ('Ana', 'López', 'ana@example.com', '111222333', 'Calle 123');

INSERT INTO Cliente (NOMBRE, APELLIDO, CORREO, TELEFONO, DIRECCION)
VALUES ('Carlos', 'García', 'carlos@example.com', '444555666', 'Avenida 456');

INSERT INTO Cliente (NOMBRE, APELLIDO, CORREO, TELEFONO, DIRECCION)
VALUES ('Sofía', 'Hernández', 'sofia@example.com', '777888999', 'Carrera 789');

INSERT INTO Cliente (NOMBRE, APELLIDO, CORREO, TELEFONO, DIRECCION)
VALUES ('Luis', 'Martín', 'luis@example.com', '123123123', 'Avenida Sur 12');

INSERT INTO Cliente (NOMBRE, APELLIDO, CORREO, TELEFONO, DIRECCION)
VALUES ('Laura', 'Díaz', 'laura@example.com', '456456456', 'Calle Norte 34');

INSERT INTO Cliente (NOMBRE, APELLIDO, CORREO, TELEFONO, DIRECCION)
VALUES ('Pedro', 'Sánchez', 'pedro@example.com', '789789789', 'Avenida Oeste 56');

INSERT INTO Cliente (NOMBRE, APELLIDO, CORREO, TELEFONO, DIRECCION)
VALUES ('María', 'Rodríguez', 'maria@example.com', '987987987', 'Carrera Este 78');

INSERT INTO Cliente (NOMBRE, APELLIDO, CORREO, TELEFONO, DIRECCION)
VALUES ('Elena', 'Gutiérrez', 'elena@example.com', '654654654', 'Calle Poniente 90');

INSERT INTO Cliente (NOMBRE, APELLIDO, CORREO, TELEFONO, DIRECCION)
VALUES ('Javier', 'Fernández', 'javier@example.com', '321321321', 'Avenida Central 12');

INSERT INTO Cliente (NOMBRE, APELLIDO, CORREO, TELEFONO, DIRECCION)
VALUES ('Isabel', 'López', 'isabel@example.com', '888888888', 'Calle 67');

INSERT INTO Cliente (NOMBRE, APELLIDO, CORREO, TELEFONO, DIRECCION)
VALUES ('Miguel', 'Alvarez', 'miguel@example.com', '999999999', 'Carrera 45');

INSERT INTO Cliente (NOMBRE, APELLIDO, CORREO, TELEFONO, DIRECCION)
VALUES ('Alejandro', 'Gómez', 'alejandro@example.com', '777777777', 'Avenida 23');

INSERT INTO Cliente (NOMBRE, APELLIDO, CORREO, TELEFONO, DIRECCION)
VALUES ('Lucía', 'Pérez', 'lucia@example.com', '555555555', 'Calle 89');

INSERT INTO Cliente (NOMBRE, APELLIDO, CORREO, TELEFONO, DIRECCION)
VALUES ('Martina', 'Hernández', 'martina@example.com', '444444444', 'Carrera 56');

-- Insertar datos en la tabla Pedidos
INSERT INTO Pedidos (IDPedido, IDCliente, Fecha, Total, Estado)
VALUES (1, 1, '2024-03-01', 150.50, 'Completado');

INSERT INTO Pedidos (IDPedido, IDCliente, Fecha, Total, Estado)
VALUES (2, 2, '2024-03-02', 75.20, 'Pendiente');

INSERT INTO Pedidos (IDPedido, IDCliente, Fecha, Total, Estado)
VALUES (3, 3, '2024-03-03', 200.00, 'En proceso');

INSERT INTO Pedidos (IDPedido, IDCliente, Fecha, Total, Estado)
VALUES (4, 4, '2024-03-04', 100.00, 'Cancelado');

INSERT INTO Pedidos (IDPedido, IDCliente, Fecha, Total, Estado)
VALUES (5, 5, '2024-03-05', 50.75, 'Completado');

INSERT INTO Pedidos (IDPedido, IDCliente, Fecha, Total, Estado)
VALUES (6, 6, '2024-03-06', 180.25, 'Pendiente');

INSERT INTO Pedidos (IDPedido, IDCliente, Fecha, Total, Estado)
VALUES (7, 7, '2024-03-07', 90.50, 'En proceso');

INSERT INTO Pedidos (IDPedido, IDCliente, Fecha, Total, Estado)
VALUES (8, 8, '2024-03-08', 300.00, 'Completado');

INSERT INTO Pedidos (IDPedido, IDCliente, Fecha, Total, Estado)
VALUES (9, 9, '2024-03-09', 75.00, 'Pendiente');

INSERT INTO Pedidos (IDPedido, IDCliente, Fecha, Total, Estado)
VALUES (10, 10, '2024-03-10', 120.00, 'Completado');

INSERT INTO Pedidos (IDPedido, IDCliente, Fecha, Total, Estado)
VALUES (11, 11, '2024-03-11', 250.00, 'En proceso');

INSERT INTO Pedidos (IDPedido, IDCliente, Fecha, Total, Estado)
VALUES (12, 12, '2024-03-12', 80.50, 'Pendiente');

INSERT INTO Pedidos (IDPedido, IDCliente, Fecha, Total, Estado)
VALUES (13, 13, '2024-03-13', 150.00, 'Completado');

INSERT INTO Pedidos (IDPedido, IDCliente, Fecha, Total, Estado)
VALUES (14, 14, '2024-03-14', 200.75, 'Pendiente');

INSERT INTO Pedidos (IDPedido, IDCliente, Fecha, Total, Estado)
VALUES (15, 15, '2024-03-15', 180.00, 'Completado');
