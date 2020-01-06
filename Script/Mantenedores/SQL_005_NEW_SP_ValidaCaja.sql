USE [delivery]
GO

/****** Object:  StoredProcedure [dbo].[ValidaCaja]    Script Date: 17-10-2019 0:54:25 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[ValidaCaja]
@IdUsuario int
AS
DECLARE @Validador int
SET @Validador = (SELECT count(*) FROM caja WHERE dbo.caja.Id_Usuario = @IdUsuario	AND dbo.caja.Accion	= 'Apertura')
IF(@Validador > 0)
BEGIN	
SELECT 'OK'
END
ELSE
SELECT 'NO'
GO