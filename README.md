# 🚗 Driving License Management System (DVLD)

## 📌 Overview

DVLD is a full-featured desktop application built using **.NET Framework** and **SQL Server** to manage driving license operations.  
The system simulates real-world workflows including license issuance, test scheduling, retakes, and license detention management.

---

## 🏗️ Architecture

The project follows a **3-Tier Architecture**:

- **Data Access Layer (DAL)**  
  Handles database communication using ADO.NET and SQL queries.

- **Business Layer (BLL)**  
  Contains business logic, validations, and rules.

- **Presentation Layer (WinForms)**  
  Provides a user-friendly desktop interface.

---

## 🗄️ Database Design

- Fully relational database using **SQL Server**
- Strong use of **Foreign Keys** to maintain data integrity

### Key Entities:
- People  
- Users  
- Drivers  
- Licenses  
- Applications  
- TestAppointments  
- Tests  
- DetainedLicenses  

---

## ⚙️ Key Features

### 👤 User & People Management
- Add / Update users  
- Link users to people  
- Authentication system  

### 🚘 License Management
- Issue new driving licenses  
- Renew licenses  
- Replace damaged/lost licenses  

### 📝 Applications System
- Local driving license applications  
- International license applications  
- Application status tracking  

### 🧪 Test Management
- Schedule tests (Vision, Written, Driving)  
- Handle test retakes  
- Track passed/failed tests  

### ⛔ Detained Licenses
- Detain licenses  
- Release detained licenses  
- Track detention history  

---

## 🔍 Technical Highlights

- Built using **ADO.NET (SqlConnection, SqlCommand, SqlDataReader)**
- Complex SQL queries with joins and aggregations  
- Business validation logic  
- Dynamic UI updates using WinForms  
- Multi-module system with separation of concerns  

---

## 🚀 Example Functionalities

- Prevent duplicate license applications  
- Automatically calculate **retake fees**  
- Check if a person already has a driver record  
- Track number of attempts per test  
- Manage application lifecycle  

---

## 🛠️ Technologies Used

- .NET Framework (WinForms)  
- SQL Server  
- ADO.NET  
- C#  

---

## ⚠️ Important Setup Instructions

### ▶️ How to Open the Project

To run the project correctly:

1. Open Visual Studio  
2. Click on **Open a Project or Solution**  
3. Navigate to the project folder  
4. Open:

> ⚠️ Do NOT use "Open Folder" as it may cause errors or missing references.

---

### 🗄️ Database Configuration

Each user may have a different SQL Server setup.

1. Open `App.config`  
2. Update the connection string:

connectionString="Server=YOUR_SERVER_NAME;Database=DVLD;Integrated Security=True;"
```xml
connectionString="Server=.;Database=DVLD;Integrated Security=True;"
connectionString="Server=YOUR_SERVER_NAME;Database=DVLD;Integrated Security=True;"
🚀 Startup Project

Before running the application:

Right-click on the project in Solution Explorer
Select Set as Startup Project
Choose:
LoginAccount
⚠️ The application will not run correctly if another project is selected.
