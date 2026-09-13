# 📚 Library Management API -- Technical Coding Exercise

## Overview

You have been provided with a small C# console application representing
a basic library management system.

The application currently contains sample data for:

-   Books
-   Borrowers
-   Borrowing records

The application uses the provided `LibraryDB` class as an **in-memory
data store**.

Your task is to convert the existing console application into an
**ASP.NET Core Web API** and implement the requirements described below.

You are free to restructure or refactor the provided code as you believe
appropriate.

------------------------------------------------------------------------

## ⏱️ Time

**60 minutes**

The goal is not necessarily to implement every possible feature, but to
produce a working, well-structured solution and demonstrate your
approach to solving the problem.

------------------------------------------------------------------------

## 🚀 Getting Started

### 1. Clone the Repository

Clone this repository to your local computer before starting the
exercise.


### 2. Open the Project

Open the project using your preferred development environment.

For example:

-   Visual Studio
-   Visual Studio Code
-   JetBrains Rider

### 3. Review the Existing Application

Before making changes, take a few minutes to review:

-   The existing models
-   `LibraryDB`
-   The sample data
-   The current console application

You may modify the existing structure and add new files, folders,
classes, interfaces, or models where you believe appropriate.

### 4. Run the Existing Application

Make sure the supplied application runs successfully before beginning
your changes.

------------------------------------------------------------------------

# Requirements

## 1. Retrieve Borrowers and Borrowed Books

Create an API endpoint that retrieves all borrowers and the books they
have borrowed.

For example:

``` http
GET /api/borrowers
```

The response should clearly show each borrower and their borrowing
information.

At minimum, the response should contain:

-   Borrower name
-   Books borrowed

You may include other relevant information if you believe it improves
the API response.

The exact response model is up to you.

------------------------------------------------------------------------

## 2. Create a Borrowing

Create an API endpoint that allows a new borrowing record to be added.

For example:

``` http
POST /api/borrowings
```

The request should allow the caller to specify:

-   The borrower
-   One or more books
-   The name of the person signing off the borrowing

The system should automatically populate:

-   Borrowing ID
-   Borrowed date

A newly created borrowing should have no returned date.

The exact request and response models are up to you.

------------------------------------------------------------------------

## 📖 Book Availability

The `Stock` property of a book represents the number of copies
**currently available for borrowing**.

For example:

``` text
The Hobbit
Stock: 4
```

This means that four copies of *The Hobbit* are currently available.

When a book is successfully borrowed, its available stock should be
reduced accordingly.

A book with:

``` text
Stock: 0
```

is currently unavailable and **must not be borrowed**.

> **Important:** If any requested book is unavailable, the borrowing
> should not be created.

------------------------------------------------------------------------

## ✅ Validation

The API should handle invalid requests appropriately.

Consider scenarios including:

-   The borrower does not exist
-   A requested book does not exist
-   A requested book is out of stock
-   No books are supplied
-   The signed-off-by person is not supplied
-   Invalid request data is supplied

The API should return appropriate HTTP responses for successful and
unsuccessful operations.

------------------------------------------------------------------------

# Technical Requirements

-   Use **ASP.NET Core Web API**
-   Continue using the supplied `LibraryDB` as the in-memory data store
-   A real database is **not required**
-   A frontend is **not required**
-   Authentication and authorization are **not required**
-   The existing sample data should remain available when the
    application starts

You may modify the existing project structure and introduce additional
classes, interfaces, models, or folders where you believe appropriate.

------------------------------------------------------------------------

## Good Luck! 🚀

Focus on producing a solution that you would be comfortable explaining
and maintaining as part of a real application.
