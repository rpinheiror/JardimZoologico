# Zoo Management System

A **C# object-oriented coursework project** that models zoo administration through separate domain, management, and exception-related projects. Developed for the Object-Oriented Programming course.

[Project report](RelatorioPOO_RodrigoPinheiro_31502.docx) · [Management layer](GestaoZoologico/) · [Console entry point](MAIN/Program.cs)

## Overview

The code is organized around animals, tickets, clients, food, employees, and enclosures. Its educational focus is separating responsibilities across projects and expressing domain operations through C# classes.

For example, the animal management service provides methods to add and remove animals from an in-memory list. Addition rejects null animals and duplicate identifiers; removal searches by identifier and reports whether an animal was found.

## Technologies and concepts

- **C#** and .NET project files
- **.NET 10** target for the console project
- Object-oriented design and separation of responsibilities
- Generic collections and LINQ in the management layer

## Repository structure

| Path | Role |
| --- | --- |
| `BO/` | Business object project used by the management layer |
| `GestaoZoologico/` | Management classes for animals, tickets, clients, food, employees, and enclosures |
| `Exceptions/` | Exception-related project |
| `MAIN/` | Console project and application entry point |
| `JardimZoologico/` | Additional project layout, including Dados and Regras directories |
| `JardimZoologico.slnx` | Root solution file; see the current setup notes below |
| `RelatorioPOO_RodrigoPinheiro_31502.docx` | Original coursework report in Portuguese |

## Current status

The repository contains domain and management code, but the console entry point currently only prints **“Gestão de Jardim Zoológico”**. It does not yet expose an interactive management menu.

There are also project path inconsistencies in the committed setup:

- The root `JardimZoologico.slnx` refers to `introducao/JardimZoologico.csproj`, while no `introducao/` directory is present at the repository root.
- `MAIN/MAIN.csproj` refers to `../Dados/Dados.csproj`, while no root-level `Dados/` directory is present. A `Dados/` directory exists inside `JardimZoologico/`.

These references need to be reconciled with the actual project layout before the application can be built reliably from a fresh clone. Successful compilation has not been verified as part of this documentation update.

## Getting started

### Requirements

- Git
- .NET 10 SDK for the `MAIN` console project
- A C# editor or compatible IDE

Clone the repository:

```sh
git clone https://github.com/rpinheiror/JardimZoologico.git
cd JardimZoologico
```

Review the project references described above. Once they point to the intended projects, build and launch the console project with:

```sh
dotnet build MAIN/MAIN.csproj
dotnet run --project MAIN/MAIN.csproj
```

The console entry point currently displays the startup message only. The management operations are implemented separately in `GestaoZoologico/`.

## Suggested next steps

- Align solution and project references with the repository layout.
- Add a console interface that exercises the existing management services.
- Add tests for null input, duplicate animal IDs, and removal of nonexistent animals.
- Document examples of each implemented management operation.

## Author

**Rodrigo Henrique Silva Pinheiro** — student no. 31502.

The original report, source identifiers, and console message are in Portuguese.
