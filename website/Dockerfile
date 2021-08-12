# Use latest microsoft SDK
FROM mcr.microsoft.com/dotnet/sdk AS build
# Publish the app from source code
WORKDIR /src
COPY . .
RUN dotnet publish -c Release -o /build/output
# Use latest microsoft .NET runtime
FROM mcr.microsoft.com/dotnet/aspnet AS runtime
# Copy published app from previous stage
COPY --from=build /build/output /app
WORKDIR /app
# Expose 90/tcp port
EXPOSE 90
# Execute web server
ENTRYPOINT [ "dotnet", "website.dll" ]