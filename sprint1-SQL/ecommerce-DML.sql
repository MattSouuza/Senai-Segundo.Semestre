USE ECommerce;

INSERT INTO Lojas (NomeLoja)
VALUES ('SENAI Store');

INSERT INTO Categorias (NomeCategoria, IDLoja)
VALUES ('Cursos', 1), ('Acess�rios', 1);

INSERT INTO Subcategorias (NomeSubcategoria, IDCategoria)
VALUES ('Inform�tica B�sica', 1), ('Desenvolvimento', 1), ('Meio Ambiente', 2);

INSERT INTO Produtos (NomeProduto, Valor, IDSubcategoria)
VALUES ('Excel B�sico', 400, 1) , ('CSharp M�dio', 500, 1), ('Jaqueta', 100, 2);

INSERT INTO Clientes (NomeCliente)
VALUES ('Matheus'), ('Dioguera');

INSERT INTO Pedidos (NrPedido, DataPedido, StatusPedido, IDCliente)
VALUES (5365, '03/02/2020', 'Em Andamento', 1), (2425, '02/02/2020', 'Entregue', 2)

INSERT INTO PedidosProdutos (IDPedido, IDProduto)
VALUES (1, 2), (2, 1);