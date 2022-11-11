#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["ShopeeApi/ShopeeApi.csproj", "ShopeeApi/"]
COPY ["DataLayer/DataLayer.csproj", "DataLayer/"]
COPY ["LogicLayer/LogicLayer.csproj", "LogicLayer/"]
COPY ["LoggerService/LoggerService.csproj", "LoggerService/"]
RUN dotnet restore "ShopeeApi/ShopeeApi.csproj"
COPY . .
WORKDIR "/src/ShopeeApi"
RUN dotnet build "ShopeeApi.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ShopeeApi.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ShopeeApi.dll"]