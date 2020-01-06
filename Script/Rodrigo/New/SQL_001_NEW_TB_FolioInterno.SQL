IF OBJECT_ID ('dbo.FolioInterno') IS NOT NULL
	DROP TABLE dbo.FolioInterno
GO

CREATE TABLE dbo.FolioInterno
	(
	CabId    INT CONSTRAINT DF_FolioInterno_CabId DEFAULT ((0)) NOT NULL,
	NroFolio INT CONSTRAINT DF_FolioInterno_NroFolio DEFAULT ((0)) NOT NULL,
	Fecha    DATETIME CONSTRAINT DF_FolioInterno_Fecha DEFAULT (getdate()) NOT NULL
	)
GO