create procedure GetProductoFamilia
@IdFamilia int
as
begin

select id_producto id, ltrim(rtrim(descripcion_producto)) nombre 
from productos where CodigoFamilia=@IdFamilia order by descripcion_producto

end
