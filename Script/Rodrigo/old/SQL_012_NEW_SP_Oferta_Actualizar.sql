CREATE PROCEDURE Oferta_Actualizar
@Id int,
@NombreOferta nvarchar(30),
@PrecioOferta int,
@Activo int
as
begin

UPDATE Oferta
SET NombreOferta = @NombreOferta
   ,PrecioOferta = @PrecioOferta
   ,Activo = @Activo
WHERE idOferta = @Id

select 'OK'
END


