# 📚 Online Training Center - Backend System

## 🏢 Nile Sugar Company - Technical Task

This project represents the backend system for an **Online Training Center**, developed as part of a technical assessment for **Nile Sugar Company**.  
The system provides a RESTful API to manage courses, trainers, trainees, registrations, attendance tracking, certificates, and feedback.

---

## 🛠️ Tech Stack

* **.NET Core 6.0**
* **ASP.NET Core Web API**
* **Entity Framework Core**
* **SQL Server**
* **Swagger** for API documentation
* **Dependency Injection**
* **Repository Pattern**

---

## 📂 Project Structure

```bash
OnlineTrainingCenter/
│
├── Controllers/        # API Controllers
├── Models/             # Data Models
├── Data/               # Database Context (DbContext)
├── Services/           # Business Logic Layer
├── Migrations/         # EF Core Migrations
├── Program.cs
├── appsettings.json    # Configuration File
└── README.md           # Project Documentation
```

---

## 💄 Database Design

The database consists of the following tables and relationships:

### **Core Tables**

| Table                    | Description                                              |
| ------------------------ | -------------------------------------------------------- |
| **Trainees**             | Stores trainee personal information.                     |
| **Trainers**             | Stores trainer information.                              |
| **Courses**              | Course details including name and number of lectures.    |
| **TrainerCourses**       | Many-to-Many relation between trainers and courses.      |
| **CoursePriceHistories** | Historical pricing records for courses.                  |
| **CourseRegistrations**  | Registration records linking trainees to courses.        |
| **Certificates**         | Certificates issued to trainees after course completion. |
| **Attendances**          | Attendance records for registered trainees.              |
| **Feedbacks**            | Feedback provided by trainees after course completion.   |

---

## 🚀 Getting Started

### Prerequisites

* [.NET 6 SDK](https://dotnet.microsoft.com/download)
* SQL Server
* (Optional) [EF Core CLI](https://learn.microsoft.com/en-us/ef/core/cli/dotnet)

### Setup Steps

1. Clone the repository:

   ```bash
   git clone [Repository-Link]
   cd OnlineTrainingCenter
   ```

2. Configure the connection string inside `appsettings.json`.

3. Apply database migrations:

   ```bash
   dotnet ef database update
   ```

4. Run the application:

   ```bash
   dotnet run
   ```

5. Access Swagger documentation at:

   ```
   https://localhost:5001/swagger
   ```

---

## 📟 API Documentation

Swagger UI is enabled and provides interactive API testing:

```
https://localhost:5001/swagger
```

---

## ✨ Features

✅ Trainer Management  
✅ Course Management  
✅ Trainee Registration  
✅ Attendance Tracking  
✅ Certificates Issuance  
✅ Feedback Collection  
✅ Historical Pricing for Courses  
✅ API Documentation with Swagger

---

## 🏢 About Nile Sugar

This project is developed as part of the technical assessment for **Nile Sugar Company**, focusing on backend system architecture, clean code practices, and API design.

---

## 👌 Author

* **Toqa Tarek**
* Email: [Toqa.tw2000@gmail.com]
* LinkedIn: [https://www.linkedin.com/in/tokatarek/]

---

## 📌 Notes

* This is a backend-only project.
* Frontend or client application is not included.
* Database diagram and relationships are available in the project documentation.

---



## ✅ Final Notes

This system demonstrates a clean, modular approach to building scalable backend APIs using modern ASP.NET Core best practices.