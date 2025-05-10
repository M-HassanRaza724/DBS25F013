-- MySQL dump 10.13  Distrib 8.0.41, for Win64 (x86_64)
--
-- Host: localhost    Database: db_final_project
-- ------------------------------------------------------
-- Server version	8.0.41

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
-- Dumping data for table `admins`
--

LOCK TABLES `admins` WRITE;
/*!40000 ALTER TABLE `admins` DISABLE KEYS */;
/*!40000 ALTER TABLE `admins` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping data for table `customers`
--

LOCK TABLES `customers` WRITE;
/*!40000 ALTER TABLE `customers` DISABLE KEYS */;
INSERT INTO `customers` VALUES (1,1,'Muhammad Hassan Raza');
/*!40000 ALTER TABLE `customers` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping data for table `department`
--

LOCK TABLES `department` WRITE;
/*!40000 ALTER TABLE `department` DISABLE KEYS */;
/*!40000 ALTER TABLE `department` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping data for table `employee_assignation`
--

LOCK TABLES `employee_assignation` WRITE;
/*!40000 ALTER TABLE `employee_assignation` DISABLE KEYS */;
/*!40000 ALTER TABLE `employee_assignation` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping data for table `employees`
--

LOCK TABLES `employees` WRITE;
/*!40000 ALTER TABLE `employees` DISABLE KEYS */;
INSERT INTO `employees` VALUES (1,'Ali Ahmad','03210000009','2025-05-04',51,2);
/*!40000 ALTER TABLE `employees` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping data for table `invoice`
--

LOCK TABLES `invoice` WRITE;
/*!40000 ALTER TABLE `invoice` DISABLE KEYS */;
/*!40000 ALTER TABLE `invoice` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping data for table `lookups`
--

LOCK TABLES `lookups` WRITE;
/*!40000 ALTER TABLE `lookups` DISABLE KEYS */;
INSERT INTO `lookups` VALUES (0,'default','default'),(1,'1','admin'),(49,'designation','Deleted Employee'),(50,'designation','Data Scientist'),(51,'designation','Full Stack Developer'),(52,'designation','FrontEnd Developer'),(53,'designation','BackEnd Developer'),(54,'designation','UI/UX Designer'),(55,'designation','QA Engineer'),(56,'designation','DevOps Engineer'),(57,'designation','Project Manager'),(58,'designation','Product Owner'),(59,'user_role','Employee'),(60,'user_role','Admin'),(61,'user_role','Department Head'),(62,'platform','Web'),(63,'platform','Android'),(64,'platform','iOS'),(65,'platform','Windows'),(66,'platform','macOS'),(67,'platform','Linux'),(68,'platform','Cross-platform'),(69,'platform','Hybrid'),(70,'status','Pending'),(71,'status','In-Progress'),(72,'status','Completed'),(73,'status','Cancelled'),(74,'status','On-Hold'),(75,'status','Rejected'),(76,'budget_type','<$5000'),(77,'budget_type','$5000-$20000'),(78,'budget_type','$20000-$50000'),(79,'budget_type','$50000+'),(80,'payment_status','Pending'),(81,'payment_status','Partially Paid'),(82,'payment_status','Paid'),(83,'payment_status','Overdue'),(84,'payment_status','Cancelled'),(85,'admin_role','Super Admin'),(86,'admin_role','Support Admin'),(87,'admin_role','Billing Admin'),(88,'service_category','Development'),(89,'service_category','Design'),(90,'service_category','Testing'),(91,'service_category','Consulting'),(92,'priority','Low'),(93,'priority','Medium'),(94,'priority','High'),(95,'priority','Critical'),(96,'user_role','Customer');
/*!40000 ALTER TABLE `lookups` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping data for table `orderdetails`
--

LOCK TABLES `orderdetails` WRITE;
/*!40000 ALTER TABLE `orderdetails` DISABLE KEYS */;
INSERT INTO `orderdetails` VALUES (5,8,1,'stationary store website for my stationary store',76,62);
/*!40000 ALTER TABLE `orderdetails` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping data for table `orders`
--

LOCK TABLES `orders` WRITE;
/*!40000 ALTER TABLE `orders` DISABLE KEYS */;
INSERT INTO `orders` VALUES (8,NULL,1,'2025-05-08 19:00:00',70);
/*!40000 ALTER TABLE `orders` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping data for table `reviews`
--

LOCK TABLES `reviews` WRITE;
/*!40000 ALTER TABLE `reviews` DISABLE KEYS */;
/*!40000 ALTER TABLE `reviews` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping data for table `salary`
--

LOCK TABLES `salary` WRITE;
/*!40000 ALTER TABLE `salary` DISABLE KEYS */;
/*!40000 ALTER TABLE `salary` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping data for table `serviceinvolved`
--

LOCK TABLES `serviceinvolved` WRITE;
/*!40000 ALTER TABLE `serviceinvolved` DISABLE KEYS */;
INSERT INTO `serviceinvolved` VALUES (1,'Regular maintenance, updates, troubleshooting, tech support'),(2,'Functional testing, performance testing, security testing, automation testing'),(3,'App design, web design, brand identity, product design'),(4,'Business apps, social networking apps, gaming apps, utility apps'),(5,'E-commerce sites, CMS solutions, landing pages, corporate websites'),(6,'Business applications, enterprise software, process automation, custom tool development');
/*!40000 ALTER TABLE `serviceinvolved` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping data for table `services`
--

LOCK TABLES `services` WRITE;
/*!40000 ALTER TABLE `services` DISABLE KEYS */;
INSERT INTO `services` VALUES (1,'IT Consulting and Support',0,'We provide expert IT consulting to help you strategize, plan, and implement effective technology solutions.'),(2,'Quality Assurance & Testing',0,'We conduct rigorous testing to ensure your software is bug-free, reliable, and optimized for performance.'),(3,'UI/UX Design',0,'We craft intuitive, aesthetic, and functional user interfaces for your applications and websites, ensuring a great user experience.'),(4,'Mobile App Development',0,'We specialize in developing user-friendly mobile applications for both iOS and Android platforms.'),(5,'Web Development',0,'We build responsive, scalable, and engaging websites to help you establish a robust online presence.'),(6,'Custom Software Development',0,'Our team creates custom software solutions to address your specific business requirements, improving productivity and streamlining operations.');
/*!40000 ALTER TABLE `services` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping data for table `servicetechnologies`
--

LOCK TABLES `servicetechnologies` WRITE;
/*!40000 ALTER TABLE `servicetechnologies` DISABLE KEYS */;
INSERT INTO `servicetechnologies` VALUES (3,'User research, wireframing, prototyping, testing'),(4,'Swift, Kotlin, Flutter, React Native'),(5,'HTML5, CSS3, JavaScript, React, Node.js, PHP'),(6,'C++, Java, Python, .NET');
/*!40000 ALTER TABLE `servicetechnologies` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping data for table `specialprojects`
--

LOCK TABLES `specialprojects` WRITE;
/*!40000 ALTER TABLE `specialprojects` DISABLE KEYS */;
/*!40000 ALTER TABLE `specialprojects` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping data for table `users`
--

LOCK TABLES `users` WRITE;
/*!40000 ALTER TABLE `users` DISABLE KEYS */;
INSERT INTO `users` VALUES (1,'hassana18200','hassan@gmail.com','123###',96),(2,'ali123','ali@gmail.com','123###',59);
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

-- Dump completed on 2025-05-10 15:43:48
