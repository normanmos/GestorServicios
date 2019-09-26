CREATE DATABASE  IF NOT EXISTS `proyecto_isoo` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `proyecto_isoo`;
-- MySQL dump 10.13  Distrib 8.0.17, for Win64 (x86_64)
--
-- Host: localhost    Database: proyecto_isoo
-- ------------------------------------------------------
-- Server version	8.0.17

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `agenda_mantenimiento`
--

DROP TABLE IF EXISTS `agenda_mantenimiento`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `agenda_mantenimiento` (
  `idagenda_mantenimiento` int(11) NOT NULL AUTO_INCREMENT,
  `id_trabajo` int(11) DEFAULT NULL,
  `detalle` varchar(45) DEFAULT NULL,
  `id_servicio` int(11) DEFAULT NULL,
  `id_usuario_agenda` int(11) DEFAULT NULL,
  `id_departamento` int(11) DEFAULT NULL,
  `id_zona` int(11) DEFAULT NULL,
  `id_grupo_afectado` int(11) DEFAULT NULL,
  `id_estado_ejecucion` int(11) DEFAULT NULL,
  PRIMARY KEY (`idagenda_mantenimiento`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `agenda_mantenimiento`
--

LOCK TABLES `agenda_mantenimiento` WRITE;
/*!40000 ALTER TABLE `agenda_mantenimiento` DISABLE KEYS */;
INSERT INTO `agenda_mantenimiento` VALUES (7,3,'ninguno',14,0,13,33,1004,0);
/*!40000 ALTER TABLE `agenda_mantenimiento` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `app`
--

DROP TABLE IF EXISTS `app`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `app` (
  `idapp` int(11) NOT NULL AUTO_INCREMENT,
  `descripcion` varchar(45) DEFAULT NULL,
  `idplataforma` int(11) DEFAULT NULL,
  `start` varchar(45) DEFAULT NULL,
  `stop` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`idapp`),
  KEY `fk_app_plataforma_idx` (`idplataforma`),
  CONSTRAINT `fk_app_plataforma` FOREIGN KEY (`idplataforma`) REFERENCES `plataforma` (`idplataforma`)
) ENGINE=InnoDB AUTO_INCREMENT=123 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `app`
--

LOCK TABLES `app` WRITE;
/*!40000 ALTER TABLE `app` DISABLE KEYS */;
INSERT INTO `app` VALUES (119,'GAMBAS',212,'',''),(120,'OFFICE',211,'',''),(121,'CHROME',211,'',''),(122,'ICLOUD',214,'','');
/*!40000 ALTER TABLE `app` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `codigo_ejecucion`
--

DROP TABLE IF EXISTS `codigo_ejecucion`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `codigo_ejecucion` (
  `idcodigo_ejecucion` int(11) NOT NULL,
  `descripcion` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`idcodigo_ejecucion`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `codigo_ejecucion`
--

LOCK TABLES `codigo_ejecucion` WRITE;
/*!40000 ALTER TABLE `codigo_ejecucion` DISABLE KEYS */;
INSERT INTO `codigo_ejecucion` VALUES (401,'inicializacion'),(402,'procedimiento prinicpal'),(403,'codigo de busqueda'),(404,'procesamiento de datos'),(405,'tratamiento datos');
/*!40000 ALTER TABLE `codigo_ejecucion` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `departamento`
--

DROP TABLE IF EXISTS `departamento`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `departamento` (
  `iddepartamento` int(11) NOT NULL,
  `descripcion` varchar(45) DEFAULT NULL,
  `idgrupo` int(11) DEFAULT NULL,
  `direccion` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`iddepartamento`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `departamento`
--

LOCK TABLES `departamento` WRITE;
/*!40000 ALTER TABLE `departamento` DISABLE KEYS */;
INSERT INTO `departamento` VALUES (11,'Comercial',1,'Plaza Dañin '),(12,'Marketing',2,'Plaza Dañin'),(13,'Soporte tecnico',3,'Plaza Dañin'),(14,'Control de Calidad',4,'Plaza Dañin'),(15,'Sistemas',5,'Plaza Dañin');
/*!40000 ALTER TABLE `departamento` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `escenario`
--

DROP TABLE IF EXISTS `escenario`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `escenario` (
  `idescenario` int(11) NOT NULL AUTO_INCREMENT,
  `descripcion` varchar(45) DEFAULT NULL,
  `id_tema` int(11) DEFAULT NULL,
  PRIMARY KEY (`idescenario`)
) ENGINE=InnoDB AUTO_INCREMENT=108 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `escenario`
--

LOCK TABLES `escenario` WRITE;
/*!40000 ALTER TABLE `escenario` DISABLE KEYS */;
INSERT INTO `escenario` VALUES (107,'DATOS REDUNDANTES',117);
/*!40000 ALTER TABLE `escenario` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `estado_ejecucion`
--

DROP TABLE IF EXISTS `estado_ejecucion`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `estado_ejecucion` (
  `idestado_ejecucion` int(11) NOT NULL,
  `idcodigo_ejecucion` int(11) DEFAULT NULL,
  `motivo` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`idestado_ejecucion`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `estado_ejecucion`
--

LOCK TABLES `estado_ejecucion` WRITE;
/*!40000 ALTER TABLE `estado_ejecucion` DISABLE KEYS */;
INSERT INTO `estado_ejecucion` VALUES (1,1,'En proceso'),(2,2,'En proceso'),(3,3,'Terminado'),(4,4,'Terminado'),(5,5,'Terminado');
/*!40000 ALTER TABLE `estado_ejecucion` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `grupo`
--

DROP TABLE IF EXISTS `grupo`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `grupo` (
  `idgrupo` int(11) NOT NULL,
  `descripcion` varchar(45) DEFAULT NULL,
  `idusuario` int(11) DEFAULT NULL,
  `idzona` int(11) DEFAULT NULL,
  PRIMARY KEY (`idgrupo`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `grupo`
--

LOCK TABLES `grupo` WRITE;
/*!40000 ALTER TABLE `grupo` DISABLE KEYS */;
INSERT INTO `grupo` VALUES (1001,'equipo 1',991,11),(1002,'equipo 2',992,22),(1003,'equipo 3',993,33),(1004,'equipo 4',994,44),(1005,'equipo 5',995,55);
/*!40000 ALTER TABLE `grupo` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `plataforma`
--

DROP TABLE IF EXISTS `plataforma`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `plataforma` (
  `idplataforma` int(11) NOT NULL AUTO_INCREMENT,
  `descripcion` varchar(45) DEFAULT NULL,
  `idservidor` int(11) DEFAULT NULL,
  `idtipo_plataforma` int(11) DEFAULT NULL,
  PRIMARY KEY (`idplataforma`),
  KEY `fk_plataforma_servidor_idx` (`idservidor`),
  KEY `fk_plataforma_tipo_plataforma_idx` (`idtipo_plataforma`),
  CONSTRAINT `fk_plataforma_servidor` FOREIGN KEY (`idservidor`) REFERENCES `servidor` (`idservidor`),
  CONSTRAINT `fk_plataforma_tipo_plataforma` FOREIGN KEY (`idtipo_plataforma`) REFERENCES `tipo_plataforma` (`idtipo_plataforma`)
) ENGINE=InnoDB AUTO_INCREMENT=215 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `plataforma`
--

LOCK TABLES `plataforma` WRITE;
/*!40000 ALTER TABLE `plataforma` DISABLE KEYS */;
INSERT INTO `plataforma` VALUES (211,'WINDOWS',303,12),(212,'LINUX',301,10),(214,'MAC',301,13);
/*!40000 ALTER TABLE `plataforma` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `servicio`
--

DROP TABLE IF EXISTS `servicio`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `servicio` (
  `idservicio` int(11) NOT NULL AUTO_INCREMENT,
  `descripcion` varchar(45) DEFAULT NULL,
  `idapp` int(11) DEFAULT NULL,
  `idplataforma` int(11) DEFAULT NULL,
  `idservidor` int(11) DEFAULT NULL,
  PRIMARY KEY (`idservicio`),
  KEY `fk_servicio_app_idx` (`idapp`),
  KEY `fk_servicio_plataforma_idx` (`idplataforma`),
  KEY `fk_servicio_servidor_idx` (`idservidor`),
  CONSTRAINT `fk_servicio_app` FOREIGN KEY (`idapp`) REFERENCES `app` (`idapp`),
  CONSTRAINT `fk_servicio_plataforma` FOREIGN KEY (`idplataforma`) REFERENCES `plataforma` (`idplataforma`),
  CONSTRAINT `fk_servicio_servidor` FOREIGN KEY (`idservidor`) REFERENCES `servidor` (`idservidor`)
) ENGINE=InnoDB AUTO_INCREMENT=16 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `servicio`
--

LOCK TABLES `servicio` WRITE;
/*!40000 ALTER TABLE `servicio` DISABLE KEYS */;
INSERT INTO `servicio` VALUES (13,'MANTENIMIENTO',121,214,304),(14,'BACKUP',120,211,301),(15,'SOBREESCRITURA',119,212,303);
/*!40000 ALTER TABLE `servicio` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `servidor`
--

DROP TABLE IF EXISTS `servidor`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `servidor` (
  `idservidor` int(11) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(45) DEFAULT NULL,
  `direccion_ip` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`idservidor`)
) ENGINE=InnoDB AUTO_INCREMENT=333 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `servidor`
--

LOCK TABLES `servidor` WRITE;
/*!40000 ALTER TABLE `servidor` DISABLE KEYS */;
INSERT INTO `servidor` VALUES (301,'ADMINISTRACION','172.168.1.1'),(302,'RESPALDOS','172.168.1.2'),(303,'BODEGA','172.168.1.3'),(304,'DLL','172.168.1.4'),(305,'LICENCIAS','172.168.1.5'),(332,'HACKING','192.168.105');
/*!40000 ALTER TABLE `servidor` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `solucion`
--

DROP TABLE IF EXISTS `solucion`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `solucion` (
  `idsolucion` int(11) NOT NULL AUTO_INCREMENT,
  `descripcion` longtext,
  `id_escenario` int(11) DEFAULT NULL,
  PRIMARY KEY (`idsolucion`)
) ENGINE=InnoDB AUTO_INCREMENT=108 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `solucion`
--

LOCK TABLES `solucion` WRITE;
/*!40000 ALTER TABLE `solucion` DISABLE KEYS */;
INSERT INTO `solucion` VALUES (107,'VERIFICAR QUE DATOS INGRESAN',107);
/*!40000 ALTER TABLE `solucion` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tema`
--

DROP TABLE IF EXISTS `tema`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tema` (
  `idtema` int(11) NOT NULL AUTO_INCREMENT,
  `descripcion` varchar(45) DEFAULT NULL,
  `idservicio` int(11) DEFAULT NULL,
  PRIMARY KEY (`idtema`)
) ENGINE=InnoDB AUTO_INCREMENT=118 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tema`
--

LOCK TABLES `tema` WRITE;
/*!40000 ALTER TABLE `tema` DISABLE KEYS */;
INSERT INTO `tema` VALUES (104,'A',12),(110,'B',12),(111,'C',12),(112,'D',12),(113,'E',12),(114,'F',12),(117,'ERROR DE ESCRITURA',15);
/*!40000 ALTER TABLE `tema` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tipo_plataforma`
--

DROP TABLE IF EXISTS `tipo_plataforma`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tipo_plataforma` (
  `idtipo_plataforma` int(11) NOT NULL AUTO_INCREMENT,
  `descripcion` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`idtipo_plataforma`)
) ENGINE=InnoDB AUTO_INCREMENT=21 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tipo_plataforma`
--

LOCK TABLES `tipo_plataforma` WRITE;
/*!40000 ALTER TABLE `tipo_plataforma` DISABLE KEYS */;
INSERT INTO `tipo_plataforma` VALUES (10,'JAVA'),(11,'C#'),(12,'PHP'),(13,'C++'),(14,'PYTHON'),(15,'ANDROID'),(17,'IOS');
/*!40000 ALTER TABLE `tipo_plataforma` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tipo_trabajo`
--

DROP TABLE IF EXISTS `tipo_trabajo`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tipo_trabajo` (
  `idtipo_trabajo` int(11) NOT NULL,
  `descripcion` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`idtipo_trabajo`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tipo_trabajo`
--

LOCK TABLES `tipo_trabajo` WRITE;
/*!40000 ALTER TABLE `tipo_trabajo` DISABLE KEYS */;
INSERT INTO `tipo_trabajo` VALUES (11,'Revision de base de datos'),(12,'Realizacion de pruebas'),(13,'Analisis de sistemas'),(14,'Administrador Base de datos'),(15,'Revision de codigo');
/*!40000 ALTER TABLE `tipo_trabajo` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tipo_usuario`
--

DROP TABLE IF EXISTS `tipo_usuario`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tipo_usuario` (
  `idtipo_usuario` int(11) NOT NULL,
  `descripcion` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`idtipo_usuario`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tipo_usuario`
--

LOCK TABLES `tipo_usuario` WRITE;
/*!40000 ALTER TABLE `tipo_usuario` DISABLE KEYS */;
INSERT INTO `tipo_usuario` VALUES (1,'ADMINISTRADOR'),(2,'OPERADOR');
/*!40000 ALTER TABLE `tipo_usuario` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `trabajo`
--

DROP TABLE IF EXISTS `trabajo`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `trabajo` (
  `id_trabajo` int(11) NOT NULL,
  `idtipo_trabajo` int(11) DEFAULT NULL,
  `razon` varchar(45) DEFAULT NULL,
  `detallo_trabajo` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`id_trabajo`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `trabajo`
--

LOCK TABLES `trabajo` WRITE;
/*!40000 ALTER TABLE `trabajo` DISABLE KEYS */;
INSERT INTO `trabajo` VALUES (1,11,'Datos incoerentes','a'),(2,12,'Revision de codigo','b'),(3,13,'Revision Base de datos','c'),(4,14,'Asignacion de variables','d'),(5,15,'Compliacion ','e');
/*!40000 ALTER TABLE `trabajo` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `usuario`
--

DROP TABLE IF EXISTS `usuario`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `usuario` (
  `idusuario` varchar(11) NOT NULL,
  `contrasena` varchar(45) DEFAULT NULL,
  `nombre` varchar(45) DEFAULT NULL,
  `apellido` varchar(45) DEFAULT NULL,
  `idtipo_usuario` int(11) DEFAULT NULL,
  `iddepartamento` int(11) DEFAULT NULL,
  PRIMARY KEY (`idusuario`),
  UNIQUE KEY `idusuario` (`idusuario`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `usuario`
--

LOCK TABLES `usuario` WRITE;
/*!40000 ALTER TABLE `usuario` DISABLE KEYS */;
INSERT INTO `usuario` VALUES ('admin','admin','Administrador','',1,10),('ijunco','ijunco','Israel','Junco',2,13),('kmoran','kmoran','Kevin','Moran',1,11),('nnunez','nnunez','Norman','Nuñez',1,11),('test','test','Testeador','Testeador',2,11);
/*!40000 ALTER TABLE `usuario` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `usuario_agenda`
--

DROP TABLE IF EXISTS `usuario_agenda`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `usuario_agenda` (
  `idusuario_agenda` int(11) NOT NULL,
  `id_creador` varchar(45) DEFAULT NULL,
  `id_responsable` varchar(45) DEFAULT NULL,
  `id_ejecutor` varchar(45) DEFAULT NULL,
  `fecha_inicio` date DEFAULT NULL,
  `fecha_fin` date DEFAULT NULL,
  `est_fecha_inicio` datetime DEFAULT NULL,
  `est_fecha_fin` datetime DEFAULT NULL,
  PRIMARY KEY (`idusuario_agenda`),
  KEY `fk_usuarioagenda_usuario_idx` (`idusuario_agenda`,`id_creador`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `usuario_agenda`
--

LOCK TABLES `usuario_agenda` WRITE;
/*!40000 ALTER TABLE `usuario_agenda` DISABLE KEYS */;
INSERT INTO `usuario_agenda` VALUES (0,'nnunez','kmoran','ijunco',NULL,NULL,'2019-08-25 02:32:00','2019-08-26 02:32:00');
/*!40000 ALTER TABLE `usuario_agenda` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `zona`
--

DROP TABLE IF EXISTS `zona`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `zona` (
  `idzona` int(11) NOT NULL,
  `descripcion` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`idzona`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `zona`
--

LOCK TABLES `zona` WRITE;
/*!40000 ALTER TABLE `zona` DISABLE KEYS */;
INSERT INTO `zona` VALUES (11,'Centro'),(22,'Sur'),(33,'Este'),(44,'Oeste'),(55,'Norte');
/*!40000 ALTER TABLE `zona` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping events for database 'proyecto_isoo'
--

--
-- Dumping routines for database 'proyecto_isoo'
--
/*!50003 DROP PROCEDURE IF EXISTS `PROC_CONSULTAR_APP` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `PROC_CONSULTAR_APP`()
BEGIN
	SELECT A.IDAPP AS ID, A.DESCRIPCION AS NOMBRE, B.DESCRIPCION AS IDPLAT, A.START AS INICIO, A.STOP AS DETENER  FROM APP A
	INNER JOIN PLATAFORMA B
	ON A.IDPLATAFORMA=B.IDPLATAFORMA;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `PROC_CONSULTAR_ESCENARIO` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `PROC_CONSULTAR_ESCENARIO`()
BEGIN
	select a.idescenario as ID,
    a.descripcion as NOMBRE,
    b.descripcion as escenario
    from escenario a
    inner join tema b 
    on a.id_tema=b.idtema;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `PROC_CONSULTAR_PLATAFORMA` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `PROC_CONSULTAR_PLATAFORMA`()
BEGIN
select a.idplataforma as ID,a.descripcion AS NOMBRE,c.nombre as SERVIDOR,b.descripcion as TIPO_PLATAFORMA  from plataforma a
inner join tipo_plataforma b
on b.idtipo_plataforma=a.idtipo_plataforma
inner join servidor c
on c.idservidor=a.idservidor;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `PROC_CONSULTAR_SERVICIO` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `PROC_CONSULTAR_SERVICIO`()
BEGIN
	SELECT A.IDSERVICIO AS ID,A.DESCRIPCION AS NOMBRE,B.DESCRIPCION AS APP,C.DESCRIPCION AS PLATAFORMA,D.NOMBRE AS SERVIDOR FROM SERVICIO A
	INNER JOIN APP B
	ON A.IDAPP=B.IDAPP
	INNER JOIN PLATAFORMA C
	ON A.IDPLATAFORMA= C.IDPLATAFORMA
    INNER JOIN SERVIDOR D
    ON A.IDSERVIDOR=D.IDSERVIDOR;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `PROC_CONSULTAR_SERVIDOR` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `PROC_CONSULTAR_SERVIDOR`()
BEGIN
	select IDSERVIDOR AS ID, NOMBRE AS NOMBRE, DIRECCION_IP AS IP from servidor;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `PROC_CONSULTAR_SOLUCION` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `PROC_CONSULTAR_SOLUCION`()
BEGIN
	select a.idsolucion as ID,
    a.descripcion as NOMBRE,
    b.descripcion as escenario
    from solucion a
    inner join escenario b 
    on a.id_escenario=b.idescenario;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `PROC_CONSULTAR_TEMA` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `PROC_CONSULTAR_TEMA`()
BEGIN
	select a.idtema as ID,
    a.descripcion as NOMBRE,
    b.descripcion as servicio
    from tema a
    inner join servicio b 
    on a.idservicio=b.idservicio;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `PROC_CONSULTAR_TIPO_PLATAFORMA` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `PROC_CONSULTAR_TIPO_PLATAFORMA`()
BEGIN
select idtipo_plataforma as id,descripcion as nombre from tipo_plataforma;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `PROC_ELIMINAR_APP` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `PROC_ELIMINAR_APP`(in PID INT)
BEGIN
	delete from APP where IDAPP=PID;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `PROC_ELIMINAR_ESCENARIO` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `PROC_ELIMINAR_ESCENARIO`(in PID INT)
BEGIN
	delete from escenario where idescenario=PID;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `PROC_ELIMINAR_PLATAFORMA` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `PROC_ELIMINAR_PLATAFORMA`(in PID INT)
BEGIN
	delete from PLATAFORMA where IDPLATAFORMA=PID;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `PROC_ELIMINAR_SERVICIO` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `PROC_ELIMINAR_SERVICIO`(in PID INT)
BEGIN
	delete from SERVICIO where IDSERVICIO=PID;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `PROC_ELIMINAR_SERVIDOR` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `PROC_ELIMINAR_SERVIDOR`(in PID INT)
BEGIN
	delete from servidor where idservidor=PID;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `PROC_ELIMINAR_SOLUCION` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `PROC_ELIMINAR_SOLUCION`(in PID INT)
BEGIN
	delete from solucion where idsolucion=PID;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `PROC_ELIMINAR_TEMA` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `PROC_ELIMINAR_TEMA`(in PID INT)
BEGIN
	delete from tema where idtema=PID;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `PROC_ELIMINAR_TIPO_PLATAFORMA` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `PROC_ELIMINAR_TIPO_PLATAFORMA`(in PID INT)
BEGIN
	delete from TIPO_PLATAFORMA where IDTIPO_PLATAFORMA=PID;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `PROC_INSERTAR_APP` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `PROC_INSERTAR_APP`(IN PNOMBRE VARCHAR(100),IN PPLATAFORMA INT,IN START VARCHAR(100),IN STOP VARCHAR(100))
BEGIN
insert into APP (DESCRIPCION,IDPLATAFORMA,START,STOP)values(
    PNOMBRE,
    PPLATAFORMA,
    START,
    STOP
);
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `PROC_INSERTAR_ESCENARIO` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `PROC_INSERTAR_ESCENARIO`(IN P1 VARCHAR(100),IN P2 VARCHAR(100),
IN P3 VARCHAR(100),IN P4 VARCHAR(100))
BEGIN
insert into escenario (descripcion,id_tema)values(p1,p2);
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `PROC_INSERTAR_PLATAFORMA` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `PROC_INSERTAR_PLATAFORMA`(IN PNOMBRE VARCHAR(100),IN PSERVIDOR INT,IN PTIPOPLATAFORMA INT)
BEGIN
insert into PLATAFORMA (DESCRIPCION,IDSERVIDOR,IDTIPO_PLATAFORMA)values(
    PNOMBRE,
    PSERVIDOR,
    PTIPOPLATAFORMA
);
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `PROC_INSERTAR_SERVICIO` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `PROC_INSERTAR_SERVICIO`(IN PNOMBRE VARCHAR(100),IN PAPP INT,IN PPLATAFORMA INT,IN PSERVIDOR INT)
BEGIN
insert into SERVICIO (DESCRIPCION,IDAPP,IDPLATAFORMA,IDSERVIDOR)values(
    PNOMBRE,
    PAPP,
    PPLATAFORMA,
    PSERVIDOR
);
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `PROC_INSERTAR_SERVIDOR` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `PROC_INSERTAR_SERVIDOR`(IN PNOMBRE VARCHAR(100),IN PDIRECCION_IP VARCHAR(100))
BEGIN
insert into servidor (nombre,direccion_ip)values(
    PNOMBRE,
    PDIRECCION_IP
);
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `PROC_INSERTAR_SOLUCION` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `PROC_INSERTAR_SOLUCION`(IN P1 VARCHAR(100),IN P2 VARCHAR(100),
IN P3 VARCHAR(100),IN P4 VARCHAR(100))
BEGIN
insert into solucion (descripcion,id_escenario)values(p1,p2);
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `PROC_INSERTAR_TEMA` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `PROC_INSERTAR_TEMA`(IN P1 VARCHAR(100),IN P2 VARCHAR(100),
IN P3 VARCHAR(100),IN P4 VARCHAR(100))
BEGIN
insert into tema (descripcion,idservicio)values(p1,p2);
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `PROC_INSERTAR_TIPO_PLATAFORMA` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `PROC_INSERTAR_TIPO_PLATAFORMA`(IN PNOMBRE VARCHAR(100))
BEGIN
insert into tipo_plataforma (descripcion)values(
    PNOMBRE
);
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `PROC_MODIFICAR_APP` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `PROC_MODIFICAR_APP`(IN PNOMBRE VARCHAR(100),IN PPLATAFORMA INT,IN PSTART VARCHAR(100),IN PSTOP VARCHAR(100),IN ID INT)
BEGIN
UPDATE  APP
SET DESCRIPCION=PNOMBRE,
	IDPLATAFORMA=PPLATAFORMA,
    START=PSTART,
    STOP=PSTOP
WHERE IDAPP=ID;    
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `PROC_MODIFICAR_ESCENARIO` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `PROC_MODIFICAR_ESCENARIO`(IN p1 VARCHAR(100),IN p2 VARCHAR(100),
IN p3 VARCHAR(100),
IN p4 VARCHAR(100))
BEGIN
	UPDATE escenario 
    SET descripcion=p1,
    id_tema=p2
	WHERE idescenario=p4;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `PROC_MODIFICAR_PLATAFORMA` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `PROC_MODIFICAR_PLATAFORMA`(IN PNOMBRE VARCHAR(100),IN PSERVIDOR INT,IN PTIPO_PLATAFORMA INT, IN PID INT)
BEGIN
	UPDATE PLATAFORMA
    SET DESCRIPCION=PNOMBRE,
    IDSERVIDOR=PSERVIDOR,
    IDTIPO_PLATAFORMA=PTIPO_PLATAFORMA
	WHERE IDPLATAFORMA=PID;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `PROC_MODIFICAR_SERVICIO` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `PROC_MODIFICAR_SERVICIO`(IN PNOMBRE VARCHAR(100),IN PAPP INT,IN PPLATAFORMA INT,IN PSERVIDOR INT,IN ID INT)
BEGIN
UPDATE  SERVICIO
SET DESCRIPCION=PNOMBRE,
	IDAPP=PAPP,
	IDPLATAFORMA=PPLATAFORMA,
    IDSERVIDOR=PSERVIDOR
WHERE IDSERVICIO=ID;    
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `PROC_MODIFICAR_SERVIDOR` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `PROC_MODIFICAR_SERVIDOR`(IN PNOMBRE VARCHAR(100),IN PIP VARCHAR(100), IN PID INT)
BEGIN
	UPDATE SERVIDOR 
    SET NOMBRE=PNOMBRE, DIRECCION_IP=PIP
	WHERE IDSERVIDOR=PID;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `PROC_MODIFICAR_SOLUCION` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `PROC_MODIFICAR_SOLUCION`(IN p1 VARCHAR(100),IN p2 VARCHAR(100),
IN p3 VARCHAR(100),
IN p4 VARCHAR(100))
BEGIN
	UPDATE solucion 
    SET descripcion=p1,
    id_escenario=p2
	WHERE idsolucion=p4;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `PROC_MODIFICAR_TEMA` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `PROC_MODIFICAR_TEMA`(IN p1 VARCHAR(100),IN p2 VARCHAR(100),
IN p3 VARCHAR(100),
IN p4 VARCHAR(100))
BEGIN
	UPDATE tema 
    SET descripcion=p1,
    idservicio=p2
	WHERE idtema=p4;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `PROC_MODIFICAR_TIPO_PLATAFORMA` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `PROC_MODIFICAR_TIPO_PLATAFORMA`(IN PNOMBRE VARCHAR(100), IN PID INT)
BEGIN
	UPDATE TIPO_PLATAFORMA 
    SET DESCRIPCION=PNOMBRE
	WHERE IDTIPO_PLATAFORMA=PID;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `PROC_REPORTE_MODULO1` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `PROC_REPORTE_MODULO1`()
BEGIN
select a.descripcion as servicio,b.descripcion as app,b.start as inicio,b.stop as fin,
c.descripcion as plataforma, d.descripcion as tipo_plataforma, e.nombre as servidor,e.direccion_ip as ip
from servicio a
inner join app b
on a.idapp=b.idapp
inner join plataforma c
on b.idplataforma=c.idplataforma
inner join tipo_plataforma d
on c.idtipo_plataforma=d.idtipo_plataforma
inner join  servidor e
on c.idservidor=e.idservidor;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `PROC_REPORTE_MODULO2` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `PROC_REPORTE_MODULO2`()
BEGIN
	select a.idagenda_mantenimiento as ID,t.razon as MOTIVO_AGENDACION,a.detalle as DETALLE, us.idusuario as RESPONSABLE, d.descripcion as DPTO_AFECTADO, g.descripcion as GRUPO_AFECTADO, ej.motivo As ESTADO
from agenda_mantenimiento a
inner join usuario_agenda u
on a.id_usuario_agenda = u.idusuario_agenda
inner join usuario us
on u.id_responsable = us.idusuario
inner join trabajo t
on a.id_trabajo = t.id_trabajo
inner join  departamento d
on a.id_departamento=d.iddepartamento
inner join  grupo g
on a.id_grupo_afectado = g.idgrupo
inner join  estado_ejecucion ej
on a.id_estado_ejecucion = ej.idestado_ejecucion;

END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `PROC_REPORTE_MODULO3` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `PROC_REPORTE_MODULO3`()
BEGIN
	select a.descripcion as solucion,b.descripcion as escenario,c.descripcion as tema, d.descripcion as servicio
from solucion a
inner join escenario b
on a.id_escenario=b.idescenario
inner join tema c
on b.id_tema=c.idtema
inner join servicio d
on c.idservicio=d.idservicio;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2019-08-25  2:41:25
