# Anotações Jornada Fullstack 2024 - Balta.IO

# Dia 01 - Backend, Minimal APIs e Entity Framework

## Comandos iniciais

``` bash
### Criação dos projetos
mkdir Fina
cd Fina
dotnet new sln
dotnet new web -o Fina.Api
dotnet new blazorwasm -o Fina.Web --pwa
dotnet new classlib -o Fina.Core

### Vincular projetos à Solução
dotnet sln add ./Fina.Api
dotnet sln add ./Fina.Core
dotnet sln add ./Fina.Web

### Vincular projetos API e WEB ao Core
cd Fina.Api
dotnet add reference ../Fina.Core
cd ..
cd Fina.Web
dotnet add reference ../Fina.Core
cd ..
dotnet build
```

