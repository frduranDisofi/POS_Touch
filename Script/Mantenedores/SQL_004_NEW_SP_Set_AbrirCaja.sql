USE [delivery]
GO

/****** Object:  StoredProcedure [dbo].[Set_AbrirCaja]    Script Date: 17-10-2019 0:54:18 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[Set_AbrirCaja]
@IdUsuario int,
@Monto int,
@Glosa varchar (100)
AS
INSERT INTO Caja
(
    --Id - column value is auto-generated
    Accion,
    Id_Usuario,
    Monto,
    Fecha,
	Glosa
)
VALUES
(
    -- Id - int
    'Apertura', -- Accion - varchar
    @IdUsuario, -- Id_Usuario - int
    @Monto, -- Monto - int
    getdate(), -- Fecha - datetime
	@Glosa
)
GO


