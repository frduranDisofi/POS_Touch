CREATE PROCEDURE ValidaMonto
@IdUsuario int,
@Monto int
AS
BEGIN
	DECLARE @Validador int 
	SET @Validador = (SELECT count(*) FROM dbo.Caja c WHERE Id_Usuario = @IdUsuario AND Accion = 'Apertura' AND Monto < @Monto)

	IF	(@Validador = 0)
	BEGIN
		SELECT	'OK'
	END
	ELSE
	BEGIN
	SELECT 'NO'
	END
END