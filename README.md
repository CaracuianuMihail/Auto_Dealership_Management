# 🚗 Auto Dealership Management
**Auto Dealership Management** is a desktop application developed in **C# (.NET)** with a graphical interface made in **Windows Forms (WinForms)**. It allows for the complete management of an auto dealer's activities, including the administration of cars, customers, orders and commercial documents (contracts, invoices, offers).

## 🎯 Objectives
- Efficient management of cars and customers
- Generating commercial documents in standard or premium format
- Applying discounts and filtering data
- Exporting data in CSV format
- Lazy-loading for car images
- Friendly and intuitive graphical interface

## ⚙️ Technologies used
- 🧱 Language: C# (.NET Framework)
- 🪟 Interface: WinForms
- 🗄️ Database: SQL Server LocalDB
- 🧰 Libraries: `System.IO`, `System.Drawing`, `System.Linq`, `System.Windows.Forms`

## 🧠 Principles and Architecture
The project is built according to modern **software engineering** principles:
- ✅ Compliance with **SOLID** principles:
- Single Responsibility
- Open/Closed
- Liskov Substitution
- Interface Segregation
- Dependency Inversion

- 📐 Layered Architecture:
- Presentation (UI)
- Business Logic
- Data Access

## 🔁 Implemented Design Patterns

### 🔨 Creational Patterns
- **Singleton** – `CustomerReportManager`
- **Factory Method** – `TestDriveFactory`
- **Abstract Factory** – `DocumentFactory` (contracts/invoices/offers)
- **Builder + Prototype** – `CustomCarBuilder` and `CustomCar` (for car configuration)

### 🧱 Structural Patterns
- **Adapter** – `CarCsvAdapter` for CSV export
- **Proxy** – `CarImageProxy` for lazy loading of images
- **Flyweight** – for memory optimization between cars with common data
- **Decorator** – for adding features to cars (warranty, audio system)

### 🧩 Behavioral Patterns
- **Strategy** – `IDiscountStrategy` for various types of discounts
- **Command** – managing orders as independent objects (`PlaceOrderCommand`)
- **State** – order statuses (Pending, Approved, Delivered, Canceled)
- **Iterator** – filtered traversal of car collections

## 🖥️ How to run the application
1. Open the solution in **Visual Studio**
2. Check if the SQL LocalDB database is available on the system
3. Run the main project (WinForms)
4. Make sure that the images and resource files are in the correct locations (if applicable)
5. Interact with the UI to add/edit cars, customers, orders, and documents

## 📂 Project structure (example)
AutoDealershipManagement/
- ├── Forms/ # Graphical Interface (WinForms)
- ├── Business/ # Business Logic
- ├── Data/ # Data Access (Repos, Models)
- ├── Models/ # Entities and Interfaces
- ├── Patterns/ # Implementations for Design Patterns
- ├── Resources/ # Images, CSV files, etc.
- ├── Program.cs # Entry Point
- └── AutoDealershipManagement.sln

## 📌 Contributions
This project was made as a year project within the Technical University of Moldova, discipline *Software Design Techniques and Mechanisms*.
**Author:** Caracuianu Mihail
**Coordinator:** asis. univ. Cebotari Daria

🛠️ If you like the project, don't forget to give it a ⭐ and contribute with ideas for improvement!
