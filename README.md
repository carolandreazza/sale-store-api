
# Sistema de Gerenciamento de Vendas e Estoque

O sistema SaleStoreERP é uma API para gerenciamento de loja, permitindo o cadastro de produtos, clientes, vendas e estoque. Este documento fornece uma visão geral das funcionalidades oferecidas pelo sistema e instruções para executar e testar a API localmente.

## Funcionalidades Principais

### Cadastro de Produtos
- Permite o cadastro de produtos com informações como nome, preço, descrição, fornecedor e data de validade.
- Os produtos cadastrados são armazenados em memória.

### Cadastro de Clientes
- Permite o registro de informações sobre os clientes, como nome, endereço e telefone.
- Os clientes registrados são armazenados em memória.

### Gerenciamento de Vendas
- **Registrar uma Venda:** Associa um cliente a um ou mais produtos vendidos, com quantidade e preço.
- **Consultar Vendas por Cliente:** Busca todas as vendas realizadas por um cliente específico.
- **Relatórios de Vendas:** Gera relatórios sobre vendas diárias, mensais, produtos mais vendidos, etc.
- As vendas são registradas e gerenciadas em memória.

### Gerenciamento de Estoque
- **Adicionar Itens ao Estoque:** Registra a entrada de novos produtos no estoque.
- **Retirar Itens do Estoque:** Controla a quantidade de itens em estoque após vendas.
- **Verificação de Validade:** Verifica a validade dos produtos com base na data de validade.
- As informações do estoque são armazenadas em memória.

## Instruções para Executar a API Localmente

## Como Executar Localmente

1. Clone este repositório:

```bash
git clone [https://github.com/seu-usuario/nome-do-repositorio.git](https://github.com/carolandreazza/sale-store-api.git)
```

2. Navegue até o diretório do projeto:

```bash
cd sale-store-api
```

3. Execute o projeto:

```bash
dotnet run
```

O servidor estará em execução em `https://localhost:5001`.

## Como Testar a API

Recomendamos o uso do Postman para testar a API.

### Exemplo de Uso

#### 1. Listar todos os produtos

- Método: GET
- URL: `https://localhost:5001/api/products`

#### 2. Adicionar um novo produto

- Método: POST
- URL: `https://localhost:5001/api/products`
- Corpo (JSON):

```json
{
    "Id": 1,
    "Name": "Produto A",
    "Price": 10.99,
    "Description": "Descrição do Produto A",
    "Supplier": "Fornecedor A",
    "ExpiryDate": "2024-12-31T00:00:00"
}
```

#### 3. Atualizar um produto existente

- Método: PUT
- URL: `https://localhost:5001/api/products/1`
- Corpo (JSON):

```json
{
    "Id": 1,
    "Name": "Produto A Atualizado",
    "Price": 12.99,
    "Description": "Nova Descrição do Produto A",
    "Supplier": "Novo Fornecedor A",
    "ExpiryDate": "2025-12-31T00:00:00"
}
```

#### 4. Excluir um produto

- Método: DELETE
- URL: `https://localhost:5001/api/products/1`

## Documentação da API

A documentação completa da API pode ser encontrada em `https://localhost:5001/swagger/index.html`.


## Exemplo de Uso dos Clientes

### Listar Todos os Clientes

Retorna uma lista de todos os clientes cadastrados no sistema.

- **Método HTTP:** GET
- **URL:** `https://localhost:5001/api/clients`

#### Exemplo de Requisição:

```http
GET https://localhost:5001/api/clients
```

#### Exemplo de Resposta (200 OK):

```json
[
    {
        "id": 1,
        "name": "John Doe",
        "address": "123 Main St",
        "phone": "555-1234"
    },
    {
        "id": 2,
        "name": "Jane Smith",
        "address": "456 Elm St",
        "phone": "555-5678"
    }
]
```

### Adicionar um Novo Cliente

Adiciona um novo cliente ao sistema.

- **Método HTTP:** POST
- **URL:** `https://localhost:5001/api/clients`

#### Exemplo de Requisição:

```http
POST https://localhost:5001/api/clients
Content-Type: application/json

{
    "name": "Alice Johnson",
    "address": "789 Oak St",
    "phone": "555-9012"
}
```

#### Exemplo de Resposta (201 Created):

```json
{
    "id": 3,
    "name": "Alice Johnson",
    "address": "789 Oak St",
    "phone": "555-9012"
}
```

### Atualizar um Cliente Existente

Atualiza as informações de um cliente existente no sistema.

- **Método HTTP:** PUT
- **URL:** `https://localhost:5001/api/clients/{id}`

#### Exemplo de Requisição:

```http
PUT https://localhost:5001/api/clients/3
Content-Type: application/json

{
    "id": 3,
    "name": "Alice Johnson Updated",
    "address": "789 Oak St",
    "phone": "555-9999"
}
```

#### Exemplo de Resposta (204 No Content):

Não há corpo de resposta, apenas um código de status indicando que a atualização foi bem-sucedida.

### Excluir um Cliente

Exclui um cliente existente do sistema.

- **Método HTTP:** DELETE
- **URL:** `https://localhost:5001/api/clients/{id}`

#### Exemplo de Requisição:

```http
DELETE https://localhost:5001/api/clients/3
```

#### Exemplo de Resposta (204 No Content):

Não há corpo de resposta, apenas um código de status indicando que a exclusão foi bem-sucedida.

## Exemplo de Uso do Gerenciamento de Vendas

### Registrar uma Venda

Associa um cliente a um ou mais produtos vendidos, com quantidade e preço.

- **Método HTTP:** POST
- **URL:** `https://localhost:5001/api/sales`

#### Exemplo de Requisição:

```http
POST https://localhost:5001/api/sales
Content-Type: application/json

{
    "clientId": 1,
    "products": [
        {
            "productId": 1,
            "quantity": 2
        },
        {
            "productId": 2,
            "quantity": 1
        }
    ]
}
```

#### Exemplo de Resposta (201 Created):

```json
{
    "id": 1,
    "clientId": 1,
    "products": [
        {
            "productId": 1,
            "quantity": 2,
            "subtotal": 21.98
        },
        {
            "productId": 2,
            "quantity": 1,
            "subtotal": 15.99
        }
    ],
    "total": 37.97,
    "date": "2024-05-10T12:30:00"
}
```

### Consultar Vendas por Cliente

Busca todas as vendas realizadas por um cliente específico.

- **Método HTTP:** GET
- **URL:** `https://localhost:5001/api/sales/client/{clientId}`

#### Exemplo de Requisição:

```http
GET https://localhost:5001/api/sales/client/1
```

#### Exemplo de Resposta (200 OK):

```json
[
    {
        "id": 1,
        "clientId": 1,
        "products": [
            {
                "productId": 1,
                "quantity": 2,
                "subtotal": 21.98
            },
            {
                "productId": 2,
                "quantity": 1,
                "subtotal": 15.99
            }
        ],
        "total": 37.97,
        "date": "2024-05-10T12:30:00"
    },
    {
        "id": 2,
        "clientId": 1,
        "products": [
            {
                "productId": 3,
                "quantity": 3,
                "subtotal": 59.97
            }
        ],
        "total": 59.97,
        "date": "2024-05-11T10:45:00"
    }
]
```

### Relatórios de Vendas

Gera relatórios sobre vendas diárias, mensais, produtos mais vendidos, etc.

*Os detalhes específicos dos parâmetros e formatos dos relatórios podem variar.*

- **Método HTTP:** GET
- **URL:** `https://localhost:5001/api/sales/reports?startDate={startDate}&endDate={endDate}`

#### Exemplo de Requisição:

```http
GET https://localhost:5001/api/sales/reports?startDate=2024-05-01&endDate=2024-05-31
```

#### Exemplo de Resposta (200 OK):

```json
{
    "startDate": "2024-05-01T00:00:00",
    "endDate": "2024-05-31T23:59:59",
    "totalSales": 3,
    "totalRevenue": 157.94,
    "averageRevenuePerSale": 52.65,
    "mostSoldProducts": [
        {
            "productId": 3,
            "productName": "Product C",
            "totalQuantitySold": 7
        },
        {
            "productId": 1,
            "productName": "Product A",
            "totalQuantitySold": 5
        }
    ]
}
```

## Exemplo de Uso do  Gerenciamento de Estoque

### Adicionar Itens ao Estoque

Registra a entrada de novos produtos no estoque.

- **Método HTTP:** POST
- **URL:** `https://localhost:5001/api/inventory`

#### Exemplo de Requisição:

```http
POST https://localhost:5001/api/inventory
Content-Type: application/json

{
    "productId": 1,
    "quantity": 10
}
```

#### Exemplo de Resposta (201 Created):

```json
{
    "productId": 1,
    "quantity": 10,
    "dateAdded": "2024-05-10T14:00:00"
}
```

### Retirar Itens do Estoque

Controla a quantidade de itens em estoque após vendas.

- **Método HTTP:** POST
- **URL:** `https://localhost:5001/api/inventory/withdraw

`

#### Exemplo de Requisição:

```http
POST https://localhost:5001/api/inventory/withdraw
Content-Type: application/json

{
    "productId": 1,
    "quantity": 5
}
```

#### Exemplo de Resposta (200 OK):

```json
{
    "productId": 1,
    "quantityWithdrawn": 5,
    "remainingQuantity": 5
}
```

### Verificação de Validade

Verifica a validade dos produtos com base na data de validade.

- **Método HTTP:** GET
- **URL:** `https://localhost:5001/api/inventory/expiryCheck`

#### Exemplo de Requisição:

```http
GET https://localhost:5001/api/inventory/expiryCheck
```

#### Exemplo de Resposta (200 OK):

```json
[
    {
        "productId": 1,
        "productName": "Product A",
        "expiryDate": "2024-06-30T00:00:00",
        "daysUntilExpiry": 50
    },
    {
        "productId": 2,
        "productName": "Product B",
        "expiryDate": "2024-07-15T00:00:00",
        "daysUntilExpiry": 65
    }
]
```

