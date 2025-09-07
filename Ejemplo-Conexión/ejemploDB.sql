CREATE DATABASE IF NOT EXISTS testdb;
USE testdb;

CREATE TABLE IF NOT EXISTS todos (
  id INT AUTO_INCREMENT  PRIMARY KEY,
  title VARCHAR(255) NOT NULL,
  done TINYINT(1) DEFAULT 0
);

INSERT INTO todos (title, done) VALUES ('Aprender VB.NET', 0);

INSERT INTO todos VALUES  (0, 'Aprender VB.NET', 0);

INSERT INTO todos (title) VALUES ('Aprender VB.NET');

Select * from todos;

Drop table todos;
DROP DATABASE testdb;