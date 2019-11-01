CREATE TABLE [dbo].[Students]
(
	[Id] INT NOT NULL PRIMARY KEY,
	[Surname] CHAR(15) ,
	[Name] CHAR(15),
	[Patronumic] CHAR(15),
	[YearOfBirth]INT,
	[Reting] INT,
	[Faculty] CHAR(15),
	[University] CHAR(15)
)