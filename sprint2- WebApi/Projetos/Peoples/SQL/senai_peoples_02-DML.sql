USE T_Peoples;

INSERT INTO Funcionarios (Nome, Sobrenome) 
VALUES	('Catarina', 'Strada')
		,('Tadeu', 'Vitelli');

UPDATE Funcionarios SET DataNascimento = '1993-03-17';

INSERT INTO TipoUsuario (TituloTipoUsuario)
VALUES	('Comum'),
		('Adminstrador');

INSERT INTO Usuario (Nome, Email, Senha, IdTipoUsuario)
VALUES	('Matheus Souza', 'matheus@email.com', '123456', 1),
		('Adm', 'adm@email.com', 'adm123', 2);