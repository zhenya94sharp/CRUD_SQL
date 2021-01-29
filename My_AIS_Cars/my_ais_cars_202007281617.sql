--
-- Скрипт сгенерирован Devart dbForge Studio 2020 for MySQL, Версия 9.0.304.0
-- Домашняя страница продукта: http://www.devart.com/ru/dbforge/mysql/studio
-- Дата скрипта: 28.07.2020 16:17:19
-- Версия сервера: 8.0.20
-- Версия клиента: 4.1
--

-- 
-- Отключение внешних ключей
-- 
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;

-- 
-- Установить режим SQL (SQL mode)
-- 
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;

-- 
-- Установка кодировки, с использованием которой клиент будет посылать запросы на сервер
--
SET NAMES 'utf8';

--
-- Установка базы данных по умолчанию
--
USE my_ais_cars;

--
-- Удалить процедуру `cars_delete_by_id`
--
DROP PROCEDURE IF EXISTS cars_delete_by_id;

--
-- Удалить процедуру `cars_insert_new`
--
DROP PROCEDURE IF EXISTS cars_insert_new;

--
-- Удалить процедуру `cars_search_model`
--
DROP PROCEDURE IF EXISTS cars_search_model;

--
-- Удалить процедуру `cars_select_all`
--
DROP PROCEDURE IF EXISTS cars_select_all;

--
-- Удалить процедуру `cars_truncate`
--
DROP PROCEDURE IF EXISTS cars_truncate;

--
-- Удалить процедуру `cars_update`
--
DROP PROCEDURE IF EXISTS cars_update;

--
-- Удалить таблицу `cars`
--
DROP TABLE IF EXISTS cars;

--
-- Удалить таблицу `models_cars`
--
DROP TABLE IF EXISTS models_cars;

--
-- Установка базы данных по умолчанию
--
USE my_ais_cars;

--
-- Создать таблицу `models_cars`
--
CREATE TABLE models_cars (
  id int NOT NULL AUTO_INCREMENT,
  model varchar(20) NOT NULL DEFAULT '',
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AUTO_INCREMENT = 5,
CHARACTER SET utf8,
COLLATE utf8_general_ci;

--
-- Создать таблицу `cars`
--
CREATE TABLE cars (
  id int NOT NULL AUTO_INCREMENT,
  id_model int NOT NULL,
  body varchar(20) NOT NULL DEFAULT '',
  year date NOT NULL,
  balance int NOT NULL,
  price int NOT NULL,
  credit tinyint NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AUTO_INCREMENT = 28,
AVG_ROW_LENGTH = 4096,
CHARACTER SET utf8,
COLLATE utf8_general_ci;

DELIMITER $$

--
-- Создать процедуру `cars_update`
--
CREATE DEFINER = 'root'@'localhost'
PROCEDURE cars_update (IN in_id_model int, IN in_body varchar(20), IN in_year date, IN in_balance int, IN in_price int, IN in_id int, IN in_credit tinyint)
BEGIN
  UPDATE `cars`
  SET `id_model` = in_id_model,
      `body` = in_body,
      `year` = in_year,
      `balance` = in_balance,
      `price` = in_price,
      `credit` = in_credit
  WHERE `id` = in_id;
END
$$

--
-- Создать процедуру `cars_truncate`
--
CREATE DEFINER = 'root'@'localhost'
PROCEDURE cars_truncate ()
BEGIN
  TRUNCATE cars;
END
$$

--
-- Создать процедуру `cars_select_all`
--
CREATE DEFINER = 'root'@'localhost'
PROCEDURE cars_select_all ()
BEGIN
  SELECT
    *
  FROM cars;
END
$$

--
-- Создать процедуру `cars_search_model`
--
CREATE DEFINER = 'root'@'localhost'
PROCEDURE cars_search_model (IN in_model varchar(20))
BEGIN
  SELECT
    *
  FROM `cars`
  WHERE `id_model` = (SELECT
      `id`
    FROM models_cars
    WHERE model = in_model);
END
$$

--
-- Создать процедуру `cars_insert_new`
--
CREATE DEFINER = 'root'@'localhost'
PROCEDURE cars_insert_new (IN in_id_model int, IN in_body varchar(20), IN in_year date, IN in_balance int, IN in_price int, IN in_credit tinyint)
BEGIN
  INSERT INTO `cars` (`id_model`, `body`, `year`, `balance`, `price`, `credit`)
    VALUES (in_id_model, in_body, in_year, in_balance, in_price, in_credit);
END
$$

--
-- Создать процедуру `cars_delete_by_id`
--
CREATE DEFINER = 'root'@'localhost'
PROCEDURE cars_delete_by_id (IN in_id int)
BEGIN
  DELETE
    FROM `cars`
  WHERE `id` = in_id;
END
$$

DELIMITER ;

-- 
-- Вывод данных для таблицы models_cars
--
INSERT INTO models_cars VALUES
(1, 'Mercedes-Benz'),
(2, 'Reno'),
(3, 'BMW'),
(4, 'Toyota');

-- 
-- Вывод данных для таблицы cars
--
INSERT INTO cars VALUES
(1, 1, 'S 500', '2018-07-01', 5, 5000000, 1),
(2, 2, 'Logan', '2016-07-02', 15, 300000, 0),
(4, 3, '520', '2019-07-01', 4, 3333333, 0),
(5, 1, 'C 180', '2018-02-12', 6, 2000000, 1),
(6, 4, 'Camry', '2018-05-02', 7, 2000000, 1),
(7, 4, 'Corolla', '2016-08-05', 10, 1000000, 0),
(8, 3, '525', '2012-07-02', 5, 500000, 0),
(9, 1, 'AMG', '2020-07-02', 3, 5000000, 1),
(10, 4, 'Land Cruiser 200', '2018-03-03', 7, 4000000, 0),
(14, 2, 'Duster', '2018-03-02', 15, 800000, 1);

-- 
-- Восстановить предыдущий режим SQL (SQL mode)
--
/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;

-- 
-- Включение внешних ключей
-- 
/*!40014 SET FOREIGN_KEY_CHECKS = @OLD_FOREIGN_KEY_CHECKS */;