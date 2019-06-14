DROP TABLE colaboradores;
CREATE TABLE colaboradores(
	id INT PRIMARY KEY IDENTITY(1,1),
	nome VARCHAR(50),
	cpf VARCHAR(14),
	salario DECIMAL(10,2),
	sexo VARCHAR(10),
	cargo VARCHAR(45),
	programador BIT
);

SELECT * FROM colaboradores;