# 📚 Book Manager Full Stack Application

A full-stack Book Management System built using **ASP.NET Core Web API** and **Angular**.

This project demonstrates modern full-stack development practices including:

* RESTful API design
* Clean backend architecture
* Angular standalone frontend
* CRUD operations
* Professional project structure

---

# 🚀 Features

✅ Create a book
✅ View all books
✅ Update book details
✅ Delete books
✅ Duplicate validation handling
✅ Clean error responses
✅ Responsive UI

---

# 🧱 Tech Stack

## Backend — book-manager-backend

* ASP.NET Core Web API (.NET 8)
* Entity Framework Core
* SQL Server
* REST API
* Dependency Injection

## Frontend — book-manager-frontend

* Angular
* TypeScript
* HTML / CSS
* Angular HTTP Client
* Standalone Components

---

# 📂 Project Structure

```
BookManagerApp
│
├── book-manager-backend     → ASP.NET Core Web API
│
└── book-manager-frontend    → Angular Application
```

---

# ⚙️ How to Run the Project

## 1️⃣ Clone Repository

```
git clone https://github.com/YOUR_USERNAME/BookManagerApp.git
cd BookManagerApp
```

---

# ▶️ Run Backend

Navigate to backend folder:

```
cd book-manager-backend
```

Restore dependencies:

```
dotnet restore
```

Run the API:

```
dotnet run
```

Backend will start at:

```
https://localhost:5001
```

Swagger UI:

```
https://localhost:5001/swagger
```

---

# ▶️ Run Frontend

Open a new terminal and navigate:

```
cd book-manager-frontend
```

Install dependencies:

```
npm install
```

Run Angular:

```
ng serve
```

Frontend runs at:

```
http://localhost:4200
```

---

# 🔗 API Endpoints

| Method | Endpoint        | Description    |
| ------ | --------------- | -------------- |
| GET    | /api/books      | Get all books  |
| GET    | /api/books/{id} | Get book by id |
| POST   | /api/books      | Create book    |
| PUT    | /api/books/{id} | Update book    |
| DELETE | /api/books/{id} | Delete book    |

---

# ✅ Validation & Error Handling

The API handles:

* Duplicate book prevention
* Validation errors
* Graceful error responses
* Proper HTTP status codes

Example error response:

```
{
  "message": "Book with this title already exists"
}
```

---

---

# 🧠 Architecture Decisions

Backend follows:

* Controller → Service → Data Access pattern
* Dependency Injection
* Entity Framework ORM

Frontend follows:

* Angular Standalone Components
* Service-based API communication
* Reactive HTTP handling

# 👨‍💻 Author

**Nipun Mihimal**
Software Engineer (.NET)

---

# 📬 Contact

Feel free to reach out for any clarification regarding this project.

---
