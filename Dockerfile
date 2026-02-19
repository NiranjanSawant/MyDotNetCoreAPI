# Build stage
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src

COPY . .

RUN dotnet restore WebAppTest1.sln
RUN dotnet publish WebAppTest1/WebAppTest1.csproj -c Release -o /app/publish

# Runtime stage
FROM mcr.microsoft.com/dotnet/aspnet:6.0
WORKDIR /app

COPY --from=build /app/publish .

ENTRYPOINT ["dotnet", "WebAppTest1.dll"]
