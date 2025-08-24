# MvcCourses

Small ASP.NET Core MVC appication.

## How to Run the App
1. Prereqs: Visual Studio 2022 (ASP.NET workload) + .NET 8 SDK.
2. Open the solution in Visual Studio.
3. Press **Ctrl+F5** or click on green triangle.
4. Navigate to `/Course` at the end of the http: to view and add courses.

## What It Demonstrates
- **Strongly typed views**: `IEnumerable<Course>` (Index) and `Course` (Create)
- **Tag Helpers**:
  - Navigation links (`asp-controller`, `asp-action`)
  - Form + Label/Input/Select + Validation Tag Helpers in Create
- **Logging**: `ILogger<CourseController>` writes informational and warning entries
- **No DB**: In-memory list to focus on MVC + Tag Helpers

## Screenshots have been included in file folder



