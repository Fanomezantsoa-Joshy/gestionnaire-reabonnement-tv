-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1
-- Généré le : dim. 04 oct. 2026 à 22:12
-- Version du serveur : 10.4.32-MariaDB
-- Version de PHP : 8.0.30

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données : `streamlinedb`
--

-- --------------------------------------------------------

--
-- Structure de la table `abonnement`
--

CREATE TABLE `abonnement` (
  `codeabonnement` int(11) NOT NULL,
  `clientcode` int(11) DEFAULT NULL,
  `cartedecodeurcode` int(11) DEFAULT NULL,
  `offrecode` int(11) NOT NULL,
  `datedebut` date DEFAULT NULL,
  `datefin` date DEFAULT NULL,
  `statut` varchar(20) DEFAULT NULL,
  `modepaiement` varchar(50) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Déchargement des données de la table `abonnement`
--

INSERT INTO `abonnement` (`codeabonnement`, `clientcode`, `cartedecodeurcode`, `offrecode`, `datedebut`, `datefin`, `statut`, `modepaiement`) VALUES
(1, 6, 1, 6, '2026-10-04', '2026-12-03', 'En cours', 'En espece'),
(2, 7, 3, 8, '2026-10-04', '2026-11-03', 'En cours', 'Mobile Money'),
(3, 11, 6, 9, '2026-10-04', '2027-01-02', 'En cours', 'Mobile Money'),
(4, 13, 7, 10, '2026-10-04', '2026-11-03', 'En cours', 'Mobile Money');

-- --------------------------------------------------------

--
-- Structure de la table `administrateur`
--

CREATE TABLE `administrateur` (
  `NomAdmin` varchar(50) NOT NULL,
  `Nom` varchar(50) DEFAULT NULL,
  `Prenoms` varchar(50) DEFAULT NULL,
  `Naissance` date DEFAULT NULL,
  `Mdp` varchar(10) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Déchargement des données de la table `administrateur`
--

INSERT INTO `administrateur` (`NomAdmin`, `Nom`, `Prenoms`, `Naissance`, `Mdp`) VALUES
('Admin', 'RAKOTOARINIRINA', 'Fanomezantsoa Joshy', '2008-10-04', 'motdepasse');

-- --------------------------------------------------------

--
-- Structure de la table `cartedecodeur`
--

CREATE TABLE `cartedecodeur` (
  `CodeCarte` int(11) NOT NULL,
  `NumeroUnique` varchar(50) DEFAULT NULL,
  `Etat` varchar(20) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Déchargement des données de la table `cartedecodeur`
--

INSERT INTO `cartedecodeur` (`CodeCarte`, `NumeroUnique`, `Etat`) VALUES
(1, 'CARD-0123456789', 'Actif'),
(3, 'CARD-1123456789', 'Actif'),
(4, 'CARD-2123456789', 'Actif'),
(5, 'CARD-3123456789', 'Actif'),
(6, 'CARD-4123456789', 'Actif'),
(7, 'CARD-5123456789', 'Actif'),
(8, 'CARD-6123456789', 'Actif'),
(9, 'CARD-7123456789', 'Actif'),
(10, 'CARD-8123456789', 'Actif'),
(11, 'CARD-9123456789', 'Actif'),
(12, 'CARD-1223456789', 'Non actif'),
(13, 'CARD-1323456789', 'Non actif'),
(14, 'CARD-1423456789', 'Non actif'),
(15, 'CARD-1523456789', 'Non actif'),
(16, 'CARD-1623456789', 'Non actif'),
(17, 'CARD-1723456789', 'Non actif'),
(18, 'CARD-1823456789', 'Non actif'),
(19, 'CARD-1923456789', 'Non actif');

-- --------------------------------------------------------

--
-- Structure de la table `chaine`
--

CREATE TABLE `chaine` (
  `CodeChaine` int(11) NOT NULL,
  `Nom` varchar(100) NOT NULL,
  `Categorie` varchar(50) DEFAULT NULL,
  `Date` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Déchargement des données de la table `chaine`
--

INSERT INTO `chaine` (`CodeChaine`, `Nom`, `Categorie`, `Date`) VALUES
(1, 'Chaine 1', 'Documentaire', '2026-05-06'),
(2, 'Chaine 2', 'Sport', '2026-05-06'),
(3, 'Chaine 3', 'Série', '2026-05-06'),
(4, 'Chaine 4', 'Film', '2026-05-06'),
(5, 'Chaine 5', 'Sport', '2026-05-06'),
(6, 'Chaine 6', 'Musique', '2026-05-06'),
(7, 'Chaine 7', 'Info', '2026-05-06'),
(8, 'Chaine 8', 'Documentaire', '2026-05-06'),
(9, 'Chaine 9', 'Film', '2026-05-06'),
(11, 'Chaine 11', 'Sport', '2026-05-06'),
(12, 'Chaine 12', 'Info', '2026-05-06'),
(13, 'Chaine 13', 'Musique', '2026-05-06'),
(14, 'Chaine 14', 'Divertissement', '2026-05-06'),
(15, 'Chaine 15', 'Comédie', '2026-05-06');

-- --------------------------------------------------------

--
-- Structure de la table `client`
--

CREATE TABLE `client` (
  `CodeClient` int(11) NOT NULL,
  `Nom` varchar(50) DEFAULT NULL,
  `Prenom` varchar(50) DEFAULT NULL,
  `Adresse` varchar(150) DEFAULT NULL,
  `Email` varchar(100) DEFAULT NULL,
  `CarteDecodeurCode` int(11) DEFAULT NULL,
  `CodeUtilisateur` int(11) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Déchargement des données de la table `client`
--

INSERT INTO `client` (`CodeClient`, `Nom`, `Prenom`, `Adresse`, `Email`, `CarteDecodeurCode`, `CodeUtilisateur`) VALUES
(6, 'RAKOTOARINIRINA', 'Fanomezantsoa Joshy', 'Tambohobe', 'joshyfanomezantsoa3@gmail.com', 1, 1),
(7, 'RAKOTO', 'Paul', 'Tanambao', 'rakoto@gmail.com', 3, 2),
(11, 'MARIE', 'Louise', 'Ivato', 'louise@gmail.com', 6, 3),
(12, 'MOHAMED', 'Ali', 'Andohalo', 'ali@gmail.com', 5, 4),
(13, 'MALALA', 'Fitia', 'Ankorondrano', 'fitia@gmail.com', 7, 5),
(14, 'MIANGALY', 'Fitia', 'Ambohipo', 'miangaly@gmail.com', 8, 6),
(15, 'JEAN', 'Luc', 'Mahamasina', 'luc@gmail.com', 9, 7),
(16, 'JEAN', 'Paul', 'Tanambao', 'paul@gmail.com', 10, 8),
(17, 'RAKOTO', 'Christian', 'Analakely', 'christian@gmail.com', 11, 9);

-- --------------------------------------------------------

--
-- Structure de la table `facture`
--

CREATE TABLE `facture` (
  `CodeFacture` int(11) NOT NULL,
  `NumeroFacture` varchar(50) DEFAULT NULL,
  `CodeClient` int(11) NOT NULL,
  `Montant` decimal(10,2) DEFAULT NULL,
  `Date` date DEFAULT NULL,
  `Statut` varchar(20) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Déchargement des données de la table `facture`
--

INSERT INTO `facture` (`CodeFacture`, `NumeroFacture`, `CodeClient`, `Montant`, `Date`, `Statut`) VALUES
(1, 'STREAM-FACT-1', 0, 500.00, '2026-05-07', 'Payé'),
(37, 'STREAM-FACT-2', 0, -1.00, '2026-05-07', 'Payé'),
(38, 'STREAM-FACT-38', 0, 20000.00, '2026-05-07', 'Payé'),
(39, 'STREAM-FACT-39', 0, 20.00, '2026-05-07', 'Payé'),
(40, 'STREAM-FACT-40', 0, 40000.00, '2026-05-07', 'Payé'),
(41, 'STREAM-FACT-41', 6, 20.00, '2026-05-07', 'Payé'),
(42, NULL, 11, 20.00, '2026-05-07', 'Payé'),
(43, NULL, 6, 10.00, '2026-05-08', 'Payé'),
(44, 'STREAM-FACT-44', 6, 20.00, '2026-05-08', 'Payé'),
(45, 'STREAM-FACT-45', 12, 40000.00, '2026-05-08', 'Payé'),
(46, NULL, 12, 50.00, '2026-05-08', 'Payé'),
(47, NULL, 12, 20000.00, '2026-05-08', 'Payé'),
(48, 'STREAM-FACT-48', 13, 40000.00, '2026-10-04', 'Payé'),
(49, 'STREAM-FACT-49', 14, 40000.00, '2026-10-04', 'Payé'),
(50, 'STREAM-FACT-50', 15, 40000.00, '2026-10-04', 'Payé'),
(51, 'STREAM-FACT-51', 16, 40000.00, '2026-10-04', 'Payé'),
(52, 'STREAM-FACT-52', 17, 40000.00, '2026-10-04', 'Payé'),
(53, 'STREAM-FACT-53', 6, 60000.00, '2026-10-04', 'Payé'),
(54, 'STREAM-FACT-54', 7, -1.00, '2026-10-04', 'Payé'),
(55, 'STREAM-FACT-55', 11, -1.00, '2026-10-04', 'Payé'),
(56, 'STREAM-FACT-56', 13, -1.00, '2026-10-04', 'Payé');

-- --------------------------------------------------------

--
-- Structure de la table `historiqueadmin`
--

CREATE TABLE `historiqueadmin` (
  `CodeHistorique` int(11) NOT NULL,
  `NomAdmin` varchar(50) DEFAULT NULL,
  `DateAction` date DEFAULT NULL,
  `Action` varchar(200) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Déchargement des données de la table `historiqueadmin`
--

INSERT INTO `historiqueadmin` (`CodeHistorique`, `NomAdmin`, `DateAction`, `Action`) VALUES
(1, 'Joshy', '2026-05-08', 'Action'),
(2, 'Fanome', '2026-10-04', 'Création d\'un compte administrateur | Nom : Fanome'),
(3, 'Fanome', '2026-10-04', 'Modification des informations du client. | Nom du client : ANDRIAMISAINA'),
(4, 'Fanome', '2026-10-04', 'Modification des informations du client. | Nom du client : Nom'),
(5, 'Fanome', '2026-10-04', 'Modification des informations du client. | Nom du client : nouveau'),
(6, 'Fanome', '2026-10-04', 'Achat d\'un décodeur. | Numéro : CARD-5123456789 | Code client : 13'),
(7, 'Fanome', '2026-10-04', 'Achat d\'un décodeur. | Numéro : CARD-6123456789 | Code client : 14'),
(8, 'Fanome', '2026-10-04', 'Achat d\'un décodeur. | Numéro : CARD-7123456789 | Code client : 15'),
(9, 'Fanome', '2026-10-04', 'Modification des informations du client. | Nom du client : RAKOTO'),
(10, 'Fanome', '2026-10-04', 'Achat d\'un décodeur. | Numéro : CARD-8123456789 | Code client : 16'),
(11, 'Fanome', '2026-10-04', 'Achat d\'un décodeur. | Numéro : CARD-9123456789 | Code client : 17'),
(12, 'Fanome', '2026-10-04', 'Modification des informations d\'une chaîne. | Chaîne N° : 22'),
(13, 'Fanome', '2026-10-04', 'Modification des informations d\'une offre. | Numéro de l\'offre : 6'),
(14, 'Fanome', '2026-10-04', 'Modification des informations d\'une offre. | Numéro de l\'offre : 8'),
(15, 'Fanome', '2026-10-04', 'Création d\'un nouveau offre : | Nom : Guna.UI2.WinForms.Internal.PlaceholderTextBox, Text: Medium'),
(16, 'Fanome', '2026-10-04', 'Création d\'un nouveau offre : | Nom : Guna.UI2.WinForms.Internal.PlaceholderTextBox, Text: Promotion'),
(17, 'Fanome', '2026-10-04', 'Modification des informations d\'une offre. | Numéro de l\'offre : 10'),
(18, 'Fanome', '2026-10-04', 'Création d\'un nouveau offre : | Nom : Guna.UI2.WinForms.Internal.PlaceholderTextBox, Text: Promotion 2'),
(19, 'Fanome', '2026-10-04', 'Modification des informations d\'une offre. | Numéro de l\'offre : 9'),
(20, 'Fanome', '2026-10-04', 'Achat offre : 6 | Code client : 6 | Facture N°: STREAM-FACT-53'),
(21, 'Fanome', '2026-10-04', 'Achat offre : 8 | Code client : 7 | Facture N°: STREAM-FACT-54'),
(22, 'Fanome', '2026-10-04', 'Achat offre : 9 | Code client : 11 | Facture N°: STREAM-FACT-55'),
(23, 'Fanome', '2026-10-04', 'Achat offre : 10 | Code client : 13 | Facture N°: STREAM-FACT-56'),
(24, 'Admin', '2026-10-04', 'Création d\'un compte administrateur | Nom : Admin');

-- --------------------------------------------------------

--
-- Structure de la table `notification`
--

CREATE TABLE `notification` (
  `CodeNotification` int(11) NOT NULL,
  `ClientCode` int(11) DEFAULT NULL,
  `OffreCode` int(11) NOT NULL,
  `Quantite` int(11) NOT NULL,
  `Message` varchar(200) DEFAULT NULL,
  `DateEnvoi` date DEFAULT NULL,
  `Statut` varchar(20) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Déchargement des données de la table `notification`
--

INSERT INTO `notification` (`CodeNotification`, `ClientCode`, `OffreCode`, `Quantite`, `Message`, `DateEnvoi`, `Statut`) VALUES
(1, 6, 8, 2, 'Achat VIP', '2026-05-07', 'Réfusé'),
(2, 6, 8, 2, 'Achat VIP', '2026-05-07', 'Accépté'),
(3, 6, 8, 2, 'Achat VIP', '2026-05-07', 'Accépté'),
(4, 6, 8, 2, 'Achat VIP', '2026-05-07', 'Accépté'),
(5, 6, 8, 2, 'Achat VIP', '2026-05-07', 'Réfusé'),
(6, 6, 8, 2, 'Achat VIP', '2026-05-07', 'Réfusé'),
(9, 6, 6, 2, 'Achat VIP', '2026-05-07', 'Accépté'),
(10, 6, 6, 2, 'Achat VIP', '2026-05-08', 'Accépté');

-- --------------------------------------------------------

--
-- Structure de la table `offre`
--

CREATE TABLE `offre` (
  `CodeOffre` int(11) NOT NULL,
  `Nom` varchar(100) NOT NULL,
  `Prix` decimal(10,2) DEFAULT NULL,
  `Duree` int(11) DEFAULT NULL,
  `Description` varchar(200) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Déchargement des données de la table `offre`
--

INSERT INTO `offre` (`CodeOffre`, `Nom`, `Prix`, `Duree`, `Description`) VALUES
(6, 'Simple', 30000.00, 30, 'Chaine de base'),
(8, 'VIP', 50000.00, 30, 'Toute les chaînes'),
(9, 'Medium', 40000.00, 30, 'Chaine de base, sport'),
(10, 'Promotion 1', 20000.00, 30, 'Promotion toute chaines'),
(11, 'Promotion 2', 10000.00, 30, 'Chaines de base');

-- --------------------------------------------------------

--
-- Structure de la table `offrechaine`
--

CREATE TABLE `offrechaine` (
  `CodeOffre` int(11) NOT NULL,
  `CodeChaine` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Déchargement des données de la table `offrechaine`
--

INSERT INTO `offrechaine` (`CodeOffre`, `CodeChaine`) VALUES
(6, 1),
(6, 2),
(6, 3),
(6, 4),
(6, 5),
(6, 6),
(6, 7),
(8, 1),
(8, 2),
(8, 3),
(8, 4),
(8, 5),
(8, 6),
(8, 7),
(8, 8),
(8, 9),
(8, 11),
(8, 12),
(8, 13),
(8, 14),
(8, 15),
(9, 1),
(9, 2),
(9, 3),
(9, 4),
(9, 5),
(9, 6),
(9, 7),
(9, 8),
(9, 9),
(9, 11),
(9, 12),
(10, 1),
(10, 2),
(10, 3),
(10, 4),
(10, 5),
(10, 6),
(10, 7),
(10, 8),
(10, 9),
(10, 11),
(10, 12),
(10, 13),
(10, 14),
(10, 15),
(11, 1),
(11, 2),
(11, 3),
(11, 4),
(11, 5),
(11, 6),
(11, 7),
(11, 8),
(11, 9),
(11, 11);

-- --------------------------------------------------------

--
-- Structure de la table `utilisateur`
--

CREATE TABLE `utilisateur` (
  `CodeUtilisateur` int(11) NOT NULL,
  `Username` varchar(50) DEFAULT NULL,
  `Email` varchar(100) DEFAULT NULL,
  `MotDePasse` varchar(100) NOT NULL,
  `Role` varchar(20) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Déchargement des données de la table `utilisateur`
--

INSERT INTO `utilisateur` (`CodeUtilisateur`, `Username`, `Email`, `MotDePasse`, `Role`) VALUES
(1, 'ANTSAMi', NULL, 'ANTSA2026', 'Admin'),
(2, NULL, '1', '1', 'Client'),
(3, 'Joshy', 'joshyfanomezantsoa@gmail.com', 'mdp', 'client'),
(4, 'Jesaia', 'fd@gmail.com', 'mdp', 'client');

--
-- Index pour les tables déchargées
--

--
-- Index pour la table `abonnement`
--
ALTER TABLE `abonnement`
  ADD PRIMARY KEY (`codeabonnement`),
  ADD KEY `FK_Abonnement_Client` (`clientcode`),
  ADD KEY `FK_Abonnement_Carte` (`cartedecodeurcode`),
  ADD KEY `FK_Abonnement_Offre` (`offrecode`);

--
-- Index pour la table `administrateur`
--
ALTER TABLE `administrateur`
  ADD PRIMARY KEY (`NomAdmin`);

--
-- Index pour la table `cartedecodeur`
--
ALTER TABLE `cartedecodeur`
  ADD PRIMARY KEY (`CodeCarte`),
  ADD UNIQUE KEY `NumeroUnique` (`NumeroUnique`);

--
-- Index pour la table `chaine`
--
ALTER TABLE `chaine`
  ADD PRIMARY KEY (`CodeChaine`);

--
-- Index pour la table `client`
--
ALTER TABLE `client`
  ADD PRIMARY KEY (`CodeClient`),
  ADD UNIQUE KEY `Email` (`Email`),
  ADD KEY `CarteDecodeurCode` (`CarteDecodeurCode`),
  ADD KEY `fk_client_utilisateur` (`CodeUtilisateur`);

--
-- Index pour la table `facture`
--
ALTER TABLE `facture`
  ADD PRIMARY KEY (`CodeFacture`),
  ADD UNIQUE KEY `NumeroFacture` (`NumeroFacture`);

--
-- Index pour la table `historiqueadmin`
--
ALTER TABLE `historiqueadmin`
  ADD PRIMARY KEY (`CodeHistorique`),
  ADD KEY `NomAdmin` (`NomAdmin`);

--
-- Index pour la table `notification`
--
ALTER TABLE `notification`
  ADD PRIMARY KEY (`CodeNotification`),
  ADD KEY `ClientCode` (`ClientCode`);

--
-- Index pour la table `offre`
--
ALTER TABLE `offre`
  ADD PRIMARY KEY (`CodeOffre`);

--
-- Index pour la table `offrechaine`
--
ALTER TABLE `offrechaine`
  ADD PRIMARY KEY (`CodeOffre`,`CodeChaine`),
  ADD KEY `CodeChaine` (`CodeChaine`);

--
-- Index pour la table `utilisateur`
--
ALTER TABLE `utilisateur`
  ADD PRIMARY KEY (`CodeUtilisateur`);

--
-- AUTO_INCREMENT pour les tables déchargées
--

--
-- AUTO_INCREMENT pour la table `abonnement`
--
ALTER TABLE `abonnement`
  MODIFY `codeabonnement` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- AUTO_INCREMENT pour la table `cartedecodeur`
--
ALTER TABLE `cartedecodeur`
  MODIFY `CodeCarte` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=20;

--
-- AUTO_INCREMENT pour la table `chaine`
--
ALTER TABLE `chaine`
  MODIFY `CodeChaine` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=23;

--
-- AUTO_INCREMENT pour la table `client`
--
ALTER TABLE `client`
  MODIFY `CodeClient` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=18;

--
-- AUTO_INCREMENT pour la table `facture`
--
ALTER TABLE `facture`
  MODIFY `CodeFacture` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=57;

--
-- AUTO_INCREMENT pour la table `historiqueadmin`
--
ALTER TABLE `historiqueadmin`
  MODIFY `CodeHistorique` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=25;

--
-- AUTO_INCREMENT pour la table `notification`
--
ALTER TABLE `notification`
  MODIFY `CodeNotification` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT pour la table `offre`
--
ALTER TABLE `offre`
  MODIFY `CodeOffre` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;

--
-- AUTO_INCREMENT pour la table `utilisateur`
--
ALTER TABLE `utilisateur`
  MODIFY `CodeUtilisateur` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- Contraintes pour les tables déchargées
--

--
-- Contraintes pour la table `offrechaine`
--
ALTER TABLE `offrechaine`
  ADD CONSTRAINT `offrechaine_ibfk_1` FOREIGN KEY (`CodeOffre`) REFERENCES `offre` (`CodeOffre`),
  ADD CONSTRAINT `offrechaine_ibfk_2` FOREIGN KEY (`CodeChaine`) REFERENCES `chaine` (`CodeChaine`);

DELIMITER $$
--
-- Évènements
--
CREATE DEFINER=`root`@`localhost` EVENT `event_nettoyage_factures` ON SCHEDULE EVERY 1 DAY STARTS '2026-05-02 20:17:53' ON COMPLETION NOT PRESERVE ENABLE DO BEGIN
    DELETE FROM Facture
    WHERE AbonnementCode NOT IN (SELECT CodeAbonnement FROM Abonnement);

    UPDATE Abonnement a
    JOIN Facture f ON a.CodeAbonnement = f.AbonnementCode
    SET a.Statut = 'En attente'
    WHERE f.Statut = 'Non payé';

    UPDATE Abonnement a
    JOIN Facture f ON a.CodeAbonnement = f.AbonnementCode
    SET a.Statut = 'Actif'
    WHERE f.Statut = 'Payée';
END$$

DELIMITER ;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
