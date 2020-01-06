create procedure Promocion_Grabar
@Nombre nvarchar(50),
@Precio int
as
begin
insert into Oferta
(CodigoOferta,NombreOferta,PrecioOferta)
values
('',@Nombre,@Precio)

DECLARE @IdOFerta int
select @IdOFerta=MAX(iDoFERTA) from Oferta
select @IdOFerta
end