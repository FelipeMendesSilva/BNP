# BNP - Consulta de Movimentos Manuais 

Aplicação full-stack que lista e insere movimentos manuais no banco de dados.

## Funcionalidades

. Inserção de movimentos manuais  
. Exibição dos mocimentos manuais  

## Tecnologias

Back-end/Front-end: ASP.NET Core (.NET 8)  
Containerização: Docker

### .Estrutura do Projeto  

```
├── BNP.CMM.API/           # Aplicaçã API .NET
│   └── Dockerfile
├── data/                  # Persistência dos dados PostgreSQL
├── iniciar-app.bat        # Inicia os serviços
├── docker-compose.yml     # Orquestração dos serviços 
├── CMM.API.sln            # Solução 
└── README.md              # Este arquivo
```

## Execução

Você pode iniciar ambos os serviços usando docker-compose, ou simplesmente executando o arquivo **iniciar-app.bat**.

### .Docker Compose

Na raiz do projeto, execute:

```
bash

docker-compose up --build
```

### .Visual Studio

Para executar a aplicação no Visual Studio altere a ConnectionString de "Default" para "PostgresConnection".
A opção "Default" é a ConnectionString que conecta ao Postgres do container Docker.

```
namespace BNP.CMM.Infra.IoC
{
    public static class RegisterInfraServicesExtension
    {
        public static void RegisterInfraServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IManualMovementsRepository, ManualMovementsRepository>();

            var connectionString = configuration.GetConnectionString("PostgresConnection");
            services.AddDbContext<AppDbContext>(options =>
                options.UseNpgsql(connectionString));
        }
    }
}
```

## Front-end Consulta de Movimentos Manuais 

- Acesse: http://localhost:5035  



