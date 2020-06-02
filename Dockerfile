FROM microsoft/aspnet
ARG source=TestWebApp/.
WORKDIR /inetpub/wwwroot
COPY ${source} .
