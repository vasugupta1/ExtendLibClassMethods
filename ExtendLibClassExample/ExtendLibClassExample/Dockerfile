FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["ExtendLibClassExample/ExtendLibClassExample.csproj", "ExtendLibClassExample/"]
RUN dotnet restore "ExtendLibClassExample/ExtendLibClassExample.csproj"
COPY . .
WORKDIR "/src/ExtendLibClassExample"
RUN dotnet build "ExtendLibClassExample.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ExtendLibClassExample.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ExtendLibClassExample.dll"]
