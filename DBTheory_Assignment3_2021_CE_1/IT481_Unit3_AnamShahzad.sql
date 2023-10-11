USE [Northwind]
GO
/****** Object:  User [User_CEO]    Script Date: 10/12/2023 1:31:59 AM ******/
CREATE USER [User_CEO] FOR LOGIN [User_CEO] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  User [User_HR]    Script Date: 10/12/2023 1:31:59 AM ******/
CREATE USER [User_HR] FOR LOGIN [User_HR] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  User [User_Sales]    Script Date: 10/12/2023 1:31:59 AM ******/
CREATE USER [User_Sales] FOR LOGIN [User_Sales] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  DatabaseRole [CeoRole]    Script Date: 10/12/2023 1:31:59 AM ******/
CREATE ROLE [CeoRole]
GO
/****** Object:  DatabaseRole [HrRole]    Script Date: 10/12/2023 1:31:59 AM ******/
CREATE ROLE [HrRole]
GO
/****** Object:  DatabaseRole [SalesRole]    Script Date: 10/12/2023 1:31:59 AM ******/
CREATE ROLE [SalesRole]
GO
ALTER ROLE [CeoRole] ADD MEMBER [User_CEO]
GO
ALTER ROLE [HrRole] ADD MEMBER [User_HR]
GO
ALTER ROLE [SalesRole] ADD MEMBER [User_Sales]
GO
