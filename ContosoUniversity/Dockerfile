# Stage 1: Build
FROM mcr.microsoft.com/dotnet/framework/sdk:4.8 AS build
WORKDIR C:\\app

COPY . .

RUN nuget restore ContosoUniversity.sln

RUN msbuild ContosoUniversity.csproj \
    /p:Configuration=Release \
    /p:DeployOnBuild=true \
    /p:WebPublishMethod=FileSystem \
    /p:PublishUrl=C:\\publish \
    /p:DeleteExistingFiles=True

# Stage 2: Runtime
FROM mcr.microsoft.com/dotnet/framework/aspnet:4.8-windowsservercore-ltsc2022 AS final
WORKDIR C:\\inetpub\\wwwroot
COPY --from=build C:\\publish .
