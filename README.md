# .NetCore Api Demo

### Objective
Your app structure should encourage [The SOLID Principals of software development](http://www.c-sharpcorner.com/UploadFile/damubetha/solid-principles-in-C-Sharp/) and be easy to unit test. This includes the ability to mock dependencies and persistence layers.

### Layers

#### coredemo.api
--  Includes controllers and app config.This is the main Startup project
#### coredemo.contracts
--  Interfaces go here. 
#### coredemo.dal
--  Data Access Layer. This Layer is the main DB abstraction. Holds your repositories which define how each model will interact with the database.
#### coredemo.model
--  Defines the app model. Hold your POCOS and Data Validations.
#### coredemo.services
--  Business logic is placed here. 

### Tech Stack

- Dapper 
- Swagger
- Dependency Injection built into ASP.NetCore 

### Set Up Script for Demo DB

```sql
CREATE TABLE [dbo].[Products](
    [ProductID] [int] IDENTITY(1,1) NOT NULL,
    [Name] [nvarchar](max) NULL,
    [Quantity] [int] NULL,
    [Price] [float] NULL,
 CONSTRAINT [PK_Products] PRIMARY KEY CLUSTERED 
(
    [ProductID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
 
GO
```