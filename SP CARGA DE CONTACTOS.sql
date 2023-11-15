--/////////////// CARGA DE EMPLEADOS /////////////////

CREATE PROCEDURE SP_INSERT_EMPLEADO
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

-- SP PARA CARGAR LOS COMBO BOX COMPLEMENTARIOS

CREATE PROCEDURE SP_GET_PUESTOS
AS
BEGIN
	SELECT ID_PUESTO, PUESTO
	FROM PUESTOS
	ORDER BY PUESTO
END;

CREATE PROCEDURE SP_GET_SEDES
AS
BEGIN
	SELECT ID_SEDE, NOMBRE 
	FROM SEDES
	ORDER BY NOMBRE
END;


--//////////////// SP CARGA DE CLIENTE ///////////////////

CREATE PROCEDURE SP_INSERT_CLIENTE
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

-- SP BARRIOS COMPLEMENTARIO

CREATE PROCEDURE SP_GET_BARRIOS
AS
BEGIN
	SELECT ID_BARRIO, BARRIO 
	FROM BARRIOS
	ORDER BY BARRIO
END;

--//////////////// SP CARGA DE PROVEEDORES ///////////////////

CREATE PROCEDURE SP_INSERT_PROVEEDORES
@NOMBRE VARCHAR(50),
@RAZON INT,
@CALLE VARCHAR(50),
@BARRIO INT
AS
BEGIN
	INSERT INTO PROVEEDORES (ID_PROVEEDOR,NOMBRE,ID_RAZON,CALLE,ID_BARRIO)
	VALUES ((SELECT MAX(ID_PROVEEDOR) + 1 FROM PROVEEDORES),@NOMBRE,@RAZON,@CALLE,@BARRIO);
END;

-- SP RAZON SOCIAL COMPLEMENTARIO

CREATE PROCEDURE SP_GET_RAZON
AS
BEGIN
	SELECT ID_RAZON, DESCRIPCION 
	FROM RAZON_SOCIAL
	ORDER BY DESCRIPCION
END;

--//////////////// SP CARGA DE LUTHIER ///////////////////

CREATE PROCEDURE SP_INSERT_LUTHIERS
@NOMBRE VARCHAR(50),
@APELLIDO VARCHAR(50)
AS
BEGIN
	INSERT INTO LUTHIERS (ID_LUTHIER,NOMBRE,APELLIDO)
	VALUES ((SELECT MAX(ID_LUTHIER) + 1 FROM LUTHIERS),@NOMBRE, @APELLIDO);
END;