FROM mcr.microsoft.com/mssql/server

RUN mkdir /var/opt/sqlserver

COPY DockerDemo.mdf /var/opt/sqlserver
COPY DockerDemo_log.ldf  /var/opt/sqlserver

ENV SA_PASSWORD=Passw0rd
ENV ACCEPT_EULA=Y

HEALTHCHECK --interval=10s  \
	CMD /opt/mssql-tools/bin/sqlcmd -S . -U sa -P Passw0rd \
		-Q "CREATE DATABASE [DockerDemo] ON (FILENAME = '/var/opt/sqlserver/DockerDemo.mdf'),(FILENAME = '/var/opt/sqlserver/DockerDemo_log.ldf') FOR ATTACH"