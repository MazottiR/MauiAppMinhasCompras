Descrição em MarkDown do AppMinhasCompras

Aplicativo Minhas Compras - Documentação Técnica

🚀 Visão Geral

O Aplicativo Minhas Compras é uma aplicação móvel multiplataforma desenvolvida com
.NET MAUI para gerenciamento de lista de compras, permitindo adicionar, editar, remover
e calcular o total de produtos.

🛠 Tecnologias Utilizadas

.NET MAUI
SQLite
C#

📦 Estrutura do Projeto

Arquitetura

Padrão Model-View-ViewModel (MVVM)
Persistência de dados com SQLite
Navegação entre páginas usando NavigationPage

Estrutura de Pastas

Models/: Definição das entidades
Views/: Interfaces de usuário
Helpers/: Utilitários e helpers

🗂 Componentes Principais

1. Modelo: Produto

public class Produto
{
    [PrimaryKey, AutoIncrement]
    public int Id { get; set; }
    public string Descricao { get; set; }
    public double Quantidade { get; set; }
    public double Preco { get; set; }
    public double Total { get => Quantidade * Preco; }
}

2. Banco de Dados: SQLiteDatabaseHelper

Responsável pelas operações CRUD:

Insert(): Insere novo produto
Update(): Atualiza produto existente
Delete(): Remove produto
GetAll(): Recupera todos os produtos
Search(): Busca produtos por descrição

3. Páginas

Lista de Produtos (ListaProduto.xaml)

Exibe lista de produtos
Permite adicionar, remover e somar produtos
Barra de pesquisa para filtrar produtos

Novo Produto (NovoProduto.xaml)

Formulário para adicionar novo produto
Campos: Descrição, Quantidade, Preço

Editar Produto (EditarProduto.xaml)

Formulário para editar produto existente
Pré-preenche campos com dados do produto selecionado

💡 Funcionalidades

Adicionar novo produto
Editar produto existente
Remover produto
Calcular total de compras
Pesquisar produtos

![Captura de tela 2025-03-30 201130](https://github.com/user-attachments/assets/d60d483b-2232-4425-9d20-4f75e4e03050)

![Captura de tela 2025-03-30 201203](https://github.com/user-attachments/assets/1f8d0ca2-be19-4190-a842-ac8db9609a01)

![Captura de tela 2025-03-30 201203](https://github.com/user-attachments/assets/1d8fe123-f4ce-4697-bf96-1444b1ea1b22)
