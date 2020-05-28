CREATE DATABASE dovizotomasyon;
USE dovizotomasyon;

/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `doviz` (
  `doviz_id` int NOT NULL AUTO_INCREMENT,
  `doviz_adi` varchar(3) NOT NULL,
  `doviz_tam_adi` varchar(20) NOT NULL,
  `doviz_logo` char(5) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  PRIMARY KEY (`doviz_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

CREATE TABLE `deger` (
  `doviz_id` int NOT NULL AUTO_INCREMENT,
  `alis_fiyat` DECIMAL(9,4) NOT NULL,
  `satis_fiyat` DECIMAL(9,4) NOT NULL,
  PRIMARY KEY (`doviz_id`),
  KEY `fk_doviz_id` (`doviz_id`),
  CONSTRAINT `fk_doviz_id` FOREIGN KEY (`doviz_id`) REFERENCES `doviz` (`doviz_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

CREATE TABLE `kasa` (
  `doviz_id` int NOT NULL AUTO_INCREMENT,
  `doviz_miktar` DECIMAL(9,4) NOT NULL,
  PRIMARY KEY (`doviz_id`),
  CONSTRAINT `kasa_ibfk_1` FOREIGN KEY (`doviz_id`) REFERENCES `doviz` (`doviz_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

CREATE TABLE `islem` (
  `islem_id` int NOT NULL AUTO_INCREMENT,
  `islem_adi` varchar(20) NOT NULL,
  PRIMARY KEY (`islem_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

CREATE TABLE `yetki` (
  `yetki_id` int NOT NULL AUTO_INCREMENT,
  `yetki_adi` varchar(20) NOT NULL,
  PRIMARY KEY (`yetki_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

CREATE TABLE `personel` (
  `personel_id` int NOT NULL AUTO_INCREMENT,
  `yetki_id` int NOT NULL,
  `ad` varchar(30) NOT NULL,
  `soyad` varchar(30) NOT NULL,
  `kullanici_adi` varchar(50) NOT NULL,
  `sifre` varchar(30) DEFAULT '1234' NOT NULL ,
  PRIMARY KEY (`personel_id`),
  KEY `fk_yetki_id` (`yetki_id`),
  CONSTRAINT `fk_yetki_id` FOREIGN KEY (`yetki_id`) REFERENCES `yetki` (`yetki_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

CREATE TABLE `alısveris` (
  `a_id` int NOT NULL AUTO_INCREMENT,
  `tarih` timestamp  NOT NULL,
  `islem_id` int NOT NULL,
  `doviz_id` int NOT NULL,
  `personel_id` int NOT NULL,
  `miktar` DECIMAL(9,4) NOT NULL,
  PRIMARY KEY (`a_id`),
  KEY `fk_islem_id` (`islem_id`),
  KEY `fk2_doviz_id` (`doviz_id`),
  KEY `fk_personel_id` (`personel_id`),
  CONSTRAINT `fk2_doviz_id` FOREIGN KEY (`doviz_id`) REFERENCES `doviz` (`doviz_id`),
  CONSTRAINT `fk_islem_id` FOREIGN KEY (`islem_id`) REFERENCES `islem` (`islem_id`),
  CONSTRAINT `fk_personel_id` FOREIGN KEY (`personel_id`) REFERENCES `personel` (`personel_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

INSERT INTO doviz (doviz_adi, doviz_tam_adi, doviz_logo) VALUES ('USD', 'Amerikan Doları', '$');
INSERT INTO doviz (doviz_adi, doviz_tam_adi, doviz_logo) VALUES ('EUR', 'Euro', '€');
INSERT INTO doviz (doviz_adi, doviz_tam_adi, doviz_logo) VALUES ('GBP', 'İngiliz Sterlini', '£');
INSERT INTO doviz (doviz_adi, doviz_tam_adi, doviz_logo) VALUES ('CHF', 'İsviçre Frangı', '₣');
INSERT INTO doviz (doviz_adi, doviz_tam_adi, doviz_logo) VALUES ('RUB', 'Rus Rublesi', '₽');
INSERT INTO doviz (doviz_adi, doviz_tam_adi, doviz_logo) VALUES ('KRW', 'Güney Kore Wonu', '₩');
INSERT INTO doviz (doviz_adi, doviz_tam_adi, doviz_logo) VALUES ('JPY', 'Japon Yeni', '¥');

INSERT INTO dovizotomasyon.kasa (doviz_id, doviz_miktar) VALUES ('1', '1000');
INSERT INTO dovizotomasyon.kasa (doviz_id, doviz_miktar) VALUES ('2', '1000');
INSERT INTO dovizotomasyon.kasa (doviz_id, doviz_miktar) VALUES ('3', '1543');
INSERT INTO dovizotomasyon.kasa (doviz_id, doviz_miktar) VALUES ('4', '432.21');
INSERT INTO dovizotomasyon.kasa (doviz_id, doviz_miktar) VALUES ('5', '34.4532');
INSERT INTO dovizotomasyon.kasa (doviz_id, doviz_miktar) VALUES ('6', '7213');
INSERT INTO dovizotomasyon.kasa (doviz_id, doviz_miktar) VALUES ('7', '232.12');

INSERT INTO islem (islem_adi) VALUES ('Alış');
INSERT INTO islem (islem_adi) VALUES ('Satış');

INSERT INTO yetki (yetki_adi) VALUES ('Yönetici');
INSERT INTO yetki (yetki_adi) VALUES ('Personel');
INSERT INTO yetki (yetki_adi) VALUES ('İzleyici');

INSERT INTO personel (yetki_id, ad, soyad, kullanici_adi, sifre) VALUES ('1','Mehmet Akif','Çay','akif', '12345');
INSERT INTO personel (yetki_id, ad, soyad, kullanici_adi) VALUES ('1','Uğur Erçelik','Ugur','ugur');
INSERT INTO personel (yetki_id, ad, soyad, kullanici_adi) VALUES ('1','Bora Ulaş','Bayar','bora');


/* SELECT deger.alis_fiyat WHERE doviz_id = 2;
/* Test değerleri
INSERT INTO deger(doviz_id,alis_fiyat,satis_fiyat) VALUES(1,3.36,3.45);
INSERT INTO deger(doviz_id,alis_fiyat,satis_fiyat) VALUES(2,7.38,8.36);
INSERT INTO deger(doviz_id,alis_fiyat,satis_fiyat) VALUES(3,8.29,9.12);
INSERT INTO deger(doviz_id,alis_fiyat,satis_fiyat) VALUES(4,6.96,7.02);
INSERT INTO deger(doviz_id,alis_fiyat,satis_fiyat) VALUES(5,0.095,0.115);
INSERT INTO deger(doviz_id,alis_fiyat,satis_fiyat) VALUES(6,0.0055,0.88);
INSERT INTO deger(doviz_id,alis_fiyat,satis_fiyat) VALUES(7,0.063,0.094);
*/

-- https://stackoverflow.com/questions/50093144/mysql-8-0-client-does-not-support-authentication-protocol-requested-by-server
-- API için yetkileri yenile
-- ALTER USER 'root'@'localhost' IDENTIFIED WITH mysql_native_password BY '12345';
-- flush privileges;
SELECT doviz.doviz_logo, doviz.doviz_tam_adi, deger.satis_fiyat, deger.alis_fiyat FROM deger INNER JOIN  doviz ON deger.doviz_id = doviz.doviz_id;
INSERT INTO alısveris(tarih, islem_id, doviz_id, personel_id, miktar) VALUES(NOW(),1,1,3,3415.32);
-- SELECT * FROM personel WHERE kullanici_adi = 'ugur'; // örnek kullanıcı liste seçimi
-- SELECT * FROM dovizotomasyon.personel WHERE kullanici_adi = 'akif' AND sifre = '12345'; // Örnek şifre girişi