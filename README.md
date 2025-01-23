# Diary-App-ASP.NET-Core
A simple web-based diary application built with ASP.NET Core 9

This application allows users to create, edit, and delete diary entries. It's designed with a user-friendly interface to manage personal journal entries with basic CRUD (Create, Read, Update, Delete) functionality.

### `Features`
Create New Entries: Users can easily add new diary entries with a title and content.
<img src="gitimg\create.png" />

<br>
View Entries: All diary entries are displayed in a table with options to edit or delete each entry.
<img src="gitimg\index.png" />
<br>
Edit Entries: Users can edit existing entries and update their details.
<img src="gitimg\edit.png" />
<br>
Delete Entries: Users can remove entries from the diary.
<img src="gitimg\delete.png" />
<br>
Validation: This app includes both client-side and server-side validation.

### `Technology Stack`
Backend: ASP.NET Core 9
Database: SQL Server (via Entity Framework Core)
Frontend: HTML, Bootstrap for UI

### `Setup & Installation`
Clone this repository to your local machine.
Install required dependencies using the .NET SDK.
Update the appsettings.json to configure your database connection string.
Run the application using dotnet run.
### `Usage`
Once the app is running, you can visit the homepage to view and manage your diary entries.
Click "Create New Entry" to add a new diary entry.
Use the edit and delete buttons to modify or remove entries.