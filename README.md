# ListApp_estudos

__Projeto de estudos com sql server, dotnet e angular.__

_Dependências @frontend:_

    npm add ngx-bootstrap

    npm i --save ngx-bootstrap

_Dependências @backend:_

    dotnet add package Microsoft.EntityFrameworkCore 

    dotnet add package Microsoft.EntityFrameworkCore.Relational 

    dotnet add package Microsoft.EntityFrameworkCore.Tools 

    dotnet add package Microsoft.EntityFrameworkCore.SqlServer.Design 

    dotnet add package Microsoft.EntityFrameworkCore.SqlServer


__Principais comandos:__
    
Para gerar as migrations: 
    dotnet ef migrations add mgInit --context Contexto
Para criar ou atualizar o banco:

    dotnet ef database update -- --environment Production


@Fontes:
- https://docs.microsoft.com/pt-br/ef/core/managing-schemas/migrations/?tabs=dotnet-core-cli
- https://docs.microsoft.com/pt-br/ef/core/get-started/overview/install
- https://www.nuget.org/
- https://www.npmjs.com/
- https://docs.microsoft.com/pt-br/dotnet/framework/data/adonet/connection-string-syntax
- https://stackoverflow.com/questions/8243008/format-of-the-initialization-string-does-not-conform-to-specification-starting-a
- https://www.c-sharpcorner.com/article/entity-framework-core-in-docker-container-part-ii-sqlite/
- https://docs.microsoft.com/pt-br/aspnet/core/data/ef-mvc/migrations?view=aspnetcore-6.0
- https://docs.microsoft.com/en-us/dotnet/architecture/modernize-desktop/example-migration
- https://docs.microsoft.com/en-us/ef/core/managing-schemas/migrations/applying?tabs=dotnet-core-cli

__Para resolver conflitos de conexão:__
- https://docs.microsoft.com/pt-br/aspnet/core/tutorials/first-mvc-app/working-with-sql?view=aspnetcore-6.0&tabs=visual-studio-code

__Problemas com o arquivo Program.cs:__
- https://docs.microsoft.com/pt-br/ef/core/cli/dbcontext-creation?tabs=dotnet-core-cli

Gerador de gitignore:
- https://www.toptal.com/developers/gitignore

⚠️ ATENÇÃO! ⚠️

Se estiver usando uma conexão SqlServer por meio de container, atente-se para mudança de instância na string de conexão em Program.cs, Linha 13.