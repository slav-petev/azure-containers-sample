FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /azure-container-sample
COPY . /azure-container-sample
RUN cd AzureContainersSample.Web
RUN dotnet restore
RUN dotnet publish -o /azure-container-sample/publish -c Release

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS runtime
ENV DOTNET_URLS=http://+:5000
WORKDIR /publish
COPY --from=build /azure-container-sample/publish /publish

ENTRYPOINT ["dotnet", "AzureContainersSample.Web.dll"]
