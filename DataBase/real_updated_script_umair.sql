-- MySQL dump 10.13  Distrib 8.0.40, for Win64 (x86_64)
--
-- Host: localhost    Database: db_final_project
-- ------------------------------------------------------
-- Server version	8.0.40

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
-- Table structure for table `admins`
--

DROP TABLE IF EXISTS `admins`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `admins` (
  `admin_id` int NOT NULL AUTO_INCREMENT,
  `user_id` int NOT NULL,
  `name` varchar(255) NOT NULL,
  `phone` varchar(20) DEFAULT NULL,
  `admin_role` int DEFAULT '0',
  PRIMARY KEY (`admin_id`),
  KEY `admin_role` (`admin_role`),
  KEY `user_id` (`user_id`),
  CONSTRAINT `admins_ibfk_1` FOREIGN KEY (`admin_role`) REFERENCES `lookups` (`lookup_id`) ON DELETE SET NULL,
  CONSTRAINT `admins_ibfk_2` FOREIGN KEY (`user_id`) REFERENCES `users` (`user_id`) ON DELETE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `admins`
--

LOCK TABLES `admins` WRITE;
/*!40000 ALTER TABLE `admins` DISABLE KEYS */;
INSERT INTO `admins` VALUES (1,19,'Farhan','03361234567',21);
/*!40000 ALTER TABLE `admins` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `customers`
--

DROP TABLE IF EXISTS `customers`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `customers` (
  `customer_id` int NOT NULL AUTO_INCREMENT,
  `user_id` int DEFAULT NULL,
  `name` varchar(45) NOT NULL,
  PRIMARY KEY (`customer_id`),
  KEY `user_id` (`user_id`),
  CONSTRAINT `customers_ibfk_1` FOREIGN KEY (`user_id`) REFERENCES `users` (`user_id`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `customers`
--

LOCK TABLES `customers` WRITE;
/*!40000 ALTER TABLE `customers` DISABLE KEYS */;
INSERT INTO `customers` VALUES (4,11,'Junaid'),(6,31,'Dora');
/*!40000 ALTER TABLE `customers` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `department`
--

DROP TABLE IF EXISTS `department`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `department` (
  `department_id` int NOT NULL AUTO_INCREMENT,
  `department_name` varchar(100) NOT NULL,
  `service_id` int NOT NULL,
  `user_id` int NOT NULL,
  PRIMARY KEY (`department_id`),
  UNIQUE KEY `department_name` (`department_name`),
  KEY `service_id` (`service_id`),
  KEY `user_id` (`user_id`),
  CONSTRAINT `department_ibfk_1` FOREIGN KEY (`service_id`) REFERENCES `services` (`service_id`) ON DELETE CASCADE,
  CONSTRAINT `department_ibfk_2` FOREIGN KEY (`user_id`) REFERENCES `users` (`user_id`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `department`
--

LOCK TABLES `department` WRITE;
/*!40000 ALTER TABLE `department` DISABLE KEYS */;
/*!40000 ALTER TABLE `department` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Temporary view structure for view `departmentoverview`
--

DROP TABLE IF EXISTS `departmentoverview`;
/*!50001 DROP VIEW IF EXISTS `departmentoverview`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `departmentoverview` AS SELECT 
 1 AS `department_id`,
 1 AS `department_name`,
 1 AS `service_name`,
 1 AS `head_name`,
 1 AS `employee_count`*/;
SET character_set_client = @saved_cs_client;

--
-- Table structure for table `employee_assignation`
--

DROP TABLE IF EXISTS `employee_assignation`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `employee_assignation` (
  `assign_id` int NOT NULL AUTO_INCREMENT,
  `employee_id` int DEFAULT '0',
  `order_id` int NOT NULL,
  PRIMARY KEY (`assign_id`),
  UNIQUE KEY `employee_id` (`employee_id`,`order_id`),
  KEY `order_id` (`order_id`),
  CONSTRAINT `employee_assignation_ibfk_1` FOREIGN KEY (`employee_id`) REFERENCES `employees` (`employee_id`) ON DELETE SET NULL,
  CONSTRAINT `employee_assignation_ibfk_2` FOREIGN KEY (`order_id`) REFERENCES `orders` (`order_id`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `employee_assignation`
--

LOCK TABLES `employee_assignation` WRITE;
/*!40000 ALTER TABLE `employee_assignation` DISABLE KEYS */;
/*!40000 ALTER TABLE `employee_assignation` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `employees`
--

DROP TABLE IF EXISTS `employees`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `employees` (
  `employee_id` int NOT NULL AUTO_INCREMENT,
  `name` varchar(255) NOT NULL,
  `phone` varchar(20) DEFAULT NULL,
  `joined_date` date NOT NULL DEFAULT (curdate()),
  `designation_id` int DEFAULT NULL,
  `user_id` int DEFAULT NULL,
  PRIMARY KEY (`employee_id`),
  KEY `designation_id` (`designation_id`),
  KEY `fk_user_id` (`user_id`),
  CONSTRAINT `employees_ibfk_1` FOREIGN KEY (`designation_id`) REFERENCES `lookups` (`lookup_id`) ON DELETE SET NULL,
  CONSTRAINT `fk_user_id` FOREIGN KEY (`user_id`) REFERENCES `users` (`user_id`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `employees`
--

LOCK TABLES `employees` WRITE;
/*!40000 ALTER TABLE `employees` DISABLE KEYS */;
INSERT INTO `employees` VALUES (1,'Farhan','03368656100','2022-02-02',18,19),(2,'Zeshan','0336123456','2020-02-02',19,35),(6,'Shahid','03210909909','2025-05-08',20,7);
/*!40000 ALTER TABLE `employees` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Temporary view structure for view `get_admins_info`
--

DROP TABLE IF EXISTS `get_admins_info`;
/*!50001 DROP VIEW IF EXISTS `get_admins_info`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `get_admins_info` AS SELECT 
 1 AS `Username`,
 1 AS `Email`,
 1 AS `Name`,
 1 AS `Phone`,
 1 AS `Role`*/;
SET character_set_client = @saved_cs_client;

--
-- Temporary view structure for view `get_customers_info`
--

DROP TABLE IF EXISTS `get_customers_info`;
/*!50001 DROP VIEW IF EXISTS `get_customers_info`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `get_customers_info` AS SELECT 
 1 AS `CustomerName`,
 1 AS `Email`,
 1 AS `OrdersBooked`,
 1 AS `TotalSpending`,
 1 AS `AverageRating`*/;
SET character_set_client = @saved_cs_client;

--
-- Temporary view structure for view `get_employees_info`
--

DROP TABLE IF EXISTS `get_employees_info`;
/*!50001 DROP VIEW IF EXISTS `get_employees_info`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `get_employees_info` AS SELECT 
 1 AS `Username`,
 1 AS `EmployeeName`,
 1 AS `Phone`,
 1 AS `JoinedDate`,
 1 AS `Designation`,
 1 AS `OrdersCompleted`,
 1 AS `Salary`,
 1 AS `TotalAmountPaidAsBonus`*/;
SET character_set_client = @saved_cs_client;

--
-- Temporary view structure for view `get_services`
--

DROP TABLE IF EXISTS `get_services`;
/*!50001 DROP VIEW IF EXISTS `get_services`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `get_services` AS SELECT 
 1 AS `service_id`,
 1 AS `name`,
 1 AS `category_id`,
 1 AS `description`,
 1 AS `service_involved`,
 1 AS `technology`*/;
SET character_set_client = @saved_cs_client;

--
-- Table structure for table `invoice`
--

DROP TABLE IF EXISTS `invoice`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `invoice` (
  `invoice_id` int NOT NULL AUTO_INCREMENT,
  `order_id` int NOT NULL,
  `price` decimal(12,2) NOT NULL,
  `payment_status_id` int DEFAULT '0',
  `due_date` date NOT NULL,
  `created_at` timestamp NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`invoice_id`),
  KEY `order_id` (`order_id`),
  KEY `payment_status_id` (`payment_status_id`),
  KEY `idx_due_date` (`due_date`),
  CONSTRAINT `invoice_ibfk_1` FOREIGN KEY (`order_id`) REFERENCES `orders` (`order_id`) ON DELETE CASCADE,
  CONSTRAINT `invoice_ibfk_2` FOREIGN KEY (`payment_status_id`) REFERENCES `lookups` (`lookup_id`) ON DELETE SET NULL
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `invoice`
--

LOCK TABLES `invoice` WRITE;
/*!40000 ALTER TABLE `invoice` DISABLE KEYS */;
INSERT INTO `invoice` VALUES (1,1,10500.00,15,'2025-05-06','2025-05-04 19:00:00'),(2,2,12000.00,15,'2025-05-06','2025-05-04 19:00:00');
/*!40000 ALTER TABLE `invoice` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `lookups`
--

DROP TABLE IF EXISTS `lookups`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `lookups` (
  `lookup_id` int NOT NULL AUTO_INCREMENT,
  `key_group` varchar(100) NOT NULL,
  `value` varchar(100) NOT NULL,
  PRIMARY KEY (`lookup_id`)
) ENGINE=InnoDB AUTO_INCREMENT=49 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `lookups`
--

LOCK TABLES `lookups` WRITE;
/*!40000 ALTER TABLE `lookups` DISABLE KEYS */;
INSERT INTO `lookups` VALUES (1,'user_role','Admin'),(2,'user_role','Customer'),(3,'user_role','Employee'),(4,'service','Web development'),(5,'service','Game development'),(6,'service','Android app development'),(7,'service','Cloud-computing based development'),(8,'service','Artificial intelligence models'),(9,'service','Machine learning models'),(10,'service','Enterprise app development'),(11,'service','IOT app development'),(12,'order','Work in progress'),(13,'order','Completed'),(14,'order','Cancelled'),(15,'payment','Paid'),(16,'payment','Pending'),(17,'employee_designation','Supervisor'),(18,'employee_designation','Software engineer'),(19,'employee_designation','Data scientist'),(20,'employee_designation','Game developer'),(21,'admin_role','Primary admin'),(22,'admin_role','Secondary admin');
/*!40000 ALTER TABLE `lookups` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `orderdetails`
--

DROP TABLE IF EXISTS `orderdetails`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `orderdetails` (
  `order_detail_id` int NOT NULL AUTO_INCREMENT,
  `order_id` int NOT NULL,
  `service_id` int DEFAULT '0',
  `initial_budget_id` int DEFAULT NULL,
  `platform_id` int DEFAULT '0',
  PRIMARY KEY (`order_detail_id`),
  KEY `initial_budget_id` (`initial_budget_id`),
  KEY `order_id` (`order_id`),
  KEY `platform_id` (`platform_id`),
  KEY `idx_orderdetails_service` (`service_id`),
  CONSTRAINT `orderdetails_ibfk_1` FOREIGN KEY (`initial_budget_id`) REFERENCES `lookups` (`lookup_id`) ON DELETE SET NULL,
  CONSTRAINT `orderdetails_ibfk_2` FOREIGN KEY (`order_id`) REFERENCES `orders` (`order_id`) ON DELETE CASCADE,
  CONSTRAINT `orderdetails_ibfk_3` FOREIGN KEY (`service_id`) REFERENCES `services` (`service_id`) ON DELETE SET NULL,
  CONSTRAINT `orderdetails_ibfk_4` FOREIGN KEY (`platform_id`) REFERENCES `lookups` (`lookup_id`) ON DELETE SET NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `orderdetails`
--

LOCK TABLES `orderdetails` WRITE;
/*!40000 ALTER TABLE `orderdetails` DISABLE KEYS */;
/*!40000 ALTER TABLE `orderdetails` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `orders`
--

DROP TABLE IF EXISTS `orders`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `orders` (
  `order_id` int NOT NULL AUTO_INCREMENT,
  `employee_id` int DEFAULT '0',
  `user_id` int DEFAULT '0',
  `created_at` timestamp NULL DEFAULT CURRENT_TIMESTAMP,
  `status_id` int DEFAULT '0',
  PRIMARY KEY (`order_id`),
  KEY `employee_id` (`employee_id`),
  KEY `user_id` (`user_id`),
  KEY `idx_orders_status` (`status_id`),
  CONSTRAINT `orders_ibfk_1` FOREIGN KEY (`employee_id`) REFERENCES `employees` (`employee_id`) ON DELETE SET NULL,
  CONSTRAINT `orders_ibfk_2` FOREIGN KEY (`user_id`) REFERENCES `users` (`user_id`) ON DELETE SET NULL,
  CONSTRAINT `orders_ibfk_3` FOREIGN KEY (`status_id`) REFERENCES `lookups` (`lookup_id`) ON DELETE SET NULL
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `orders`
--

LOCK TABLES `orders` WRITE;
/*!40000 ALTER TABLE `orders` DISABLE KEYS */;
INSERT INTO `orders` VALUES (1,1,31,'2025-05-06 03:28:00',12),(2,1,31,'2024-06-06 04:00:00',13),(3,2,11,'2020-09-09 03:08:00',12);
/*!40000 ALTER TABLE `orders` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `reviews`
--

DROP TABLE IF EXISTS `reviews`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `reviews` (
  `review_id` int NOT NULL AUTO_INCREMENT,
  `order_id` int NOT NULL,
  `reviewer_name` varchar(255) NOT NULL,
  `stars` int NOT NULL,
  `date` date NOT NULL,
  `description` text NOT NULL,
  PRIMARY KEY (`review_id`),
  KEY `order_id` (`order_id`),
  CONSTRAINT `reviews_ibfk_1` FOREIGN KEY (`order_id`) REFERENCES `orders` (`order_id`) ON DELETE CASCADE,
  CONSTRAINT `reviews_chk_1` CHECK ((`stars` between 1 and 5))
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `reviews`
--

LOCK TABLES `reviews` WRITE;
/*!40000 ALTER TABLE `reviews` DISABLE KEYS */;
INSERT INTO `reviews` VALUES (1,1,'Dora',4,'2025-05-06','Good service.'),(2,2,'Dora',3,'2025-05-06','Connection issues.');
/*!40000 ALTER TABLE `reviews` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `salary`
--

DROP TABLE IF EXISTS `salary`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `salary` (
  `salary_id` int NOT NULL AUTO_INCREMENT,
  `employee_id` int NOT NULL,
  `pay_date` date NOT NULL,
  `amount` decimal(12,2) NOT NULL,
  `bonus` decimal(10,2) DEFAULT '0.00',
  PRIMARY KEY (`salary_id`),
  KEY `employee_id` (`employee_id`),
  KEY `idx_pay_date` (`pay_date`),
  CONSTRAINT `salary_ibfk_1` FOREIGN KEY (`employee_id`) REFERENCES `employees` (`employee_id`) ON DELETE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=1911 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `salary`
--

LOCK TABLES `salary` WRITE;
/*!40000 ALTER TABLE `salary` DISABLE KEYS */;
INSERT INTO `salary` VALUES (1,2,'2025-05-08',50000.00,0.00),(2,1,'2025-01-10',75000.00,1000.00);
/*!40000 ALTER TABLE `salary` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `serviceinvolved`
--

DROP TABLE IF EXISTS `serviceinvolved`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `serviceinvolved` (
  `service_id` int NOT NULL,
  `service_involved` varchar(255) NOT NULL,
  PRIMARY KEY (`service_id`,`service_involved`),
  CONSTRAINT `serviceinvolved_ibfk_1` FOREIGN KEY (`service_id`) REFERENCES `services` (`service_id`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `serviceinvolved`
--

LOCK TABLES `serviceinvolved` WRITE;
/*!40000 ALTER TABLE `serviceinvolved` DISABLE KEYS */;
INSERT INTO `serviceinvolved` VALUES (2,''),(3,''),(4,''),(5,''),(11,'Android integration'),(12,''),(13,'Sensor-sentient applications');
/*!40000 ALTER TABLE `serviceinvolved` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `services`
--

DROP TABLE IF EXISTS `services`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `services` (
  `service_id` int NOT NULL AUTO_INCREMENT,
  `name` varchar(255) NOT NULL,
  `category_id` int DEFAULT '0',
  `description` text NOT NULL,
  PRIMARY KEY (`service_id`),
  UNIQUE KEY `name` (`name`),
  KEY `idx_services_category` (`category_id`),
  CONSTRAINT `services_ibfk_1` FOREIGN KEY (`category_id`) REFERENCES `lookups` (`lookup_id`) ON DELETE SET NULL
) ENGINE=InnoDB AUTO_INCREMENT=16 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `services`
--

LOCK TABLES `services` WRITE;
/*!40000 ALTER TABLE `services` DISABLE KEYS */;
INSERT INTO `services` VALUES (2,'website building',4,'To create good websites'),(3,'Battle royal games for PC',5,'Building BR games for PC.'),(4,'AI model training',8,'AI model training for businesses'),(5,'Machine learning ',9,'Machine learning using advanced models'),(11,'Mailing applications',10,'Applications with email services'),(12,'Songs applications development',10,'Apps for songs'),(13,'Arduino-based applications',11,'Applications reequiring hardware integration.');
/*!40000 ALTER TABLE `services` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `servicetechnologies`
--

DROP TABLE IF EXISTS `servicetechnologies`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `servicetechnologies` (
  `service_id` int NOT NULL,
  `technology` varchar(255) NOT NULL,
  PRIMARY KEY (`service_id`,`technology`),
  CONSTRAINT `servicetechnologies_ibfk_1` FOREIGN KEY (`service_id`) REFERENCES `services` (`service_id`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `servicetechnologies`
--

LOCK TABLES `servicetechnologies` WRITE;
/*!40000 ALTER TABLE `servicetechnologies` DISABLE KEYS */;
INSERT INTO `servicetechnologies` VALUES (2,''),(3,''),(4,''),(5,''),(11,'Dart'),(12,''),(13,'Arduino, C++');
/*!40000 ALTER TABLE `servicetechnologies` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `specialprojects`
--

DROP TABLE IF EXISTS `specialprojects`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `specialprojects` (
  `sp_id` int NOT NULL AUTO_INCREMENT,
  `order_id` int NOT NULL,
  `title` varchar(255) NOT NULL,
  PRIMARY KEY (`sp_id`),
  KEY `order_id` (`order_id`),
  CONSTRAINT `specialprojects_ibfk_1` FOREIGN KEY (`order_id`) REFERENCES `orders` (`order_id`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `specialprojects`
--

LOCK TABLES `specialprojects` WRITE;
/*!40000 ALTER TABLE `specialprojects` DISABLE KEYS */;
/*!40000 ALTER TABLE `specialprojects` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `users`
--

DROP TABLE IF EXISTS `users`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `users` (
  `user_id` int NOT NULL AUTO_INCREMENT,
  `username` varchar(255) NOT NULL,
  `email` varchar(255) NOT NULL,
  `password` varchar(255) NOT NULL,
  `role_id` int NOT NULL,
  PRIMARY KEY (`user_id`),
  UNIQUE KEY `email` (`email`),
  KEY `role_id` (`role_id`),
  KEY `idx_username` (`username`),
  CONSTRAINT `users_ibfk_1` FOREIGN KEY (`role_id`) REFERENCES `lookups` (`lookup_id`) ON DELETE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=45 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `users`
--

LOCK TABLES `users` WRITE;
/*!40000 ALTER TABLE `users` DISABLE KEYS */;
INSERT INTO `users` VALUES (2,'ali123','ali123@gmail.com','123456',2),(4,'2e','2l','2d',2),(5,'ahmad123','ahmad@gmail.com','123456',2),(6,'asghar123','asghar123@gmail.com','123456',2),(7,'shahid123','shahid@gmail.com','123456',2),(8,'rehan123','rehan123@gmail.com','123456',2),(10,'sarah123','sarah123@gmail.com','123456d',2),(11,'junaid123','junaid123@gmail.com','123456',2),(19,'farhan','farhan123@gmail.com','098',1),(31,'dora123','dora123@gmail.com','321',2),(34,'kamran123','kaaamran123@gmail.com','098',2),(35,'zeshan123','zeshan123@gmail.com','888',3);
/*!40000 ALTER TABLE `users` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping events for database 'db_final_project'
--

--
-- Dumping routines for database 'db_final_project'
--
/*!50003 DROP PROCEDURE IF EXISTS `sp_get_admin_role` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_get_admin_role`(IN p_admin_id INT)
BEGIN
	SELECT l.value
    FROM admins a
    JOIN lookups l ON l.lookup_id = a.admin_role
    WHERE a.admin_id = p_admin_id;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `sp_get_employee_salary` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_get_employee_salary`(IN p_employee_id INT)
BEGIN
	SELECT *
    FROM salary s
    WHERE s.employee_id = p_employee_id;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `sp_get_lookup_id` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_get_lookup_id`(IN p_key_group VARCHAR (100), IN p_value VARCHAR(100))
BEGIN
	SELECT lookup_id
    FROM lookups
    WHERE key_group = p_key_group AND value = p_value;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `sp_get_user_by_role` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_get_user_by_role`(IN user_role VARCHAR(50))
BEGIN
	IF user_role = 'admin' THEN
		SELECT * FROM users NATURAL JOIN admins;
	ELSEIF user_role = 'employee' THEN
		SELECT * FROM users NATURAL JOIN employees;
	ELSEIF user_role = 'customer' THEN
		SELECT * FROM users NATURAL JOIN customers;
	END IF;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `sp_manage_admin` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_manage_admin`(
	IN operation_type VARCHAR(20),
    IN p_admin_id INT,
    IN p_user_id INT,
    IN p_name VARCHAR(255),
    IN p_phone VARCHAR(20),
    IN p_admin_role INT
)
BEGIN
	IF operation_type = 'add' THEN
		INSERT INTO admins VALUES (p_admin_id, p_user_id, p_name, p_phone, p_admin_role);
	ELSEIF operation_type = 'update' THEN
		UPDATE admins SET name = p_name, phone = p_phone WHERE admin_id = p_admin_id;
	ELSEIF operation_type = 'delete' THEN
		DELETE FROM admins WHERE admin_id = p_admin_id;
	END IF;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `sp_manage_customer` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_manage_customer`(
	IN operation_type VARCHAR(20),
    IN p_customer_id INT,
    IN p_user_id INT, 
    IN p_name VARCHAR(45)
)
BEGIN
	IF operation_type = 'add' THEN 
		INSERT INTO customers(customer_id, user_id, name) VALUES(p_customer_id, p_user_id, p_name);
	ELSEIF operation_type = 'update' THEN
		UPDATE customers SET name = p_name WHERE customer_id = p_customer_id;
	ELSEIF operation_type = 'delete' THEN
		DELETE FROM customers WHERE customer_id = p_customer_id;
	END IF;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `sp_manage_employee` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_manage_employee`(
	IN operation_type VARCHAR(20),
    IN p_employee_id INT,
    IN p_name VARCHAR(255),
    IN p_phone VARCHAR(20),
    IN p_joined_date DATE,
    IN p_designation_id INT,
    IN p_user_id INT
)
BEGIN
	IF operation_type = 'add' THEN
		INSERT INTO employees VALUES(p_employee_id, p_name, p_phone, p_joined_date, p_designation_id, p_user_id);
	ELSEIF operation_type = 'update' THEN
		UPDATE employees SET name = p_name, phone = p_phone WHERE employee_id = p_employee_id;
	ELSEIF operation_type = 'delete' THEN
		DELETE FROM employees WHERE employee_id = p_employee_id;
	END IF;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `sp_manage_salary` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_manage_salary`(
	IN operation_type VARCHAR (20),
    IN p_salary_id INT,
    IN p_employee_id INT,
    IN p_pay_date DATE,
    IN p_amount DECIMAL(12, 2),
    IN p_bonus DECIMAL(10, 2)
)
BEGIN 
	IF operation_type = 'add' THEN	
		INSERT INTO salary(employee_id, pay_date, amount, bonus) VALUES (p_employee_id, p_pay_date, p_amount, p_bonus);
	ELSEIF operation_type = 'update' THEN
		UPDATE salary SET pay_date = p_pay_date, amount = p_amount, bonus = p_bonus WHERE salary_id = p_salary_id;
	ELSEIF operation_type = 'delete' THEN
		DELETE FROM salary WHERE salary_id = p_salary_id;
	END IF;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `sp_manage_service` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_manage_service`(
	IN operation_type VARCHAR(20),
    IN p_service_id INT,
    IN p_name VARCHAR(255),
    IN p_category_id INT,
    IN p_description TEXT
)
BEGIN 
	IF operation_type = 'add' THEN
		INSERT INTO services(name, category_id, description) VALUES (p_name, p_category_id, p_description);
	ELSEIF operation_type = 'update' THEN 
		UPDATE services SET name = p_name, description = p_description WHERE service_id = p_service_id;
	ELSEIF operation_type = 'delete' THEN
		DELETE FROM services WHERE service_id = p_service_id;
	END IF;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `sp_manage_subservice` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_manage_subservice`(
	IN operation_type VARCHAR(20),
    IN p_service_id INT,
    IN p_service_involved VARCHAR(255)
)
BEGIN
	IF operation_type = 'add' THEN
		INSERT INTO serviceinvolved VALUES (p_service_id, p_service_involved);
	ELSEIF operation_type = 'update' THEN
		UPDATE serviceinvolved SET service_involved = p_service_involved WHERE service_id = p_service_id;
	ELSEIF operation_type = 'delete' THEN
		DELETE FROM serviceinvolved WHERE service_id = p_service_id;
	END IF;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `sp_manage_technology` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_manage_technology`(
	IN operation_type VARCHAR(20),
    IN p_service_id INT,
    IN p_technology VARCHAR(255)
)
BEGIN
	IF operation_type = 'add' THEN 
		INSERT INTO servicetechnologies VALUES (p_service_id, p_technology);
	ELSEIF operation_type = 'update' THEN
		UPDATE servicetechnologies SET technology = p_technology WHERE service_id = p_service_id;
	ELSEIF operation_type = 'delete' THEN 
		DELETE FROM servicetechnologies WHERE service_id = p_service_id;
	END IF;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `sp_manage_user` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_manage_user`(
	IN operation_type VARCHAR(20),
    IN p_user_id INT,
    IN p_username VARCHAR(255),
    IN p_email VARCHAR(255),
    IN p_password VARCHAR(255),
    IN p_role_id INT
)
BEGIN
	IF operation_type = 'add' THEN
		INSERT INTO users(username, email, password, role_id) VALUES (p_username, p_email, p_password, p_role_id);
	ELSEIF operation_type = 'update' THEN
		UPDATE users SET users.email = p_email, users.password = p_password WHERE users.user_id = p_user_id;
	ELSEIF operation_type = 'delete' THEN
		DELETE FROM users WHERE users.user_id = p_user_id;
	END IF;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;

--
-- Final view structure for view `departmentoverview`
--

/*!50001 DROP VIEW IF EXISTS `departmentoverview`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `departmentoverview` AS select `d`.`department_id` AS `department_id`,`d`.`department_name` AS `department_name`,`s`.`name` AS `service_name`,`u`.`username` AS `head_name`,count(`e`.`employee_id`) AS `employee_count` from (((`department` `d` join `services` `s` on((`d`.`service_id` = `s`.`service_id`))) join `users` `u` on((`d`.`user_id` = `u`.`user_id`))) left join `employees` `e` on(`e`.`designation_id` in (select `lookups`.`lookup_id` from `lookups` where (`lookups`.`key_group` = 'designation')))) group by `d`.`department_id` */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `get_admins_info`
--

/*!50001 DROP VIEW IF EXISTS `get_admins_info`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `get_admins_info` AS select `u`.`username` AS `Username`,`u`.`email` AS `Email`,`a`.`name` AS `Name`,`a`.`phone` AS `Phone`,`l`.`value` AS `Role` from ((`users` `u` join `admins` `a` on((`u`.`user_id` = `a`.`user_id`))) join `lookups` `l` on((`l`.`lookup_id` = `a`.`admin_role`))) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `get_customers_info`
--

/*!50001 DROP VIEW IF EXISTS `get_customers_info`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `get_customers_info` AS select `c`.`name` AS `CustomerName`,min(`u`.`email`) AS `Email`,count(`o`.`order_id`) AS `OrdersBooked`,cast(coalesce(sum(`i`.`price`),0) as double) AS `TotalSpending`,cast(coalesce(avg(`r`.`stars`),0) as double) AS `AverageRating` from ((((`users` `u` join `customers` `c` on((`u`.`user_id` = `c`.`user_id`))) left join `orders` `o` on((`o`.`user_id` = `u`.`user_id`))) left join `reviews` `r` on((`r`.`order_id` = `o`.`order_id`))) left join `invoice` `i` on((`i`.`order_id` = `o`.`order_id`))) group by `c`.`customer_id` */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `get_employees_info`
--

/*!50001 DROP VIEW IF EXISTS `get_employees_info`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `get_employees_info` AS select min(`u`.`username`) AS `Username`,min(`e`.`name`) AS `EmployeeName`,min(`e`.`phone`) AS `Phone`,min(`e`.`joined_date`) AS `JoinedDate`,min(`l`.`value`) AS `Designation`,min((select count(`o1`.`order_id`) from `orders` `o1` where ((`o1`.`employee_id` = `e`.`employee_id`) and (`o1`.`status_id` = 13)))) AS `OrdersCompleted`,round(avg(`s`.`amount`),2) AS `Salary`,round(sum(distinct `s`.`bonus`),2) AS `TotalAmountPaidAsBonus` from ((((`users` `u` join `employees` `e` on((`u`.`user_id` = `e`.`user_id`))) left join `lookups` `l` on((`l`.`lookup_id` = `e`.`designation_id`))) left join `orders` `o` on((`o`.`employee_id` = `e`.`employee_id`))) left join `salary` `s` on((`s`.`employee_id` = `e`.`employee_id`))) group by `e`.`employee_id` */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `get_services`
--

/*!50001 DROP VIEW IF EXISTS `get_services`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `get_services` AS select `s`.`service_id` AS `service_id`,`s`.`name` AS `name`,`s`.`category_id` AS `category_id`,`s`.`description` AS `description`,`si`.`service_involved` AS `service_involved`,`st`.`technology` AS `technology` from ((`services` `s` left join `serviceinvolved` `si` on((`si`.`service_id` = `s`.`service_id`))) left join `servicetechnologies` `st` on((`st`.`service_id` = `s`.`service_id`))) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2025-05-10  0:11:58
