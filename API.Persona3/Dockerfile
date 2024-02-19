#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER app
ARG CS="Server=172.17.0.2;Database=persona_answers;User Id=sa;Password=1q2w3e4r@#$"
ENV CONNECTION_STRING=$CS
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["API.Persona3/API.Persona3.csproj", "API.Persona3/"]
RUN dotnet restore "./API.Persona3/API.Persona3.csproj"
COPY . .
WORKDIR "/src/API.Persona3"
RUN dotnet build "./API.Persona3.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./API.Persona3.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "API.Persona3.dll"]