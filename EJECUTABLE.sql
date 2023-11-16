USE [TIENDA_MUSICA_V14]
GO
/****** Object:  UserDefinedFunction [dbo].[F_DESCUENTO]    Script Date: 15/11/2023 23:14:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[F_DESCUENTO] ( @IMPORTE DECIMAL(10,2) , @DESCUENTO INT )
RETURNS DECIMAL(10,2)
AS
BEGIN
    DECLARE @RESULTADO DECIMAL(10,2)
    
    SELECT @RESULTADO = @IMPORTE * (@DESCUENTO/100)
    
    RETURN @RESULTADO
END;

GO
/****** Object:  UserDefinedFunction [dbo].[F_RECARGO]    Script Date: 15/11/2023 23:14:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[F_RECARGO](@RECARGO DECIMAL(3,2))
RETURNS @TABLA TABLE
(ID_PRODUCTO SMALLINT,
NOMBRE VARCHAR(50),
DESCRIPCION VARCHAR(50),
PRECIO MONEY,
RECARGO DECIMAL(3,2),
PRECIO_RECARGO MONEY,
TIPO_PRODUCTO SMALLINT,
MARCA SMALLINT,
STOC INT)
AS
BEGIN
	INSERT @TABLA
	SELECT ID_PRODUCTO, NOMBRE, DESCRIPCION, PRECIO,
	@RECARGO, (PRECIO + (PRECIO * (1+ @RECARGO))), TP.TIPO, M.MARCA, STOCK FROM PRODUCTOS P, TIPOS_PRODUCTOS TP,
	MARCAS M WHERE P.ID_T_PRODUCTO = TP.ID_T_PRODUCTO AND P.ID_MARCA = M.ID_MARCA
	RETURN
END
GO
/****** Object:  Table [dbo].[BARRIOS]    Script Date: 15/11/2023 23:14:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[BARRIOS](
	[ID_BARRIO] [int] NOT NULL,
	[BARRIO] [varchar](50) NULL,
	[ID_PROVINCIA] [int] NULL,
 CONSTRAINT [PK_BARRIOS] PRIMARY KEY CLUSTERED 
(
	[ID_BARRIO] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CARACTERISTICAS]    Script Date: 15/11/2023 23:14:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CARACTERISTICAS](
	[ID_CARACTERISTICA] [int] NOT NULL,
	[DETALLES] [varchar](50) NULL,
	[ID_T_CARACTERISTICA] [int] NULL,
	[ID_PRODUCTO] [int] NULL,
 CONSTRAINT [PK_CARACTERISTICAS] PRIMARY KEY CLUSTERED 
(
	[ID_CARACTERISTICA] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CLIENTES]    Script Date: 15/11/2023 23:14:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CLIENTES](
	[ID_CLIENTE] [int] NOT NULL,
	[NOMBRE] [varchar](50) NULL,
	[APELLIDO] [varchar](50) NULL,
	[ID_BARRIO] [int] NULL,
	[TELEFONO] [bigint] NULL,
	[EMAIL] [varchar](50) NULL,
 CONSTRAINT [PK_CLIENTES] PRIMARY KEY CLUSTERED 
(
	[ID_CLIENTE] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[DETALLE_FACTURA]    Script Date: 15/11/2023 23:14:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DETALLE_FACTURA](
	[ID_DET_FACT] [int] NOT NULL,
	[NRO_FACTURA] [int] NULL,
	[ID_PRODUCTO] [int] NULL,
	[CANTIDAD] [int] NULL,
	[PRECIO] [decimal](10, 2) NULL,
 CONSTRAINT [PK_DETALLE_FACTURA] PRIMARY KEY CLUSTERED 
(
	[ID_DET_FACT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DETALLE_PEDIDO]    Script Date: 15/11/2023 23:14:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DETALLE_PEDIDO](
	[ID_DET_PED] [int] NOT NULL,
	[ID_PEDIDO] [int] NULL,
	[ID_PRODUCTO] [int] NULL,
	[CANTIDAD] [int] NULL,
	[PRECIO] [decimal](10, 2) NULL,
 CONSTRAINT [PK_DETALLE_PEDIDO] PRIMARY KEY CLUSTERED 
(
	[ID_DET_PED] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DETALLE_SERVICIO]    Script Date: 15/11/2023 23:14:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DETALLE_SERVICIO](
	[ID_DET_SERV] [int] NOT NULL,
	[NRO_FACTURA] [int] NULL,
	[ID_LUTHIER] [int] NULL,
	[ID_T_SERV] [int] NULL,
	[PRECIO_X_HORA] [decimal](10, 2) NULL,
	[HORAS] [int] NULL,
 CONSTRAINT [PK_DETALLE_SERVICIO] PRIMARY KEY CLUSTERED 
(
	[ID_DET_SERV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[EMPLEADOS]    Script Date: 15/11/2023 23:14:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[EMPLEADOS](
	[LEGAJO] [int] NOT NULL,
	[NOMBRE] [varchar](50) NULL,
	[APELLIDO] [varchar](50) NULL,
	[ID_PUESTO] [int] NULL,
	[ID_SEDE] [int] NULL,
	[TELEFONO] [bigint] NULL,
	[FECHA_INGRESO] [date] NULL,
 CONSTRAINT [PK_EMPLEADOS] PRIMARY KEY CLUSTERED 
(
	[LEGAJO] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[FACTURAS]    Script Date: 15/11/2023 23:14:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FACTURAS](
	[NRO_FACTURA] [int] NOT NULL,
	[FECHA] [date] NULL,
	[LEGAJO] [int] NULL,
	[ID_CLIENTE] [int] NULL,
	[ID_PAGO] [int] NULL,
	[ID_SEDE] [int] NULL,
	[ID_ENVIO] [int] NULL,
 CONSTRAINT [PK_FACTURAS] PRIMARY KEY CLUSTERED 
(
	[NRO_FACTURA] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[FORMA_ENVIO]    Script Date: 15/11/2023 23:14:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[FORMA_ENVIO](
	[ID_ENVIO] [int] NOT NULL,
	[ENVIO] [varchar](50) NULL,
 CONSTRAINT [PK_FORMA_ENVIO] PRIMARY KEY CLUSTERED 
(
	[ID_ENVIO] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[FORMA_PAGO]    Script Date: 15/11/2023 23:14:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[FORMA_PAGO](
	[ID_PAGO] [int] NOT NULL,
	[PAGO] [varchar](50) NULL,
 CONSTRAINT [PK_FORMA_PAGO] PRIMARY KEY CLUSTERED 
(
	[ID_PAGO] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[LUTHIERS]    Script Date: 15/11/2023 23:14:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[LUTHIERS](
	[ID_LUTHIER] [int] NOT NULL,
	[NOMBRE] [varchar](50) NULL,
	[APELLIDO] [varchar](50) NULL,
 CONSTRAINT [PK_LUTHIER] PRIMARY KEY CLUSTERED 
(
	[ID_LUTHIER] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[MARCAS]    Script Date: 15/11/2023 23:14:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[MARCAS](
	[ID_MARCA] [int] NOT NULL,
	[MARCA] [varchar](50) NULL,
 CONSTRAINT [PK_MARCAS] PRIMARY KEY CLUSTERED 
(
	[ID_MARCA] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PAISES]    Script Date: 15/11/2023 23:14:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PAISES](
	[ID_PAIS] [int] NOT NULL,
	[PAIS] [varchar](50) NULL,
 CONSTRAINT [PK_PAIS] PRIMARY KEY CLUSTERED 
(
	[ID_PAIS] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PEDIDOS]    Script Date: 15/11/2023 23:14:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PEDIDOS](
	[ID_PEDIDO] [int] NOT NULL,
	[FECHA] [date] NULL,
	[ID_PROVEEDOR] [int] NULL,
	[ID_PAGO] [int] NULL,
	[ID_ENVIO] [int] NULL,
 CONSTRAINT [PK_PEDIDOS] PRIMARY KEY CLUSTERED 
(
	[ID_PEDIDO] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PRODUCTOS]    Script Date: 15/11/2023 23:14:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PRODUCTOS](
	[ID_PRODUCTO] [int] NOT NULL,
	[NOMBRE] [varchar](50) NULL,
	[DESCRIPCION] [varchar](100) NULL,
	[ID_T_PRODUCTO] [int] NULL,
	[ID_MARCA] [int] NULL,
	[ID_PROVEEDOR] [int] NULL,
	[ID_PAIS] [int] NULL,
	[STOCK] [int] NULL,
	[PRECIO] [decimal](10, 2) NULL,
 CONSTRAINT [PK_PRODUCTOS] PRIMARY KEY CLUSTERED 
(
	[ID_PRODUCTO] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PROVEEDORES]    Script Date: 15/11/2023 23:14:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PROVEEDORES](
	[ID_PROVEEDOR] [int] NOT NULL,
	[NOMBRE] [varchar](50) NULL,
	[ID_RAZON] [int] NULL,
	[CALLE] [varchar](50) NULL,
	[ID_BARRIO] [int] NULL,
 CONSTRAINT [PK_PROVEDORES] PRIMARY KEY CLUSTERED 
(
	[ID_PROVEEDOR] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PROVINCIAS]    Script Date: 15/11/2023 23:14:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PROVINCIAS](
	[ID_PROVINCIA] [int] NOT NULL,
	[PROVINCIA] [varchar](50) NULL,
	[ID_PAIS] [int] NULL,
 CONSTRAINT [PK_PROVINCIAS] PRIMARY KEY CLUSTERED 
(
	[ID_PROVINCIA] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PUESTOS]    Script Date: 15/11/2023 23:14:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PUESTOS](
	[ID_PUESTO] [int] NOT NULL,
	[PUESTO] [varchar](50) NULL,
 CONSTRAINT [PK_PUESTOS] PRIMARY KEY CLUSTERED 
(
	[ID_PUESTO] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[RAZON_SOCIAL]    Script Date: 15/11/2023 23:14:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[RAZON_SOCIAL](
	[ID_RAZON] [int] NOT NULL,
	[DESCRIPCION] [varchar](50) NULL,
 CONSTRAINT [PK_RAZON_SOCIAL] PRIMARY KEY CLUSTERED 
(
	[ID_RAZON] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SEDES]    Script Date: 15/11/2023 23:14:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SEDES](
	[ID_SEDE] [int] NOT NULL,
	[NOMBRE] [varchar](50) NULL,
	[CALLE] [varchar](50) NULL,
	[ID_BARRIO] [int] NULL,
	[TELEFONO] [bigint] NULL,
	[EMAIL] [varchar](50) NULL,
 CONSTRAINT [PK_SEDES] PRIMARY KEY CLUSTERED 
(
	[ID_SEDE] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TIPO_SERVICIO]    Script Date: 15/11/2023 23:14:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TIPO_SERVICIO](
	[ID_T_SERV] [int] NOT NULL,
	[SERVICIO] [varchar](50) NULL,
 CONSTRAINT [PK_TIPO_SERVICIO] PRIMARY KEY CLUSTERED 
(
	[ID_T_SERV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TIPOS_CARACTERISTICAS]    Script Date: 15/11/2023 23:14:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TIPOS_CARACTERISTICAS](
	[ID_T_CARACTERISTICA] [int] NOT NULL,
	[TIPO] [varchar](50) NULL,
 CONSTRAINT [PK_TIPOS_CARACTERISTICAS] PRIMARY KEY CLUSTERED 
(
	[ID_T_CARACTERISTICA] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TIPOS_PRODUCTOS]    Script Date: 15/11/2023 23:14:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TIPOS_PRODUCTOS](
	[ID_T_PRODUCTO] [int] NOT NULL,
	[TIPO] [varchar](50) NULL,
 CONSTRAINT [PK_TIPOS_PRODUCTO] PRIMARY KEY CLUSTERED 
(
	[ID_T_PRODUCTO] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[BARRIOS]  WITH CHECK ADD  CONSTRAINT [FK_BARRIOS_PROVINCIAS] FOREIGN KEY([ID_PROVINCIA])
REFERENCES [dbo].[PROVINCIAS] ([ID_PROVINCIA])
GO
ALTER TABLE [dbo].[BARRIOS] CHECK CONSTRAINT [FK_BARRIOS_PROVINCIAS]
GO
ALTER TABLE [dbo].[CARACTERISTICAS]  WITH CHECK ADD  CONSTRAINT [FK_CARACTERISTICAS_PRODUCTOS] FOREIGN KEY([ID_PRODUCTO])
REFERENCES [dbo].[PRODUCTOS] ([ID_PRODUCTO])
GO
ALTER TABLE [dbo].[CARACTERISTICAS] CHECK CONSTRAINT [FK_CARACTERISTICAS_PRODUCTOS]
GO
ALTER TABLE [dbo].[CARACTERISTICAS]  WITH CHECK ADD  CONSTRAINT [FK_CARACTERISTICAS_TIPOS_CARACTERISTICAS] FOREIGN KEY([ID_T_CARACTERISTICA])
REFERENCES [dbo].[TIPOS_CARACTERISTICAS] ([ID_T_CARACTERISTICA])
GO
ALTER TABLE [dbo].[CARACTERISTICAS] CHECK CONSTRAINT [FK_CARACTERISTICAS_TIPOS_CARACTERISTICAS]
GO
ALTER TABLE [dbo].[CLIENTES]  WITH CHECK ADD  CONSTRAINT [FK_CLIENTES_BARRIOS] FOREIGN KEY([ID_BARRIO])
REFERENCES [dbo].[BARRIOS] ([ID_BARRIO])
GO
ALTER TABLE [dbo].[CLIENTES] CHECK CONSTRAINT [FK_CLIENTES_BARRIOS]
GO
ALTER TABLE [dbo].[DETALLE_FACTURA]  WITH CHECK ADD  CONSTRAINT [FK_DETALLE_FACTURA_FACTURAS] FOREIGN KEY([NRO_FACTURA])
REFERENCES [dbo].[FACTURAS] ([NRO_FACTURA])
GO
ALTER TABLE [dbo].[DETALLE_FACTURA] CHECK CONSTRAINT [FK_DETALLE_FACTURA_FACTURAS]
GO
ALTER TABLE [dbo].[DETALLE_FACTURA]  WITH CHECK ADD  CONSTRAINT [FK_DETALLE_FACTURA_PRODUCTOS] FOREIGN KEY([ID_PRODUCTO])
REFERENCES [dbo].[PRODUCTOS] ([ID_PRODUCTO])
GO
ALTER TABLE [dbo].[DETALLE_FACTURA] CHECK CONSTRAINT [FK_DETALLE_FACTURA_PRODUCTOS]
GO
ALTER TABLE [dbo].[DETALLE_PEDIDO]  WITH CHECK ADD  CONSTRAINT [FK_DETALLE_PEDIDO_PEDIDOS] FOREIGN KEY([ID_PEDIDO])
REFERENCES [dbo].[PEDIDOS] ([ID_PEDIDO])
GO
ALTER TABLE [dbo].[DETALLE_PEDIDO] CHECK CONSTRAINT [FK_DETALLE_PEDIDO_PEDIDOS]
GO
ALTER TABLE [dbo].[DETALLE_PEDIDO]  WITH CHECK ADD  CONSTRAINT [FK_DETALLE_PEDIDO_PRODUCTOS] FOREIGN KEY([ID_PRODUCTO])
REFERENCES [dbo].[PRODUCTOS] ([ID_PRODUCTO])
GO
ALTER TABLE [dbo].[DETALLE_PEDIDO] CHECK CONSTRAINT [FK_DETALLE_PEDIDO_PRODUCTOS]
GO
ALTER TABLE [dbo].[DETALLE_SERVICIO]  WITH CHECK ADD  CONSTRAINT [FK_DETALLE_SERVICIO_FACTURAS] FOREIGN KEY([NRO_FACTURA])
REFERENCES [dbo].[FACTURAS] ([NRO_FACTURA])
GO
ALTER TABLE [dbo].[DETALLE_SERVICIO] CHECK CONSTRAINT [FK_DETALLE_SERVICIO_FACTURAS]
GO
ALTER TABLE [dbo].[DETALLE_SERVICIO]  WITH CHECK ADD  CONSTRAINT [FK_DETALLE_SERVICIO_LUTHIERS] FOREIGN KEY([ID_LUTHIER])
REFERENCES [dbo].[LUTHIERS] ([ID_LUTHIER])
GO
ALTER TABLE [dbo].[DETALLE_SERVICIO] CHECK CONSTRAINT [FK_DETALLE_SERVICIO_LUTHIERS]
GO
ALTER TABLE [dbo].[DETALLE_SERVICIO]  WITH CHECK ADD  CONSTRAINT [FK_DETALLE_SERVICIO_TIPO_SERVICIO] FOREIGN KEY([ID_T_SERV])
REFERENCES [dbo].[TIPO_SERVICIO] ([ID_T_SERV])
GO
ALTER TABLE [dbo].[DETALLE_SERVICIO] CHECK CONSTRAINT [FK_DETALLE_SERVICIO_TIPO_SERVICIO]
GO
ALTER TABLE [dbo].[EMPLEADOS]  WITH CHECK ADD  CONSTRAINT [FK_EMPLEADOS_PUESTOS] FOREIGN KEY([ID_PUESTO])
REFERENCES [dbo].[PUESTOS] ([ID_PUESTO])
GO
ALTER TABLE [dbo].[EMPLEADOS] CHECK CONSTRAINT [FK_EMPLEADOS_PUESTOS]
GO
ALTER TABLE [dbo].[EMPLEADOS]  WITH CHECK ADD  CONSTRAINT [FK_EMPLEADOS_SEDES] FOREIGN KEY([ID_SEDE])
REFERENCES [dbo].[SEDES] ([ID_SEDE])
GO
ALTER TABLE [dbo].[EMPLEADOS] CHECK CONSTRAINT [FK_EMPLEADOS_SEDES]
GO
ALTER TABLE [dbo].[FACTURAS]  WITH CHECK ADD  CONSTRAINT [FK_FACTURA_FORMA_ENVIO] FOREIGN KEY([ID_ENVIO])
REFERENCES [dbo].[FORMA_ENVIO] ([ID_ENVIO])
GO
ALTER TABLE [dbo].[FACTURAS] CHECK CONSTRAINT [FK_FACTURA_FORMA_ENVIO]
GO
ALTER TABLE [dbo].[FACTURAS]  WITH CHECK ADD  CONSTRAINT [FK_FACTURAS_CLIENTES] FOREIGN KEY([ID_CLIENTE])
REFERENCES [dbo].[CLIENTES] ([ID_CLIENTE])
GO
ALTER TABLE [dbo].[FACTURAS] CHECK CONSTRAINT [FK_FACTURAS_CLIENTES]
GO
ALTER TABLE [dbo].[FACTURAS]  WITH CHECK ADD  CONSTRAINT [FK_FACTURAS_EMPLEADOS] FOREIGN KEY([LEGAJO])
REFERENCES [dbo].[EMPLEADOS] ([LEGAJO])
GO
ALTER TABLE [dbo].[FACTURAS] CHECK CONSTRAINT [FK_FACTURAS_EMPLEADOS]
GO
ALTER TABLE [dbo].[FACTURAS]  WITH CHECK ADD  CONSTRAINT [FK_FACTURAS_FORMA_PAGO] FOREIGN KEY([ID_PAGO])
REFERENCES [dbo].[FORMA_PAGO] ([ID_PAGO])
GO
ALTER TABLE [dbo].[FACTURAS] CHECK CONSTRAINT [FK_FACTURAS_FORMA_PAGO]
GO
ALTER TABLE [dbo].[FACTURAS]  WITH CHECK ADD  CONSTRAINT [FK_FACTURAS_SEDES] FOREIGN KEY([ID_SEDE])
REFERENCES [dbo].[SEDES] ([ID_SEDE])
GO
ALTER TABLE [dbo].[FACTURAS] CHECK CONSTRAINT [FK_FACTURAS_SEDES]
GO
ALTER TABLE [dbo].[PEDIDOS]  WITH CHECK ADD  CONSTRAINT [FK_PEDIDOS_FORMA_ENVIO] FOREIGN KEY([ID_ENVIO])
REFERENCES [dbo].[FORMA_ENVIO] ([ID_ENVIO])
GO
ALTER TABLE [dbo].[PEDIDOS] CHECK CONSTRAINT [FK_PEDIDOS_FORMA_ENVIO]
GO
ALTER TABLE [dbo].[PEDIDOS]  WITH CHECK ADD  CONSTRAINT [FK_PEDIDOS_FORMA_PAGO] FOREIGN KEY([ID_PAGO])
REFERENCES [dbo].[FORMA_PAGO] ([ID_PAGO])
GO
ALTER TABLE [dbo].[PEDIDOS] CHECK CONSTRAINT [FK_PEDIDOS_FORMA_PAGO]
GO
ALTER TABLE [dbo].[PEDIDOS]  WITH CHECK ADD  CONSTRAINT [FK_PEDIDOS_PROVEEDORES] FOREIGN KEY([ID_PROVEEDOR])
REFERENCES [dbo].[PROVEEDORES] ([ID_PROVEEDOR])
GO
ALTER TABLE [dbo].[PEDIDOS] CHECK CONSTRAINT [FK_PEDIDOS_PROVEEDORES]
GO
ALTER TABLE [dbo].[PRODUCTOS]  WITH CHECK ADD  CONSTRAINT [FK_PRODUCTOS_MARCAS] FOREIGN KEY([ID_MARCA])
REFERENCES [dbo].[MARCAS] ([ID_MARCA])
GO
ALTER TABLE [dbo].[PRODUCTOS] CHECK CONSTRAINT [FK_PRODUCTOS_MARCAS]
GO
ALTER TABLE [dbo].[PRODUCTOS]  WITH CHECK ADD  CONSTRAINT [FK_PRODUCTOS_PAISES] FOREIGN KEY([ID_PAIS])
REFERENCES [dbo].[PAISES] ([ID_PAIS])
GO
ALTER TABLE [dbo].[PRODUCTOS] CHECK CONSTRAINT [FK_PRODUCTOS_PAISES]
GO
ALTER TABLE [dbo].[PRODUCTOS]  WITH CHECK ADD  CONSTRAINT [FK_PRODUCTOS_PROVEEDORES] FOREIGN KEY([ID_PROVEEDOR])
REFERENCES [dbo].[PROVEEDORES] ([ID_PROVEEDOR])
GO
ALTER TABLE [dbo].[PRODUCTOS] CHECK CONSTRAINT [FK_PRODUCTOS_PROVEEDORES]
GO
ALTER TABLE [dbo].[PRODUCTOS]  WITH CHECK ADD  CONSTRAINT [FK_PRODUCTOS_TIPOS_PRODUCTOS] FOREIGN KEY([ID_T_PRODUCTO])
REFERENCES [dbo].[TIPOS_PRODUCTOS] ([ID_T_PRODUCTO])
GO
ALTER TABLE [dbo].[PRODUCTOS] CHECK CONSTRAINT [FK_PRODUCTOS_TIPOS_PRODUCTOS]
GO
ALTER TABLE [dbo].[PROVEEDORES]  WITH CHECK ADD  CONSTRAINT [FK_PROVEDORES_BARRIOS] FOREIGN KEY([ID_BARRIO])
REFERENCES [dbo].[BARRIOS] ([ID_BARRIO])
GO
ALTER TABLE [dbo].[PROVEEDORES] CHECK CONSTRAINT [FK_PROVEDORES_BARRIOS]
GO
ALTER TABLE [dbo].[PROVEEDORES]  WITH CHECK ADD  CONSTRAINT [FK_PROVEEDORES_RAZON_SOCIAL] FOREIGN KEY([ID_RAZON])
REFERENCES [dbo].[RAZON_SOCIAL] ([ID_RAZON])
GO
ALTER TABLE [dbo].[PROVEEDORES] CHECK CONSTRAINT [FK_PROVEEDORES_RAZON_SOCIAL]
GO
ALTER TABLE [dbo].[PROVINCIAS]  WITH CHECK ADD  CONSTRAINT [FK_PROVINCIAS_PAISES] FOREIGN KEY([ID_PAIS])
REFERENCES [dbo].[PAISES] ([ID_PAIS])
GO
ALTER TABLE [dbo].[PROVINCIAS] CHECK CONSTRAINT [FK_PROVINCIAS_PAISES]
GO
ALTER TABLE [dbo].[SEDES]  WITH CHECK ADD  CONSTRAINT [FK_SEDES_BARRIOS] FOREIGN KEY([ID_BARRIO])
REFERENCES [dbo].[BARRIOS] ([ID_BARRIO])
GO
ALTER TABLE [dbo].[SEDES] CHECK CONSTRAINT [FK_SEDES_BARRIOS]
GO
/****** Object:  StoredProcedure [dbo].[SP_CONSULTAR_PRODUCTO]    Script Date: 15/11/2023 23:14:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_CONSULTAR_PRODUCTO]
@id INT
AS 
BEGIN
	SELECT * from PRODUCTOS P
	left join  tipos_productos tp on p.ID_T_PRODUCTO = tp.ID_T_PRODUCTO 
	where p.ID_PRODUCTO = @id
END;
GO
/****** Object:  StoredProcedure [dbo].[SP_CONSULTAR_TIPO_SERVICIO]    Script Date: 15/11/2023 23:14:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_CONSULTAR_TIPO_SERVICIO]
AS 
BEGIN
	SELECT ID_T_SERV, SERVICIO 
	FROM TIPO_SERVICIO
	ORDER BY SERVICIO
END 

GO
/****** Object:  StoredProcedure [dbo].[SP_GET_BARRIOS]    Script Date: 15/11/2023 23:14:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_GET_BARRIOS]
AS
BEGIN
	SELECT ID_BARRIO, BARRIO 
	FROM BARRIOS
	ORDER BY BARRIO
END;

GO
/****** Object:  StoredProcedure [dbo].[SP_GET_CLIENTE]    Script Date: 15/11/2023 23:14:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_GET_CLIENTE]
AS
BEGIN
	SELECT ID_CLIENTE, NOMBRE, APELLIDO 
	FROM CLIENTES
	ORDER BY APELLIDO
END;
GO
/****** Object:  StoredProcedure [dbo].[SP_GET_EMPLEADO_X_SEDE]    Script Date: 15/11/2023 23:14:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_GET_EMPLEADO_X_SEDE]
@SEDE INT
AS
BEGIN
	SELECT LEGAJO, NOMBRE, APELLIDO
	FROM EMPLEADOS
	WHERE ID_SEDE = @SEDE
	ORDER BY APELLIDO
END;
GO
/****** Object:  StoredProcedure [dbo].[SP_GET_FORMA_ENVIO]    Script Date: 15/11/2023 23:14:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_GET_FORMA_ENVIO]
AS
BEGIN
	SELECT ID_ENVIO, ENVIO 
	FROM FORMA_ENVIO
	ORDER BY ENVIO
END;
GO
/****** Object:  StoredProcedure [dbo].[SP_GET_FORMA_PAGO]    Script Date: 15/11/2023 23:14:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_GET_FORMA_PAGO]
AS
BEGIN
	SELECT ID_PAGO, PAGO 
	FROM FORMA_PAGO
	ORDER BY PAGO
END;

GO
/****** Object:  StoredProcedure [dbo].[SP_GET_LUTHIERS]    Script Date: 15/11/2023 23:14:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SP_GET_LUTHIERS]
AS 
BEGIN
	SELECT ID_LUTHIER, NOMBRE, APELLIDO
	FROM LUTHIERS
	ORDER BY APELLIDO
END 
GO
/****** Object:  StoredProcedure [dbo].[SP_GET_MARCAS]    Script Date: 15/11/2023 23:14:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_GET_MARCAS]
AS
BEGIN
	SELECT ID_MARCA, MARCA 
	FROM MARCAS
	ORDER BY MARCA
END;
GO
/****** Object:  StoredProcedure [dbo].[SP_GET_PAISES]    Script Date: 15/11/2023 23:14:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_GET_PAISES]
AS
BEGIN
	SELECT ID_PAIS, PAIS 
	FROM PAISES
	ORDER BY PAIS
END;

GO
/****** Object:  StoredProcedure [dbo].[SP_GET_PROVEEDOR]    Script Date: 15/11/2023 23:14:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_GET_PROVEEDOR]
AS
BEGIN
	SELECT ID_PROVEEDOR, NOMBRE
	FROM PROVEEDORES
	ORDER BY NOMBRE
END;
GO
/****** Object:  StoredProcedure [dbo].[SP_GET_PUESTOS]    Script Date: 15/11/2023 23:14:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_GET_PUESTOS]
AS
BEGIN
	SELECT ID_PUESTO, PUESTO
	FROM PUESTOS
	ORDER BY PUESTO
END;
GO
/****** Object:  StoredProcedure [dbo].[SP_GET_RAZON]    Script Date: 15/11/2023 23:14:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_GET_RAZON]
AS
BEGIN
	SELECT ID_RAZON, DESCRIPCION 
	FROM RAZON_SOCIAL
	ORDER BY DESCRIPCION
END;

GO
/****** Object:  StoredProcedure [dbo].[SP_GET_SEDES]    Script Date: 15/11/2023 23:14:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_GET_SEDES]
AS
BEGIN
	SELECT ID_SEDE, NOMBRE 
	FROM SEDES
	ORDER BY NOMBRE
END;

GO
/****** Object:  StoredProcedure [dbo].[SP_GET_TIPO_CARACTERISTICA]    Script Date: 15/11/2023 23:14:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_GET_TIPO_CARACTERISTICA]
AS
BEGIN
	SELECT ID_T_CARACTERISTICA, TIPO
	FROM TIPOS_CARACTERISTICAS
	ORDER BY TIPO
END;
GO
/****** Object:  StoredProcedure [dbo].[SP_GET_TIPO_PRODUCTO]    Script Date: 15/11/2023 23:14:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_GET_TIPO_PRODUCTO]
AS
BEGIN
	SELECT ID_T_PRODUCTO, TIPO 
	FROM TIPOS_PRODUCTOS
	ORDER BY TIPO
END;
GO
/****** Object:  StoredProcedure [dbo].[SP_INSERT_CARACTERISTICAS]    Script Date: 15/11/2023 23:14:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_INSERT_CARACTERISTICAS]
@DETALLES VARCHAR(50),
@TIPO_CARACTERISTICA INT,
@PRODUCTO INT
AS
BEGIN
	INSERT INTO CARACTERISTICAS (ID_CARACTERISTICA,DETALLES,ID_T_CARACTERISTICA,ID_PRODUCTO)
	VALUES ((SELECT MAX(ID_CARACTERISTICA) + 1 FROM CARACTERISTICAS),@DETALLES,@TIPO_CARACTERISTICA,@PRODUCTO);
END;

GO
/****** Object:  StoredProcedure [dbo].[SP_INSERT_CLIENTE]    Script Date: 15/11/2023 23:14:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_INSERT_CLIENTE]
@NOMBRE VARCHAR(50),
@APELLIDO VARCHAR(50),
@ID_BARRIO INT,
@TELEFONO INT,
@EMAIL VARCHAR(100)
AS
BEGIN
	INSERT INTO CLIENTES (ID_CLIENTE,NOMBRE,APELLIDO,ID_BARRIO,TELEFONO,EMAIL)
	VALUES ((SELECT MAX(ID_CLIENTE) + 1 FROM CLIENTES),@NOMBRE,@APELLIDO,@ID_BARRIO,@TELEFONO,@EMAIL);
END;
GO
/****** Object:  StoredProcedure [dbo].[SP_INSERT_EMPLEADO]    Script Date: 15/11/2023 23:14:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_INSERT_EMPLEADO]
@NOMBRE VARCHAR(50),
@APELLIDO VARCHAR(50),
@PUESTO INT,
@SEDE INT,
@TELEFONO BIGINT,
@FECHAINGRESO DATE
AS
BEGIN
	INSERT INTO EMPLEADOS(LEGAJO,NOMBRE,APELLIDO,ID_PUESTO,ID_SEDE,TELEFONO,FECHA_INGRESO)
	VALUES ((SELECT MAX(LEGAJO) + 1 FROM EMPLEADOS),@NOMBRE,@APELLIDO,@PUESTO,@SEDE,@TELEFONO,@FECHAINGRESO);
END; 
GO
/****** Object:  StoredProcedure [dbo].[SP_INSERT_LUTHIERS]    Script Date: 15/11/2023 23:14:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_INSERT_LUTHIERS]
@NOMBRE VARCHAR(50),
@APELLIDO VARCHAR(50)
AS
BEGIN
	INSERT INTO LUTHIERS (ID_LUTHIER,NOMBRE,APELLIDO)
	VALUES ((SELECT MAX(ID_LUTHIER) + 1 FROM LUTHIERS),@NOMBRE, @APELLIDO);
END;

GO
/****** Object:  StoredProcedure [dbo].[SP_INSERT_PRODUCTOS]    Script Date: 15/11/2023 23:14:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_INSERT_PRODUCTOS]
@NOMBRE VARCHAR(50),
@DESCRIPCION VARCHAR(100),
@TIPO_PRODUCTO INT,
@MARCA INT,
@PROVEEDOR INT,
@PAIS INT,
@STOCK INT,
@PRECIO DECIMAL(10,2)
AS
BEGIN
	INSERT INTO PRODUCTOS (ID_PRODUCTO,NOMBRE,DESCRIPCION,ID_T_PRODUCTO,ID_MARCA,ID_PROVEEDOR,ID_PAIS,STOCK,PRECIO)
	VALUES ((SELECT MAX(ID_PRODUCTO) + 1 FROM PRODUCTOS),@NOMBRE,@DESCRIPCION,@TIPO_PRODUCTO,@MARCA,@PROVEEDOR,@PAIS,@STOCK,@PRECIO);
END;

GO
/****** Object:  StoredProcedure [dbo].[SP_INSERT_PROVEEDORES]    Script Date: 15/11/2023 23:14:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_INSERT_PROVEEDORES]
@NOMBRE VARCHAR(50),
@RAZON INT,
@CALLE VARCHAR(50),
@BARRIO INT
AS
BEGIN
	INSERT INTO PROVEEDORES (ID_PROVEEDOR,NOMBRE,ID_RAZON,CALLE,ID_BARRIO)
	VALUES ((SELECT MAX(ID_PROVEEDOR) + 1 FROM PROVEEDORES),@NOMBRE,@RAZON,@CALLE,@BARRIO);
END;

GO
