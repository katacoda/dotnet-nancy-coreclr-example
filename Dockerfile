FROM microsoft/dotnet:1.0.0-preview2-sdk

RUN         mkdir -p /src
WORKDIR     /src
COPY        project.json /src
RUN         ["dotnet", "restore"]
COPY        ./src /src
RUN         ["dotnet", "build"]
EXPOSE      8080
CMD         ["dotnet", "run"]
