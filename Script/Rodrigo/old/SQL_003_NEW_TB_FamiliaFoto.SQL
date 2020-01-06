IF OBJECT_ID ('dbo.FamiliaFoto') IS NOT NULL
	DROP TABLE dbo.FamiliaFoto
GO

CREATE TABLE dbo.FamiliaFoto
	(
	Id         INT IDENTITY NOT NULL,
	FamiliaId  INT CONSTRAINT DF_FamiliaFoto_FamiliaId DEFAULT ((0)) NOT NULL,
	Foto       VARBINARY (max) NOT NULL,
	FotoNombre NVARCHAR (50) CONSTRAINT DF_FamiliaFoto_FotoNombre DEFAULT ('') NOT NULL
	)
GO