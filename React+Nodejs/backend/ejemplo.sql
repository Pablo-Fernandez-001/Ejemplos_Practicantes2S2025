CREATE DATABASE ejemplo;
DROP DATABASE ejemplo WHERE name = ejemplo;

USE ejemplo;


CREATE TABLE users(
    id INT AUTO_INCREMENT PRIMARY KEY,
    name VARCHAR(100),
    email VARCHAR(100)
);

CREATE TABLE register(
    id  INT PRIMARY KEY,
    nombre VARCHAR(100),
    apellido VARCHAR(100),
    correo VARCHAR(250),
    direccion  VARCHAR(100),
    estatura INT,
)

