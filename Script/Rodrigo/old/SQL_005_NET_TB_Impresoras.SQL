IF OBJECT_ID ('dbo.Impresoras') IS NOT NULL
	DROP TABLE dbo.Impresoras
GO

CREATE TABLE dbo.Impresoras
	(
	Id            INT IDENTITY NOT NULL,
	ImpresoraUno  NVARCHAR (50) NOT NULL,
	ImpresoraDos  NVARCHAR (50) NOT NULL,
	ImpresoraTres NVARCHAR (50) NOT NULL,
	CONSTRAINT PK_Impresoras PRIMARY KEY (Id)
	)
GO