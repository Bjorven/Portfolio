CREATE TABLE [dbo].[Employees]
(
	[employeeID] NVARCHAR(50) NOT NULL PRIMARY KEY, 
    [name] NCHAR(10) NULL, 
    [surname] NCHAR(10) NULL, 
    [password] NVARCHAR(50) NULL, 
    [role] NCHAR(10) NULL
)
