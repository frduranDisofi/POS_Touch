ALTER PROCEDURE [dbo].[CerrarCaja]
@IdUsuario int 
AS
BEGIN
UPDATE dbo.Caja
	SET
    dbo.Caja.Accion = 'Cerrada'
	where dbo.Caja.Id_Usuario = @IdUsuario

	SELECT 'OK'

	END