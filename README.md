# Product Management API

## Overview
This project is developed using ASP.NET Core Web API with .NET 8.

## Features
- CRUD Operations
- SQL Server Database
- Entity Framework Core
- Repository Pattern
- JWT Authentication
- Swagger Documentation
- FluentValidation
- Global Exception Middleware
- Docker Support

## Technologies Used
- ASP.NET Core Web API
- SQL Server
- Entity Framework Core
- Swagger
- JWT Authentication
- Docker

## Run Project

1. Open solution in Visual Studio
2. Update connection string
3. Run migration
4. Run project

## Swagger URL

https://localhost:7057/swagger

## Login API

POST:
https://localhost:7057/api/Auth/login

{
  "username": "admin",
  "password": "admin123"
}