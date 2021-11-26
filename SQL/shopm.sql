-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Gép: 127.0.0.1
-- Létrehozás ideje: 2021. Nov 26. 14:31
-- Kiszolgáló verziója: 10.4.19-MariaDB
-- PHP verzió: 8.0.7

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Adatbázis: `shopm`
--

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `news`
--

CREATE TABLE `news` (
  `id` int(11) NOT NULL,
  `author` varchar(255) NOT NULL,
  `title` varchar(255) NOT NULL,
  `description` varchar(255) NOT NULL,
  `date` datetime NOT NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `productcategories`
--

CREATE TABLE `productcategories` (
  `id` int(11) NOT NULL,
  `name` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- A tábla adatainak kiíratása `productcategories`
--

INSERT INTO `productcategories` (`id`, `name`) VALUES
(1, 'Tejtermék'),
(9, 'Ital'),
(10, 'Élelmiszer'),
(12, 'Péksütemény'),
(13, 'Édesség'),
(14, 'Szeszes ital'),
(15, 'Elektronikai cikk'),
(16, 'Barkács cikk'),
(17, 'Fűszer');

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `products`
--

CREATE TABLE `products` (
  `id` int(11) NOT NULL,
  `cID` int(11) NOT NULL,
  `name` varchar(255) NOT NULL,
  `price` bigint(20) NOT NULL,
  `discount` float NOT NULL,
  `count` bigint(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- A tábla adatainak kiíratása `products`
--

INSERT INTO `products` (`id`, `cID`, `name`, `price`, `discount`, `count`) VALUES
(1, 1, 'Tej', 120, 0, 3),
(2, 1, 'Vaj', 400, 0, 5),
(10, 17, 'Bors', 54, 0, 895),
(11, 17, 'Só', 100, 0, 4),
(12, 9, 'Ásványvíz', 54, 0, 895),
(13, 9, 'Ice tea', 257, 5, 120),
(14, 1, 'Túró', 900, 0, 5),
(15, 1, 'Joghurt', 120, 0, 10),
(16, 1, 'Sajt', 420, 0, 12),
(17, 10, 'Liszt', 420, 0, 12),
(18, 10, 'Cukor', 540, 0, 104),
(19, 17, 'Fűszerpaprika', 95, 0, 45),
(20, 12, 'Szegedi virslis', 250, 0, 1),
(21, 12, 'Fánk', 230, 0, 5),
(22, 12, 'Kakaóscsiga', 280, 0, 7),
(23, 12, 'Meggyes rétes', 145, 0, 6),
(24, 13, 'Gumicukor', 450, 0, 24),
(25, 13, 'Chips', 270, 0, 8),
(26, 13, 'Nyalóka', 80, 0, 45),
(27, 14, 'Pezsgő', 1250, 0, 8),
(28, 14, 'Vörös bor', 2450, 0, 19),
(29, 15, 'Mobiltelefon', 18990, 0, 3),
(30, 15, 'Walkie-Talkie', 3450, 0, 4),
(31, 15, 'Gamer egér', 28000, 0, 4),
(32, 15, 'Gamer billentyűzet', 32955, 0, 6),
(33, 16, 'Csavarhúzó készlet', 485, 0, 4),
(34, 16, 'Csavar', 10, 0, 4452);

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `transactions`
--

CREATE TABLE `transactions` (
  `id` int(11) NOT NULL,
  `employee` varchar(255) NOT NULL,
  `description` varchar(255) NOT NULL,
  `price` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- A tábla adatainak kiíratása `transactions`
--

INSERT INTO `transactions` (`id`, `employee`, `description`, `price`) VALUES
(1, 'Admin', 'Termék eladás', 15066),
(2, 'Admin', 'Termék eladás', 1016),
(3, 'Admin', 'Termék eladás', 1270),
(4, 'Admin', 'Termék eladás', 38740),
(5, 'Admin', 'Termék eladás', 66858),
(6, 'Admin', 'Termék eladás', 840),
(7, 'Admin', 'Alkalmazott fizetése', -500),
(8, 'silvio', 'Termék eladás', 15675),
(9, 'Admin', 'Termék eladás', 480),
(10, 'Admin', 'Termék eladás', 230),
(11, 'Admin', 'Termék eladás', 3290),
(12, 'Admin', 'Termék eladás', 140),
(13, 'Admin', 'Termék eladás', 4320);

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `users`
--

CREATE TABLE `users` (
  `id` int(11) NOT NULL,
  `username` varchar(255) NOT NULL,
  `password` varchar(255) NOT NULL,
  `role` varchar(255) NOT NULL,
  `name` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- A tábla adatainak kiíratása `users`
--

INSERT INTO `users` (`id`, `username`, `password`, `role`, `name`) VALUES
(1, 'Admin', 'crWzsg+o2g37qseA3l6Qys/DiajR5S9raBGAIAOkXVQ347lZRtUzEQ==', 'admin', 'Pelda Janos'),
(2, 'David', 'uVG6e0AeukpfoIUVvjR+RKKpASAnFrWJPTLp9y7hb2q6vFHkY7Q9iQ==', 'employee', 'David Kovacs'),
(3, 'gunnvor', '7vYReanVAyezArOl8TA/meA4XPQIuXI4JNjHC1CqBogUtYIXJVO8jg==', 'employee', 'Gunnvor Angelina'),
(4, 'cajetan', 'T/yr+77pzv68BS7HgSqVM7Dc+uHFIf82lllOTwcx0DMu4KB9bj8xyw==', 'employee', 'Victoria Cajetan'),
(5, 'cali', 'XjWYkCaLQjl6tvZ8SCdQpB8auFtLEh+mks4YN4QQZBeKHQMnGg94Jg==', 'employee', 'Cali Pushpa'),
(6, 'garnette', 'fAavbYEM5fHlpH/u1v7m3BZXsWNPzaWLh63Ncpxap7kot1cFL10qWw==', 'employee', 'Mylène Garnette'),
(7, 'nermin', 'VD8sjsnchyHlZw9hPCi7zGvw/crFjNDr11xgmDgYfEMrimNFUIbBJQ==', 'employee', 'Kašpar Nermin'),
(8, 'theophilos', 'xmpkBw6Qrg1fMjIbpuRxR94qXZ8BHVPK9ZyDhGmdm7kxk/xNJdypjw==', 'employee', 'Theophilos Lestat'),
(9, 'frank', 'aX9a1dPIrMe2e6hiCc09Ehb0j7IOl1Uah2hjraOPAjg2z3XRoX2Azw==', 'employee', 'Nadège Frank'),
(10, 'lebanah', '8L679CPE+pFviyb1DsNz/+1WM1SGNbHH4VDOPsfwW+bB5gpfmkVcPw==', 'employee', 'Lebanah Koa'),
(11, 'hollis', 'ny+ndrB7yW1Hyp9Jplbna2K9DL7ubuTy0kNGTLzA+OEQmySQipWtwA==', 'employee', 'Pier Hollis'),
(12, 'paphnoutios', '7dBustqQ7qHlW50GSC+uEh28SFrIpUHhiMRrOZJe1DPAPc/s/v8lsw==', 'employee', 'Nana Paphnoutios'),
(13, 'silvio', 'T6XVojLyihrBDwp2xNM4wwNr+zmFDGa6Z7zcoa5aHwX4u4ShTVsgbQ==', 'employee', 'Silvio Ekaterine'),
(14, 'raju', 'jk9jlQoT8xDtkWZ8NQ8lsexf2t6UYvl0Loor+BXNcjOpZChZY9XkaQ==', 'employee', 'Raju Chrissie'),
(15, 'matey', 'M1H/ZImxajAV32e2o2JMSwquFFEpUxiCWU8tqzxBC+QwdL3LRhczfg==', 'employee', 'Matey Victoria'),
(16, 'molly', 'TIO4+o3PjLXlO8TSD/4hN5ZsJFJxN7fgcnAk+N9NC8pqmz/iOFWwVw==', 'employee', 'Lateefah Molly'),
(17, 'patrik', '+oX50FVxRKncGlsElHiYa9BcdOsK+TUyv2mbh+lDTjdG7Ci6xp3K1A==', 'employee', 'Xenagoras Patrik'),
(18, 'erland', 'LykpaPgx/kdXOwep4Up0636oqOgOdA6rhVfclAHArFgsAyIVjY9hmg==', 'employee', 'Erland Krystle'),
(19, 'francisco', 'rRuRpbvn0ryAnKk93Jy/TBF6uV7ssuCrvd7E/gzs7ZarUcQxX6K6Rg==', 'employee', 'Aku Francisco'),
(20, 'axelle', '6J50NSl2KklvADnNsvNM+4+kLj2Lezl6BXbmfv+ftbXqIArHh4FQFA==', 'employee', 'Lindiwe Axelle'),
(21, 'reziko', 'FtInPwbtWxDTjeOwv9xv4evxhi4MZH+srP31vlQGZXT4NZfQLAm3pQ==', 'employee', 'Blagoslav Reziko'),
(22, 'louise', 'PqNSh8Ml7xrrXlelTNQ+4MSPi4xAVJ59og4Y24UsewTkLaSNOrrvfg==', 'employee', 'Randúlfr Louise');

--
-- Indexek a kiírt táblákhoz
--

--
-- A tábla indexei `news`
--
ALTER TABLE `news`
  ADD PRIMARY KEY (`id`);

--
-- A tábla indexei `productcategories`
--
ALTER TABLE `productcategories`
  ADD PRIMARY KEY (`id`);

--
-- A tábla indexei `products`
--
ALTER TABLE `products`
  ADD PRIMARY KEY (`id`);

--
-- A tábla indexei `transactions`
--
ALTER TABLE `transactions`
  ADD PRIMARY KEY (`id`);

--
-- A tábla indexei `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`id`);

--
-- A kiírt táblák AUTO_INCREMENT értéke
--

--
-- AUTO_INCREMENT a táblához `news`
--
ALTER TABLE `news`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT a táblához `productcategories`
--
ALTER TABLE `productcategories`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=21;

--
-- AUTO_INCREMENT a táblához `products`
--
ALTER TABLE `products`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=40;

--
-- AUTO_INCREMENT a táblához `transactions`
--
ALTER TABLE `transactions`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=14;

--
-- AUTO_INCREMENT a táblához `users`
--
ALTER TABLE `users`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=23;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
