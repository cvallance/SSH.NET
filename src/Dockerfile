FROM microsoft/dotnet:2.1.301-sdk
MAINTAINER Charles Vallance <vallance.charles@gmail.com>

WORKDIR /app

# Copy csproj and restore as distinct layers
COPY ./Issue355BugRepo.sln ./
COPY ./Renci.SshNet.NETCore/*.csproj ./Renci.SshNet.NETCore/
COPY ./Issue355BugRepo/*.csproj ./Issue355BugRepo/
RUN dotnet restore

# Copy everything else and build
COPY . ./
RUN dotnet build Issue355BugRepo.sln

# Build runtime image
WORKDIR /app/Issue355BugRepo
ENTRYPOINT ["dotnet", "run"]
