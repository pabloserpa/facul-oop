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

- Pressionar F1
- OMNISharp - Restart
