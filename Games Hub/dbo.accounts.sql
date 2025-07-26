CREATE TABLE accounts
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [username] NVARCHAR(15) NOT NULL, 
    [password] NVARCHAR(15) NOT NULL, 
    [email] NVARCHAR(30) NOT NULL, 
    CONSTRAINT [FK_accounts_ToTable] FOREIGN KEY (Id) REFERENCES [scores]([userId])
)
