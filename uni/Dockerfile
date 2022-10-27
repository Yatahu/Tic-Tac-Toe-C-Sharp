FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["uni/uni.csproj", "uni/"]
RUN dotnet restore "uni/uni.csproj"
COPY . .
WORKDIR "/src/uni"
RUN dotnet build "uni.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "uni.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "uni.dll"]
