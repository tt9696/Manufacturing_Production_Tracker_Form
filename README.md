# 🏭 Manufacturing Production Tracker

A desktop application developed using **C# WinForms** and **SQL Server** to help track manufacturing production records. The system provides CRUD operations, real-time KPI dashboards, production analytics, instant search, and Excel export functionality.

---



## 📌 Overview

This project was developed as a self-learning project to strengthen my skills in:

* C# WinForms application development
* SQL Server database integration
* ADO.NET
* Data visualization using LiveCharts2
* Responsive desktop UI design
* Excel report generation using EPPlus

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

## 🖥️ Application Screenshots

### Dashboard

![Dashboard](Dashboard.png)

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
4. Update the SQL Server connection string in `DatabaseHelper.cs`.
5. Create the `Production` table in SQL Server.
6. Run the application.

---

## 📁 Project Structure

```text
Manufacturing_Production_Tracker_Form
├─ ManufacturingTracker
    │
    ├── Database
        └── DatabaseSetup.sql
    ├── DatabaseHelper.cs
    ├── Form1.cs
    ├── Form1.Designer.cs
    ├── Program.cs
├── Dashboard.png
├── README.md
└── ManufacturingTracker.sln
```

---

## 🔮 Future Improvements

* Date range filtering
* Monthly production reports
* User authentication
* PDF report export
* Production trend analysis
---

## 👨‍💻 Author

Developed as a self-learning project to practice desktop application development, database integration, dashboard visualization, and reporting using C# and SQL Server.
