# Spectre.Client

[![Build Status](https://dev.azure.com/jkirsteins/Spectre.Client/_apis/build/status/kirsis.Spectre.Client?branchName=master)](https://dev.azure.com/jkirsteins/Spectre.Client/_build/latest?definitionId=1&branchName=master) [![Nuget](https://img.shields.io/nuget/v/Spectre.Client?color=blue&style=flat)](https://www.nuget.org/packages/Spectre.Client/)

A `netstandard2.0` library for calling the <a href="https://www.saltedge.com/products/spectre">SaltEdge</a> Global Data Aggregation API.

## Testing and Building

    dotnet test
    dotnet build

## Installation

    dotnet add <PROJECT> package Spectre.Client

## Getting Started

The client uses [Refit](https://github.com/reactiveui/refit), so initialize the client by:

```csharp
var client = RestService.For<ISaltEdgeClient>("https://www.saltedge.com/api/v5/");
```

If you're using ASP.NET, you might want to add it as a service in `ConfigureServices`:

```csharp
services.AddScoped(_ => RestService.For<ISaltEdgeClient>(
  new HttpClient(
    new SaltEdgeHttpClientHandler(
      Configuration["SaltEdge:AppId"],
      Configuration["SaltEdge:Secret"])
    )
    {
      BaseAddress = new Uri("https://www.saltedge.com/api/v5/"),
    }));
```

## Implemented functionality

- Create a customer: `ISaltEdgeClient.CreateCustomer`
- Request a connect session: `ISaltEdgeClient.CreateConnectSession`
- Fetch customer connections: `ISaltEdgeClient.GetConnections`
- Fetch connection accounts: `ISaltEdgeClient.GetAccounts`

---

Licenced under an MIT licence. Maintainer: Jānis Kiršteins [@jkirsteins](https://twitter.com/jkirsteins)

Copyright &copy; 2019 Jānis Kiršteins
