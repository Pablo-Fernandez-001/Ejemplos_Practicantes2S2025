CREATE DATABASE ejemplo;
DROP DATABASE ejemplo WHERE name = ejemplo;

USE ejemplo;


CREATE TABLE users(
    id INT AUTO_INCREMENT PRIMARY KEY,
    name VARCHAR(100),
    email VARCHAR(100)
);

