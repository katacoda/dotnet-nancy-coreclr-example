FROM microsoft/dotnet:1.1.1-sdk
RUN         mkdir -p /src
WORKDIR     /src

COPY        src/Nancy.Demo.Hosting.Docker.csproj /src
RUN         ["dotnet", "restore"]

COPY        ./src /src
RUN         ["dotnet", "build"]

EXPOSE      8080
CMD         ["dotnet", "run"]
