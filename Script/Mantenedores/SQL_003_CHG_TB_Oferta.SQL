ALTER TABLE dbo.Oferta
  ADD Activo int NOT NULL DEFAULT 1
GO

EXEC sp_addextendedproperty
  N'MS_Description', N'1 activo, 0 no activo',
  N'SCHEMA', N'dbo',
  N'TABLE', N'Oferta',
  N'COLUMN', N'Activo'
GO