build:
    dotnet build

publish:
    dotnet build -c publish

fmt:
    csharpier format .
