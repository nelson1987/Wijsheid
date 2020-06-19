#Depending on the operating system of the host machines(s) that will build or run the containers, the image specified in the FROM statement may need to be changed.
#For more information, please see https://aka.ms/containercompat

#  FROM microsoft/dotnet:2.2-aspnetcore-runtime-nanoserver-1803 AS base
#  WORKDIR /app
#  EXPOSE 80
#  EXPOSE 443
 
#  FROM microsoft/dotnet:2.2-sdk-nanoserver-1803 AS build
#  WORKDIR /src
#  COPY ["src/Wijsheid.Api/Wijsheid.Api.csproj", "Wijsheid.Api/"]
#  RUN dotnet restore "Wijsheid.Api/Wijsheid.Api.csproj"
#  COPY . .
#  WORKDIR "/src/Wijsheid.Api"
#  RUN dotnet build "Wijsheid.Api.csproj" -c Release -o /app

#  FROM build AS publish
#  RUN dotnet publish "Wijsheid.Api.csproj" -c Release -o /app

#  FROM base AS final
#  WORKDIR /app
#  COPY --from=publish /app .
#  ENTRYPOINT ["dotnet", "Wijsheid.Api.dll"]
# FROM microsoft/dotnet:2.2-aspnetcore-runtime
# LABEL version="1.0.0" description="aplicacao Asp .Net Core MVC"
# COPY dist /app
# WORKDIR /app
# EXPOSE 80/tcp
# ENTRYPOINT ["dotnet","Wijsheid.Api.dll"]
FROM microsoft/dotnet:2.2-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM microsoft/dotnet:2.2-sdk AS build
WORKDIR /src
# COPY ["src/Wijsheid.Api/Wijsheid.Api.csproj", "Wijsheid.Api/"]
# COPY ["src/WijSheid.Application.Models/WijSheid.Application.Models.csproj", "WijSheid.Application.Models/"]
# COPY ["src/Wijsheid.Application.Contracts/Wijsheid.Application.Contracts.csproj", "Wijsheid.Application.Contracts/"]
# COPY ["src/Wijsheid.Crosscutting/Wijsheid.Crosscutting.csproj", "Wijsheid.Crosscutting/"]
# COPY ["src/Wijsheid.Service/Wijsheid.Service.csproj", "Wijsheid.Service/"]
# COPY ["src/Wijsheid.Repository.Contracts/Wijsheid.Repository.Contracts.csproj", "Wijsheid.Repository.Contracts/"]
# COPY ["src/Wijsheid.Domain/Wijsheid.Domain.csproj", "Wijsheid.Domain/"]
# COPY ["src/Wijsheid.Service.Contracts/Wijsheid.Service.Contracts.csproj", "Wijsheid.Service.Contracts/"]
# COPY ["src/Wijsheid.Repository/Wijsheid.Repository.csproj", "Wijsheid.Repository/"]
# COPY ["src/Wijsheid.Application/Wijsheid.Application.csproj", "Wijsheid.Application/"]
COPY "src" .
# RUN dotnet restore "Wijsheid/Wijsheid.Api/Wijsheid.Api.csproj"
RUN dotnet restore
RUN dotnet test
COPY . .
# WORKDIR "/src/Wijsheid.Api"
# RUN dotnet test "Wijsheid.DomainTests/Wijsheid.Api.csproj" -c Release -o /app
# dotnet test [Diretorio_De_testes]~/projects/test1/test1.csproj

WORKDIR "/src/Wijsheid.Api"
RUN dotnet build "Wijsheid.Api.csproj" -c Release -o /app


FROM build AS publish
RUN dotnet publish "Wijsheid.Api.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "Wijsheid.Api.dll"]