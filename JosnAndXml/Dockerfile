#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["JosnAndXml/JosnAndXml.csproj", "JosnAndXml/"]
RUN dotnet restore "JosnAndXml/JosnAndXml.csproj"
COPY . .
WORKDIR "/src/JosnAndXml"
RUN dotnet build "JosnAndXml.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "JosnAndXml.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "JosnAndXml.dll"]
