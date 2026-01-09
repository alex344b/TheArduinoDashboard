# Build stage
FROM mcr.microsoft.com/dotnet/sdk:10.0-preview AS build
WORKDIR /src

# Copy csproj and restore dependencies
COPY TheArduinoDashboard/TheArduinoDashboard.csproj TheArduinoDashboard/
RUN dotnet restore TheArduinoDashboard/TheArduinoDashboard.csproj

# Copy everything else and build
COPY . .
WORKDIR /src/TheArduinoDashboard
RUN dotnet publish -c Release -o /app/publish

# Runtime stage
FROM mcr.microsoft.com/dotnet/aspnet:10.0-preview AS runtime
WORKDIR /app

# Create non-root user for security
RUN adduser --disabled-password --gecos '' appuser

COPY --from=build /app/publish .

# Set environment variables
ENV ASPNETCORE_URLS=http://+:13000
ENV ASPNETCORE_ENVIRONMENT=Production

# Change ownership and switch to non-root user
RUN chown -R appuser:appuser /app
USER appuser

EXPOSE 13000

ENTRYPOINT ["dotnet", "TheArduinoDashboard.dll"]
