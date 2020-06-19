FROM microsoft/dotnet:2.2-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM microsoft/dotnet:2.2-sdk AS build
WORKDIR /src
COPY "src" .
RUN dotnet restore

RUN dotnet test
COPY . .
WORKDIR "/src/Wijsheid.Api"
RUN dotnet build "Wijsheid.Api.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "Wijsheid.Api.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "Wijsheid.Api.dll"]