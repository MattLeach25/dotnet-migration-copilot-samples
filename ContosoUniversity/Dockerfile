# Build stage
FROM mcr.microsoft.com/dotnet/framework/sdk:4.8 AS build
WORKDIR C:\\app

COPY packages.config .
COPY ContosoUniversity.csproj .
COPY . .

RUN nuget restore ContosoUniversity.csproj

RUN msbuild ContosoUniversity.csproj /p:Configuration=Release /p:DeployOnBuild=true /p:WebPublishMethod=FileSystem /p:PublishUrl=C:\\publish /p:DeleteExistingFiles=True

# Runtime stage
FROM mcr.microsoft.com/dotnet/framework/aspnet:4.8 AS runtime
WORKDIR C:\\inetpub\\wwwroot

EXPOSE 80

COPY --from=build C:/publish .
