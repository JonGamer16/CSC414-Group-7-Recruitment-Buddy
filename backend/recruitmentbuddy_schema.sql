-- MySQL dump 10.13  Distrib 8.0.42, for Win64 (x86_64)
--
-- Host: localhost    Database: recruitmentbuddy
-- ------------------------------------------------------
-- Server version	8.0.42

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
-- Table structure for table `answerinterests`
--

DROP TABLE IF EXISTS `answerinterests`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `answerinterests` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `AnswerId` int DEFAULT NULL,
  `Interest` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`Id`),
  KEY `AnswerId` (`AnswerId`),
  CONSTRAINT `answerinterests_ibfk_1` FOREIGN KEY (`AnswerId`) REFERENCES `questionnaireanswers` (`AnswerId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `answerinterests`
--

LOCK TABLES `answerinterests` WRITE;
/*!40000 ALTER TABLE `answerinterests` DISABLE KEYS */;
/*!40000 ALTER TABLE `answerinterests` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `answersubjects`
--

DROP TABLE IF EXISTS `answersubjects`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `answersubjects` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `AnswerId` int DEFAULT NULL,
  `Subject` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`Id`),
  KEY `AnswerId` (`AnswerId`),
  CONSTRAINT `answersubjects_ibfk_1` FOREIGN KEY (`AnswerId`) REFERENCES `questionnaireanswers` (`AnswerId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `answersubjects`
--

LOCK TABLES `answersubjects` WRITE;
/*!40000 ALTER TABLE `answersubjects` DISABLE KEYS */;
/*!40000 ALTER TABLE `answersubjects` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `answerworkplacevalues`
--

DROP TABLE IF EXISTS `answerworkplacevalues`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `answerworkplacevalues` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `AnswerId` int DEFAULT NULL,
  `Value` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`Id`),
  KEY `AnswerId` (`AnswerId`),
  CONSTRAINT `answerworkplacevalues_ibfk_1` FOREIGN KEY (`AnswerId`) REFERENCES `questionnaireanswers` (`AnswerId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `answerworkplacevalues`
--

LOCK TABLES `answerworkplacevalues` WRITE;
/*!40000 ALTER TABLE `answerworkplacevalues` DISABLE KEYS */;
/*!40000 ALTER TABLE `answerworkplacevalues` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `classes`
--

DROP TABLE IF EXISTS `classes`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `classes` (
  `ClassId` int NOT NULL,
  `ClassName` varchar(50) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci DEFAULT NULL,
  PRIMARY KEY (`ClassId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `classes`
--

LOCK TABLES `classes` WRITE;
/*!40000 ALTER TABLE `classes` DISABLE KEYS */;
INSERT INTO `classes` VALUES (1,'Arts and Humanities'),(2,'Fine Arts'),(3,'Music'),(4,'Theatre'),(5,'Literature'),(6,'Philosophy'),(7,'History'),(8,'Art History'),(9,'Business'),(10,'Business Administration'),(11,'Marketing'),(12,'Finance'),(13,'Accounting'),(14,'Management'),(15,'Entrepreneurship'),(16,'International Business'),(17,'-Science and Technology'),(18,'Biology'),(19,'Chemistry'),(20,'Physics'),(21,'Computer Science'),(22,'Information Technology'),(23,'Environmental Science'),(24,'Mathematics'),(25,'Health Sciences'),(26,'Nursing'),(27,'Public Health'),(28,'Pharmacy'),(29,'Physical Therapy'),(30,'Nutrition'),(31,'Occupational Therapy'),(32,'Health Administration'),(33,'Social Sciences'),(34,'Psychology'),(35,'Sociology'),(36,'Political Science'),(37,'Economics'),(38,'Anthropology'),(39,'International Relations'),(40,'Education'),(41,'-Engineering'),(42,'Civil Engineering'),(43,'Mechanical Engineering'),(44,'Electrical Engineering'),(45,'Chemical Engineering'),(46,'Computer Engineering'),(47,'Aerospace Engineering'),(48,'Applied Sciences'),(49,'Graphic Design'),(50,'Culinary Arts'),(51,'Hospitality Management'),(52,'Interior Design'),(53,'Fashion Design'),(54,'Interdisciplinary Studies'),(55,'Women\'s Studies'),(56,'Environmental Studies'),(57,'Ethnic Studies'),(58,'Global Studies');
/*!40000 ALTER TABLE `classes` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `programcareerclusters`
--

DROP TABLE IF EXISTS `programcareerclusters`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `programcareerclusters` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `ProgramId` int DEFAULT NULL,
  `Cluster` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`Id`),
  KEY `ProgramId` (`ProgramId`),
  CONSTRAINT `programcareerclusters_ibfk_1` FOREIGN KEY (`ProgramId`) REFERENCES `programs` (`ProgramId`) ON DELETE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=17 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `programcareerclusters`
--

LOCK TABLES `programcareerclusters` WRITE;
/*!40000 ALTER TABLE `programcareerclusters` DISABLE KEYS */;
INSERT INTO `programcareerclusters` VALUES (1,1,'Information technology'),(2,1,'STEM'),(3,2,'Agriculture, food, and natural resources'),(4,2,'Business management and administration'),(5,3,'Arts, audio/video technology, and communication'),(6,3,'Marketing, sales, and service'),(7,4,'Health science'),(8,5,'Education and training'),(9,6,'Finance'),(10,6,'Business management and administration'),(11,7,'STEM'),(12,7,'Manufacturing'),(13,8,'Law, public safety, corrections, and security'),(14,9,'Hospitality and tourism'),(15,10,'Agriculture, food, and natural resources'),(16,10,'STEM');
/*!40000 ALTER TABLE `programcareerclusters` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `programs`
--

DROP TABLE IF EXISTS `programs`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `programs` (
  `ProgramId` int NOT NULL AUTO_INCREMENT,
  `Name` varchar(255) DEFAULT NULL,
  `EducationLevel` varchar(255) DEFAULT NULL,
  `ClassEnv` varchar(50) DEFAULT NULL,
  `SocialEnergy` varchar(50) DEFAULT NULL,
  `Mind` varchar(50) DEFAULT NULL,
  `Nature` varchar(50) DEFAULT NULL,
  `Tactics` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`ProgramId`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `programs`
--

LOCK TABLES `programs` WRITE;
/*!40000 ALTER TABLE `programs` DISABLE KEYS */;
INSERT INTO `programs` VALUES (1,'Computer Science - BS','Bachelor\'s Degree','online','introvert','intuitive','thinking','judging'),(2,'Agriculture Business - AS','Associate Degree','hybrid','ambivert','observant','feeling','prospecting'),(3,'Digital Media Arts - BA','Bachelor\'s Degree','all on campus','extravert','neutral mind','neutral nature','neutral tactics'),(4,'Nursing - BSN','Bachelor\'s Degree','hybrid','ambivert','observant','feeling','judging'),(5,'Elementary Education - BA','Bachelor\'s Degree','all on campus','extravert','neutral mind','feeling','judging'),(6,'Accounting - AAS','Associate Degree','online','introvert','observant','thinking','judging'),(7,'Mechanical Engineering - BS','Bachelor\'s Degree','full time','introvert','intuitive','thinking','judging'),(8,'Criminal Justice - BA','Bachelor\'s Degree','online','ambivert','observant','thinking','neutral tactics'),(9,'Hospitality Management - AS','Associate Degree','part time','extravert','neutral mind','feeling','prospecting'),(10,'Environmental Science - BS','Bachelor\'s Degree','hybrid','introvert','intuitive','feeling','prospecting');
/*!40000 ALTER TABLE `programs` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `programsubjects`
--

DROP TABLE IF EXISTS `programsubjects`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `programsubjects` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `ProgramId` int DEFAULT NULL,
  `Subject` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`Id`),
  KEY `ProgramId` (`ProgramId`),
  CONSTRAINT `programsubjects_ibfk_1` FOREIGN KEY (`ProgramId`) REFERENCES `programs` (`ProgramId`) ON DELETE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=24 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `programsubjects`
--

LOCK TABLES `programsubjects` WRITE;
/*!40000 ALTER TABLE `programsubjects` DISABLE KEYS */;
INSERT INTO `programsubjects` VALUES (1,1,'Math'),(2,1,'Science'),(3,2,'Science'),(4,2,'Math'),(5,3,'Arts'),(6,3,'English'),(7,3,'Music'),(8,4,'Science'),(9,4,'English'),(10,5,'English'),(11,5,'History'),(12,5,'Math'),(13,6,'Math'),(14,6,'English'),(15,7,'Math'),(16,7,'Science'),(17,8,'History'),(18,8,'English'),(19,9,'English'),(20,9,'Math'),(21,9,'Sports'),(22,10,'Science'),(23,10,'Math');
/*!40000 ALTER TABLE `programsubjects` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `programworkplacevalues`
--

DROP TABLE IF EXISTS `programworkplacevalues`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `programworkplacevalues` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `ProgramId` int DEFAULT NULL,
  `ValueName` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`Id`),
  KEY `ProgramId` (`ProgramId`),
  CONSTRAINT `programworkplacevalues_ibfk_1` FOREIGN KEY (`ProgramId`) REFERENCES `programs` (`ProgramId`) ON DELETE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=31 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `programworkplacevalues`
--

LOCK TABLES `programworkplacevalues` WRITE;
/*!40000 ALTER TABLE `programworkplacevalues` DISABLE KEYS */;
INSERT INTO `programworkplacevalues` VALUES (1,1,'independence'),(2,1,'good pay and benefits'),(3,1,'growth opportunities'),(4,2,'consistency'),(5,2,'low stress'),(6,2,'meaningful work'),(7,3,'peer connections'),(8,3,'creativity'),(9,3,'work-life balance'),(10,4,'meaningful work'),(11,4,'security'),(12,4,'growth opportunities'),(13,5,'collaboration'),(14,5,'peer connections'),(15,5,'meaningful work'),(16,6,'consistency'),(17,6,'security'),(18,6,'good pay and benefits'),(19,7,'good pay and benefits'),(20,7,'growth opportunities'),(21,7,'low stress'),(22,8,'security'),(23,8,'meaningful work'),(24,8,'independence'),(25,9,'peer connections'),(26,9,'low stress'),(27,9,'work-life balance'),(28,10,'meaningful work'),(29,10,'growth opportunities'),(30,10,'collaboration');
/*!40000 ALTER TABLE `programworkplacevalues` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `questionnaireanswers`
--

DROP TABLE IF EXISTS `questionnaireanswers`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `questionnaireanswers` (
  `AnswerId` int NOT NULL AUTO_INCREMENT,
  `UserId` int DEFAULT NULL,
  `EducationLevel` varchar(50) DEFAULT NULL,
  `PersonalityType` varchar(50) DEFAULT NULL,
  `OtherPersonality` text,
  `ProgramType` varchar(50) DEFAULT NULL,
  `Comments` text,
  PRIMARY KEY (`AnswerId`),
  KEY `UserId` (`UserId`),
  CONSTRAINT `questionnaireanswers_ibfk_1` FOREIGN KEY (`UserId`) REFERENCES `users` (`UserId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `questionnaireanswers`
--

LOCK TABLES `questionnaireanswers` WRITE;
/*!40000 ALTER TABLE `questionnaireanswers` DISABLE KEYS */;
/*!40000 ALTER TABLE `questionnaireanswers` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `users`
--

DROP TABLE IF EXISTS `users`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `users` (
  `UserId` int NOT NULL AUTO_INCREMENT,
  `Username` varchar(50) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci DEFAULT NULL,
  `PasswordHash` varchar(50) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci NOT NULL,
  PRIMARY KEY (`UserId`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `users`
--

LOCK TABLES `users` WRITE;
/*!40000 ALTER TABLE `users` DISABLE KEYS */;
INSERT INTO `users` VALUES (1,'testuser','1234');
/*!40000 ALTER TABLE `users` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2025-04-30 19:51:32
