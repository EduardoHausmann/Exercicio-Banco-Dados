CREATE TABLE colaboradores(
	id INT PRIMARY KEY IDENTITY(1,1),
	nome VARCHAR(50),
	cpf CHAR(14),
	salario DECIMAL(8,2),
	sexo VARCHAR(10),
	cargo VARCHAR(45),
	programador BIT
);