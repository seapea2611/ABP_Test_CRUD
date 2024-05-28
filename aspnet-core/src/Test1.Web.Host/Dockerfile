FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build

WORKDIR /src
COPY ["src/Test1.Web.Host/Test1.Web.Host.csproj", "src/Test1.Web.Host/"]
COPY ["src/Test1.Web.Core/Test1.Web.Core.csproj", "src/Test1.Web.Core/"]
COPY ["src/Test1.Application/Test1.Application.csproj", "src/Test1.Application/"]
COPY ["src/Test1.Core/Test1.Core.csproj", "src/Test1.Core/"]
COPY ["src/Test1.EntityFrameworkCore/Test1.EntityFrameworkCore.csproj", "src/Test1.EntityFrameworkCore/"]
WORKDIR "/src/src/Test1.Web.Host"
RUN dotnet restore 

WORKDIR /src
COPY ["src/Test1.Web.Host", "src/Test1.Web.Host"]
COPY ["src/Test1.Web.Core", "src/Test1.Web.Core"]
COPY ["src/Test1.Application", "src/Test1.Application"]
COPY ["src/Test1.Core", "src/Test1.Core"]
COPY ["src/Test1.EntityFrameworkCore", "src/Test1.EntityFrameworkCore"]
WORKDIR "/src/src/Test1.Web.Host"
RUN dotnet publish -c Release -o /publish --no-restore

FROM mcr.microsoft.com/dotnet/aspnet:7.0
EXPOSE 80
WORKDIR /app
COPY --from=build /publish .
ENTRYPOINT ["dotnet", "Test1.Web.Host.dll"]
