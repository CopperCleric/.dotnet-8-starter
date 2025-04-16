# .NET 8 Starter 

A minimal stater code, built with **.NET 8**, following **Clean Architecture** principles. This project demonstrates backend development practices including **EF Core with code-first**, **JWT authentication**, **exception handling**, **pagination**, and **API documentation** via Swagger.


## 🚀 Tech Stack

- **.NET 8**
- **EF Core 8**
- **Supabase PostgreSQL**
- **Swagger**


## 🧱 Project Architecture

### **Controller -> Service -> Repository -> Context**


## ✅ Features Implemented

- ✅ Register new user with token generation
- ✅ Get all users with pagination
- ✅ Get user by ID
- ✅ Update user
- ✅ Delete user
- ✅ Clean Architecture with separation of concerns
- ✅ JWT Authentication
- ✅ Swagger API Documentation
- ✅ Global Exception Middleware
- ✅ Pagination 
- ✅ Centralized `ApiResponse<T>` structure


## 🧪 How to Run

1. **Clone the repo**

2. **Configure your `appsettings.json`**  
   - Set your PostgreSQL connection string  
   - Add JWT configuration (Secret, Issuer, Audience)

3. **Seed Database**
  ```
  dotnet ef migrations add SeedUsers --project Infrastructure --startup-project WebApi
  
  dotnet ef database update --project Infrastructure --startup-project WebApi
  ```
4. **Launch the app**

  ```
    dotnet run --project WebApi
  ```

5. **Access SwaggerUI**

  ```
    https://localhost:<port>/swagger
  ```


## 🧩 EF Core - Code-First Approach

  - Database schema is auto-generated from entity using EF Core.
  - You may optionally add **seed data** within the `OnModelCreating` method in `ApplicationDbContext` to populate initial records during migrations.

### 🔨 Migration Commands

```
# Create a migration
dotnet ef migrations add <migration_name> --project Infrastructure --startup-project WebApi

# Apply the migration to database
dotnet ef database update --project Infrastructure --startup-project WebApi

```
