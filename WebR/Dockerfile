
FROM microsoft/dotnet:2.1-aspnetcore-runtime-nanoserver-sac2016 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM microsoft/dotnet:2.1-sdk-nanoserver-sac2016 AS build
ARG BUILDCONFIG=RELEASE
ARG VERSION=1.0.0

COPY WebR.csproj /build/

RUN dotnet restore "WebR/WebR.csproj"

COPY . ./build/
WORKDIR /build/
RUN dotnet publish ./"WebR.csproj" -c $BUILDCONFIG -o out /p:Version=$VERSION
FROM microsoft/dotnet:2.1-aspnetcore-runtime
WORKDIR /app
COPY --from=build /build/out .
ENTRYPOINT ["dotnet", "WebR.dll"]

COPY ["WebR/WebR.csproj", "WebR/"]





