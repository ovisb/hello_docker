FROM mcr.microsoft.com/dotnet/sdk:8.0 as builder

WORKDIR /app

COPY . .

RUN dotnet publish -c=Release -o=build

FROM mcr.microsoft.com/dotnet/sdk:8.0-alpine

USER app

WORKDIR /app

COPY --from=builder /app/build .

EXPOSE 8080

ENTRYPOINT [ "dotnet", "hello_docker.dll" ]