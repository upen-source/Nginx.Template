# Nginx.Template

[![.NET](https://github.com/afgalvan/Nginx.Template/actions/workflows/dotnet.yml/badge.svg)](https://github.com/afgalvan/Nginx.Template/actions/workflows/dotnet.yml)
[![NuGet](https://github.com/afgalvan/Nginx.Template/actions/workflows/publish.yml/badge.svg)](https://github.com/afgalvan/Nginx.Template/actions/workflows/publish.yml)
[![Nuget Version](https://img.shields.io/nuget/v/Nginx.Template?label=Version&logo=NuGet&labelColor=22272E&color=blue)](https://www.nuget.org/packages/Nginx.Template/)

ASP.NET project template with nginx.

## Features

- ASP.NET
- Entity Framework
- Docker & docker compose
- nginx
- MySQL
- editorconfig

## Installation

```bash
dotnet new -i Nginx.Template
```

## Usage

```bash
dotnet new ngx-api -o Your.Project
```

## Run it from Docker

```bash
# Run & build the containers in background
docker-compose -f docker/docker-compose.yml up --build -d
# Then, to see the nginx logs
docker attach api_proxy

# Or in attached mode
docker-compose -f docker/docker-compose.yml up --build
```

Open a browser and go to <http://localhost/WeatherForecast>
