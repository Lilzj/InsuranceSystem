# InsuranceSystem
An API develop for health insurance to help administrators with policy managements.

# Getting Started
These are the pre-requisite of the project

# Required
```
.NET 8 SDK
.EF Core 8
.SQL server
.Xunit (for running the test)
.Visual studio (Latest version)
```

# Introduction
This project was developed using the latest .NET technologies.
```
Design pattern: CQRS and Mediator pattern
Architectural design: Clean Architecture.
```

This design pattern was adopted for Modularity and Maintainability as it helps separate concerns into distinct layers. This makes the codebase more maintainable and allows for easier updates or changes to specific components without affecting the entire application

# Running
To run this application, change the connection string in the appSettings.json to your connection string using the required database stated above
execute migrations by running "update-database" in the console manager or using cli (open terminal and enter dotnet ef database update).
To update claim status, a token was implemented to authenticate the call of the update endpoint

# Things not covered
```
.Logging
.Authentication and Authorization using JWT or other provider
.Global exception middleware handler
```


# TODO:
```
.Seed data
.Complete endpoints unit testing
```





