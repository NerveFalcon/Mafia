FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Play/Play.csproj", "Play/"]
RUN dotnet restore "Play/Play.csproj"
COPY . .
WORKDIR "/src/Play"
RUN dotnet build "Play.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Play.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Play.dll"]
