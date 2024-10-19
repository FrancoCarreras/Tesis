FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build

WORKDIR /src
COPY ["src/Tesis.AdminFutbol.Web.Host/Tesis.AdminFutbol.Web.Host.csproj", "src/Tesis.AdminFutbol.Web.Host/"]
COPY ["src/Tesis.AdminFutbol.Web.Core/Tesis.AdminFutbol.Web.Core.csproj", "src/Tesis.AdminFutbol.Web.Core/"]
COPY ["src/Tesis.AdminFutbol.Application/Tesis.AdminFutbol.Application.csproj", "src/Tesis.AdminFutbol.Application/"]
COPY ["src/Tesis.AdminFutbol.Core/Tesis.AdminFutbol.Core.csproj", "src/Tesis.AdminFutbol.Core/"]
COPY ["src/Tesis.AdminFutbol.EntityFrameworkCore/Tesis.AdminFutbol.EntityFrameworkCore.csproj", "src/Tesis.AdminFutbol.EntityFrameworkCore/"]
WORKDIR "/src/src/Tesis.AdminFutbol.Web.Host"
RUN dotnet restore 

WORKDIR /src
COPY ["src/Tesis.AdminFutbol.Web.Host", "src/Tesis.AdminFutbol.Web.Host"]
COPY ["src/Tesis.AdminFutbol.Web.Core", "src/Tesis.AdminFutbol.Web.Core"]
COPY ["src/Tesis.AdminFutbol.Application", "src/Tesis.AdminFutbol.Application"]
COPY ["src/Tesis.AdminFutbol.Core", "src/Tesis.AdminFutbol.Core"]
COPY ["src/Tesis.AdminFutbol.EntityFrameworkCore", "src/Tesis.AdminFutbol.EntityFrameworkCore"]
WORKDIR "/src/src/Tesis.AdminFutbol.Web.Host"
RUN dotnet publish -c Release -o /publish --no-restore

FROM mcr.microsoft.com/dotnet/aspnet:8.0
EXPOSE 80
WORKDIR /app
COPY --from=build /publish .
ENTRYPOINT ["dotnet", "Tesis.AdminFutbol.Web.Host.dll"]
