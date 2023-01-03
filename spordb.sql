-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Anamakine: 127.0.0.1:3306
-- Üretim Zamanı: 03 Oca 2023, 17:41:35
-- Sunucu sürümü: 5.7.36
-- PHP Sürümü: 7.4.26

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Veritabanı: `spordb`
--

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `member`
--

DROP TABLE IF EXISTS `member`;
CREATE TABLE IF NOT EXISTS `member` (
  `id` int(11) NOT NULL,
  `adsoyad` varchar(50) COLLATE utf8_turkish_ci NOT NULL,
  `tel` varchar(50) COLLATE utf8_turkish_ci NOT NULL,
  `cins` varchar(10) COLLATE utf8_turkish_ci NOT NULL,
  `yas` int(11) NOT NULL,
  `ucret` int(11) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=2 DEFAULT CHARSET=utf8 COLLATE=utf8_turkish_ci;

--
-- Tablo döküm verisi `member`
--

INSERT INTO `member` (`id`, `adsoyad`, `tel`, `cins`, `yas`, `ucret`) VALUES
(40, 'Alihan Dalgıç', '582', 'Erkek', 24, 123);

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `odeme`
--

DROP TABLE IF EXISTS `odeme`;
CREATE TABLE IF NOT EXISTS `odeme` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `ay` varchar(100) COLLATE utf8_turkish_ci NOT NULL,
  `uye` varchar(100) COLLATE utf8_turkish_ci NOT NULL,
  `ucret` int(11) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=7 DEFAULT CHARSET=utf8 COLLATE=utf8_turkish_ci;

--
-- Tablo döküm verisi `odeme`
--

INSERT INTO `odeme` (`id`, `ay`, `uye`, `ucret`) VALUES
(6, '7/2023', 'Naz Yiğit', 150),
(5, '1/2023', 'Alihan Dalgıç', 120),
(4, '1/2023', 'Naz Yiğit', 100);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
