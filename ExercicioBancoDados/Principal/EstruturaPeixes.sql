﻿DROP TABLE peixes;
CREATE TABLE peixes(
	id INT PRIMARY KEY IDENTITY(1,1),
	nome VARCHAR(50),
	raca VARCHAR(45),
	preco DECIMAL(6,2),
	quantidade INT
);

SELECT * FROM peixes;