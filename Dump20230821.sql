CREATE DATABASE  IF NOT EXISTS `controlpersonalbd` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `controlpersonalbd`;
-- MySQL dump 10.13  Distrib 8.0.34, for Win64 (x86_64)
--
-- Host: localhost    Database: controlpersonalbd
-- ------------------------------------------------------
-- Server version	8.0.34

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
-- Table structure for table `horarios`
--

DROP TABLE IF EXISTS `horarios`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `horarios` (
  `IdHorarios` int NOT NULL AUTO_INCREMENT,
  `JarnadaUsuario` varchar(15) NOT NULL,
  `HorarioEntrada` datetime NOT NULL,
  `HorarioSalida` datetime NOT NULL,
  `IdPersonal` int NOT NULL,
  PRIMARY KEY (`IdHorarios`),
  KEY `IdPersonal` (`IdPersonal`),
  CONSTRAINT `IdPersonal` FOREIGN KEY (`IdPersonal`) REFERENCES `personal` (`IdPersona`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `horarios`
--

LOCK TABLES `horarios` WRITE;
/*!40000 ALTER TABLE `horarios` DISABLE KEYS */;
/*!40000 ALTER TABLE `horarios` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `personal`
--

DROP TABLE IF EXISTS `personal`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `personal` (
  `IdPersona` int NOT NULL AUTO_INCREMENT,
  `NombrePersonal` varchar(45) NOT NULL,
  `ApellidoPersonal` varchar(45) NOT NULL,
  `CargoPersonal` varchar(20) NOT NULL,
  `CorreoPersonal` varchar(45) NOT NULL,
  `Contaseña` varchar(15) NOT NULL,
  PRIMARY KEY (`IdPersona`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `personal`
--

LOCK TABLES `personal` WRITE;
/*!40000 ALTER TABLE `personal` DISABLE KEYS */;
INSERT INTO `personal` VALUES (2,'Michael','Chuchuca','Administrador','michaelchuchuca@yahoo.com','1234'),(3,'Luis','Chuchuca','Administrador','michaelchuchuca@yahoo.com','1234'),(4,'Felix','Barrera','Administador','Fbarrera@yahoo.com','1234'),(5,'Luis','Barrera','Empleado','Luis@yahoo.com','1234'),(6,'Felix','Barrera','Empleado','Felix@yahoo.com','1234'),(7,'Eduardo','Farro','Empleado','Felix@yahoo.com','1234'),(8,'Mariuxi','Tejada','Empleado','Mt@jada.com','1234');
/*!40000 ALTER TABLE `personal` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `registros`
--

DROP TABLE IF EXISTS `registros`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `registros` (
  `IdRegistro` int NOT NULL AUTO_INCREMENT,
  `IdPersona` int NOT NULL,
  `NombreUsuario` varchar(25) NOT NULL,
  `HorarioEntrada` datetime DEFAULT NULL,
  `HorarioSalida` datetime DEFAULT NULL,
  PRIMARY KEY (`IdRegistro`)
) ENGINE=InnoDB AUTO_INCREMENT=26 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `registros`
--

LOCK TABLES `registros` WRITE;
/*!40000 ALTER TABLE `registros` DISABLE KEYS */;
INSERT INTO `registros` VALUES (1,2,'Michael','2023-08-14 13:11:01',NULL),(2,5,'Luis',NULL,'2023-08-14 13:12:20'),(3,2,'Michael','2023-08-14 13:12:34',NULL),(4,6,'Felix','2023-08-14 13:14:31',NULL),(5,7,'Eduardo','2023-08-14 13:14:41',NULL),(6,5,'Luis','2023-08-14 13:14:49',NULL),(7,2,'Michael','2023-08-14 13:27:19',NULL),(8,2,'Michael','2023-08-14 13:30:04',NULL),(9,2,'Michael','2023-08-14 13:31:38',NULL),(10,5,'Luis','2023-08-14 13:34:08',NULL),(11,2,'Michael','2023-08-14 13:34:19',NULL),(12,2,'Michael','2023-08-14 13:35:07',NULL),(13,2,'Michael','2023-08-14 13:37:33',NULL),(14,2,'Michael','2023-08-14 13:38:52',NULL),(15,2,'Michael','2023-08-14 13:39:40',NULL),(16,2,'Michael','2023-08-14 13:43:08',NULL),(17,2,'Michael','2023-08-14 13:46:05',NULL),(18,2,'Michael','2023-08-14 13:48:37',NULL),(19,2,'Michael','2023-08-14 13:49:16',NULL),(20,2,'Michael','2023-08-14 13:52:30',NULL),(21,2,'Michael','2023-08-14 21:36:09',NULL),(22,2,'Michael',NULL,'2023-08-14 21:37:21'),(23,2,'Michael','2023-08-14 21:37:33',NULL),(24,2,'Michael','2023-08-14 21:39:27',NULL),(25,2,'Michael','2023-08-14 21:53:12',NULL);
/*!40000 ALTER TABLE `registros` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2023-08-21 22:10:31
