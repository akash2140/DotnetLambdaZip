Commands to follow while project creation of this application:

dotnet --version
dotnet new -i Amazon.Lambda.Templates
dotnet new serverless.AspNetCoreWebApp --name ValuesAPI

dotnet restore ( on both Src -----> valuesAPI & Test ----? ValuesAPI)

dotnet build  (on Src valuesAPI)
dotnet publish -c release(on Src valuesAPI)
