# Etapa de construção
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /app

# Copie os arquivos .csproj e restaure as dependências para cada projeto
COPY ./EduckBackend/EduckBackend.csproj ./EduckBackend/
COPY ./Domain/Domain.csproj ./Domain/
COPY ./Service/Service.csproj ./Service/
COPY ./Infra.Data/Infra.data.csproj ./Infra.Data/

# Restaure as dependências (este comando vai resolver as dependências entre os projetos)
RUN dotnet restore ./EducBackend/EducBackend.csproj

# Copie todos os arquivos do projeto para a imagem
COPY . .

# Compile o projeto no modo Release
RUN dotnet publish ./EducBackend/EducBackend.csproj -c Release -o /app/out

# Etapa de execução
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime
WORKDIR /app
COPY --from=build /app/out .

# Exponha a porta da aplicação
EXPOSE 80

# Defina o comando de inicialização
ENTRYPOINT ["dotnet", "EduckBackend.dll"]
