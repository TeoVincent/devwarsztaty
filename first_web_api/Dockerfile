﻿FROM microsoft/dotnet:latest
COPY . /app
WORKDIR /app

RUN ["dotnet", "restore", "--source", "https://api.nuget.org/v3/index.json", "--source", "https://www.myget.org/F/teovincentdevwarsztaty/api/v2", "--no-cache"]
RUN ["dotnet", "build"]

EXPOSE 5050/tcp
ENV ASPNETCORE_URLS http://*:5050
ENV ASPNETCORE_ENVIRONMENT Docker

ENTRYPOINT ["dotnet", "run"]