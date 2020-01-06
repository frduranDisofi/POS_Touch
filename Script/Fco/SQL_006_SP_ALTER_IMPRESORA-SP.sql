USE [delivery]
GO
/****** Object:  StoredProcedure [dbo].[FamiliaProducto_Grabar]    Script Date: 14-11-2019 1:17:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER proc [dbo].[FamiliaProducto_Grabar]
@Familia nvarchar(50),
@Impresora varchar (50)
as
begin
insert into FamiliaProducto 
(Familia,Impresora)
values
(@Familia,@Impresora)

declare @Id int
select @Id=0

select @Id=max(CodigoFamilia) from FamiliaProducto

select @Id
end


USE [delivery]
GO
/****** Object:  StoredProcedure [dbo].[FamiliaProducto_Modificar]    Script Date: 14-11-2019 1:18:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER procedure [dbo].[FamiliaProducto_Modificar]
@CodigoFamilia int,
@FamiliaProducto nvarchar(50),
@Impresora varchar (50)
as
begin
update FamiliaProducto
set Familia = @FamiliaProducto,
Impresora = @Impresora
where CodigoFamilia=@CodigoFamilia

delete FamiliaFoto where FamiliaId=@CodigoFamilia
select 'OK'
end

USE [delivery]
GO
/****** Object:  StoredProcedure [dbo].[Impresoras_Grabar]    Script Date: 14-11-2019 2:14:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER procedure [dbo].[Impresoras_Grabar]
@primera nvarchar(50),
@Id int
as
begin
if @Id =0
	insert into Impresoras
	(ImpresoraUno,ImpresoraDos,ImpresoraTres)
	values
	(@primera,'','')
	
else
update Impresoras Set ImpresoraUno=@primera
where Id=@Id

select 'OK'
END


===========================

create procedure Rpt_TicketFamilia
@idventa int
as
begin
SELECT       detalle.id_doc_cab, detalle.descripcion, detalle.precio, detalle.total, detalle.cantidad, FamiliaProducto.Impresora
FROM            FamiliaProducto INNER JOIN
                         productos ON FamiliaProducto.CodigoFamilia = productos.CodigoFamilia RIGHT OUTER JOIN
                         detalle ON productos.id_producto = detalle.codigo
where detalle.id_doc_cab=@idventa
order by FamiliaProducto.Impresora
end