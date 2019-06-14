DROP TABLE clientes;
CREATE TABLE clientes(
	id INT PRIMARY KEY IDENTITY(1,1),
	nome VARCHAR(45),
	salso DECIMAL(6,2),

);

SELECT * FROM clientes;