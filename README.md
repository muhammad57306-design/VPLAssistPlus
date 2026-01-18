# VPLAssist+ Student Manager
A desktop application for managing student records built with C# WinForms.

## Features
- **CRUD Operations**: Add and view student records (ID, Name, Course, Grade).
- **OOP Structure**: Built using a dedicated `Student` class with encapsulation.
- **Multithreading**: Saving data to a file is handled on a background thread to prevent UI freezing.
- **Data Persistence**: Records are saved locally in `students.txt`.

## How to Run
1. Open the `.sln` file in Visual Studio.
2. Press `F5` to build and run the application.
3. Enter student details and click 'Add' to see them in the grid.
4. Click 'Save' to store data permanently.

## Requirements Met
- Event-driven programming (Button clicks, Placeholder transitions).
- Error handling using try-catch blocks for numeric inputs.
