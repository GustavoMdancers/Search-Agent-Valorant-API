# Search Agent Valorant API

Aplicação web desenvolvida em Blazor WebAssembly para consultar informações de agentes do jogo VALORANT por meio da API pública `https://valorant-api.com`.

## Visão geral

Este projeto permite que o usuário informe o UUID de um agente e obtenha:

- nome do agente
- descrição
- imagem de perfil/full portrait
- mensagem de erro caso o UUID seja inválido ou o agente não exista

A interface é simples e direta, ideal para testes rápidos com a API do jogo.

## Tecnologias utilizadas

- .NET 10
- Blazor WebAssembly
- C#
- HttpClient para requisições HTTP

## Estrutura do projeto

```text
Search-Agent-Valorant-API/
├── README.md
├── LICENSE
├── SearchAgentValorantAPI/
│   ├── App.razor
│   ├── Program.cs
│   ├── SearchAgentValorantAPI.csproj
│   ├── _Imports.razor
│   ├── Layout/
│   ├── Models/
│   ├── Pages/
│   └── wwwroot/
└── ...
```

## Pré-requisitos

Antes de rodar o projeto, certifique-se de ter instalado:

- .NET SDK 10.0+
- Um navegador moderno

## Como executar

No diretório raiz do projeto, execute:

```bash
dotnet restore
dotnet build
dotnet run
```

Depois, abra o endereço informado no terminal, normalmente algo como:

```text
https://localhost:5001
```

ou

```text
http://localhost:5000
```

## Como usar

1. Abra a aplicação no navegador.
2. Informe o UUID do agente do VALORANT.
3. Clique em "Buscar Agente".
4. A aplicação consulta a API e exibe o nome, descrição e imagem do agente.

Exemplo de UUID já pré-carregado na interface:

```text
e370fa57-4757-3604-3648-499e1f642d3f
```

## Requisição realizada

A aplicação faz uma chamada para a API pública do VALORANT:

```text
https://valorant-api.com/v1/agents/{uuid}
```

Os dados retornados são convertidos em modelos locais e apresentados na tela.

## Observações

- A aplicação consome uma API externa e depende da disponibilidade do serviço.
- Caso o UUID esteja incorreto ou a API responda com erro, a tela exibe uma mensagem informativa.
- O projeto foi construído como uma demonstração simples de consumo de API com Blazor.

## Licença

Este projeto está sob a licença presente no arquivo [LICENSE](LICENSE).
