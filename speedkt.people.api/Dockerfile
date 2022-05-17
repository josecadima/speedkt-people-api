#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images.

#Depending on the operating system of the host machines(s) that will build or run the containers, the image specified in the FROM statement may need to be changed.
#For more information, please see https://aka.ms/containercompat

# Step 1. Create the 'base' image and open ports 80 & 443
FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

# Step 2. Build source code from 'sdk' image. 
# THEN Generate binaries into the /app/build folder of this image
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["speedkt.people.api/speedkt.people.api.csproj", "speedkt.people.api/"]
RUN dotnet restore "speedkt.people.api/speedkt.people.api.csproj"
COPY . .
WORKDIR "/src/speedkt.people.api"
RUN dotnet build "speedkt.people.api.csproj" -c Release -o /app/build

# Step 3. Publish binaries into the /app/publish folder
FROM build AS publish
RUN dotnet publish "speedkt.people.api.csproj" -c Release -o /app/publish

# Step 4. Copy published binaries from 'build' image into Working directory of 'base' image
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "speedkt.people.api.dll"]