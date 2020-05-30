CREATE DATABASE EstilosMusicais_Tarde;

USE EstilosMusicais_Tarde;

CREATE TABLE EstilosMusicais (
	IDEstiloMusical		INT PRIMARY KEY IDENTITY,
	NomeEstilo			VARCHAR(200) NOT NULL
);

CREATE TABLE Artistas (
	IDArtista			INT PRIMARY KEY IDENTITY,
	NomeArtista			VARCHAR(200) NOT NULL 
);

CREATE TABLE Albuns (
	IDAlbum				INT PRIMARY KEY IDENTITY,
	NomeAlbum			VARCHAR(200) NOT NULL,
	DataLancamento		DATE,
	QtdMinutos			DECIMAL NOT NULL,
	Localizacao			VARCHAR(200),
	QtdVisualizacao		BIGINT NOT NULL,
	IDEstiloMusical		INT FOREIGN KEY REFERENCES EstilosMusicais (IDEstiloMusical),
	IDArtista			INT FOREIGN KEY REFERENCES Artistas (IDArtista)
);

CREATE TABLE Usuarios (
	IDUsuario			INT PRIMARY KEY IDENTITY,
	NomeUsuario			VARCHAR(200) NOT NULL
);

CREATE TABLE TipoUsuarios (
	IDTipoUsuario		INT PRIMARY KEY IDENTITY,
	UsuarioTipo			VARCHAR(200) NOT NULL
);

ALTER TABLE Albuns ADD IDArtista INT FOREIGN KEY REFERENCES Artistas (IDArtista);
ALTER TABLE ALBUNS ADD IDEstiloMusical INT FOREIGN KEY REFERENCES EstilosMusicais (IDEstiloMusical);

SELECT * FROM EstilosMusicais;
SELECT * FROM Artistas;
SELECT * FROM Albuns;
SELECT * FROM Usuarios;
SELECT * FROM TipoUsuarios;

EXEC sp_rename 'TipoUsuario', 'TipoUsuarios'

ALTER TABLE Usuarios ADD IDTipoUsuario INT FOREIGN KEY REFERENCES TipoUsuario (IDTipoUsuario);

-- DML
SELECT * FROM EstilosMusicais;
SELECT * FROM Artistas;
SELECT * FROM Albuns;
SELECT * FROM Usuarios;
SELECT * FROM TipoUsuarios;

--Comando para inserir dados
INSERT INTO EstilosMusicais (NomeEstilo) VALUES ('Rock'), ('Pop'), ('Rap')

INSERT INTO Artistas (NomeArtista) VALUES ('Eu'), ('Voc�'), ('E o Zubumafu')

ALTER TABLE Albuns ADD Qtd BIGINT NOT NULL;
ALTER TABLE Albuns ADD Localizacao VARCHAR(200);

INSERT INTO Albuns (NomeAlbum, DataLancamento, QtdMinutos, Localizacao, QtdVisualizacao, IDEstiloMusical,IDArtista)
VALUES ('Last Impressions Of Earth', '27/08/2020', 37.9, 'SP',30000, 1, 2 )

--Comando altera os dados
UPDATE Albuns
SET DataLancamento = '09/08/1996'
WHERE IDAlbum = 1;

--Limpa todos os dados da tabela
TRUNCATE TABLE Albuns;

DROP TABLE Albuns;

INSERT INTO EstilosMusicais (NomeEstilo) VALUES ('Trash Metal'), ('Metal'), ('Eletronic')

INSERT INTO Artistas (NomeArtista) VALUES ('Z�'), ('Maria'), ('Jubileuzinho')

INSERT INTO Albuns (NomeAlbum, DataLancamento, QtdMinutos, Localizacao, QtdVisualizacao, IDEstiloMusical,IDArtista)
VALUES ('First Impressions Of Earth', '08/07/2043', 57.4, 'St. Petersburg', 2140000, 5, 6)

INSERT INTO Albuns (NomeAlbum, DataLancamento, QtdMinutos, Localizacao, QtdVisualizacao, IDEstiloMusical,IDArtista)
VALUES ('Cage', '14/12/3256', 325.4, 'Bonn', 5745000, 2, 6)

INSERT INTO Albuns (NomeAlbum, DataLancamento, QtdMinutos, Localizacao, QtdVisualizacao, IDEstiloMusical,IDArtista)
VALUES ('Hello', '06/07/5643', 325.4, 'Munich', 500000, 1, 4)

INSERT INTO Albuns (NomeAlbum, DataLancamento, QtdMinutos, Localizacao, QtdVisualizacao, IDEstiloMusical,IDArtista)
VALUES ('I Dont Know', '12/05/2006', 56.6, 'Seattle', 6445, 2, 6)

--Inserir mais de um dado de uma vez s�
INSERT INTO Usuarios (NomeUsuario, IDTipoUsuario)
VALUES ('Jo�o', 1), ('Carlos', 1), ('Jos�', 1), ('Matheus', 2), ('Lucas', 1)

INSERT INTO TipoUsuarios (UsuarioTipo) VALUES ('Cliente'), ('ADM')

TRUNCATE TABLE Usuarios;

DELETE FROM Artistas
WHERE IDArtista = 5;

UPDATE Albuns
SET QtdVisualizacao = 4000
WHERE IDAlbum = 3;

UPDATE Usuarios
SET IDTipoUsuario = 2
WHERE IDUsuario = 5;

UPDATE Artistas
SET NomeArtista = 'Matheus'
WHERE IDArtista = 2;

-- Aula do dia 31/01
-- DQL Linguagem de Consulta de Dados

SELECT * FROM Artistas;

SELECT NomeArtista FROM Artistas;

SELECT NomeAlbum, DataLancamento FROM Albuns;

SELECT * FROM Albuns WHERE IDAlbum = 1;-- Fun��o WHERE

SELECT * FROM Albuns WHERE IDAlbum > 1;

SELECT NomeAlbum, QtdMinutos FROM Albuns
WHERE (DataLancamento IS NULL) OR (Localizacao IS NULL)

-- LIKE Compara��o de texto

SELECT IDAlbum, NomeAlbum FROM Albuns
WHERE NomeAlbum LIKE '%Last%' -- A fun�ao LIKE busca uma palavra especificada
-- O "%" Significa o resto da frase

-- Ex:
-- 'Last' Busca a palavra sem especificar se � no come�o da frase ou no final
-- 'Last%' Busca a palavra no come�o da frase
-- '%Last' Busca a palavra no final da frase
-- '%Last%' Busca a palavra em qualquer parte da frase

-- Se eu estou buscando 'Last%' e a palavra Last nao esta no come�o
-- da frase, o programa nao vai encontrar a palavra

-- Ordena�ao

SELECT NomeAlbum FROM Albuns
ORDER BY NomeAlbum;

-- ORDER Ordena os dados
-- Se for um VARCHAR, ele organiza em ordem alfabetica
-- Se for um INT (DECIMAL, TINYINT, etc.), ele organiza em ordem numerica

SELECT IDAlbum, NomeAlbum, QtdMinutos FROM Albuns
ORDER BY QtdMinutos;

-- Ordena�ao invertida

SELECT IDAlbum, NomeAlbum, QtdMinutos FROM Albuns
ORDER BY QtdMinutos DESC; -- Fun��o DESC ordena por ordem DECRESCENTE

SELECT IDAlbum, NomeAlbum, QtdMinutos FROM Albuns
ORDER BY QtdMinutos ASC; -- Fun��o ASC ordena por ordem CRESCENTE

-- COUNT

SELECT COUNT(IDAlbum) FROM Albuns;

