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

@Fontes:
- https://docs.microsoft.com/pt-br/ef/core/get-started/overview/install
- https://www.nuget.org/
- https://www.npmjs.com/

Gerador de gitignore:
- https://www.toptal.com/developers/gitignore

⚠️ ATENÇÃO! ⚠️

Se estiver usando uma conexão SqlServer por meio de container, atente-se para mudança de instância na string de conexão em Program.cs, Linha 13.