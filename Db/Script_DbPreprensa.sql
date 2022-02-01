------------------------------------------>Creacion DataBase
Create DataBase DbPreprensa
Go
Use DbPreprensa
Go

------------------------------------------>Creacion Tablas
Create Table Usuario(
Id int identity not null,
Usuario Varchar(15),
Clave Varchar(15),
Nivel smallint)
Go

Create Table Personal(
Id int identity primary key not null,
Tipo smallint,
Nombre Varchar(100),
Apellido Varchar(100),
Cargo Varchar(100))
Go

Create Table Cliente(
Id int identity primary key not null,
Tipo smallint,
Nombre Varchar(100),
Apellido Varchar(100))
Go

Create Table Articulo(
IdArticulo int identity primary key not null,
Descripcion Varchar(100),
FechaRegistro Datetime,
Tipo Varchar(100),
Estado smallint,
Codigo Varchar(10))
Go

Create Table ProducionCabecera(
NumProducion int primary key not null,
Estado smallint,
FechaRegistro Datetime,
IdElaborado int references Personal,
IdSolicitado int references Personal,
IdCliente int references Cliente)
Go

Create Table ProduccionDetalle(
NumProducion int,
IdArticulo int references Articulo,
CantPedido int,
CantProducion int,
Comentario Varchar(250),
Estado int
)

Go

Create Table DetalleActividades(
IdActividad int primary key not null identity,
NumProducion int,
IdArticulo int,
Descripcion Varchar(200),
FechaRegistro Date,
HoraInicio Varchar(20),
HoraFin Varchar(20),
CantCorreciones char(10),
CantPaginas char(10),
ComentCol Varchar(100),
ComentCor Varchar(100)
)

------------------------------>Registro de Tablas
-->Usuario
insert Into Usuario values('vmatos','Damon199312@',1)
insert Into Usuario values('pLopez','123',2)
insert Into Usuario values('mLarosa','123',2)

-->Elaborado 
insert into Personal values(1,'Victor Brian','Matos Jara','Jefe de produccion')
insert into Personal values(1,'Patricia','Lopez','Asistente de produccion')
insert into Personal values(1,'Mariana','La Rosa','Asistente de produccion')

-->Solicitado
insert into Personal values(2,'Joaquin','Montes','Jefe de ventas')
insert into Personal values(2,'Andrea','De Lima','Asistente de ventas')
insert into Personal values(2,'Ximena','Del Valle','Asistente de ventas')

-->Articulo
Insert Into Articulo values('La odisea',getdate(),'Libro',1,'19-000425')
Insert Into Articulo values('La Iliada',getdate(),'Libro',1,'19-000426')
Insert Into Articulo values('Harry Potter',getdate(),'Libro',1,'19-000427')
Insert Into Articulo values('Paco Yunque',getdate(),'Libro',1,'19-000428')
Insert Into Articulo values('Sangre de campeon',getdate(),'Libro',1,'19-000429')
Insert Into Articulo values('Otelo',getdate(),'Libro',1,'19-000430')
Insert Into Articulo values('cronicas de narnia',getdate(),'Libro',1,'19-000431')
Insert Into Articulo values('coquito',getdate(),'Libro',1,'19-000432')
Insert Into Articulo values('Carretas',getdate(),'Revista',1,'19-000433')
Insert Into Articulo values('cosas',getdate(),'Revista',1,'19-000435')
Insert Into Articulo values('Somos',getdate(),'Revista',1,'19-000436')

-->clientes
Insert Into Cliente values(1,'Diego','Buenaventura Gomez')
Insert Into Cliente values(1,'Barbara','Altamirano')
Insert Into Cliente values(1,'Silvana','Montenegro')

-->cabecera
insert into ProducionCabecera values(1,1,getdate(),1,4,3)
insert into ProducionCabecera values(2,1,getdate(),2,5,2)
insert into ProducionCabecera values(3,1,getdate(),2,5,2)
insert into ProducionCabecera values(4,1,getdate(),3,6,1)


insert into ProducionCabecera values(5,1,getdate(),2,5,2)
insert into ProducionCabecera values(6,1,getdate(),2,5,2)
insert into ProducionCabecera values(7,1,getdate(),3,6,1)

-->cliente 1
Insert Into ProduccionDetalle values(1,1,40,0,'',1)
Insert Into ProduccionDetalle values(1,3,20,0,'',1)
Insert Into ProduccionDetalle values(1,4,20,0,'',1)
Insert Into ProduccionDetalle values(1,6,10,0,'',1)
Insert Into ProduccionDetalle values(1,7,60,0,'',1)

-->cliente 2
Insert Into ProduccionDetalle values(2,1,40,0,'',1)
Insert Into ProduccionDetalle values(2,3,20,0,'',1)
Insert Into ProduccionDetalle values(2,8,20,0,'',1)

-->cliente 3
Insert Into ProduccionDetalle values(3,9,40,0,'',1)
Insert Into ProduccionDetalle values(3,10,20,0,'',1)
Insert Into ProduccionDetalle values(3,5,20,0,'',1)
Insert Into ProduccionDetalle values(3,6,10,0,'',1)

-->cliente 4
Insert Into ProduccionDetalle values(4,10,40,0,'',1)
Insert Into ProduccionDetalle values(4,3,20,0,'',1)
Insert Into ProduccionDetalle values(4,4,20,0,'',1)
Insert Into ProduccionDetalle values(4,11,10,0,'',1)
Insert Into ProduccionDetalle values(4,9,60,0,'',1)
Insert Into ProduccionDetalle values(4,7,60,0,'',1)

--> cliente 5
Insert Into ProduccionDetalle values(5,4,20,0,'',1)
Insert Into ProduccionDetalle values(5,11,10,0,'',1)
Insert Into ProduccionDetalle values(5,9,60,0,'',1)
Insert Into ProduccionDetalle values(5,7,60,0,'',1)

--> cliente 6
Insert Into ProduccionDetalle values(6,4,20,0,'',1)
Insert Into ProduccionDetalle values(6,10,10,0,'',1)
Insert Into ProduccionDetalle values(6,3,60,0,'',1)
Insert Into ProduccionDetalle values(6,1,60,0,'',1)

--> cliente 7
Insert Into ProduccionDetalle values(7,4,20,0,'',1)
Insert Into ProduccionDetalle values(7,1,10,0,'',1)
Insert Into ProduccionDetalle values(7,5,60,0,'',1)
Insert Into ProduccionDetalle values(7,3,60,0,'',1)


--Procedimientos
Go
Create Proc Sp_InicioSesion(
@Usuario Varchar(15),
@Clave Varchar(15))
As
Begin
Set Nocount on
	if(Exists(select 1 from Usuario Where Usuario = @Usuario And Clave = @Clave))
		Begin
			 Declare @Nivel Varchar(30)
			 Set @Nivel=(select Nivel from Usuario Where Usuario = @Usuario And Clave = @Clave)
			 Select 'Bienvenido Usuario:' + Rtrim(@Usuario) As Resultado,@Nivel As Nivel,
			 1 As Estado
		End
	Else
		Begin	 
			 Select 'Acceso Denegado :' As Resultado,'' As Nivel,
			 0 As Estado
		End
Set Nocount off
End
Go

Create Proc Sp_ListarPedidosProducir
As
Begin
Set Nocount on
 Select * into #Elaborado  from Personal where Tipo = 1
 Select * into #Solicitado from Personal where Tipo = 2
 
 Select pc.NumProducion,
 Case pc.Estado when 1 then 'Pendiente' when 2 then 'Generado' else 'Anulado' End As Estado,
 pc.FechaRegistro,
 e.Apellido + ' ' + e.Nombre As Elaborado,
 e.Cargo As [Cargo Elaborado],
 s.Apellido + ' ' + s.Nombre As Solicitado,
 s.Cargo As [Cargo Solicitado],
 c.Apellido + ' ' + c.Nombre As Cliente
 From ProducionCabecera pc
 Inner Join Cliente c on pc.IdCliente = c.Id
 Inner Join #Elaborado e on e.Id =pc.IdElaborado
 Inner Join #Solicitado s on s.Id = pc.IdSolicitado

 Drop Table #Elaborado
 Drop Table #Solicitado
Set Nocount off
End
Go

Create Proc Sp_BuscarPedidosProducir(@FechaInicio Varchar(10),@FechaFin Varchar(10))
As
Begin
Set Nocount on
 Select * into #Elaborado  from Personal where Tipo = 1
 Select * into #Solicitado from Personal where Tipo = 2
 
 Select pc.NumProducion,
 Case pc.Estado when 1 then 'Pendiente' when 2 then 'Generado' else 'Anulado' End As Estado,
 pc.FechaRegistro,
 e.Apellido + ' ' + e.Nombre As Elaborado,
 e.Cargo As [Cargo Elaborado],
 s.Apellido + ' ' + s.Nombre As Solicitado,
 s.Cargo As [Cargo Solicitado],
 c.Apellido + ' ' + c.Nombre As Cliente
 From ProducionCabecera pc
 Inner Join Cliente c on pc.IdCliente = c.Id
 Inner Join #Elaborado e on e.Id =pc.IdElaborado
 Inner Join #Solicitado s on s.Id = pc.IdSolicitado
 Where Convert(Date,pc.FechaRegistro) Between Convert(Date,@FechaInicio) And Convert(Date,@FechaFin) 

 Drop Table #Elaborado
 Drop Table #Solicitado
Set Nocount off
End
Go

Create Proc Sp_ListarDetallePedidoProducion(
@NumProducion Int
)
As
Begin
Set Nocount on
 Select * into #Elaborado  from Personal where Tipo = 1
 Select * into #Solicitado from Personal where Tipo = 2
 
 Select pc.NumProducion,
 Case pc.Estado when 1 then 'Pendiente' when 2 then 'Generado' else 'Anulado' End As Estado,
 Convert(varchar,pc.FechaRegistro, 103) As FechaRegistro,
 e.Apellido + ' ' + e.Nombre As Elaborado,
 e.Cargo As[CargoElaborado],
 s.Apellido + ' ' + s.Nombre As Solicitado,
 s.Cargo As [CargoSolicitado],
 c.Apellido + ' ' + c.Nombre As Cliente
 From ProducionCabecera pc
 Inner Join Cliente c on pc.IdCliente = c.Id
 Inner Join #Elaborado e on e.Id =pc.IdElaborado
 Inner Join #Solicitado s on s.Id = pc.IdSolicitado
 Where pc.NumProducion = @NumProducion


 Select 
 a.IdArticulo,
 a.Descripcion,
 a.Tipo,
 pd.CantPedido As [Cantidad Pedido],
 pd.CantProducion As [Cantidad Producion],
 pd.Comentario 
 From ProduccionDetalle pd Inner Join Articulo a on pd.IdArticulo = a.IdArticulo 
 where pd.NumProducion = @NumProducion And pd.Estado > 0

 Drop Table #Elaborado
 Drop Table #Solicitado
Set Nocount off
End
Go