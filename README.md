# Hello Docker .NET core sample app

## Pre requirements

In order to test it you need the following:
- docker engine and client

## How to run

```bash
docker build -t 'yourImageName:yourTag' .

docker run --rm -p 5000:8080 'yourImageName:yourTag'
 
curl  http://localhost:5000                                             
Hello, Docker!
 ```
