# ATM Machine System

A comprehensive Desktop ATM simulation built using C# (.NET 8.0) and Windows Forms (WinForms), backed by a Microsoft SQL Server database.

## 🚀 Features

- **User Authentication:** Secure login using an Account Number and PIN.
- **Account Management:**
  - Create a new account with personal details (Name, Address, Phone, Occupation, Date of Birth).
  - Admin login and user registration capabilities.
- **Core Banking Operations:**
  - **Check Balance:** View your current account balance.
  - **Deposit:** Add funds to your account securely.
  - **Withdraw:** Withdraw funds from your account.
  - **Fast Cash:** Quick withdrawal options for predefined amounts.
  - **Change PIN:** Update the account PIN.
  - **Mini Statement:** View recent transaction history.

## 🛠️ Technology Stack

- **Language:** C# 
- **Framework:** .NET 8.0 (Windows Forms)
- **Database:** Microsoft SQL Server (utilizing `Microsoft.Data.SqlClient`)
- **IDE:** Visual Studio

## ⚙️ Setup & Installation

1. **Clone the repository:**
   ```bash
   git clone <repository-url>
   ```
2. **Open the Project:**
   Open the solution file (`Project-c#.sln`) in Visual Studio.
3. **Database Configuration:**
   - Ensure you have a local instance of Microsoft SQL Server running (e.g., `SQLEXPRESS`).
   - Create a new database named `ATMDB`.
   - Run the following SQL commands to create the necessary tables:
     
     ```sql
     CREATE DATABASE ATMDB;
     USE ATMDB;

     -- Table for Users
     CREATE TABLE AccountTb1 (
         AccNum VARCHAR(50) PRIMARY KEY,
         Name VARCHAR(100),
         Address VARCHAR(255),
         Pin INT,
         Phone VARCHAR(20),
         Occupation VARCHAR(50),
         DOB DATE,
         Balance INT
     );

     -- Table for Administrators
     CREATE TABLE AdminTb (
         AdNum VARCHAR(50) PRIMARY KEY,
         AdName VARCHAR(100),
         Address VARCHAR(255),
         Pin INT,
         Phone VARCHAR(20),
         Occupation VARCHAR(50),
         DOB DATE
     );

     -- Table for Transactions
     CREATE TABLE TransactionTb1 (
         TId INT IDENTITY(1,1) PRIMARY KEY,
         AccNum VARCHAR(50),
         Type VARCHAR(50),
         Amount INT,
         TDate VARCHAR(50)
     );
     ```
   - *Note:* The default connection string in the codebase points to `Data Source=MAHiTO\SQLEXPRESS`. If your local server has a different name, you must update the `connectionString` variable across the form files (e.g., `Login.cs`, `Account.cs`, `Withdraw.cs`, etc.).
4. **Build and Run:**
   - Restore any required NuGet packages.
   - Build the solution and press `F5` or click **Start** to run the application.

## 📁 Project Structure

- `Program.cs`: The main entry point of the application.
- `Login.cs`: Handles user authentication.
- `Home.cs`: The main dashboard presenting ATM options to the user.
- `Account.cs`: Form for creating a new bank account.
- `Deposit.cs`, `Withdraw.cs`, `Balance.cs`, `FastCash.cs`, `ChangePin.cs`: Forms handling specific core banking transactions.
- `MiniStatement.cs`: Displays the user's transaction summary.
- `AdminReg.cs` / `ALogin.cs`: Handle administrative logins and functionalities.
- `Search.cs` / `UserInfo.cs`: Interfaces to search and display user information.
