# Facul-OOP

## Criação projeto

### Para criar a solução

```
dotnet new sln
dotnet new gitignore
```

### Para criar o arquivo gitignore

```
dotnet new gitignore
```

### Para criar o projeto

```
dotnet new webapi -n FaculOop.WebApi -o src/WebApi
```

### Para vincular o projeto a solução

```
dotnet sln add src/WebApi/FaculOop.WebApi.csproj
```

### Para confiar no certificado de DEV

```
dotnet dev-certs https --trust
```

### Em caso de travamentos

-   Pressionar F1
-   OMNISharp - Restart

## Migration

### Instalar pacote EF

```bash
dotnet tool install --global dotnet-ef
```

### Criar migração

```bash
dotnet ef migrations add Initital --project src/WebApi/FaculOop.WebApi.csproj --startup-project src/WebApi/FaculOop.WebApi.csproj
```

### Atualizando base de dados

```bash
dotnet ef database update --project src/WebApi/FaculOop.WebApi.csproj --startup-project src/WebApi/FaculOop.WebApi.csproj
```
