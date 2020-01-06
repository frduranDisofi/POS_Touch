ALTER PROCEDURE [dbo].[GrabaFamilia]
@Familia varchar (100)
AS
BEGIN
	INSERT INTO dbo.FamiliaProducto
	(
	    Familia
	)
	VALUES
	(
	    @Familia-- Familia - nvarchar
	)

	SELECT	'OK'
END