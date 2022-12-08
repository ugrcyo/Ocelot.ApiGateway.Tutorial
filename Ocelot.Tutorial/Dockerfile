FROM mcr.microsoft.com/dotnet/sdk:6.0
WORKDIR /app
COPY . .
RUN dotnet restore
RUN dotnet publish ApiGateway.csproj -c Release -o out
WORKDIR out
ENV ASPNETCORE_URLS="http://*:1453"
ENTRYPOINT ["dotnet", "ApiGateway.dll"]