#  Product API (ASP.NET Core Minimal API)
A simple ASP.NET Core Minimal API that performs basic CRUD operations on a Product resource.

![.NET](https://img.shields.io/badge/.NET-8.0-blue)
![C#](https://img.shields.io/badge/C%23-Programming-purple)
![ASP.NET Core](https://img.shields.io/badge/ASP.NET-Core-green)
![Status](https://img.shields.io/badge/Status-Completed-success)


---

##  Features

* Create a product (POST)
* Get all products (GET)
* Get product by ID (GET)
* Delete a product (DELETE)
* Swagger UI for easy testing

---

##  Project Structure

```
ProductApi/
│
├── Product.cs              # Product model
├── ProductEndpoint.cs      # Business logic
├── Program.cs              # Routing & app setup
└── README.md
```

---

##  Technologies

* ASP.NET Core (.NET)
* Minimal API
* Swagger (OpenAPI)
* C#

---

##  How to Run

1. Clone the repository:

```
git clone https://github.com/your-username/ProductApi.git
cd ProductApi
```

2. Run the project:

```
dotnet run
```

3. Open Swagger:

```
https://localhost:xxxx/swagger
```

(Replace `xxxx` with your port number)

---

##  API Endpoints

### Create Product

POST `/products`

```
{
  "name": "Laptop",
  "description": "Gaming laptop",
  "price": 1500
}
```

---

###  Get All Products

GET `/products`

---

###  Get Product by ID

GET `/products/{id}`

Example:

```
GET /products/1
```

---

###  Delete Product

DELETE `/products/{id}`

Example:

```
DELETE /products/1
```

---

##  Example Response

```
{
  "productId": 1,
  "name": "Laptop",
  "description": "Gaming laptop",
  "price": 1500
}
```

---

##  Notes

* Data is stored in memory (no database)
* Data will reset when the app restarts
* This project is for learning/demo purposes

---

##  How It Works

* Program.cs → Defines API routes
* ProductEndpoint.cs → Contains logic
* Product.cs → Defines data model
* Data stored in a List<Product>
