Swedish
Kontaktkatalog
Ett konsolbaserat kontaktregister byggt i C# med .NET 8.
Projektet visar grunderna i lagerindelad arkitektur, repository-mönstret och enhetstester med xUnit och Moq.

Funktioner

- Lägga till nya kontakter med validering
- Förhindra dubbletter baserat på e-postadress
- Söka kontakter via namn (okänsligt för stora och små bokstäver)
- Filtrera kontakter via taggar
- Visa alla sparade kontakter
- Menybaserat konsolgränssnitt
- Enhetstester skrivna med xUnit och Moq
- Exempel på både [Fact]- och [Theory]-tester

Krav

- .NET 8.0
- Visual Studio 2022 (rekommenderas)
- Git (valfritt, om du vill klona projektet)

Köra Applikationen
Alternativ 1 – Via Visual Studio (inget terminalfönster behövs)

- Starta Visual Studio
- Välj File → Open → Project/Solution
- Öppna lösningsfilen
- ContactCatalogue.sln
- I Solution Explorer, högerklicka på projektet ContactCatalogue
- Välj Set as Startup Project
- Starta programmet med:
- F5 för att köra med felsökning
- Ctrl + F5 för att köra utan felsökning
- Ett konsolfönster öppnas automatiskt med programmets huvudmeny.

Köra Tester
- Testprojektet innehåller tester för:
- ContactService
- ContactRepository

Alternativ 1 – Köra tester i Visual Studio
- Öppna Test Explorer
- Meny: Test → Test Explorer
- Klicka på Run All Tests
- Visual Studio visar resultat med grön/röd indikator och loggar.
- Skärmbilder av lyckade tester (Fact + Theory) finns i docs-mappen.

Om Projektet

Detta projekt är skapat som en del av en .NET-kurs. Fokus ligger på:

- Att implementera ett repository + service-lager
- Användning av Dictionary<int, Contact> och HashSet<string> för effektiv datalagring
- LINQ-baserad sökning och filtrering
- Egna undantag (custom exceptions)
- Enhetstester med xUnit och Moq
- Dokumentation av hur projektet körs och testas


English
Contact Catalogue

A console-based contact management application built in C# using .NET 8.
The project demonstrates clean architecture principles, the repository pattern, and unit testing with xUnit and Moq.

Features

1. Add new contacts with validation
2. Prevent duplicate email addresses
3. Search contacts by name (case-insensitive)
4. Filter contacts by tags
5. Display all stored contacts
6. Console-driven menu interface
7. Unit tests using xUnit and Moq
8. Includes both [Fact] and [Theory] test examples

🛠 Requirements

.NET 8.0
Visual Studio 2022 (recommended)
Git (optional, if cloning the repository)
Running the Application
Option 1 — Using Visual Studio (No Terminal Required)

- Open Visual Studio
- Select File → Open → Project/Solution
- Open the solution file:
- ContactCatalogue.sln

- In the Solution Explorer, right-click the project named ContactCatalogue
- Select Set as Startup Project
- Run the program using:
- F5 — Run with Debugging
- Ctrl + F5 — Run Without Debugging
- The console window will open and display the application menu.

Running the Tests

The test project includes unit tests for:
- ContactService
- ContactRepository

- Run Tests in Visual Studio
- Open Test Explorer
- (Menu: Test → Test Explorer)
- Click Run All Tests

Visual Studio will show the results with green/red indicators.
The screenshots of successful test runs (Fact + Theory) are located in the docs folder.

About This Project

This project was developed as part of a .NET course assignment.
It focuses on:
- Designing a simple repository and service architecture
- Using Dictionary<int, Contact> and HashSet<string> for efficient storage
- Implementing LINQ for searching and filtering
- Creating and throwing custom exceptions
- Writing unit tests using xUnit and Moq
- Providing clear instructions and documentation
