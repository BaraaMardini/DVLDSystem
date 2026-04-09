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
2. Locate the connection string:

```xml
	<connectionStrings>
		<add name="DefaultConnection"
			 connectionString="Server=.;Database=DVLD;Integrated Security=True;" />
	</connectionStrings>


```

### 🚀 Startup Project

Before running the application:

1. In Solution Explorer, right-click on the project `LoginAccount`
2. Select **Set as Startup Project**

> ⚠️ The application may not run correctly if another project is set as startup.
>
> ### 🗄️ Restore Database

If the DVLD database is not present on your machine:

1. Open **SQL Server Management Studio (SSMS)**.  
2. In the **Databases** node, select **Restore Database**.  
3. Choose the backup file `DVLD.bak` provided in the project.  
4. Ensure the restored database name matches the **connection string** in `App.config`.  
   Example:
   ```xml
   <connectionStrings>
       <add name="DefaultConnection"
            connectionString="Server=YOUR_SERVER_NAME;Database=DVLD;Integrated Security=True;"
           
   </connectionStrings>

### 💡 Notes

- Make sure SQL Server is running  
- Ensure the **DVLD database** is restored before running  
- Verify all projects load without errors  
- Each user may have different credentials; update `App.config` connection string accordingly
ذ
