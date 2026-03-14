# F# Hello World Project

A simple F# project demonstrating a basic "Hello, World!" program with Paket package manager and unit tests.

## Getting Started

### Prerequisites
- .NET 6.0 SDK or later
- Paket

### Building

```bash
paket install
dotnet build
```

### Running

```bash
dotnet run --project src/HelloWorld/HelloWorld.fsproj
```

### Running Tests

```bash
dotnet test
```

## Project Structure

- `src/HelloWorld/` - Main application code
- `tests/HelloWorld.Tests/` - Unit tests
- `paket.dependencies` - Paket dependencies file

## Test Results

All tests pass successfully! ✅