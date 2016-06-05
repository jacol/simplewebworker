FROM msimons/dotnet:latest
RUN apt-get install git && git clone https://github.com/jacol/simplewebworker.git
CMD cd simplewebworker && dotnet restore && dotnet run
