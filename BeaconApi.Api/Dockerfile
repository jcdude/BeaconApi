FROM mcr.microsoft.com/dotnet/core/aspnet:2.2-stretch-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:2.2-stretch AS build
WORKDIR /src
COPY ["BeaconApi.Api/BeaconApi.Api.csproj", "BeaconApi.Api/"]
RUN dotnet restore "BeaconApi.Api/BeaconApi.Api.csproj"
COPY . .
WORKDIR "/src/BeaconApi.Api"
RUN dotnet build "BeaconApi.Api.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "BeaconApi.Api.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "BeaconApi.Api.dll"]