DROP TABLE clientes;
CREATE TABLE clientes(
	id INT PRIMARY KEY IDENTITY(1,1),
	nome VARCHAR(45),
	saldo DECIMAL(6,2),
	telefone VARCHAR(15),
	estado VARCHAR(45),
	cidade VARCHAR(45),
	bairro VARCHAR(45),
	cep VARCHAR(15),
	logradouro VARCHAR(45),
	numero int,
	complemento VARCHAR(50),
	nome_sujo BIT,
	altura DECIMAL(3,2),
	peso DECIMAL(5,2)
);

SELECT * FROM clientes;