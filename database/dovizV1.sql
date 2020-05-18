SET NAMES utf8 ;
SET character_set_client = utf8mb4 ;

CREATE TABLE `döviz` (
  `Döviz_türü` varchar(10) NOT NULL,
  `TL_alış` decimal(9,2) NOT NULL,
  `TL_satış` decimal(9,2) NOT NULL,
  `Kar_payı(makas)` varchar(50) NOT NULL,
  PRIMARY KEY (`Döviz_türü`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

CREATE TABLE `personel` (
  `personel_nu.` int(20) NOT NULL,
  `ad` varchar(30) NOT NULL,
  `soyad` varchar(20) NOT NULL,
  `yetki` varchar(20) NOT NULL,
  `adres` varchar(50) NOT NULL,
  `telefon_no` varchar(20) DEFAULT NULL,
  PRIMARY KEY (`personel_nu`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

CREATE TABLE `muhasebe` (
  `işlem_nu` int(20) NOT NULL,
  `işlem_türü` varchar(50) NOT NULL,
  `döviz(alış/satış)değeri` decimal(9,2) NOT NULL,
  `miktar` decimal(9,2) NOT NULL DEFAULT '0.00',
  `işlem_zamanı` datetime NOT NULL,
  PRIMARY KEY (`işlem_nu`),
  KEY `FK_personel_nu` (`personel_nu`),
  KEY `FK_Döviz_türü` (`Döviz_türü`),
  CONSTRAINT `FK_personel_nu` FOREIGN KEY (`personel_nu`) REFERENCES `personel` (`personel_nu`) ON DELETE RESTRICT ON UPDATE CASCADE,
  CONSTRAINT `FK_Döviz_türü` FOREIGN KEY (`Döviz_türü`) REFERENCES `döviz` (`Döviz_türü`) ON DELETE RESTRICT ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

CREATE TABLE `kasa` (
  `Döviz_türü` varchar(10) NOT NULL,
  `kasadaki_miktar` decimal(4,2) NOT NULL,
  PRIMARY KEY (`Döviz_türü`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

CREATE TABLE `Günsonu` (
  `Tarih` date NOT NULL,
  `Toplam_alış` decimal(9,2) NOT NULL,
  `Toplam_satış` decimal(9,2) NOT NULL,
  `kar` decimal(9,2) NOT NULL,
  PRIMARY KEY (`Tarih`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

CREATE TABLE `Banka_Kurları` (
  `Banka` varchar(10) NOT NULL AUTO_INCREMENT,
  `Banka_adı` varchar(50) NOT NULL,
  `Satış` decimal(4,2) NOT NULL,
  `Alış` decimal(4,2) NOT NULL,
  PRIMARY KEY (`Banka`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;





