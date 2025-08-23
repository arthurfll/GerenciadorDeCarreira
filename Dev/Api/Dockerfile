FROM bitnami/dotnet-sdk AS build

RUN mkdir -p /app/DotnetApi

COPY DotnetApi/ /app/DotnetApi

VOLUME [ "/app/DotnetApi" ]

WORKDIR /app/DotnetApi

CMD ["dotnet", "watch", "run", "--urls", "http://0.0.0.0:5555"]
