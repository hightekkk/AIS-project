-- MySQL dump 10.19  Distrib 10.2.41-MariaDB, for Linux (x86_64)
--
-- Host: localhost    Database: aero
-- ------------------------------------------------------
-- Server version	10.2.41-MariaDB-cll-lve

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `admins`
--

DROP TABLE IF EXISTS `admins`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `admins` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `login` varchar(20) COLLATE utf8mb4_unicode_ci NOT NULL,
  `password` varchar(20) COLLATE utf8mb4_unicode_ci NOT NULL,
  UNIQUE KEY `id` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `admins`
--

LOCK TABLES `admins` WRITE;
/*!40000 ALTER TABLE `admins` DISABLE KEYS */;
INSERT INTO `admins` VALUES (1,'admin','admin'),(2,'admin1','admin1');
/*!40000 ALTER TABLE `admins` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `avtobus`
--

DROP TABLE IF EXISTS `avtobus`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `avtobus` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `avt` varchar(20) NOT NULL,
  `mesta` int(50) NOT NULL,
  `nomer` varchar(30) NOT NULL,
  UNIQUE KEY `id` (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=10 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `avtobus`
--

LOCK TABLES `avtobus` WRITE;
/*!40000 ALTER TABLE `avtobus` DISABLE KEYS */;
INSERT INTO `avtobus` VALUES (5,'ПАЗ',20,'1111'),(9,'Луаз',25,'3333'),(8,'Икарус',50,'2222');
/*!40000 ALTER TABLE `avtobus` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `avtobus1`
--

DROP TABLE IF EXISTS `avtobus1`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `avtobus1` (
  `id_avto` int(11) NOT NULL AUTO_INCREMENT,
  `avto` varchar(11) COLLATE utf8mb4_unicode_ci NOT NULL,
  `nomer` int(20) NOT NULL,
  `mesta` int(11) NOT NULL,
  PRIMARY KEY (`id_avto`),
  UNIQUE KEY `nomer` (`nomer`)
) ENGINE=InnoDB AUTO_INCREMENT=28 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `avtobus1`
--

LOCK TABLES `avtobus1` WRITE;
/*!40000 ALTER TABLE `avtobus1` DISABLE KEYS */;
INSERT INTO `avtobus1` VALUES (7,'ЛиАЗ',1843,30),(8,'ПАЗ',4821,15),(9,'Икарус',8491,50),(10,'ЗИЛ',7139,16),(11,'Мерседес',9501,20),(25,'Автобус',1456,14);
/*!40000 ALTER TABLE `avtobus1` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `confirm_users`
--

DROP TABLE IF EXISTS `confirm_users`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `confirm_users` (
  `id` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `email` varchar(255) CHARACTER SET utf8 COLLATE utf8_unicode_ci NOT NULL,
  `token` varchar(255) CHARACTER SET utf8 COLLATE utf8_unicode_ci NOT NULL,
  `date_registration` datetime NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=20 DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `confirm_users`
--

LOCK TABLES `confirm_users` WRITE;
/*!40000 ALTER TABLE `confirm_users` DISABLE KEYS */;
/*!40000 ALTER TABLE `confirm_users` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `map`
--

DROP TABLE IF EXISTS `map`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `map` (
  `id` int(10) NOT NULL AUTO_INCREMENT,
  `name` varchar(255) COLLATE utf8mb4_unicode_ci NOT NULL,
  `point` varchar(255) COLLATE utf8mb4_unicode_ci NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `map`
--

LOCK TABLES `map` WRITE;
/*!40000 ALTER TABLE `map` DISABLE KEYS */;
INSERT INTO `map` VALUES (1,'Мира 23','55.417695,55.533042'),(2,'Кирова 18','55.410632,55.542187');
/*!40000 ALTER TABLE `map` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `marshrut`
--

DROP TABLE IF EXISTS `marshrut`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `marshrut` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `id_reis` int(11) DEFAULT NULL,
  `id_av` int(11) NOT NULL,
  `id_vod` int(11) NOT NULL,
  `otkuda` varchar(30) COLLATE utf8mb4_unicode_ci NOT NULL,
  `kuda` varchar(30) COLLATE utf8mb4_unicode_ci NOT NULL,
  `dateotp` datetime NOT NULL,
  `dateprib` datetime NOT NULL,
  `price` int(10) NOT NULL,
  `mestost` int(20) DEFAULT NULL,
  `avto` varchar(30) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  UNIQUE KEY `id` (`id`),
  KEY `id_av` (`id_av`),
  KEY `id_vod` (`id_vod`),
  KEY `id_reis` (`id_reis`),
  CONSTRAINT `marshrut_ibfk_1` FOREIGN KEY (`id_reis`) REFERENCES `reis` (`id`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `marshrut`
--

LOCK TABLES `marshrut` WRITE;
/*!40000 ALTER TABLE `marshrut` DISABLE KEYS */;
INSERT INTO `marshrut` VALUES (1,1,5,0,'Питер','Сочи','2022-05-19 12:00:00','2022-05-20 11:00:00',3000,23,'Луаз'),(2,2,0,0,'Уфа','Смоленск','2022-05-17 00:00:00','2022-05-18 00:00:00',2000,16,'ПАЗ'),(3,3,0,0,'Питер','Бирск','2022-05-17 00:00:00','2022-05-18 00:00:00',1500,50,'Икарус'),(4,1,0,0,'Питер','Сочи','2022-05-17 00:00:00','2022-05-18 00:00:00',1500,48,'Икарус'),(5,4,0,0,'Новгород','Москва','2022-05-19 01:00:00','2022-05-20 21:00:00',560,25,'Луаз'),(6,5,0,0,'Казань','Уфа','2022-05-19 14:55:00','2022-05-18 11:11:00',1200,15,'ПАЗ'),(7,6,0,0,'Бирск','Уфа','2022-05-19 08:58:46','2022-05-19 11:11:46',400,0,'ПАЗ'),(10,7,0,0,'Бирск','Нефтекамск','2022-05-21 12:13:39','2022-05-21 12:13:39',400,20,'ПАЗ');
/*!40000 ALTER TABLE `marshrut` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `marshrut1`
--

DROP TABLE IF EXISTS `marshrut1`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `marshrut1` (
  `id_marsh` int(11) NOT NULL AUTO_INCREMENT,
  `id_reis` int(23) NOT NULL,
  `id_avt` int(23) DEFAULT NULL,
  `id_vod` int(11) DEFAULT NULL,
  `status` varchar(11) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `description` varchar(100) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  PRIMARY KEY (`id_marsh`),
  KEY `id_reisa` (`id_reis`),
  KEY `id_avt` (`id_avt`),
  KEY `id_vod` (`id_vod`),
  CONSTRAINT `marshrut1_ibfk_1` FOREIGN KEY (`id_reis`) REFERENCES `reis1` (`id_reisa`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `marshrut1_ibfk_2` FOREIGN KEY (`id_avt`) REFERENCES `avtobus1` (`id_avto`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `marshrut1_ibfk_3` FOREIGN KEY (`id_vod`) REFERENCES `voditeli1` (`id`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=24 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `marshrut1`
--

LOCK TABLES `marshrut1` WRITE;
/*!40000 ALTER TABLE `marshrut1` DISABLE KEYS */;
INSERT INTO `marshrut1` VALUES (20,9,7,6,'Отменён','Плохая погода'),(22,11,8,7,'Отменён','Поломка автобуса'),(23,10,11,8,NULL,NULL);
/*!40000 ALTER TABLE `marshrut1` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `reis`
--

DROP TABLE IF EXISTS `reis`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `reis` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `number` int(11) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `reis`
--

LOCK TABLES `reis` WRITE;
/*!40000 ALTER TABLE `reis` DISABLE KEYS */;
INSERT INTO `reis` VALUES (1,94734),(2,58302),(3,46732),(4,68942),(5,46384),(6,45215),(7,10458),(8,35740),(9,96358);
/*!40000 ALTER TABLE `reis` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `reis1`
--

DROP TABLE IF EXISTS `reis1`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `reis1` (
  `id_reisa` int(11) NOT NULL AUTO_INCREMENT,
  `number` int(11) NOT NULL,
  `otkuda` varchar(20) COLLATE utf8mb4_unicode_ci NOT NULL,
  `kuda` varchar(20) COLLATE utf8mb4_unicode_ci NOT NULL,
  `dateotp` date NOT NULL,
  `timeotp` time NOT NULL,
  `dateprib` date NOT NULL,
  `timeprib` time NOT NULL,
  `mestost` int(11) NOT NULL,
  `price` int(11) NOT NULL,
  PRIMARY KEY (`id_reisa`)
) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `reis1`
--

LOCK TABLES `reis1` WRITE;
/*!40000 ALTER TABLE `reis1` DISABLE KEYS */;
INSERT INTO `reis1` VALUES (9,222,'Бирск','Уфа','2022-06-22','10:34:46','2022-06-22','10:34:46',26,300),(10,333,'Уфа','Бирск','2022-06-23','10:35:37','2022-06-23','10:35:37',19,300),(11,444,'Бирск','Казань','2022-06-24','10:37:48','2022-06-25','10:37:48',15,700);
/*!40000 ALTER TABLE `reis1` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `ticket`
--

DROP TABLE IF EXISTS `ticket`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `ticket` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `reis` int(11) NOT NULL,
  `avto` varchar(30) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL,
  `mesto` int(20) NOT NULL,
  `otkuda` varchar(30) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL,
  `kuda` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL,
  `last_name` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL,
  `first_name` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL,
  `mail` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL,
  UNIQUE KEY `id` (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=56 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ticket`
--

LOCK TABLES `ticket` WRITE;
/*!40000 ALTER TABLE `ticket` DISABLE KEYS */;
INSERT INTO `ticket` VALUES (1,0,'cx',1,'cx','cx','','',''),(3,0,'cx',0,'cx','cx','','',''),(4,0,'cx',0,'cx','cx','','',''),(5,0,'',0,'','','','',''),(6,0,'',0,'','','','',''),(7,0,'ЛуАЗ',1,'','','','',''),(8,0,'ЛуАЗ',1,'','','','',''),(9,0,'ЛуАЗ',1,'Питер','','','',''),(10,0,'ЛуАЗ',1,'Питер','Сочи','','',''),(11,0,'ЛуАЗ',1,'Питер','Сочи','','',''),(12,0,'ЛуАЗ',1,'Питер','Сочи','','',''),(13,0,'ЛуАЗ',1,'Питер','Сочи','','',''),(14,0,'',1,'Новгород','Москва','','',''),(15,0,'ЛуАЗ',1,'Питер','Сочи','','',''),(16,0,'ЛуАЗ',1,'Питер','Сочи','','',''),(17,0,'ЛуАЗ',1,'Питер','Сочи','Арвфыоа','Аилвоым','antonkocher@bk.ru'),(18,0,'ПАЗ',1,'Бирск','Нефтекамск','Арвфыоа','Аилвоым',''),(19,0,'',1,'Бирск','Нефтекамск','Арвфыоа','Аилвоым',''),(20,0,'ПАЗ',20,'Казань','Уфа','Арвфыоа','Аилвоым',''),(21,0,'ПАЗ',20,'Казань','Уфа','Арвфыоа','Аилвоым',''),(22,0,'ПАЗ',20,'Казань','Уфа','Арвфыоа','Аилвоым',''),(23,0,'ПАЗ',19,'Казань','Уфа','Арвфыоа','Аилвоым',''),(24,0,'ПАЗ',18,'Казань','Уфа','Арвфыоа','Аилвоым',''),(46,0,'Икарус',49,'Питер','Сочи','','',''),(45,0,'Икарус',50,'Питер','Сочи','','',''),(55,46384,'ПАЗ',16,'Казань','Уфа','Иванов','Иван','ben4tech@bk.ru'),(35,0,'ПАЗ',11,'Бирск','Уфа','Иванов','Иван','ben4tech@bk.ru'),(36,0,'ПАЗ',10,'Бирск','Уфа','Иванов','Иван','ben4tech@bk.ru'),(37,0,'ПАЗ',9,'Бирск','Уфа','Иванов','Иван','ben4tech@bk.ru'),(38,0,'ПАЗ',8,'Бирск','Уфа','Иванов','Иван','ben4tech@bk.ru'),(39,0,'ПАЗ',7,'Бирск','Уфа','Иванов','Иван','ben4tech@bk.ru'),(40,0,'ПАЗ',6,'Бирск','Уфа','Иванов','Иван','ben4tech@bk.ru'),(41,0,'ПАЗ',5,'Бирск','Уфа','Иванов','Иван','ben4tech@bk.ru'),(42,0,'ПАЗ',4,'Бирск','Уфа','Иванов','Иван','ben4tech@bk.ru'),(43,0,'ПАЗ',3,'Бирск','Уфа','Иванов','Иван','ben4tech@bk.ru'),(44,0,'ПАЗ',2,'Бирск','Уфа','Иванов','Иван','ben4tech@bk.ru'),(47,0,'ПАЗ',1,'Бирск','Уфа','Иванов','Иван','ben4tech@bk.ru'),(48,0,'ПАЗ',20,'Уфа','Смоленск','Иванов','Иван','ben4tech@bk.ru'),(49,0,'ПАЗ',19,'Уфа','Смоленск','Иванов','Иван','ben4tech@bk.ru'),(50,58302,'ПАЗ',18,'Уфа','Смоленск','Иванов','Иван','ben4tech@bk.ru'),(51,58302,'ПАЗ',17,'Уфа','Смоленск','Иванов','Иван','ben4tech@bk.ru'),(52,46384,'ПАЗ',17,'Казань','Уфа','Иванов','Иван','ben4tech@bk.ru'),(53,94734,'Луаз',25,'Питер','Сочи','Иванов','Иван','ben4tech@bk.ru'),(54,94734,'Луаз',24,'Питер','Сочи','Иванов','Иван','ben4tech@bk.ru');
/*!40000 ALTER TABLE `ticket` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `ticket1`
--

DROP TABLE IF EXISTS `ticket1`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `ticket1` (
  `id_ticket` int(11) NOT NULL AUTO_INCREMENT,
  `id_mar` int(11) NOT NULL,
  `mesto` int(15) NOT NULL,
  `last_name` varchar(30) COLLATE utf8mb4_unicode_ci NOT NULL,
  `first_name` varchar(30) COLLATE utf8mb4_unicode_ci NOT NULL,
  `email` varchar(30) COLLATE utf8mb4_unicode_ci NOT NULL,
  `status` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`id_ticket`),
  KEY `id_marsh` (`id_mar`),
  KEY `id_mar` (`id_mar`),
  CONSTRAINT `ticket1_ibfk_1` FOREIGN KEY (`id_mar`) REFERENCES `marshrut1` (`id_marsh`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=75 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ticket1`
--

LOCK TABLES `ticket1` WRITE;
/*!40000 ALTER TABLE `ticket1` DISABLE KEYS */;
INSERT INTO `ticket1` VALUES (69,20,1,'Иванов','Иван','vkr1111@bk.ru',NULL),(70,20,2,'Петров','Пётр','vkr2222@bk.ru',NULL),(72,20,3,'Вострецов','Савелий','vkr2000@bk.ru',1),(73,20,4,'Вострецов','Савелий','vkr2000@bk.ru',NULL),(74,23,1,'Б','А','gmnott@mail.ru',1);
/*!40000 ALTER TABLE `ticket1` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `users`
--

DROP TABLE IF EXISTS `users`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `users` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `first_name` varchar(50) COLLATE utf8mb4_unicode_ci NOT NULL,
  `last_name` varchar(50) COLLATE utf8mb4_unicode_ci NOT NULL,
  `email` varchar(50) COLLATE utf8mb4_unicode_ci NOT NULL,
  `email_status` tinyint(1) NOT NULL DEFAULT 0,
  `password` varchar(30) COLLATE utf8mb4_unicode_ci NOT NULL,
  `mobile` int(30) NOT NULL,
  `date_registration` datetime NOT NULL,
  `reset_password_token` varchar(100) CHARACTER SET utf8 COLLATE utf8_unicode_ci NOT NULL,
  `login` varchar(30) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  UNIQUE KEY `id` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=22 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `users`
--

LOCK TABLES `users` WRITE;
/*!40000 ALTER TABLE `users` DISABLE KEYS */;
INSERT INTO `users` VALUES (12,'Аилвоым','Арвфыоа','antonkocher@bk.ru',1,'12345678',2147483647,'2022-05-18 10:21:11','2d078564339ccc2cc20fd11f0112bc84',NULL),(14,'Иван','Иванов','ben4tech@bk.ru',1,'12345678',2147483647,'2022-05-21 10:55:10','d026a9328eccb0c20a4fefd27c24f492',NULL),(16,'Мария','Кирова','odri.dinn@gmail.com',1,'123456789',2147483647,'2022-06-20 16:46:41','',NULL),(20,'Савелий','Вострецов','vkr2000@bk.ru',1,'1234567',2147483647,'2022-06-21 14:17:19','',NULL),(21,'А','Б','gmnott@mail.ru',1,'9346936',9346936,'2022-06-24 16:23:25','',NULL);
/*!40000 ALTER TABLE `users` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `voditeli`
--

DROP TABLE IF EXISTS `voditeli`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `voditeli` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `first_name` varchar(20) COLLATE utf8mb4_unicode_ci NOT NULL,
  `last_name` varchar(20) COLLATE utf8mb4_unicode_ci NOT NULL,
  UNIQUE KEY `id` (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=7 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `voditeli`
--

LOCK TABLES `voditeli` WRITE;
/*!40000 ALTER TABLE `voditeli` DISABLE KEYS */;
INSERT INTO `voditeli` VALUES (1,'Михаил','Петров'),(5,'drgdfg','dgdfgfd'),(6,'drgdfg','dgdfgfd');
/*!40000 ALTER TABLE `voditeli` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `voditeli1`
--

DROP TABLE IF EXISTS `voditeli1`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `voditeli1` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(20) COLLATE utf8mb4_unicode_ci NOT NULL,
  `lastname` varchar(20) COLLATE utf8mb4_unicode_ci NOT NULL,
  `passport` int(10) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `voditeli1`
--

LOCK TABLES `voditeli1` WRITE;
/*!40000 ALTER TABLE `voditeli1` DISABLE KEYS */;
INSERT INTO `voditeli1` VALUES (6,'Петр','Петров',758395713),(7,'Никита','Федоров',984617384),(8,'Николай','Безруков',658193745),(11,'Водительь','Водителевв',13689436);
/*!40000 ALTER TABLE `voditeli1` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2022-07-20 13:08:52
