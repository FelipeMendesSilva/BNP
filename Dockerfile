# Etapa de build
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# Copia tudo para dentro do cont�iner
COPY . .

# Restaura e publica o projeto principal
RUN dotnet restore "BNP.CMM.API/BNP.CMM.API.csproj"
RUN dotnet publish "BNP.CMM.API/BNP.CMM.API.csproj" -c Release -o /app/publish

# Etapa de runtime
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime
WORKDIR /app

# Definindo o ambiente
ENV ASPNETCORE_ENVIRONMENT=Development

COPY --from=build /app/publish .

EXPOSE 8080
ENTRYPOINT ["dotnet", "BNP.CMM.API.dll"]