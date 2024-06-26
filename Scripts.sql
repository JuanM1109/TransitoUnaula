USE [master]
GO
/****** Object:  Database [dbTransito]    Script Date: 29/05/2024 12:27:33 p. m. ******/
CREATE DATABASE [dbTransito]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'dbTransito', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\dbTransito.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'dbTransito_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\dbTransito_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [dbTransito] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [dbTransito].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [dbTransito] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [dbTransito] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [dbTransito] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [dbTransito] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [dbTransito] SET ARITHABORT OFF 
GO
ALTER DATABASE [dbTransito] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [dbTransito] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [dbTransito] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [dbTransito] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [dbTransito] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [dbTransito] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [dbTransito] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [dbTransito] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [dbTransito] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [dbTransito] SET  DISABLE_BROKER 
GO
ALTER DATABASE [dbTransito] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [dbTransito] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [dbTransito] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [dbTransito] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [dbTransito] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [dbTransito] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [dbTransito] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [dbTransito] SET RECOVERY FULL 
GO
ALTER DATABASE [dbTransito] SET  MULTI_USER 
GO
ALTER DATABASE [dbTransito] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [dbTransito] SET DB_CHAINING OFF 
GO
ALTER DATABASE [dbTransito] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [dbTransito] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [dbTransito] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [dbTransito] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'dbTransito', N'ON'
GO
ALTER DATABASE [dbTransito] SET QUERY_STORE = ON
GO
ALTER DATABASE [dbTransito] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [dbTransito]
GO
/****** Object:  Table [dbo].[Agentes]    Script Date: 29/05/2024 12:27:33 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Agentes](
	[Cedula] [int] NOT NULL,
	[Nombre] [varchar](50) NULL,
	[Apellido] [varchar](50) NULL,
	[Edad] [int] NULL,
	[Salario] [float] NULL,
	[Telefono] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Cedula] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ciudades]    Script Date: 29/05/2024 12:27:33 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ciudades](
	[Codigo] [int] NOT NULL,
	[NombreCiudad] [varchar](50) NULL,
	[Ubicacion] [varchar](50) NULL,
	[Departamento] [int] NULL,
	[ValorAcumulado] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[Codigo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Departamentos]    Script Date: 29/05/2024 12:27:33 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Departamentos](
	[Codigo] [int] NOT NULL,
	[NombreDepartamento] [varchar](50) NULL,
	[Ubicacion] [varchar](50) NULL,
	[ValorAcumulado] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[Codigo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Infracciones]    Script Date: 29/05/2024 12:27:33 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Infracciones](
	[IdInfraccion] [int] NOT NULL,
	[Descripcion] [varchar](100) NULL,
	[Gravedad] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[IdInfraccion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Infractores]    Script Date: 29/05/2024 12:27:33 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Infractores](
	[Cedula] [int] NOT NULL,
	[Nombre] [varchar](50) NULL,
	[Apellido] [varchar](50) NULL,
	[Telefono] [int] NULL,
	[Direccion] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[Cedula] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Multas]    Script Date: 29/05/2024 12:27:33 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Multas](
	[Placa] [varchar](10) NULL,
	[Descripcion] [varchar](100) NULL,
	[Agente] [int] NULL,
	[Fecha] [date] NULL,
	[Direccion] [varchar](50) NULL,
	[Ciudad] [int] NULL,
	[Departamento] [int] NULL,
	[Fotomulta] [bit] NULL,
	[Infractor] [int] NULL,
	[Infraccion] [int] NULL,
	[Precio] [float] NULL,
	[IdMulta] [int] IDENTITY(1,1) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IdMulta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Pagos]    Script Date: 29/05/2024 12:27:33 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pagos](
	[IdFactura] [int] NOT NULL,
	[IdMulta] [int] NULL,
	[Nombre] [varchar](50) NULL,
	[Estado] [varchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[IdFactura] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Registro]    Script Date: 29/05/2024 12:27:33 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Registro](
	[IdRegistro] [int] NOT NULL,
	[Agente] [int] NULL,
	[MultasRealizadas] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[IdRegistro] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SOAT]    Script Date: 29/05/2024 12:27:33 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SOAT](
	[Placa] [varchar](10) NULL,
	[Vigente] [bit] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TM]    Script Date: 29/05/2024 12:27:33 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TM](
	[Placa] [varchar](10) NULL,
	[Vigente] [bit] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuarios]    Script Date: 29/05/2024 12:27:33 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuarios](
	[Usuario] [varchar](50) NULL,
	[Clave] [varchar](50) NULL,
	[Rol] [varchar](20) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Vehiculos]    Script Date: 29/05/2024 12:27:33 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Vehiculos](
	[Placa] [varchar](10) NOT NULL,
	[Tipo] [varchar](50) NULL,
	[Propietario] [int] NULL,
	[Color] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[Placa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Ciudades]  WITH CHECK ADD FOREIGN KEY([Departamento])
REFERENCES [dbo].[Departamentos] ([Codigo])
GO
ALTER TABLE [dbo].[Multas]  WITH CHECK ADD FOREIGN KEY([Agente])
REFERENCES [dbo].[Agentes] ([Cedula])
GO
ALTER TABLE [dbo].[Multas]  WITH CHECK ADD FOREIGN KEY([Ciudad])
REFERENCES [dbo].[Ciudades] ([Codigo])
GO
ALTER TABLE [dbo].[Multas]  WITH CHECK ADD FOREIGN KEY([Departamento])
REFERENCES [dbo].[Departamentos] ([Codigo])
GO
ALTER TABLE [dbo].[Multas]  WITH CHECK ADD FOREIGN KEY([Infraccion])
REFERENCES [dbo].[Infracciones] ([IdInfraccion])
GO
ALTER TABLE [dbo].[Multas]  WITH CHECK ADD FOREIGN KEY([Infractor])
REFERENCES [dbo].[Infractores] ([Cedula])
GO
ALTER TABLE [dbo].[Multas]  WITH CHECK ADD FOREIGN KEY([Placa])
REFERENCES [dbo].[Vehiculos] ([Placa])
GO
ALTER TABLE [dbo].[Pagos]  WITH CHECK ADD  CONSTRAINT [FK_Pagos_IdMulta] FOREIGN KEY([IdMulta])
REFERENCES [dbo].[Multas] ([IdMulta])
GO
ALTER TABLE [dbo].[Pagos] CHECK CONSTRAINT [FK_Pagos_IdMulta]
GO
ALTER TABLE [dbo].[Registro]  WITH CHECK ADD FOREIGN KEY([Agente])
REFERENCES [dbo].[Agentes] ([Cedula])
GO
ALTER TABLE [dbo].[SOAT]  WITH CHECK ADD FOREIGN KEY([Placa])
REFERENCES [dbo].[Vehiculos] ([Placa])
GO
ALTER TABLE [dbo].[TM]  WITH CHECK ADD FOREIGN KEY([Placa])
REFERENCES [dbo].[Vehiculos] ([Placa])
GO
ALTER TABLE [dbo].[Vehiculos]  WITH CHECK ADD FOREIGN KEY([Propietario])
REFERENCES [dbo].[Infractores] ([Cedula])
GO
/****** Object:  StoredProcedure [dbo].[InsertarAgente]    Script Date: 29/05/2024 12:27:33 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[InsertarAgente]
    @Cedula VARCHAR(20),
    @Nombre VARCHAR(50),
    @Apellido VARCHAR(50),
    @Edad INT,
    @Salario FLOAT,
    @Telefono VARCHAR(20)
AS
BEGIN
    SET NOCOUNT ON;

    INSERT INTO Agentes (Cedula, Nombre, Apellido, Edad, Salario, Telefono)
    VALUES (@Cedula, @Nombre, @Apellido, @Edad, @Salario, @Telefono);
END
GO
/****** Object:  StoredProcedure [dbo].[InsertarInfractor]    Script Date: 29/05/2024 12:27:33 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[InsertarInfractor]
    @Cedula VARCHAR(20),
    @Nombre VARCHAR(50),
    @Apellido VARCHAR(50),
    @Telefono VARCHAR(20),
    @Direccion VARCHAR(100)
AS
BEGIN
    SET NOCOUNT ON;

    INSERT INTO Infractores (Cedula, Nombre, Apellido, Telefono, Direccion)
    VALUES (@Cedula, @Nombre, @Apellido, @Telefono, @Direccion);
END
GO
/****** Object:  StoredProcedure [dbo].[InsertarMulta]    Script Date: 29/05/2024 12:27:33 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[InsertarMulta]
    @Placa VARCHAR(20),
    @Descripcion VARCHAR(255),
    @Agente VARCHAR(50),
    @Fecha DATETIME,
    @Direccion VARCHAR(100),
    @Ciudad VARCHAR(50),
    @Departamento VARCHAR(50),
    @Fotomulta BIT,
    @Infractor VARCHAR(100),
    @Infraccion INT,
    @Precio FLOAT
AS
BEGIN
    SET NOCOUNT ON;

    INSERT INTO Multas (Placa, Descripcion, Agente, Fecha, Direccion, Ciudad, Departamento, Fotomulta, Infractor, Infraccion, Precio)
    VALUES (@Placa, @Descripcion, @Agente, @Fecha, @Direccion, @Ciudad, @Departamento, @Fotomulta, @Infractor, @Infraccion, @Precio);
END
GO
/****** Object:  StoredProcedure [dbo].[InsertarUsuario]    Script Date: 29/05/2024 12:27:33 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[InsertarUsuario]
    @Usuario NVARCHAR(50),
    @Contraseña NVARCHAR(50),
    @Rol NVARCHAR(50) = 'Usuario'
AS
BEGIN
    BEGIN TRANSACTION;

    BEGIN TRY
        INSERT INTO Usuarios (Usuario, Clave, Rol)
        VALUES (@Usuario, @Contraseña, @Rol);

        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;
    END CATCH
END;
GO
/****** Object:  StoredProcedure [dbo].[InsertarVehiculo]    Script Date: 29/05/2024 12:27:33 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[InsertarVehiculo]
    @Placa VARCHAR(20),
    @Tipo VARCHAR(50),
    @Propietario VARCHAR(100),
    @Color VARCHAR(50)
AS
BEGIN
    SET NOCOUNT ON;

    INSERT INTO Vehiculos (Placa, Tipo, Propietario, Color)
    VALUES (@Placa, @Tipo, @Propietario, @Color);
END
GO
/****** Object:  StoredProcedure [dbo].[LoginAdministrador]    Script Date: 29/05/2024 12:27:33 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[LoginAdministrador]
    @Usuario NVARCHAR(50),
    @Contraseña NVARCHAR(50)
AS
BEGIN
    IF EXISTS (SELECT 1 FROM Usuarios WHERE Usuario = @Usuario AND Clave = @Contraseña AND Rol = 'Administrador')
    BEGIN
        SELECT 1;
    END
    ELSE
    BEGIN
        SELECT 0;
    END
END;

GO
/****** Object:  StoredProcedure [dbo].[LoginUsuario]    Script Date: 29/05/2024 12:27:33 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[LoginUsuario]
    @Usuario NVARCHAR(50),
    @Contraseña NVARCHAR(50)
AS
BEGIN
    IF EXISTS (SELECT 1 FROM Usuarios WHERE Usuario = @Usuario AND Clave = @Contraseña AND Rol = 'Usuario')
    BEGIN
        SELECT 1;
    END
    ELSE
    BEGIN
        SELECT 0;
    END
END;

GO
/****** Object:  StoredProcedure [dbo].[ModificarAgente]    Script Date: 29/05/2024 12:27:33 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ModificarAgente]
    @Cedula VARCHAR(20),
    @Nombre VARCHAR(50),
    @Apellido VARCHAR(50),
    @Edad INT,
    @Salario FLOAT,
    @Telefono VARCHAR(20)
AS
BEGIN
    SET NOCOUNT ON;

    UPDATE Agentes
    SET Nombre = @Nombre,
        Apellido = @Apellido,
        Edad = @Edad,
        Salario = @Salario,
        Telefono = @Telefono
    WHERE Cedula = @Cedula;
END
GO
/****** Object:  StoredProcedure [dbo].[ModificarInfractor]    Script Date: 29/05/2024 12:27:33 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ModificarInfractor]
    @Cedula VARCHAR(20),
    @Nombre VARCHAR(50),
    @Apellido VARCHAR(50),
    @Telefono VARCHAR(20),
    @Direccion VARCHAR(100)
AS
BEGIN
    SET NOCOUNT ON;

    UPDATE Infractores
    SET Nombre = @Nombre,
        Apellido = @Apellido,
        Telefono = @Telefono,
        Direccion = @Direccion
    WHERE Cedula = @Cedula;
END
GO
/****** Object:  StoredProcedure [dbo].[ModificarMulta]    Script Date: 29/05/2024 12:27:33 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ModificarMulta]
    @IdMulta INT,
    @Placa VARCHAR(20),
    @Descripcion VARCHAR(255),
    @Agente VARCHAR(50),
    @Fecha DATETIME,
    @Direccion VARCHAR(100),
    @Ciudad VARCHAR(50),
    @Departamento VARCHAR(50),
    @Fotomulta BIT,
    @Infractor VARCHAR(100),
    @Infraccion INT,
    @Precio MONEY
AS
BEGIN
    SET NOCOUNT ON;

    UPDATE Multas
    SET Placa = @Placa,
        Descripcion = @Descripcion,
        Agente = @Agente,
        Fecha = @Fecha,
        Direccion = @Direccion,
        Ciudad = @Ciudad,
        Departamento = @Departamento,
        Fotomulta = @Fotomulta,
        Infractor = @Infractor,
        Infraccion = @Infraccion,
        Precio = @Precio
    WHERE IdMulta = @IdMulta;
END
GO
/****** Object:  StoredProcedure [dbo].[ModificarVehiculo]    Script Date: 29/05/2024 12:27:33 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ModificarVehiculo]
    @Placa VARCHAR(20),
    @Tipo VARCHAR(50),
    @Propietario VARCHAR(100),
    @Color VARCHAR(50)
AS
BEGIN
    SET NOCOUNT ON;

    UPDATE Vehiculos
    SET Tipo = @Tipo,
        Propietario = @Propietario,
        Color = @Color
    WHERE Placa = @Placa;
END
GO
/****** Object:  StoredProcedure [dbo].[ObtenerCedula]    Script Date: 29/05/2024 12:27:33 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[ObtenerCedula]

AS
BEGIN
    SELECT Cedula FROM Infractores
END
GO
/****** Object:  StoredProcedure [dbo].[ObtenerCedulaAgente]    Script Date: 29/05/2024 12:27:33 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROCEDURE [dbo].[ObtenerCedulaAgente]
AS
BEGIN
    SELECT Cedula FROM Agentes
END
GO
/****** Object:  StoredProcedure [dbo].[ObtenerCiudadesPorDepartamento]    Script Date: 29/05/2024 12:27:33 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ObtenerCiudadesPorDepartamento]
    @IdDepartamento INT
AS
BEGIN
    SELECT NombreCiudad FROM Ciudades WHERE Departamento = @IdDepartamento
END
GO
/****** Object:  StoredProcedure [dbo].[ObtenerCodigoInfraccion]    Script Date: 29/05/2024 12:27:33 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ObtenerCodigoInfraccion]
    @Descripcion NVARCHAR(100)
AS
BEGIN
    SELECT IdInfraccion
    FROM Infracciones
    WHERE Descripcion = @Descripcion
END
GO
/****** Object:  StoredProcedure [dbo].[ObtenerDepartamentos]    Script Date: 29/05/2024 12:27:33 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ObtenerDepartamentos]
AS
BEGIN
    SELECT Codigo, NombreDepartamento FROM Departamentos
END


GO
/****** Object:  StoredProcedure [dbo].[ObtenerIdPorNombre]    Script Date: 29/05/2024 12:27:33 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create procedure [dbo].[ObtenerIdPorNombre]
@NombreCiudad varchar(20)
AS
BEGIN
select Codigo from Ciudades where NombreCiudad=@NombreCiudad
END
GO
/****** Object:  StoredProcedure [dbo].[ObtenerIdPorNombreDepartamento]    Script Date: 29/05/2024 12:27:33 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create procedure [dbo].[ObtenerIdPorNombreDepartamento]
@NombreDpto varchar(20)
AS
BEGIN
select Codigo from Departamentos where NombreDepartamento=@NombreDpto
END
GO
/****** Object:  StoredProcedure [dbo].[ObtenerInfracciones]    Script Date: 29/05/2024 12:27:33 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ObtenerInfracciones]
AS
BEGIN
    SELECT Descripcion FROM Infracciones
END
GO
/****** Object:  StoredProcedure [dbo].[ObtenerMultasPorCedula]    Script Date: 29/05/2024 12:27:33 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ObtenerMultasPorCedula]
    @CedulaInfractor INT
AS
BEGIN
    SELECT * FROM Multas WHERE Infractor = @CedulaInfractor
END
GO
/****** Object:  StoredProcedure [dbo].[ObtenerNombreAgentes]    Script Date: 29/05/2024 12:27:33 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ObtenerNombreAgentes]
AS
BEGIN
    SELECT Nombre FROM Agentes
END
GO
USE [master]
GO
ALTER DATABASE [dbTransito] SET  READ_WRITE 
GO
