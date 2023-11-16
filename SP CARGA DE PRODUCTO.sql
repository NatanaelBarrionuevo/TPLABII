-- ///////////////// SPs COMPLEMENTARIOS PARA LA CARGA DE PRODUCTOS //////////////////////

--GET TIPO PRODUCTO
CREATE PROCEDURE SP_GET_TIPO_PRODUCTO
AS
BEGIN
	SELECT ID_T_PRODUCTO, TIPO 
	FROM TIPOS_PRODUCTOS
	ORDER BY TIPO
END;

--GET MARCAS
CREATE PROCEDURE SP_GET_MARCAS
AS
BEGIN
	SELECT ID_MARCA, MARCA 
	FROM MARCAS
	ORDER BY MARCA
END;

--GET PAISES
CREATE PROCEDURE SP_GET_PAISES
AS
BEGIN
	SELECT ID_PAIS, PAIS 
	FROM PAISES
	ORDER BY PAIS
END;

--GET PROVEEDOR
CREATE PROCEDURE SP_GET_PROVEEDOR
AS
BEGIN
	SELECT ID_PROVEEDOR, NOMBRE
	FROM PROVEEDORES
	ORDER BY NOMBRE
END;

-- /////////////////////////// CARGA DEL PRODUCTO /////////////////////////

CREATE PROCEDURE SP_INSERT_PRODUCTOS
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

-- ///////////////////////////// CARGA DE LAS CARACTERISTICAS //////////////////////

CREATE PROCEDURE SP_INSERT_CARACTERISTICAS
@DETALLES VARCHAR(50),
@TIPO_CARACTERISTICA INT,
@PRODUCTO INT
AS
BEGIN
	INSERT INTO CARACTERISTICAS (ID_CARACTERISTICA,DETALLES,ID_T_CARACTERISTICA,ID_PRODUCTO)
	VALUES ((SELECT MAX(ID_CARACTERISTICA) + 1 FROM CARACTERISTICAS),@DETALLES,@TIPO_CARACTERISTICA,@PRODUCTO);
END;


-- GET TIPO CARACTERISTICA
CREATE PROCEDURE SP_GET_TIPO_CARACTERISTICA
AS
BEGIN
	SELECT ID_T_CARACTERISTICA, TIPO
	FROM TIPOS_CARACTERISTICAS
	ORDER BY TIPO
END;

--GET PRODUCTOS

CREATE PROCEDURE SP_CONSULTAR_PRODUCTO
@id INT
AS 
BEGIN
	SELECT * from PRODUCTOS P
	left join  tipos_productos tp on p.ID_T_PRODUCTO = tp.ID_T_PRODUCTO 
	where p.ID_PRODUCTO = @id
END;

CREATE PROCEDURE SP_CONSULTAR_TIPO_SERVICIO
AS 
BEGIN
	SELECT ID_T_SERV, SERVICIO 
	FROM TIPO_SERVICIO
	ORDER BY SERVICIO
END 
