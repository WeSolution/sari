--modificado por daniel --
--Crear Base de datos SARI_BD--
create database SARI_BD; --
go
use SARI_BD;
go
--Crear Tabla Direccion--
Create table Direccion(iddireccion int identity(1,1) primary key,calle varchar(50) ,numerointerior char(10) ,numeroexterior char(10) ,colonia varchar(50) ,codigopostal int,estado varchar(30),pais varchar(30));
go
--Crear Tabla Telefono--
create table Telefono(idtelefono int primary key identity(1,1),numero varchar(15) ,tipo varchar(15));
go
--Crear Tabla Persona--
create table Persona (idpersona int primary key identity (1,1), nombre varchar (60) NOT NULL, apaterno varchar (30) NOT NULL,amaterno varchar (30) NOT NULL, curp varchar (18) unique NOT NULL, rfc varchar (15) unique, fechanac date,sexo varchar(15),estadocivil varchar(15),estatus varchar(15), fkdireccion int, foreign key (fkdireccion) references Direccion (iddireccion));
go

--Crear Tabla contacto--
create table contacto(fktelefono int,fkpersona int,foreign key(fktelefono) references Telefono(idtelefono),foreign key(fkpersona) references Persona(idpersona),primary key(fkpersona,fktelefono))
go
--Crear Tabla Empleado--
create table Empleado(idempleado int identity(1,1) primary key, area varchar(20),puesto varchar(30),foto varchar(250),fkpersona int unique, foreign key(fkpersona) references Persona(idpersona))
go
--Crear Tabla Habilidad--
Create table Habilidad(idhabilidad int identity(1,1) primary key,tipo varchar(50),descripcion varchar(200),fkempleado int, foreign key(fkempleado) references Empleado(idempleado));
go
--Crear Tabla Idioma--
create table Idioma(ididioma int identity(1,1) primary key ,nombre varchar(200) ,nivel varchar(50),descripcion varchar(250),fkempleado int, foreign key(fkempleado) references Empleado(idempleado));
go
--Crear Tabla Academico--
create table Academico(idacademico int identity(1,1) primary key,inicio date,fin date,titulobtenido varchar(100),institucion varchar(100),fkempleado int, foreign key(fkempleado) references Empleado(idempleado))
go
--Crear Tabla Academico--
create table Jornada(idjornada int identity(1,1) primary key,tipo varchar(30),diasemana int, turno varchar(20),hrentrada time,hrsalida time)
go
--Crear Tabla asiste--
create table asiste(fkempleado int,fkjornada int, foreign key(fkempleado) references Empleado(idempleado),foreign key(fkjornada) references Jornada(idjornada),primary key(fkjornada,fkempleado))
go
--Crear Tabla Preferencias_Laborales--
create table Preferencias_Laborales(
id_PrefLab int identity,
Turno varchar(50),
Area varchar(50),
Puesto varchar(50),
Sueldo money,
Objetivo varchar(255),
Extra varchar(255) null, --Actividades extra que se tengan?
primary key (id_PrefLab)
);
go
--Crear Tabla More_Info--
create table More_Info(
id_MoreInfo int identity,
Idiomas varchar(255),
Herra_Ofi varchar(255), --Herramientas de Oficina
Herra_Info varchar(255), --Herramientas Informáticas.
Cursos varchar(255),
Cono_Tec varchar(255), --Conocimientos de Tecnología.
Cono_Fina varchar(255), --Conocimientos Financieros.
primary key (id_MoreInfo)
);
go
--Crear Tabla Candidatos--
create table Candidatos( --En esta tabla, se ingresarán los datos pincipales del candidato.
id_Candidato int identity,
Nacionalidad varchar(50),
E_Mail varchar(100),
No_IMSS varchar(20), --Solo pueden ser 20 digitos.
Telefono1 varchar(15), --Telefono principal.
Telefono2 varchar(15), --Telefono secundario.
--Al principio, los sig. campos se dejan vacios. Cuando se hagan los examenes, se hace un update.
Cali_Hab_Sup int default 0, --Habilidad de supervision
Cali_Cap_Dec int default 0, --Capacidad de decision en las relaciones humanas.
Cali_Cap_Eva int default 0, --Capacidad de evaluacion de problemas interpersonales.
Cali_Hab_ERI int default 0, --Habilidad para establecer relaciones interpersonales.
Cali_Sen_Com int default 0, --Sentido comun y tacto en las relaciones interpersonales.
id_PrefLab int,
id_MoreInfo int,
id_Persona int,
primary key (id_Candidato),
foreign key (id_PrefLab) references Preferencias_Laborales (id_PrefLab) --Se hace un foreign key a la tabla Preferencias_Laborales, ya que el Candidato solo puede tener una sola preferencia.
on delete set null --Cuando el registro al que hace referencia es borrado, el campo de esta tabla se deja en NULL.
on update cascade, --Cuando se haga alguna actualización al registro al que hace referencia, este tambien se actualiza.
foreign key (id_MoreInfo) references More_Info (id_MoreInfo)--Se hace un foreign key a la tabla More_Info, ya que el Candidato solo puede tener una referencia a mas información.
on delete set null --Cuando el registro al que hace referencia es borrado, el campo de esta tabla se deja en NULL.
on update cascade, --Cuando se haga alguna actualización al registro al que hace referencia, este tambien se actualiza.
foreign key (id_Persona) references Persona (idpersona)--Se hace un foreign key a la tabla Direcciones, ya que el Candidato solo puede tener una sola direccion.
on delete set null --Cuando el registro de Direccion al que hace referencia es borrado, el campo id_Direccion de esta tabla se deja en NULL.
on update cascade, --Cuando se haga alguna actualización al registro de Direccion al que hace referencia, este tambien se actualiza.
);
go
--Crear Tabla Historia_Laboral--
create table Historia_Laboral(
id_HistLab int identity, --Is this necesary?
Puesto varchar(50),
Empresa varchar(50),
Fecha_I date, --Fecha de ingreso.
Fecha_T date, --Fecha de Termino.
Area varchar(50), --Administración, Compras, etc.
Industria varchar(50), --Arquitectura, Comercio, Diseño, etc.
Sueldo money,
Motivo_Salida varchar(255),
Jefe_In varchar(50),
Puesto_Jefe varchar(50),
Telefono_Jefe varchar(50),
Contacto bit, --Podemos contactar a su jefe? Y/N
Comentarios varchar(255),
id_Candidato int,
primary key (id_HistLab),
foreign key (id_Candidato) references Candidatos (id_Candidato) --El candidato puede tener una o varias historias laborales.
on update cascade
);
go
--Crear Tabla Estudios--
create table Estudios(
id_Estudios int identity,
Pais varchar(50),
Nivel_Estudios varchar(50),
Institucion varchar(50),
Area varchar(50),
Titulo varchar(50),
Fecha_I date,
Fecha_T date,
Promedio float,
id_Candidato int,
primary key (id_Estudios),
foreign key (id_Candidato) references Candidatos (id_Candidato) --El candidato puede tener uno o varios estudios.
on update cascade
);
go
--Crear Tabla Referencias--
create table Referencias(
id_Referencia int identity,
Nombre_R varchar(50),
Direccion_R varchar(255),
Ocupacion_R varchar(50),
Telefono_R varchar(50),
id_Candidato int,
primary key (id_Referencia),
foreign key (id_Candidato) references Candidatos(id_Candidato) --El candidato puede tener una o varias referencias.
on update cascade
);
go
--Crear Tabla Preguntas_Test--
create table Preguntas_Test(
id_Pregunta int identity,
Pregunta varchar(255),
Capacidad int, --Esto es la habilidad o capacidad que se evalua en la pregunta.
--1 Habilidad de Supervision
--2 Capacidad de decicion en las relaciones humanas
--3 Capacidad de evaluacion de problemas interpersonales
--4 Habilidad para establecer relaciones interpersonales.
--5 Sentido común y tacto en las relaciones interpersonales.
Valor int, --El valor o porcentaje que se le dará a la respuesta.
primary key (id_Pregunta)
);
go
--Crear Tabla Respuestas_Test--
create table Respuestas_Test(
Inciso int, --Inciso que tendrá (0,1,2,3)
Pregunta int, --A que pregunta pertenece.
Respuesta varchar(255), --Respuesta de la pregunta.
foreign key (Pregunta) references Preguntas_Test(id_Pregunta)
on update cascade
);
go
--Crear Tabla producto--
create table producto(id_producto int identity NOT NULL,
	identificador varchar(50) NULL,
	nombre varchar(50) NULL,
	marca varchar(50) NULL,
	modelo varchar(50) NULL,
	descripcion varchar(100) NULL,
	grupo varchar(50) NULL,
	localizacion varchar(50) NULL,
	precio_compra money NULL,
	unidad_medida varchar(20) NULL,
	cantidad_medida int NULL,
	stock int NULL,
	fecha datetime NULL,
	primary key (id_producto));
GO
--Crear Tabla Salida--
CREATE TABLE salida(
	id_salida int IDENTITY NOT NULL,
	fecha date NULL,
	hora time(7) NULL,
	descripcion varchar(200) NULL,
	id_empleado int NULL,
	primary key (id_salida),
	foreign key (id_empleado) references Empleado(idempleado)
	on delete set null on update cascade);
GO
--Crear Tabla detalle_salida--
CREATE TABLE detalle_salida(
	id_detalle_salida int IDENTITY NOT NULL,
	id_salida int,
	id_producto int ,
	no_articulos int NULL,
	primary key (id_detalle_salida),
	foreign key (id_salida) references salida(id_salida)
	on delete set null on update cascade,
	foreign key (id_producto) references producto(id_producto)
	on delete set null on update cascade);
GO
--Crear Tabla proveedor--
CREATE TABLE proveedor(
	id_proveedor int IDENTITY NOT NULL,
	nombre varchar(50) NULL,
	tel_1 varchar(20) NULL,
	tel_2 varchar(20) NULL,
	ciudad varchar(50) NULL,
	direccion varchar(80) NULL,
	primary key (id_proveedor));
GO
--Crear Tabla entradas--
CREATE TABLE entradas(
	id_entrada int IDENTITY NOT NULL,
	fecha date NULL,
	hora time(7) NULL,
	descripcion varchar(200) NULL,
	total money NULL,
	id_proveedor int NULL,
	primary key (id_entrada),
	foreign key (id_proveedor) references proveedor(id_proveedor)
	on delete set null on update cascade);
GO
--Crear Tabla detalle_entradas--
CREATE TABLE detalle_entradas(
	id_detalle_entrada int IDENTITY NOT NULL,
	id_entrada int NULL,
	id_producto int NULL,
	no_articulos int NULL,
	primary key (id_detalle_entrada),
	foreign key (id_entrada) references entradas(id_entrada)
	on delete set null on update cascade,
	foreign key (id_producto) references producto(id_producto)
	on delete set null on update cascade);
GO
--Crear Tabla suministra--
CREATE TABLE suministra(
	id_suministro int IDENTITY NOT NULL,
	id_proveedor int NULL,
	id_producto int NULL,
	primary key (id_suministro),
	foreign key (id_proveedor) references proveedor(id_proveedor)
	on delete set null on update cascade,
	foreign key (id_producto) references producto(id_producto)
	on delete set null on update cascade);
GO
--Crear Tabla servicios--
CREATE TABLE servicios(
	id_servicio int IDENTITY NOT NULL,
	identificador varchar(50) NULL,
	nombre varchar(50) NULL,
	descripcion varchar(50) NULL,
	precio money NULL,
	primary key (id_servicio));
GO
--Crear Tabla atiende--
CREATE TABLE atiende(
	id_proveedor int NOT NULL,
	id_servicio int NOT NULL,
 CONSTRAINT [PK_atiende] PRIMARY KEY CLUSTERED 
(
	[id_proveedor] ASC,
	[id_servicio] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[atiende]  WITH CHECK ADD  CONSTRAINT [proveedor_atiende] FOREIGN KEY([id_proveedor])
REFERENCES [dbo].[proveedor] ([id_proveedor])
GO

ALTER TABLE [dbo].[atiende]  WITH CHECK ADD  CONSTRAINT [servicios_atiende] FOREIGN KEY([id_servicio])
REFERENCES [dbo].[servicios] ([id_servicio])
GO

--Crear Tabla area--
CREATE TABLE area(
	id_area int IDENTITY NOT NULL,
	area varchar(50) NULL,
	descripcion varchar(200) NULL,
	caracteristicas varchar(50) NULL,
	telefono varchar(50) NULL,
	id_empleado int NULL,
	primary key (id_area),
	foreign key (id_empleado) references Empleado(idempleado)
	on delete set null on update cascade);
GO
--Crear Tabla usuario--
CREATE TABLE usuario(
	id_usuario int IDENTITY NOT NULL,
	usuario varchar(50) NULL,
	pass varchar(50) NULL,
	id_empleado int NULL,
	privilegio varchar(100) NULL,
	primary key (id_usuario),
	foreign key (id_empleado) references Empleado(idempleado)
	on delete set null on update cascade);
GO
--Crear Tabla usuario--
CREATE TABLE sol_compra(
	id_compra int IDENTITY NOT NULL,
	caracteristicas varchar(200) NULL,
	tipo varchar(50) NULL,
	monto money NULL,
	fecha datetime NULL,
	estatus varchar(50) NULL,
	id_usuario int NULL,
	primary key (id_compra),
	foreign key (id_usuario) references usuario(id_usuario)
	on delete set null on update cascade);
GO
--Crear Tabla detalle_producto--
CREATE TABLE detalle_producto(
	id_compra int NOT NULL,
	id_producto int NOT NULL,
	cantidad int NULL,
	precio_venta money NULL,
PRIMARY KEY CLUSTERED 
(
	[id_compra] ASC,
	[id_producto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[detalle_producto]  WITH CHECK ADD FOREIGN KEY([id_compra])
REFERENCES [dbo].[sol_compra] ([id_compra])
GO

ALTER TABLE [dbo].[detalle_producto]  WITH CHECK ADD FOREIGN KEY([id_producto])
REFERENCES [dbo].[producto] ([id_producto])
GO

--Crear Tabla detalle_servicio--
CREATE TABLE detalle_servicio(
	id_compra int NOT NULL,
	id_servicio int NOT NULL,
	precio_venta money NULL,
PRIMARY KEY CLUSTERED 
(
	[id_compra] ASC,
	[id_servicio] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[detalle_servicio]  WITH CHECK ADD FOREIGN KEY([id_compra])
REFERENCES [dbo].[sol_compra] ([id_compra])
GO
ALTER TABLE [dbo].[detalle_servicio]  WITH CHECK ADD FOREIGN KEY([id_servicio])
REFERENCES [dbo].[servicios] ([id_servicio])
GO

