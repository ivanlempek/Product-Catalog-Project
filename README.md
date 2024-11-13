# Product Catalog Blazor
Este é um sistema web para catálogo de produtos desenvolvido em Blazor, com funcionalidades de CRUD para gerenciar produtos e categorias. O projeto segue princípios de Clean Architecture e DDD e foi implementado com uma arquitetura de microsserviços, garantindo uma separação clara entre as camadas e modularidade no sistema. O aplicativo também possui autenticação JWT e cache implementado com Redis para melhorar a performance.

## Funcionalidades
- Cadastro de Produtos: Interface para criação, edição, visualização e exclusão de produtos.
- Cadastro de Categorias: Interface para criação, edição, visualização e exclusão de categorias.
- Autenticação JWT: Controle de acesso seguro através de tokens JWT.
- Cache com Redis: Utilização de Redis para armazenamento temporário de dados, otimizando o desempenho em operações recorrentes.

## Tecnologias Utilizadas
- Blazor: Framework front-end da Microsoft para desenvolvimento de SPAs (Single Page Applications).
- C# e .NET: Linguagem de programação e framework utilizados para desenvolver o back-end.
- Redis: Banco de dados em memória para cache de dados.
- JWT (JSON Web Token): Implementação de autenticação e autorização.
- Clean Architecture e DDD: Padrões arquiteturais para manter a aplicação modular e de fácil manutenção.
