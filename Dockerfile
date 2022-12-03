#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["BookStore.Domain/BookStore.Domain.csproj", "BookStore.Domain/"]
COPY ["BookStore.Repository/BookStore.Repository.csproj", "BookStore.Repository/"]
COPY ["BookStore.Service/BookStore.Service.csproj", "BookStore.Service/"]
COPY ["BookStore.Web/BookStore.Web.csproj", "BookStore.Web/"]
COPY ["BookStore.Test/BookStore.Test.csproj", "BookStore.Test/"]
COPY ["devops.sln", "./"]
RUN dotnet restore
COPY . .
RUN dotnet build -c Release

FROM build AS publish
RUN dotnet publish -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "BookStore.Web.dll"]