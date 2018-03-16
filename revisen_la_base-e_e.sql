-- --------------------------------------------------------
-- Host:                         127.0.0.1
-- Versión del servidor:         10.1.22-MariaDB - mariadb.org binary distribution
-- SO del servidor:              Win64
-- HeidiSQL Versión:             9.4.0.5125
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;


-- Volcando estructura de base de datos para bd_sistema_estudiante
CREATE DATABASE IF NOT EXISTS `bd_sistema_estudiante` /*!40100 DEFAULT CHARACTER SET latin1 */;
USE `bd_sistema_estudiante`;

-- Volcando estructura para procedimiento bd_sistema_estudiante.Activar
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `Activar`(



	IN `p_cedula` INT



)
    COMMENT 'Activa a una persona de la tabla'
BEGIN



	UPDATE tbl_estudiante 



	SET estado = 'A'



	WHERE cedula = p_cedula;



END//
DELIMITER ;

-- Volcando estructura para procedimiento bd_sistema_estudiante.BuscarCursoA
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `BuscarCursoA`(in dato VARCHAR(512))
BEGIN
SELECT id_curso AS 'Código del curso',
		 nombre AS 'Nombre del Curso',
		 descripcion As 'Descripcion del Curso' 
FROM tbl_curso 
WHERE estado = 'A'
AND nombre like "'+ dato +'%"  OR descripcion like "'+ dato +'%" ;
END//
DELIMITER ;

-- Volcando estructura para función bd_sistema_estudiante.cantidad_deudas
DELIMITER //
CREATE DEFINER=`root`@`localhost` FUNCTION `cantidad_deudas`() RETURNS int(11)
BEGIN
	SELECT count(*) AS cantidad  into @cantidad FROM tbl_deuda;
	return  @cantidad;
END//
DELIMITER ;

-- Volcando estructura para procedimiento bd_sistema_estudiante.cargarFoto
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `cargarFoto`(IN `ced1` INT)
BEGIN

	SELECT foto 

    FROM tbl_estudiante

    WHERE cedula = ced1;

END//
DELIMITER ;

-- Volcando estructura para procedimiento bd_sistema_estudiante.Desmatricular
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `Desmatricular`(



	IN `p_idMat` INT







)
    COMMENT 'Desmatricula un curso'
BEGIN



	UPDATE tbl_estudiante 



	SET estado = 'I'



	WHERE id_matricula = p_idMat;



END//
DELIMITER ;

-- Volcando estructura para procedimiento bd_sistema_estudiante.InactivarE
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `InactivarE`(



	IN `p_cedula` INT











)
    COMMENT 'Inactiva a un (una) estudiante de la tabla'
BEGIN



	UPDATE tbl_estudiante 



	SET estado = 'I'



	WHERE cedula = p_cedula;



END//
DELIMITER ;

-- Volcando estructura para procedimiento bd_sistema_estudiante.inModCurso
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `inModCurso`(
	IN `p_id` INT(16),
	IN `p_nombre` VARCHAR(124),
	IN `p_descripcion` VARCHAR(512),
	IN `p_estado` VARCHAR(1)
)
BEGIN

DECLARE usDis INT;

SET usDis = 0;
SELECT tbl_curso.id_curso FROM tbl_curso 
WHERE tbl_curso.id_curso = p_id INTO usDis;

IF usDis = 0
THEN CALL InsertarCurso(p_nombre, p_descripcion,	p_estado);
ELSEIF usDis != 0
THEN CALL ModificarCurso(p_id, p_nombre, p_descripcion);
END IF;

SELECT usDis;
END//
DELIMITER ;

-- Volcando estructura para procedimiento bd_sistema_estudiante.inModEsT
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `inModEsT`(
	IN `p_cedula` INT,
	IN `p_nombre` VARCHAR(124),
	IN `p_apellido1` VARCHAR(124),
	IN `p_apellido2` VARCHAR(124),
	IN `p_telefono` VARCHAR(12),
	IN `p_direccion` VARCHAR(512),
	IN `p_correo` VARCHAR(256),
	IN `p_fechaNacimiento` VARCHAR(10),
	IN `p_genero` VARCHAR(1),
	IN `p_estado` VARCHAR(1),
	IN `p_tipo` VARCHAR(50),
	IN `p_foto` VARCHAR(256)
)
BEGIN

DECLARE usDis INT;

SET usDis = 0;
SELECT tbl_estudiante.cedula FROM tbl_estudiante 
WHERE tbl_estudiante.cedula = p_cedula INTO usDis;

IF usDis = 0
THEN CALL InsertarEst(p_cedula, p_nombre, p_apellido1, p_apellido2, p_telefono, p_direccion, p_correo, p_fechaNacimiento, p_genero, p_estado, p_tipo, p_foto);
ELSEIF usDis != 0
THEN CALL ModificarEst(p_cedula, p_nombre, p_apellido1, p_apellido2, p_telefono, p_direccion, p_correo, p_fechaNacimiento, p_genero, p_estado, p_tipo, p_foto);
END IF;

SELECT usDis;
END//
DELIMITER ;

-- Volcando estructura para procedimiento bd_sistema_estudiante.InsertarA
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `InsertarA`(



	IN `p_id` INT,



	IN `p_nombre` VARCHAR(50),



	IN `p_fecha` DATE,



	IN `p_hora` TIME











)
    COMMENT 'inserta una actividad a la tabla'
BEGIN



	INSERT INTO tbl_actividades



	VALUES(p_id, p_nombre, p_fecha, p_hora);



END//
DELIMITER ;

-- Volcando estructura para procedimiento bd_sistema_estudiante.InsertarCurso
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `InsertarCurso`(
	IN `p_nombre` VARCHAR(50),
	IN `p_descripcion` VARCHAR(512),
	IN `p_estado` VARCHAR(1)




)
    COMMENT 'Inserta un curso a la tabla'
BEGIN
	INSERT INTO tbl_curso(`nombre`, `descripcion`, `estado`)
	VALUES(p_nombre, p_descripcion, p_estado);
END//
DELIMITER ;

-- Volcando estructura para procedimiento bd_sistema_estudiante.InsertarD
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `InsertarD`(



	IN `p_id` INT,



	IN `p_deuda` VARCHAR(50),



	IN `p_fecha` DATE,



	IN `p_obser` VARCHAR(50),



	IN `p_estado` VARCHAR(1),



	IN `p_idEst` INT











)
    COMMENT 'Inserta una deuda a la tabla'
BEGIN



	INSERT INTO tbl_deuda



	VALUES(p_id, p_deuda, p_fecha, p_obser, p_estado, p_idEst);



END//
DELIMITER ;

-- Volcando estructura para procedimiento bd_sistema_estudiante.InsertarE
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `InsertarE`(



	IN `cedula` INT,



	IN `nombre` VARCHAR(15),



	IN `apellido1` VARCHAR(15),



	IN `apellido2` VARCHAR(15),



	IN `telefono` VARCHAR(8),



	IN `direccion` VARCHAR(15),



	IN `correo` VARCHAR(30),



	IN `fechaNacimiento` DATE,



	IN `genero` VARCHAR(1),



	IN `foto` VARCHAR(50)























)
    COMMENT 'Inserta un (una) estudiante a la tabla'
BEGIN



	INSERT INTO tbl_estudiante



	VALUES(cedula, nombre, apellido1, apellido2, telefono, direccion, correo, fechaNacimiento, genero, 'A', tipo, foto);



END//
DELIMITER ;

-- Volcando estructura para procedimiento bd_sistema_estudiante.InsertarEst
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `InsertarEst`(
	IN `p_cedula` INT,
	IN `p_nombre` VARCHAR(124),
	IN `p_apellido1` VARCHAR(124),
	IN `p_apellido2` VARCHAR(124),
	IN `p_telefono` VARCHAR(12),
	IN `p_direccion` VARCHAR(512),
	IN `p_correo` VARCHAR(256),
	IN `p_fechaNacimiento` VARCHAR(10),
	IN `p_genero` VARCHAR(1),
	IN `p_estado` VARCHAR(1),
	IN `p_tipo` VARCHAR(50),
	IN `p_foto` VARCHAR(256)
)
    COMMENT 'Inserta un (una) estudiante a la tabla'
BEGIN
	INSERT INTO tbl_estudiante
	VALUES(p_cedula, p_nombre, p_apellido1, p_apellido2, p_telefono, p_direccion, p_correo, p_fechaNacimiento, p_genero, p_estado, p_tipo, p_foto);
END//
DELIMITER ;

-- Volcando estructura para procedimiento bd_sistema_estudiante.insertar_deuda
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `insertar_deuda`()
BEGIN
DECLARE MES int;
DECLARE MES2 int;
DECLARE año int;
DECLARE año2 int;
DECLARE deudas int;
SET MES = month(now());
SET año = year(now());
SET año2 = obtener_año();
SET MES2 = obtener_ultimo_mes();
SET deudas = cantidad_deudas();
if deudas = 0 or (MES = MES2 AND año != año2) or (MES != MES2 and año != año2) or (año = año2 and MES != MES2)
then
	INSERT INTO `bd_sistema_estudiante`.`tbl_deuda` (`deuda`, `fecha`, `estado`, `tbl_estudiante_cedula`)
	SELECT "D",CURDATE(),"A",cedula from tbl_estudiante where estado = "A";
end if;
END//
DELIMITER ;

-- Volcando estructura para procedimiento bd_sistema_estudiante.ListarCurso
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `ListarCurso`()
BEGIN

SELECT id_curso AS 'Código del curso',

		 nombre AS 'Nombre del Curso',

		 descripcion As 'Descripcion del Curso' 

FROM tbl_curso WHERE estado = 'A';

END//
DELIMITER ;

-- Volcando estructura para procedimiento bd_sistema_estudiante.ListarEstA
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `ListarEstA`()
BEGIN
SELECT cedula,nombre,apellido1,apellido2,telefono,direccion,correo,fechaNacimiento,genero,tipo,foto 
FROM tbl_estudiante 
WHERE estado = 'A'; 
END//
DELIMITER ;

-- Volcando estructura para procedimiento bd_sistema_estudiante.ListarUsuarios
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `ListarUsuarios`()
BEGIN

SELECT id_administrador AS 'Codigo de usuario',

		 nombreUsuario AS 'Nombre del Usuario',
		 
		 contraseña AS 'Contraseña',

		 tipo As 'Tipo de Usuario' 

FROM tbl_usuario;

END//
DELIMITER ;

-- Volcando estructura para procedimiento bd_sistema_estudiante.ListaUsuariosInvitados
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `ListaUsuariosInvitados`()
BEGIN

SELECT id_administrador AS 'Codigo de usuario',

		 nombreUsuario AS 'Nombre del Usuario',

		 tipo As 'Tipo de Usuario' 

FROM tbl_usuario

WHERE tipo = 'I';


END//
DELIMITER ;

-- Volcando estructura para procedimiento bd_sistema_estudiante.Matricular
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `Matricular`(



	IN `p_idMat` INT,



	IN `p_idCur` INT,



	IN `p_idEst` INT



)
    COMMENT 'Matricula un curso'
BEGIN



	INSERT INTO tbl_matricula



	VALUES(p_idMat, 'A', p_idCur, p_idEst);



END//
DELIMITER ;

-- Volcando estructura para procedimiento bd_sistema_estudiante.Modificar
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `Modificar`(



	IN `p_cedula` INT,



	IN `p_nombre` VARCHAR(15),



	IN `p_apellido1` VARCHAR(15),



	IN `p_apellido2` VARCHAR(15),



	IN `p_telefono` VARCHAR(8),



	IN `p_direccion` VARCHAR(150),



	IN `p_correo` VARCHAR(30),



	IN `p_fechaNacimiento` DATE,



	IN `p_genero` VARCHAR(1),



	IN `p_estado` VARCHAR(1),



	IN `p_tipo` VARCHAR(10),



	IN `p_foto` VARCHAR(50)















)
    COMMENT 'Modifica a una persona de la tabla'
BEGIN



	UPDATE tbl_estudiante 



	SET nombre = p_nombre, apellido1 = p_apellido1, apellido2 = p_apellido2, telefono = p_telefono, direccion = p_direccion,



	correo = p_correo, fechaNacimiento = p_fechaNacimiento, genero = p_genero, tipo = p_tipo,estado=p_estado, foto= p_foto



	WHERE cedula = p_cedula;



END//
DELIMITER ;

-- Volcando estructura para procedimiento bd_sistema_estudiante.ModificarCurso
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `ModificarCurso`(
	IN `p_id` INT,
	IN `p_nombre` VARCHAR(50),
	IN `p_descripcion` VARCHAR(512)
)
    COMMENT 'Modifica a un curso'
BEGIN
	UPDATE tbl_curso 
	SET nombre = p_nombre, descripcion = p_descripcion
	WHERE id_curso = p_id;
END//
DELIMITER ;

-- Volcando estructura para procedimiento bd_sistema_estudiante.ModificarEst
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `ModificarEst`(
	IN `p_cedula` INT,
	IN `p_nombre` VARCHAR(124),
	IN `p_apellido1` VARCHAR(124),
	IN `p_apellido2` VARCHAR(124),
	IN `p_telefono` VARCHAR(12),
	IN `p_direccion` VARCHAR(512),
	IN `p_correo` VARCHAR(256),
	IN `p_fechaNacimiento` VARCHAR(10),
	IN `p_genero` VARCHAR(1),
	IN `p_estado` VARCHAR(1),
	IN `p_tipo` VARCHAR(50),
	IN `p_foto` VARCHAR(256)
)
    COMMENT 'Modifica a una persona de la tabla'
BEGIN
	UPDATE tbl_estudiante 
	SET nombre = p_nombre, apellido1 = p_apellido1, apellido2 = p_apellido2, telefono = p_telefono, direccion = p_direccion,
	correo = p_correo, fechaNacimiento = p_fechaNacimiento, genero = p_genero, tipo = p_tipo,estado=p_estado, foto= p_foto
	WHERE cedula = p_cedula;
END//
DELIMITER ;

-- Volcando estructura para función bd_sistema_estudiante.obtener_año
DELIMITER //
CREATE DEFINER=`root`@`localhost` FUNCTION `obtener_año`() RETURNS int(11)
BEGIN
	SELECT max(year(fecha)) into @año FROM tbl_deuda;
	Return @año;
END//
DELIMITER ;

-- Volcando estructura para función bd_sistema_estudiante.obtener_ultimo_mes
DELIMITER //
CREATE DEFINER=`root`@`localhost` FUNCTION `obtener_ultimo_mes`() RETURNS int(11)
BEGIN
	SELECT month(max(fecha)) into @venta FROM tbl_deuda;
	Return @venta;
END//
DELIMITER ;

-- Volcando estructura para procedimiento bd_sistema_estudiante.Pagar
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `Pagar`(



	IN `p_idPago` INT,



	IN `p_deuda` INT,



	IN `p_idEst` INT







)
BEGIN



	INSERT INTO tbl_matricula



	VALUES(p_idPago, p_deudar, p_idEst);



END//
DELIMITER ;

-- Volcando estructura para procedimiento bd_sistema_estudiante.pagar_deuda
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `pagar_deuda`(
	IN `cedula` INT,
	IN `Fecha1` DATE

)
BEGIN
	UPDATE `tbl_deuda` 
	SET `deuda`='P' 
	WHERE `tbl_estudiante_cedula`= cedula and fecha = Fecha1;
END//
DELIMITER ;

-- Volcando estructura para tabla bd_sistema_estudiante.tbl_actividades
CREATE TABLE IF NOT EXISTS `tbl_actividades` (
  `id_actividades` int(11) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(100) DEFAULT NULL,
  `fecha` date DEFAULT NULL,
  `hora` time DEFAULT NULL,
  `accion` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`id_actividades`)
) ENGINE=InnoDB AUTO_INCREMENT=28 DEFAULT CHARSET=utf8;

-- Volcando datos para la tabla bd_sistema_estudiante.tbl_actividades: ~25 rows (aproximadamente)
/*!40000 ALTER TABLE `tbl_actividades` DISABLE KEYS */;
INSERT INTO `tbl_actividades` (`id_actividades`, `nombre`, `fecha`, `hora`, `accion`) VALUES
	(1, 'wittmann', '2017-11-05', '13:03:03', 'Inicio Sesion'),
	(2, 'wittmann', '2017-11-05', '13:03:51', 'Agrego un curso'),
	(3, 'wittmann', '2017-11-05', '13:04:25', 'Generado Asistencia'),
	(4, 'wittmann', '2017-11-05', '13:04:33', 'A matriculado un curso'),
	(5, 'wittmann', '2017-11-05', '13:04:40', 'Generado Asistencia'),
	(6, 'wittmann', '2017-11-05', '13:06:58', 'Agrego un nuevo estudiante'),
	(7, 'wittmann', '2017-11-05', '13:07:34', 'A matriculado un curso'),
	(8, 'wittmann', '2017-11-05', '13:09:16', 'Cerrar Sesion'),
	(9, 'wittmann', '2017-11-05', '13:24:10', 'Inicio Sesion'),
	(10, 'wittmann', '2017-11-05', '13:27:13', 'Cerrar Sesion'),
	(11, 'wittmann', '2017-11-05', '13:33:51', 'Inicio Sesion'),
	(12, 'wittmann', '2017-11-05', '13:34:29', 'Cerrar Sesion'),
	(13, 'wittmann', '2017-11-05', '13:35:17', 'Inicio Sesion'),
	(14, 'wittmann', '2017-11-08', '11:06:11', 'Inicio Sesion'),
	(15, 'wittmann', '2017-11-08', '11:09:03', 'Inicio Sesion'),
	(16, 'wittmann', '2017-11-10', '00:09:15', 'Inicio Sesion'),
	(17, 'wittmann', '2017-11-18', '10:58:16', 'Inicio Sesion'),
	(18, 'wittmann', '2017-11-18', '10:58:33', 'Inactivo curso'),
	(19, 'wittmann', '2017-11-18', '11:00:49', 'Inicio Sesion'),
	(20, 'wittmann', '2017-11-18', '11:02:00', 'Inicio Sesion'),
	(21, 'wittmann', '2017-11-18', '11:02:25', 'Inicio Sesion'),
	(22, 'wittmann', '2017-11-18', '11:03:48', 'Inicio Sesion'),
	(23, 'wittmann', '2017-11-18', '11:05:08', 'Inicio Sesion'),
	(24, 'wittmann', '2017-11-18', '11:05:39', 'Inicio Sesion'),
	(25, 'wittmann', '2017-11-18', '11:06:21', 'Inicio Sesion'),
	(26, 'wittmann', '2017-11-18', '11:14:25', 'Inicio Sesion'),
	(27, 'wittmann', '2017-11-18', '11:14:34', 'Agrego un curso');
/*!40000 ALTER TABLE `tbl_actividades` ENABLE KEYS */;

-- Volcando estructura para tabla bd_sistema_estudiante.tbl_asistencia
CREATE TABLE IF NOT EXISTS `tbl_asistencia` (
  `id_asistencia` int(11) NOT NULL AUTO_INCREMENT,
  `id_curso` int(11) DEFAULT NULL,
  `id_estudiante` int(11) DEFAULT NULL,
  `Fecha` date DEFAULT NULL,
  `Hora` time DEFAULT NULL,
  `Estado` varchar(8) DEFAULT NULL,
  PRIMARY KEY (`id_asistencia`),
  KEY `FK__tbl_curso` (`id_curso`),
  KEY `FK__tbl_estudiante` (`id_estudiante`),
  CONSTRAINT `FK__tbl_curso` FOREIGN KEY (`id_curso`) REFERENCES `tbl_curso` (`id_curso`),
  CONSTRAINT `FK__tbl_estudiante` FOREIGN KEY (`id_estudiante`) REFERENCES `tbl_estudiante` (`cedula`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;

-- Volcando datos para la tabla bd_sistema_estudiante.tbl_asistencia: ~0 rows (aproximadamente)
/*!40000 ALTER TABLE `tbl_asistencia` DISABLE KEYS */;
INSERT INTO `tbl_asistencia` (`id_asistencia`, `id_curso`, `id_estudiante`, `Fecha`, `Hora`, `Estado`) VALUES
	(1, 0, 678611781, '2017-11-05', '13:04:40', 'Ausente');
/*!40000 ALTER TABLE `tbl_asistencia` ENABLE KEYS */;

-- Volcando estructura para tabla bd_sistema_estudiante.tbl_curso
CREATE TABLE IF NOT EXISTS `tbl_curso` (
  `id_curso` int(16) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(124) NOT NULL,
  `descripcion` varchar(512) NOT NULL,
  `estado` varchar(1) NOT NULL,
  PRIMARY KEY (`id_curso`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8;

-- Volcando datos para la tabla bd_sistema_estudiante.tbl_curso: ~1 rows (aproximadamente)
/*!40000 ALTER TABLE `tbl_curso` DISABLE KEYS */;
INSERT INTO `tbl_curso` (`id_curso`, `nombre`, `descripcion`, `estado`) VALUES
	(0, '777', '787', 'A'),
	(1, 'e.e', 'LML', 'A'),
	(2, 'hola', 'e.e', 'A'),
	(3, 'hola', 'e.e', 'A'),
	(4, 'mmmm', 'e.e', 'A');
/*!40000 ALTER TABLE `tbl_curso` ENABLE KEYS */;

-- Volcando estructura para tabla bd_sistema_estudiante.tbl_deuda
CREATE TABLE IF NOT EXISTS `tbl_deuda` (
  `id_pago` int(16) NOT NULL AUTO_INCREMENT,
  `deuda` varchar(2) NOT NULL,
  `fecha` date NOT NULL,
  `observaciones` varchar(1024) DEFAULT NULL,
  `estado` varchar(1) DEFAULT NULL,
  `tbl_estudiante_cedula` int(16) NOT NULL,
  PRIMARY KEY (`id_pago`),
  KEY `FK_tbl_deuda_tbl_estudiante` (`tbl_estudiante_cedula`),
  CONSTRAINT `FK_tbl_deuda_tbl_estudiante` FOREIGN KEY (`tbl_estudiante_cedula`) REFERENCES `tbl_estudiante` (`cedula`)
) ENGINE=InnoDB AUTO_INCREMENT=185 DEFAULT CHARSET=utf8;

-- Volcando datos para la tabla bd_sistema_estudiante.tbl_deuda: ~3 rows (aproximadamente)
/*!40000 ALTER TABLE `tbl_deuda` DISABLE KEYS */;
INSERT INTO `tbl_deuda` (`id_pago`, `deuda`, `fecha`, `observaciones`, `estado`, `tbl_estudiante_cedula`) VALUES
	(182, 'D', '2017-11-08', NULL, 'A', 116820261),
	(183, 'D', '2017-11-08', NULL, 'A', 411231231),
	(184, 'D', '2017-11-08', NULL, 'A', 678611781);
/*!40000 ALTER TABLE `tbl_deuda` ENABLE KEYS */;

-- Volcando estructura para tabla bd_sistema_estudiante.tbl_estudiante
CREATE TABLE IF NOT EXISTS `tbl_estudiante` (
  `cedula` int(16) NOT NULL,
  `nombre` varchar(124) NOT NULL,
  `apellido1` varchar(124) NOT NULL,
  `apellido2` varchar(124) NOT NULL,
  `telefono` varchar(12) DEFAULT NULL,
  `direccion` varchar(512) DEFAULT NULL,
  `correo` varchar(256) DEFAULT NULL,
  `fechaNacimiento` varchar(10) NOT NULL,
  `genero` varchar(1) NOT NULL,
  `estado` varchar(1) NOT NULL,
  `tipo` varchar(50) DEFAULT NULL,
  `foto` varchar(256) DEFAULT NULL,
  PRIMARY KEY (`cedula`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- Volcando datos para la tabla bd_sistema_estudiante.tbl_estudiante: ~2 rows (aproximadamente)
/*!40000 ALTER TABLE `tbl_estudiante` DISABLE KEYS */;
INSERT INTO `tbl_estudiante` (`cedula`, `nombre`, `apellido1`, `apellido2`, `telefono`, `direccion`, `correo`, `fechaNacimiento`, `genero`, `estado`, `tipo`, `foto`) VALUES
	(116820261, 'wittmann', 'moreno', 'umaña', '8967050', 'neilly', 'wittm@live.com', '1997/07/20', 'M', 'A', 'M', NULL),
	(411231231, 'wittmann', 'moreno', 'umaña', '89647050', 'neily', 'wittm@live.com', '20/07/1997', 'M', 'A', 'Por Centros', 'C:\\Users\\wittmann\\Documents\\Visual Studio 2017\\Projects\\SistemaEstudiante 31-10-2017\\SistemaEstudiante\\bin\\Debug\\Recursos\\411231231.png'),
	(678611781, 'prueba', 'prueba', 'prueba', '8178213', 'rio claro', 'jnjk@gmail.com', '1997/07/20', 'M', 'A', 'M', NULL);
/*!40000 ALTER TABLE `tbl_estudiante` ENABLE KEYS */;

-- Volcando estructura para tabla bd_sistema_estudiante.tbl_matricula
CREATE TABLE IF NOT EXISTS `tbl_matricula` (
  `id_matricula` int(16) NOT NULL AUTO_INCREMENT,
  `estado` varchar(1) NOT NULL,
  `curso_id_curso` int(16) NOT NULL,
  `tbl_estudiante_cedula` int(16) NOT NULL,
  `fecha` year(4) DEFAULT NULL,
  PRIMARY KEY (`id_matricula`),
  KEY `FK_tbl_matricula_tbl_curso` (`curso_id_curso`),
  KEY `FK_tbl_matricula_tbl_estudiante` (`tbl_estudiante_cedula`),
  CONSTRAINT `FK_tbl_matricula_tbl_curso` FOREIGN KEY (`curso_id_curso`) REFERENCES `tbl_curso` (`id_curso`),
  CONSTRAINT `FK_tbl_matricula_tbl_estudiante` FOREIGN KEY (`tbl_estudiante_cedula`) REFERENCES `tbl_estudiante` (`cedula`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;

-- Volcando datos para la tabla bd_sistema_estudiante.tbl_matricula: ~2 rows (aproximadamente)
/*!40000 ALTER TABLE `tbl_matricula` DISABLE KEYS */;
INSERT INTO `tbl_matricula` (`id_matricula`, `estado`, `curso_id_curso`, `tbl_estudiante_cedula`, `fecha`) VALUES
	(1, 'A', 0, 678611781, '2017'),
	(2, 'A', 0, 411231231, '2017');
/*!40000 ALTER TABLE `tbl_matricula` ENABLE KEYS */;

-- Volcando estructura para tabla bd_sistema_estudiante.tbl_pago
CREATE TABLE IF NOT EXISTS `tbl_pago` (
  `id_pago` int(11) NOT NULL,
  `deuda` varchar(50) NOT NULL,
  `est_id_estudiante` int(11) NOT NULL,
  `deuda_estado` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`id_pago`),
  KEY `FK_tbl_pago_tbl_estudiante` (`est_id_estudiante`),
  KEY `deuda_estado` (`deuda_estado`),
  CONSTRAINT `FK_tbl_pago_tbl_estudiante` FOREIGN KEY (`est_id_estudiante`) REFERENCES `tbl_estudiante` (`cedula`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- Volcando datos para la tabla bd_sistema_estudiante.tbl_pago: ~0 rows (aproximadamente)
/*!40000 ALTER TABLE `tbl_pago` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_pago` ENABLE KEYS */;

-- Volcando estructura para tabla bd_sistema_estudiante.tbl_usuario
CREATE TABLE IF NOT EXISTS `tbl_usuario` (
  `id_administrador` int(16) NOT NULL AUTO_INCREMENT,
  `nombreUsuario` varchar(100) NOT NULL,
  `contraseña` varchar(8) NOT NULL,
  `tipo` varchar(1) NOT NULL,
  `respuestaS` varchar(50) DEFAULT NULL,
  `tipoPregunta` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`id_administrador`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8;

-- Volcando datos para la tabla bd_sistema_estudiante.tbl_usuario: ~1 rows (aproximadamente)
/*!40000 ALTER TABLE `tbl_usuario` DISABLE KEYS */;
INSERT INTO `tbl_usuario` (`id_administrador`, `nombreUsuario`, `contraseña`, `tipo`, `respuestaS`, `tipoPregunta`) VALUES
	(4, 'wittmann', 'Zxcv2007', 'A', 'hola', '0');
/*!40000 ALTER TABLE `tbl_usuario` ENABLE KEYS */;

-- Volcando estructura para tabla bd_sistema_estudiante.tbl_usuario_actual
CREATE TABLE IF NOT EXISTS `tbl_usuario_actual` (
  `id` int(11) NOT NULL,
  `actual` varchar(50) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- Volcando datos para la tabla bd_sistema_estudiante.tbl_usuario_actual: ~1 rows (aproximadamente)
/*!40000 ALTER TABLE `tbl_usuario_actual` DISABLE KEYS */;
INSERT INTO `tbl_usuario_actual` (`id`, `actual`) VALUES
	(1, 'wittmann');
/*!40000 ALTER TABLE `tbl_usuario_actual` ENABLE KEYS */;

/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IF(@OLD_FOREIGN_KEY_CHECKS IS NULL, 1, @OLD_FOREIGN_KEY_CHECKS) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
