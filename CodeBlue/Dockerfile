# Get base SDK from MSFT
FROM mcr.microsoft.com/dotnet/sdk as build-env
WORKDIR /app

#Copy csproj file and restore dependecies
COPY *.csproj ./
RUN dotnet restore

#Copy proj files and build them onto release
COPY . ./
RUN dotnet publish -c Release -o out

#Generate runtime img
FROM mcr.microsoft.com/dotnet/aspnet:3.1
WORKDIR /app
EXPOSE 80
EXPOSE 5000/tcp
COPY --from=build-env /app/out .
ENTRYPOINT ["dotnet","CodeBlue.dll"]