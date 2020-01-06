CREATE PROCEDURE GuardarRetiro
@IdUsuario int,
@Monto int,
@Glosa varchar (max)
AS
BEGIN
	INSERT INTO dbo.RetiroCaja
	(
	    IdUsuario,
	    Monto,
	    Glosa
	)
	VALUES
	(
	    @IdUsuario, -- IdUsuario - int
	    @Monto, -- Monto - int
	    @Glosa-- Glosa - varchar
	)
	SELECT 'OK'
END