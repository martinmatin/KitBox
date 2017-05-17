-- phpMyAdmin SQL Dump
-- version 4.6.4
-- https://www.phpmyadmin.net/
--
-- Client :  127.0.0.1
-- Généré le :  Mar 14 Mars 2017 à 21:54
-- Version du serveur :  5.7.14
-- Version de PHP :  5.6.25

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données :  `kitbox`
--

-- --------------------------------------------------------

--
-- Structure de la table `client`
--

CREATE TABLE `client` (
  `client_id` int(11) NOT NULL,
  `name` varchar(30) NOT NULL,
--  `phone_number` varchar(20) DEFAULT NULL,
--  `address` varchar(535) DEFAULT NULL,
  `pwd` varchar(30) NOT NULL,
  `email` varchar(30) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

--
-- Structure de la table `orderedpart`
--

CREATE TABLE `orderedpart` (
  `ordered_part_id` int(11) NOT NULL,
  `order_id` int(11) NOT NULL,
  `code` varchar(15) NOT NULL,
  `mult` tinyint NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8;


--
-- Structure de la table `sale`
--

CREATE TABLE `sale` (
  `order_id` int(11) NOT NULL,
  `client_id` int(11) NOT NULL,
  `order_date` varchar(14) NOT NULL,
  `delivery_date` varchar(14) NOT NULL,
  `price` decimal(8,4) NOT NULL,
  `is_payed` varchar(7) NOT NULL,
  `is_delivered` varchar(7) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

--
-- Structure de la table `stock`
--

CREATE TABLE `stock` (
  `code` varchar(20) NOT NULL,
  `client_price` decimal(8,4) NOT NULL,
  `real_stock` smallint(6) NOT NULL,
  `virtual_stock` smallint(6) NOT NULL,
  `minimal_q` smallint(6) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

--
-- Structure de la table `part_info`
--
CREATE TABLE `part_info` (
  `part_id` int(11) NOT NULL,
  `supplier_id` int(11) NOT NULL,
  `code` varchar(20) NOT NULL,
  `delay` tinyint(4) DEFAULT NULL,
  `price` decimal(8,4) DEFAULT NULL
--  `supplier_1_price` decimal(8,4) NOT NULL,
--  `supplier_1_delay` tinyint(4) DEFAULT NULL,
--  `supplier_2_price` decimal(8,4) NOT NULL,
--  `supplier_2_delay` tinyint(4) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

--
-- Structure de la table `supplier_info`
--
CREATE TABLE `supplier_info` (
  `supplier_id` int(11) NOT NULL,
  `company` varchar(100) NOT NULL,
  `address` varchar(255) DEFAULT NULL,
  `city` varchar(100) DEFAULT NULL
--  `supplier_1_price` decimal(8,4) NOT NULL,
--  `supplier_1_delay` tinyint(4) DEFAULT NULL,
--  `supplier_2_price` decimal(8,4) NOT NULL,
--  `supplier_2_delay` tinyint(4) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8;



--
-- Index pour les tables exportées
--

--
-- Index pour la table `client`
--
ALTER TABLE `client`
  ADD PRIMARY KEY (`client_id`);

--
-- Index pour la table `orderedpart`
--


ALTER TABLE `orderedpart`
  ADD PRIMARY KEY (`ordered_part_id`);


--
-- Index pour la table `sale`
--
ALTER TABLE `sale`
  ADD PRIMARY KEY (`order_id`);

--
-- Index pour la table `stock`
--
ALTER TABLE `stock`
  ADD PRIMARY KEY (`code`);

--
-- Index pour la table `part_info`
--
ALTER TABLE `part_info`
  ADD PRIMARY KEY (`part_id`);

  --
-- Index pour la table `supplier_info`
--
ALTER TABLE `supplier_info`
  ADD PRIMARY KEY (`supplier_id`);

--
-- AUTO_INCREMENT pour les tables exportées
--

--
-- AUTO_INCREMENT pour la table `client`
--
ALTER TABLE `client`
  MODIFY `client_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=22;
--
-- AUTO_INCREMENT pour la table `orderedpart`
--
ALTER TABLE `orderedpart`
  MODIFY `ordered_part_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=33;
--
-- AUTO_INCREMENT pour la table `sale`
--
ALTER TABLE `sale`
  MODIFY `order_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

 --
-- AUTO_INCREMENT pour la table `part_info`
--
ALTER TABLE `part_info`
  MODIFY `part_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=1;


  --
  -- AUTO_INCREMENT pour la table `part_info`
  --
  ALTER TABLE `supplier_info`
   MODIFY `supplier_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=1;


/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
