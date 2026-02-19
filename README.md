#  DVLD - Drivers and Vehicles License Department

A comprehensive desktop application for managing driving licenses, vehicles, and related services. Built using **.NET Framework (WinForms)** and **SQL Server**.

## 🌟 Features
* **Manage People:** Add, Edit, Delete, and List people with filtering.
* **Manage Users:** System users with role-based permissions.
* **License Management:**
    * Issue Local & International Licenses.
    * Renew, Replace (Lost/Damaged) Licenses.
    * **Detain & Release Licenses:** Full workflow for handling traffic violations.
* **Tests Management:** Schedule Vision, Written, and Street tests.
* **Applications:** Manage different types of applications and application types.

## 🛠 Tech Stack
* **Language:** C#
* **Framework:** .NET Framework 4.7.2+ (WinForms)
* **Database:** MS SQL Server
* **Architecture:** N-Tier Architecture (Presentation, Business Logic, Data Access).
* **Data Access:** ADO.NET

## 🚀 How to Run

1. **Database Setup:** - The database backup file (`.bak`) or script (`.sql`) is included in the `/Database` folder.
   - Restore the database on your local **SQL Server** instance and name it `DVLD`.

2. **Configuration:**
   - Open the project in Visual Studio.
   - Navigate to the `DataAccessLayer` or `App.config` and update the **Connection String** with your Server Name.

3. **Run the App:**
   - Build the solution and press `F5` to start the application.

## 👤 Author
**Mohamed Hassanien Moahmed Ibrahim**
