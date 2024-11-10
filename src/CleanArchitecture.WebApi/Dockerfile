FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER $APP_UID
WORKDIR /app
EXPOSE 8080
EXPOSE 8081
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["src/CleanArchitecture.WebApi/CleanArchitecture.WebApi.csproj", "src/CleanArchitecture.WebApi/"]
RUN dotnet restore "src/CleanArchitecture.WebApi/CleanArchitecture.WebApi.csproj"
COPY . .
WORKDIR "/src/src/CleanArchitecture.WebApi"
RUN dotnet build "CleanArchitecture.WebApi.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "CleanArchitecture.WebApi.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "CleanArchitecture.WebApi.dll"]
