create procedure Impresoras_Grabar
@primera nvarchar(50),
@segunda nvarchar(50),
@tercera nvarchar(50),
@Id int
as
begin
if @Id =0
	insert into Impresoras
	(ImpresoraUno,ImpresoraDos,ImpresoraTres)
	values
	(@primera,@segunda,@tercera)
	
else
update Impresoras Set ImpresoraUno=@primera,ImpresoraDos=@segunda,
       ImpresoraTres=@tercera
where Id=@Id

select 'OK'
END