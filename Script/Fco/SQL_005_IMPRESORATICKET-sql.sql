CREATE PROCEDURE GetImpresora
AS
BEGIN
DECLARE @Impresora nvarchar(100)
SELECT @Impresora=i.ImpresoraUno FROM dbo.Impresoras i

SELECT @Impresora
END