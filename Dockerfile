FROM mcr.microsoft.com/dotnet/sdk:8.0

USER app

WORKDIR /app

COPY ./build .

EXPOSE 5000

ENTRYPOINT [ "dotnet", "hello_docker.dll" ]