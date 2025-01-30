FROM mcr.microsoft.com/dotnet/runtime:8.0 AS base
USER $APP_UID
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["Simulation/Simulation.csproj", "Simulation/"]
RUN dotnet restore "Simulation/Simulation.csproj"
COPY . .
WORKDIR "/src/Simulation"
RUN dotnet build "Simulation.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "Simulation.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
COPY Solar_Plant_data.csv /app/Solar_Plant_data.csv
ENTRYPOINT ["dotnet", "Simulation.dll"]
