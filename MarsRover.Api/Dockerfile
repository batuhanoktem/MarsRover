FROM mcr.microsoft.com/dotnet/core/aspnet:2.2-stretch-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:2.2-stretch AS build
WORKDIR /src
COPY ["MarsRover.Api/MarsRover.Api.csproj", "MarsRover.Api/"]
RUN dotnet restore "MarsRover.Api/MarsRover.Api.csproj"
COPY . .
WORKDIR "/src/MarsRover.Api"
RUN dotnet build "MarsRover.Api.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "MarsRover.Api.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "MarsRover.Api.dll"]