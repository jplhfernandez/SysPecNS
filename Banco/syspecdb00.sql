-- MariaDB dump 10.19  Distrib 10.4.25-MariaDB, for Win64 (AMD64)
--
-- Host: localhost    Database: syspecdb
-- ------------------------------------------------------
-- Server version	10.4.25-MariaDB

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
-- Table structure for table `caixas`
--

DROP TABLE IF EXISTS `caixas`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `caixas` (
  `id` int(4) NOT NULL AUTO_INCREMENT,
  `usuario_id` int(4) NOT NULL,
  `data_abertura` datetime NOT NULL,
  `saldo_inicial` decimal(10,2) NOT NULL,
  `status` char(1) NOT NULL DEFAULT 'A',
  PRIMARY KEY (`id`),
  KEY `fk_Caixa_Usuarios1_idx` (`usuario_id`),
  CONSTRAINT `fk_Caixa_Usuarios1` FOREIGN KEY (`usuario_id`) REFERENCES `usuarios` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `caixas`
--

LOCK TABLES `caixas` WRITE;
/*!40000 ALTER TABLE `caixas` DISABLE KEYS */;
/*!40000 ALTER TABLE `caixas` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `categorias`
--

DROP TABLE IF EXISTS `categorias`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `categorias` (
  `id` int(4) NOT NULL AUTO_INCREMENT,
  `nome` varchar(40) NOT NULL,
  `sigla` char(3) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=490 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `categorias`
--

LOCK TABLES `categorias` WRITE;
/*!40000 ALTER TABLE `categorias` DISABLE KEYS */;
INSERT INTO `categorias` VALUES (246,'Missangas & Confecção de Joias',NULL),(247,'Decoração de tecidos',NULL),(248,'Tricô & Suprimentos de Crochê',NULL),(249,'Suprimentos para impressão',NULL),(250,'Estamparia de Suprimentos',NULL),(251,'Produtos de Costura',NULL),(252,'Artesanato & Hobby Tecido',NULL),(253,'Suprimentos para agulhas',NULL),(254,'Artes, Ofícios e Costura',NULL),(255,'Pintura, Desenho e Suprimentos de Arte',NULL),(256,'Suprimentos Artesanais e Materiais',NULL),(257,'Suprimentos para embrulho de presente',NULL),(258,'Decorações de Festa',NULL),(259,'Tintas Automotivas e Suprimentos para Ti',NULL),(260,'Equipamentos para Serviços Pesados e Veí',NULL),(261,'Pneus Automotivos e Rodas',NULL),(262,'Ferramentas Automotivas e Equipamentos',NULL),(263,'Peças e Acessórios de Performance Automo',NULL),(264,'Cuidados com o carro',NULL),(265,'Óleos e Fluidos',NULL),(266,'Peças de Reposição Automotivas',NULL),(267,'Luzes, Lâmpadas e Indicadores',NULL),(268,'Acessórios para interiores automotivos',NULL),(269,'Acessórios Automotivos Externos',NULL),(270,'Mercadoria para entusiastas automotivos',NULL),(271,'Eletrônica Automotiva e Acessórios',NULL),(272,'RV Parts &Acessórios',NULL),(273,'Motocicleta',NULL),(274,'Produtos para Fraldas para Bebês',NULL),(275,'Suprimentos de alimentação para bebês',NULL),(276,'Gravidez & Produtos para Maternidade',NULL),(277,'Cadeirinhas para Carros de Segurança Inf',NULL),(278,'Produtos de segurança para bebês',NULL),(279,'Produtos para treinamento de toalete',NULL),(280,'Produtos para Cuidados com o Bebê',NULL),(281,'Equipamento de viagem para bebés',NULL),(282,'Atividade do bebê e produtos de entreten',NULL),(283,'Presentes de Bebê',NULL),(284,'Papelaria para Bebês',NULL),(285,'Mobiliário de Creche, Roupa de Cama e De',NULL),(286,'Bebê',NULL),(287,'Infantil Roupas e Calçados',NULL),(288,'Carrinhos de bebê e acessórios',NULL),(289,'Beleza e Cuidados Pessoais',NULL),(290,'Perfumes e Fragrâncias',NULL),(291,'Produtos para cuidados com o cabelo',NULL),(292,'Maquiagem',NULL),(293,'Produtos de cuidados da pele',NULL),(294,'Ferramentas de Beleza e Acessórios',NULL),(295,'Produtos para Cuidados com Pé, Mão e Unh',NULL),(296,'Produtos de Higiene Pessoal',NULL),(297,'Produtos de barbear e depilação',NULL),(298,'Servidores de Computador',NULL),(299,'Armazenamento de dados',NULL),(300,'Monitores de computador',NULL),(301,'Computadores & Tablets',NULL),(302,'Peças de reposição de comprimidos',NULL),(303,'Redes de Computadores',NULL),(304,'Componentes do computador',NULL),(305,'Acessórios para Tablets',NULL),(306,'Acessórios para laptop',NULL),(307,'Componentes externos do computador',NULL),(308,'Tecnologia vestível',NULL),(309,'Televisores e Produtos de Vídeo',NULL),(310,'GPS & Navegação',NULL),(311,'Fones de ouvido & Earbuds',NULL),(312,'Eletrônica de Escritório',NULL),(313,'Áudio portátil & Vídeo',NULL),(314,'Leitores de eBook e Acessórios',NULL),(315,'Celulares e Acessórios',NULL),(316,'Acessórios e Suprimentos',NULL),(317,'Projetores de vídeo',NULL),(318,'Eletrônica veicular',NULL),(319,'Câmera & Foto',NULL),(320,'Segurança e Equipamentos de Vigilância',NULL),(321,'Computadores',NULL),(322,'Home Áudio e Produtos de Teatro',NULL),(323,'Consoles de videogame e acessórios',NULL),(324,'Roupas para Meninos',NULL),(325,'Acessórios para Meninos',NULL),(326,'Joias para meninos',NULL),(327,'Relógios para Meninos',NULL),(328,'Sapatos para Meninos',NULL),(329,'Roupas Femininas',NULL),(330,'Acessórios para Meninas',NULL),(331,'Joias Femininas',NULL),(332,'Relógios para Meninas',NULL),(333,'Sapatos Femininos',NULL),(334,'Uniformes Escolares para Meninas',NULL),(335,'Bolsas de viagem',NULL),(336,'Sacolas de Viagem',NULL),(337,'Sacos de Vestuário',NULL),(338,'Conjuntos de Bagagem',NULL),(339,'Malas',NULL),(340,'Acessórios de Viagem',NULL),(341,'Guarda-chuvas',NULL),(342,'Mochilas',NULL),(343,'Bagagem',NULL),(344,'Bolsas para laptop',NULL),(345,'Vestuário Masculino',NULL),(346,'Acessórios Masculinos',NULL),(347,'Relógios Masculinos',NULL),(348,'Calçados Masculinos',NULL),(349,'Vestuário Feminino',NULL),(350,'Bolsas Femininas',NULL),(351,'Acessórios Femininos',NULL),(352,'Relógios Femininos',NULL),(353,'Calçados Femininos',NULL),(354,'Joias Femininas',NULL),(355,'Mobiliário Infantil',NULL),(356,'Cartões-presente',NULL),(357,'Produtos de higiene bucal',NULL),(358,'Produtos Visão',NULL),(359,'Produtos de Bem-Estar e Relaxamento',NULL),(360,'Produtos para Cuidados com o Bebê e Cria',NULL),(361,'Suprimentos Domésticos',NULL),(362,'Produtos para cuidados com a saúde',NULL),(363,'Dieta & Nutrição Esportiva',NULL),(364,'Suprimentos Médicos de Uso Doméstico e E',NULL),(365,'Produtos de bem-estar sexual',NULL),(366,'Saúde e Domicílio',NULL),(367,'Produtos de Nutrição Esportiva',NULL),(368,'Papelaria & Suprimentos para Embrulho de',NULL),(369,'Produtos para Portas Comerciais',NULL),(370,'Produtos de Transmissão de Energia',NULL),(371,'Materiais Industriais',NULL),(372,'Industrial Hardware',NULL),(373,'Produtos Abrasivos e de Acabamento',NULL),(374,'Adesivos Industriais, Selantes e Lubrifi',NULL),(375,'Produtos para Movimentação de Materiais',NULL),(376,'Testar, Medir e Inspecionar',NULL),(377,'Energia Industrial & Ferramentas Manuais',NULL),(378,'Hidráulica, Pneumática e Hidráulica',NULL),(379,'Filtração',NULL),(380,'Componentes Eletrônicos',NULL),(381,'Laboratório e Produtos Científicos',NULL),(382,'Zeladoria e Abastecimento de Saneamento',NULL),(383,'Produtos de Segurança e Saúde Ocupaciona',NULL),(384,'Ferramentas de Corte',NULL),(385,'Fixadores',NULL),(386,'Materiais para Educação Científica',NULL),(387,'Equipamentos de Food Service e Supriment',NULL),(388,'Produtos de Manufatura Aditiva',NULL),(389,'Suprimentos médicos profissionais',NULL),(390,'Suprimentos Odontológicos Profissionais',NULL),(391,'Embalagem e Envio de Suprimentos',NULL),(392,'Equipamentos para lojas de varejo e equi',NULL),(393,'Industrial e Científica',NULL),(394,'Produtos de Banho',NULL),(395,'Roupa de cama',NULL),(396,'Home decoração Produtos',NULL),(397,'Mobiliário',NULL),(398,'Material de limpeza doméstica',NULL),(399,'Iluminação Doméstica e Ventiladores de T',NULL),(400,'Cozinha e Jantar',NULL),(401,'Aquecimento, Resfriamento e Qualidade do',NULL),(402,'Loja Infantil em Casa',NULL),(403,'Armazenamento doméstico & Organização',NULL),(404,'Arte de parede',NULL),(405,'Aspiradores de pó e cuidados com o piso',NULL),(406,'Produtos de Engomadoria',NULL),(407,'Suprimentos para Festas',NULL),(408,'Suprimentos para pássaros de estimação',NULL),(409,'Suprimentos Cat',NULL),(410,'Suprimentos para cães',NULL),(411,'Peixes e Animais de Estimação Aquáticos',NULL),(412,'Suprimentos para cavalos',NULL),(413,'Répteis e suprimentos para anfíbios',NULL),(414,'Suprimentos para Pequenos Animais',NULL),(415,'Casa Inteligente: Novos Dispositivos Int',NULL),(416,'Casa Inteligente: Assistentes de Voz e H',NULL),(417,'Casa Inteligente: Fechaduras Inteligente',NULL),(418,'Casa Inteligente: Entretenimento Domésti',NULL),(419,'Casa Inteligente: Wi-Fi e Rede',NULL),(420,'Casa Inteligente: Câmeras e Sistemas de ',NULL),(421,'Casa Inteligente: Iluminação',NULL),(422,'Casa Inteligente: Plugues e Tomadas',NULL),(423,'Casa Inteligente: Aspiradores e Mops',NULL),(424,'Termostatos domésticos inteligentes - Ve',NULL),(425,'Casa Inteligente: Gramado e Jardim',NULL),(426,'Casa Inteligente: Outras Soluções',NULL),(427,'Casa Inteligente - Aquecimento e Refrige',NULL),(428,'Esportes & Fitness',NULL),(429,'Recreação ao ar livre',NULL),(430,'Esportes & Ar Livre',NULL),(431,'Eletrodomésticos',NULL),(432,'Bombas e Equipamentos Hidráulicos',NULL),(433,'Pintura, Tratamentos de Parede e Suprime',NULL),(434,'Segurança & Segurança',NULL),(435,'Lâmpadas',NULL),(436,'Ferramentas Elétricas & Ferramentas Manu',NULL),(437,'Utensílios de cozinha e banho',NULL),(438,'Iluminação & Ventiladores de Teto',NULL),(439,'Equipamentos Elétricos',NULL),(440,'Hardware',NULL),(441,'Material de Construção',NULL),(442,'Medição & Layout',NULL),(443,'Solda & Solda',NULL),(444,'Ferramentas',NULL),(445,'Suprimentos para festas infantis',NULL),(446,'Figuras de Brinquedo e Conjuntos de jogo',NULL),(447,'Novidade Brinquedos & Diversões',NULL),(448,'Suprimentos de Artes e Artesanato',NULL),(449,'Brinquedos de construção',NULL),(450,'Bonecas e Acessórios',NULL),(451,'Eletrônica Infantil',NULL),(452,'Jogos & Acessórios',NULL),(453,'Brinquedos de Aprendizagem e Educação',NULL),(454,'Fantoches e Teatros de Marionetas',NULL),(455,'Enigmas',NULL),(456,'Esportes e Brinquedos ao Ar Livre',NULL),(457,'bichos de pelúcia e brinquedos de pelúci',NULL),(458,'Brinquedos para bebês e crianças',NULL),(459,'Triciclos, Scooters e Vagões',NULL),(460,'Brinquedos de dedo',NULL),(461,'Conjuntos de jogos de veículos de brinqu',NULL),(462,'Brincadeiras Infantis Trens e Bondes',NULL),(463,'Brincadeiras Infantis Caminhões',NULL),(464,'Carros de Brincar com Crianças e Carros ',NULL),(465,'Barcos de Brincadeiras Infantis',NULL),(466,'Ônibus para crianças',NULL),(467,'Tratores Infantis',NULL),(468,'Carros Caça-Níqueis, Pistas de Corrida e',NULL),(469,'Sony PSP Jogos, Consoles e Acessórios',NULL),(470,'Nintendo DS Jogos, Consoles e Acessórios',NULL),(471,'Jogos PlayStation 3, Consoles e Acessóri',NULL),(472,'Jogos Wii, Consoles e Acessórios',NULL),(473,'Jogos Xbox 360, Consoles e Acessórios',NULL),(474,'Jogos para Mac & Acessórios',NULL),(475,'Nintendo 3DS & 2DS Consoles, Jogos e Ace',NULL),(476,'Sistemas Legados',NULL),(477,'Jogos PlayStation Vita, Consolas e Acess',NULL),(478,'Jogos Wii U, Consoles e Acessórios',NULL),(479,'Jogos PlayStation 4, Consoles e Acessóri',NULL),(480,'Jogos Xbox One, Consoles e Acessórios',NULL),(481,'Jogos eletrônicos',NULL),(482,'Serviços de Jogos de Vídeo Online',NULL),(483,'Hardware de Realidade Virtual e Acessóri',NULL),(484,'Nintendo Switch Consoles, Jogos e Acessó',NULL),(485,'Consolas, Jogos e Acessórios PlayStation',NULL),(486,'Xbox Series X & S Consoles, Jogos e Aces',NULL),(487,'Jogos para PC & Acessórios',NULL),(488,'Roupas para Meninas e Sapatos',NULL),(489,'Uniformes Escolares para Meninos',NULL);
/*!40000 ALTER TABLE `categorias` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `clientes`
--

DROP TABLE IF EXISTS `clientes`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `clientes` (
  `id` int(4) NOT NULL AUTO_INCREMENT,
  `nome` varchar(100) NOT NULL,
  `cpf` char(11) NOT NULL,
  `telefone` char(14) DEFAULT NULL,
  `email` varchar(60) NOT NULL,
  `data_nasc` date DEFAULT NULL,
  `data_cad` timestamp NOT NULL DEFAULT current_timestamp(),
  `ativo` bit(1) DEFAULT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `cpf_UNIQUE` (`cpf`),
  UNIQUE KEY `email_UNIQUE` (`email`)
) ENGINE=InnoDB AUTO_INCREMENT=27 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `clientes`
--

LOCK TABLES `clientes` WRITE;
/*!40000 ALTER TABLE `clientes` DISABLE KEYS */;
INSERT INTO `clientes` VALUES (25,'João Pedro Leme','12345678910','11951010144','jplhfernandez@gmail','2005-11-21','2024-08-28 14:00:14',''),(26,'Ana','94239452343','21234123434','ana@gmail.com','2000-06-14','2024-08-28 14:05:00','');
/*!40000 ALTER TABLE `clientes` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `enderecos`
--

DROP TABLE IF EXISTS `enderecos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `enderecos` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `cliente_id` int(4) NOT NULL,
  `cep` char(8) NOT NULL,
  `logradouro` varchar(100) DEFAULT NULL,
  `numero` varchar(40) NOT NULL,
  `complemento` varchar(60) DEFAULT NULL,
  `bairro` varchar(60) NOT NULL,
  `cidade` varchar(60) NOT NULL,
  `uf` char(2) NOT NULL,
  `tipo_endereco` char(3) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `fk_table1_clientes_idx` (`cliente_id`),
  CONSTRAINT `fk_table1_clientes` FOREIGN KEY (`cliente_id`) REFERENCES `clientes` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=24 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `enderecos`
--

LOCK TABLES `enderecos` WRITE;
/*!40000 ALTER TABLE `enderecos` DISABLE KEYS */;
/*!40000 ALTER TABLE `enderecos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `estoques`
--

DROP TABLE IF EXISTS `estoques`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `estoques` (
  `produto_id` int(4) NOT NULL,
  `quantidade` decimal(10,2) NOT NULL,
  `data_ultimo_movimento` timestamp NOT NULL DEFAULT current_timestamp() ON UPDATE current_timestamp(),
  KEY `fk_Estoque_Produto1_idx` (`produto_id`),
  CONSTRAINT `fk_Estoque_Produto1` FOREIGN KEY (`produto_id`) REFERENCES `produtos` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `estoques`
--

LOCK TABLES `estoques` WRITE;
/*!40000 ALTER TABLE `estoques` DISABLE KEYS */;
INSERT INTO `estoques` VALUES (1,0.00,'2024-09-03 03:00:00'),(2,0.00,'2024-09-03 03:00:00'),(3,0.00,'2024-09-03 03:00:00'),(4,0.00,'2024-09-03 03:00:00'),(5,0.00,'2024-09-03 03:00:00'),(6,0.00,'2024-09-03 03:00:00'),(7,0.00,'2024-09-03 03:00:00'),(8,0.00,'2024-09-03 03:00:00'),(11,0.00,'2024-09-03 03:00:00');
/*!40000 ALTER TABLE `estoques` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `fornecedores`
--

DROP TABLE IF EXISTS `fornecedores`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `fornecedores` (
  `id` int(4) NOT NULL AUTO_INCREMENT,
  `razao_social` varchar(100) NOT NULL,
  `fantasia` varchar(40) NOT NULL,
  `cnpj` char(14) NOT NULL,
  `contato` varchar(60) DEFAULT NULL,
  `telefone` varchar(45) DEFAULT NULL,
  `email` varchar(60) DEFAULT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `cnpj_UNIQUE` (`cnpj`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `fornecedores`
--

LOCK TABLES `fornecedores` WRITE;
/*!40000 ALTER TABLE `fornecedores` DISABLE KEYS */;
/*!40000 ALTER TABLE `fornecedores` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `itempedido`
--

DROP TABLE IF EXISTS `itempedido`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `itempedido` (
  `id` int(4) NOT NULL AUTO_INCREMENT,
  `pedido_id` int(11) NOT NULL,
  `produto_id` int(11) NOT NULL,
  `valor_unit` decimal(10,2) NOT NULL,
  `quantidade` decimal(10,2) NOT NULL,
  `desconto` decimal(10,2) DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `fk_ItemPedido_Pedido1_idx` (`pedido_id`),
  KEY `fk_ItemPedido_Produto1_idx` (`produto_id`),
  CONSTRAINT `fk_ItemPedido_Pedido1` FOREIGN KEY (`pedido_id`) REFERENCES `pedidos` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_ItemPedido_Produto1` FOREIGN KEY (`produto_id`) REFERENCES `produtos` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=14 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `itempedido`
--

LOCK TABLES `itempedido` WRITE;
/*!40000 ALTER TABLE `itempedido` DISABLE KEYS */;
/*!40000 ALTER TABLE `itempedido` ENABLE KEYS */;
UNLOCK TABLES;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `syspecdb`.`trigger_baixa_estoque`
AFTER INSERT ON `syspecdb`.`itempedido`
FOR EACH ROW
BEGIN
update estoques SET quantidade = quantidade - NEW.quantidade, data_ultimo_movimento = current_date()
where produto_id = new.produto_id
;
END */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;

--
-- Table structure for table `niveis`
--

DROP TABLE IF EXISTS `niveis`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `niveis` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `nome` varchar(45) NOT NULL,
  `sigla` varchar(45) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `niveis`
--

LOCK TABLES `niveis` WRITE;
/*!40000 ALTER TABLE `niveis` DISABLE KEYS */;
INSERT INTO `niveis` VALUES (1,'Gerente','GER'),(2,'Atendente','ATD');
/*!40000 ALTER TABLE `niveis` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `pedidos`
--

DROP TABLE IF EXISTS `pedidos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `pedidos` (
  `id` int(4) NOT NULL AUTO_INCREMENT,
  `usuario_id` int(4) NOT NULL,
  `cliente_id` int(4) NOT NULL,
  `data` timestamp NOT NULL DEFAULT current_timestamp(),
  `status` char(1) NOT NULL DEFAULT 'A',
  `desconto` decimal(10,2) DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `fk_Pedido_Usuarios1_idx` (`usuario_id`),
  KEY `fk_Pedido_Clientes1_idx` (`cliente_id`),
  CONSTRAINT `fk_Pedido_Clientes1` FOREIGN KEY (`cliente_id`) REFERENCES `clientes` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_Pedido_Usuarios1` FOREIGN KEY (`usuario_id`) REFERENCES `usuarios` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=100127 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `pedidos`
--

LOCK TABLES `pedidos` WRITE;
/*!40000 ALTER TABLE `pedidos` DISABLE KEYS */;
/*!40000 ALTER TABLE `pedidos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `produtofornecedor`
--

DROP TABLE IF EXISTS `produtofornecedor`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `produtofornecedor` (
  `produto_id` int(4) NOT NULL,
  `fornecedores_id` int(4) NOT NULL,
  PRIMARY KEY (`produto_id`,`fornecedores_id`),
  KEY `fk_Produto_has_Fornecedores_Produto1_idx` (`produto_id`),
  KEY `fk_idx` (`fornecedores_id`),
  CONSTRAINT `fk` FOREIGN KEY (`fornecedores_id`) REFERENCES `fornecedores` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_Produto_has_Fornecedores_Produto1` FOREIGN KEY (`produto_id`) REFERENCES `produtos` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `produtofornecedor`
--

LOCK TABLES `produtofornecedor` WRITE;
/*!40000 ALTER TABLE `produtofornecedor` DISABLE KEYS */;
/*!40000 ALTER TABLE `produtofornecedor` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `produtos`
--

DROP TABLE IF EXISTS `produtos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `produtos` (
  `id` int(4) NOT NULL AUTO_INCREMENT,
  `cod_barras` varchar(60) NOT NULL,
  `descricao` varchar(60) NOT NULL,
  `valor_unit` decimal(10,2) NOT NULL,
  `unidade_venda` varchar(12) NOT NULL,
  `categoria_id` int(4) NOT NULL,
  `estoque_minimo` decimal(10,2) NOT NULL,
  `classe_desconto` decimal(10,2) DEFAULT NULL,
  `imagem` blob DEFAULT NULL,
  `data_cad` timestamp NOT NULL DEFAULT current_timestamp(),
  PRIMARY KEY (`id`),
  UNIQUE KEY `idProduto_UNIQUE` (`id`),
  UNIQUE KEY `Produtocol_UNIQUE` (`cod_barras`),
  KEY `fk_Produto_Categorias1_idx` (`categoria_id`),
  CONSTRAINT `fk_Produto_Categorias1` FOREIGN KEY (`categoria_id`) REFERENCES `categorias` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `produtos`
--

LOCK TABLES `produtos` WRITE;
/*!40000 ALTER TABLE `produtos` DISABLE KEYS */;
INSERT INTO `produtos` VALUES (1,'7894563120876','Parafuso para motor de arranque caixa 10un',9.98,'unidade',266,0.00,0.12,NULL,'2024-09-03 14:22:06'),(2,'7894564583876','Pretinho pneus',11.98,'unidade',264,0.00,0.20,NULL,'2024-09-03 14:22:06'),(3,'7894564488876','Pastilha de freio para Fusca caixa com jogo',25.79,'unidade',266,0.00,0.12,NULL,'2024-09-03 14:22:06'),(4,'7894647680876','Pneu Pirelli 14 175x60',529.74,'unidade',261,0.00,0.00,NULL,'2024-09-03 14:22:06'),(5,'7894564159876','Oleo Lubrax 5w30 Litro',34.98,'unidade',265,0.00,0.15,NULL,'2024-09-03 14:22:06'),(6,'7897521120876','Limpador de parabrisas Dyna DX18 par',65.64,'unidade',263,0.00,0.00,NULL,'2024-09-03 14:22:06'),(7,'7894541258876','Bateria Moura 60A',463.98,'unidade',266,0.00,0.05,NULL,'2024-09-03 14:22:06'),(8,'7894563125874','Radiador Denso Fusca 66',897.98,'unidade',266,0.00,0.00,NULL,'2024-09-03 14:22:06'),(11,'123456789101112','Corrente de prata',10.00,'Caixa',246,5.00,0.00,NULL,'2024-09-03 14:52:21');
/*!40000 ALTER TABLE `produtos` ENABLE KEYS */;
UNLOCK TABLES;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `syspecdb`.`trigger_gera_estoque`
AFTER INSERT ON `syspecdb`.`produtos`
FOR EACH ROW
BEGIN
INSERT INTO estoques values(new.id, 0, current_date());
END */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;

--
-- Table structure for table `usuarios`
--

DROP TABLE IF EXISTS `usuarios`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `usuarios` (
  `id` int(4) NOT NULL AUTO_INCREMENT,
  `nome` varchar(60) NOT NULL,
  `email` varchar(60) NOT NULL,
  `senha` varchar(32) NOT NULL,
  `nivel_id` int(11) NOT NULL,
  `ativo` bit(1) NOT NULL DEFAULT b'1',
  PRIMARY KEY (`id`),
  UNIQUE KEY `email_UNIQUE` (`email`),
  KEY `fk_usuarios_niveis1_idx` (`nivel_id`),
  CONSTRAINT `fk_usuarios_niveis1` FOREIGN KEY (`nivel_id`) REFERENCES `niveis` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=1009 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `usuarios`
--

LOCK TABLES `usuarios` WRITE;
/*!40000 ALTER TABLE `usuarios` DISABLE KEYS */;
INSERT INTO `usuarios` VALUES (1006,'Roberto Rodhes','robertorodhes@gmail.com','e10adc3949ba59abbe56e057f20f883e',1,''),(1007,'Leonardo Amaral','leoamaral@gmail.com','202cb962ac59075b964b07152d234b70',1,''),(1008,'','','d41d8cd98f00b204e9800998ecf8427e',1,'');
/*!40000 ALTER TABLE `usuarios` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Temporary table structure for view `vw_pedido`
--

DROP TABLE IF EXISTS `vw_pedido`;
/*!50001 DROP VIEW IF EXISTS `vw_pedido`*/;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
/*!50001 CREATE TABLE `vw_pedido` (
  `pedido` tinyint NOT NULL,
  `cliente` tinyint NOT NULL,
  `produto` tinyint NOT NULL,
  `quantidade` tinyint NOT NULL,
  `valor_item` tinyint NOT NULL,
  `desc_item` tinyint NOT NULL,
  `desc_pedido` tinyint NOT NULL,
  `cod_barras` tinyint NOT NULL,
  `descricao` tinyint NOT NULL
) ENGINE=MyISAM */;
SET character_set_client = @saved_cs_client;

--
-- Final view structure for view `vw_pedido`
--

/*!50001 DROP TABLE IF EXISTS `vw_pedido`*/;
/*!50001 DROP VIEW IF EXISTS `vw_pedido`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_general_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `vw_pedido` AS select `p`.`id` AS `pedido`,`p`.`cliente_id` AS `cliente`,`ip`.`produto_id` AS `produto`,`ip`.`quantidade` AS `quantidade`,`ip`.`valor_unit` AS `valor_item`,`ip`.`desconto` AS `desc_item`,`p`.`desconto` AS `desc_pedido`,`pr`.`cod_barras` AS `cod_barras`,`pr`.`descricao` AS `descricao` from ((`pedidos` `p` join `itempedido` `ip` on(`p`.`id` = `ip`.`pedido_id`)) join `produtos` `pr` on(`ip`.`produto_id` = `pr`.`id`)) */;
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

-- Dump completed on 2024-09-06  8:37:40
