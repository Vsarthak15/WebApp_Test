CREATE TABLE [dbo].[BlogData]
(
	[Id] INT NOT NULL PRIMARY KEY identity, 
    [num] INT NOT NULL, 
    [heading] VARCHAR(50) NOT NULL, 
    [body] VARCHAR(5000) NOT NULL
)
