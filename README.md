# 🏭 Manufacturing Production Tracker

![.NET](https://img.shields.io/badge/.NET-8-blue)
![C#](https://img.shields.io/badge/C%23-WinForms-purple)
![SQL Server](https://img.shields.io/badge/SQL%20Server-Database-red)
![License](https://img.shields.io/badge/License-MIT-green)


A desktop application developed using **C# WinForms** and **SQL Server** to help track manufacturing production records. The system provides CRUD operations, real-time KPI dashboards, production analytics, instant search, and Excel export functionality.

---

## 📌 Overview
---
## 🖥️ Application Screenshots

### Dashboard

![Dashboard](Dashboard.png)

---

## Configure SQL Server

Before running the application, update the connection string in `App.config`:

```xml
Server=YOUR_SERVER_NAME;
Database=ManufacturingDB;
Trusted_Connection=True;
TrustServerCertificate=True;
```

Replace `YOUR_SERVER_NAME` with your SQL Server instance name (for example, `DESKTOP-ABC123`, `.\SQLEXPRESS`, or `(localdb)\MSSQLLocalDB`).
---

## ✨ Features

* ✅ Add new production records
* ✅ Update existing records
* ✅ Delete production records
* ✅ Instant product search
* ✅ Dashboard KPI cards

  * Total Production
  * Total Defects
  * Defect Rate
  * Total Downtime
* ✅ Production vs Defects chart
* ✅ Export production data to Excel
* ✅ Responsive layout using TableLayoutPanel

---

## 🛠️ Technologies Used

* C#
* .NET 8 WinForms
* SQL Server
* ADO.NET
* LiveCharts2
* EPPlus
* Visual Studio 2022
---

## 📊 Dashboard

The dashboard displays real-time manufacturing information including:

* Total Production
* Total Defects
* Defect Rate
* Total Downtime
* Production vs Defects comparison chart

All KPI cards and charts are refreshed automatically after adding, updating, or deleting records.

---

## 🚀 How to Run

1. Clone this repository.
2. Open the solution in Visual Studio 2022.
3. Restore NuGet packages.
4. Update the SQL Server connection string in App.config.
5. Execute Database/DatabaseSetup.sql in SQL Server Management Studio.
6. Run the application.

---

## 📁 Project Structure

```text
Manufacturing_Production_Tracker_Form
│
├── ManufacturingTracker/
│   ├── Database/
│   │   └── DatabaseSetup.sql
│   ├── App.config
│   ├── DatabaseHelper.cs
│   ├── Form1.cs
│   ├── Form1.Designer.cs
│   ├── Program.cs
│   └── ...
│
├── Dashboard.png
├── README.md
└── ManufacturingTracker.sln
```

---
## 🗄️ Database Structure

### Production Table

| Column          | Data Type |
| --------------- | --------- |
| Id              | int       |
| ProductName     | nvarchar  |
| Quantity        | int       |
| Defect          | int       |
| DowntimeMinutes | int       |
| CreatedAt       | datetime  |
| UpdatedAt       | datetime  |

---
## 🏗️ System Architecture

User
   │
   ▼
WinForms UI
   │
   ▼
DatabaseHelper (ADO.NET)
   │
   ▼
SQL Server Database
---

## 🔮 Future Improvements

* Date range filtering
* Monthly production reports
* User authentication
* PDF report export
* Production trend charts by month
---

## 👨‍💻 Author

Developed by **Tay Shiek Chi** as a personal portfolio project to strengthen skills in C#, .NET, SQL Server, desktop application development, and data visualization.

## 📚 Learning Outcomes

This project helped me gain hands-on experience with:
- Designing desktop applications using WinForms
- Building CRUD operations with ADO.NET
- Integrating SQL Server databases
- Developing KPI dashboards
- Creating charts using LiveCharts2
- Exporting data to Excel with EPPlus
- Organizing C# projects using a layered structure
