FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build

WORKDIR /src
COPY ["src/KuntoLps2.Web.Host/KuntoLps2.Web.Host.csproj", "src/KuntoLps2.Web.Host/"]
COPY ["src/KuntoLps2.Web.Core/KuntoLps2.Web.Core.csproj", "src/KuntoLps2.Web.Core/"]
COPY ["src/KuntoLps2.Application/KuntoLps2.Application.csproj", "src/KuntoLps2.Application/"]
COPY ["src/KuntoLps2.Core/KuntoLps2.Core.csproj", "src/KuntoLps2.Core/"]
COPY ["src/KuntoLps2.EntityFrameworkCore/KuntoLps2.EntityFrameworkCore.csproj", "src/KuntoLps2.EntityFrameworkCore/"]
WORKDIR "/src/src/KuntoLps2.Web.Host"
RUN dotnet restore 

WORKDIR /src
COPY ["src/KuntoLps2.Web.Host", "src/KuntoLps2.Web.Host"]
COPY ["src/KuntoLps2.Web.Core", "src/KuntoLps2.Web.Core"]
COPY ["src/KuntoLps2.Application", "src/KuntoLps2.Application"]
COPY ["src/KuntoLps2.Core", "src/KuntoLps2.Core"]
COPY ["src/KuntoLps2.EntityFrameworkCore", "src/KuntoLps2.EntityFrameworkCore"]
WORKDIR "/src/src/KuntoLps2.Web.Host"
RUN dotnet publish -c Release -o /publish --no-restore

FROM mcr.microsoft.com/dotnet/aspnet:7.0
EXPOSE 80
WORKDIR /app
COPY --from=build /publish .
ENTRYPOINT ["dotnet", "KuntoLps2.Web.Host.dll"]
