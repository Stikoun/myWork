-- phpMyAdmin SQL Dump
-- version 4.5.1
-- http://www.phpmyadmin.net
--
-- Počítač: 127.0.0.1
-- Vytvořeno: Ned 13. led 2019, 13:23
-- Verze serveru: 10.1.19-MariaDB
-- Verze PHP: 5.6.28

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Databáze: `hospital`
--

-- --------------------------------------------------------

--
-- Struktura tabulky `case`
--

CREATE TABLE `case` (
  `idCase` int(11) NOT NULL,
  `idDoctor` int(11) NOT NULL,
  `idPatient` int(11) NOT NULL,
  `idDiagnosis` int(11) NOT NULL,
  `Patient` varchar(50) COLLATE utf8_czech_ci NOT NULL,
  `Doctor` varchar(50) COLLATE utf8_czech_ci NOT NULL,
  `Name` varchar(50) COLLATE utf8_czech_ci NOT NULL,
  `Description` varchar(500) COLLATE utf8_czech_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_czech_ci;

--
-- Vypisuji data pro tabulku `case`
--

INSERT INTO `case` (`idCase`, `idDoctor`, `idPatient`, `idDiagnosis`, `Patient`, `Doctor`, `Name`, `Description`) VALUES
(1, 1, 1, 5, 'Josef Alzheimer', 'Karel Vokurka', 'JA-Migrena', ''),
(2, 2, 1, 1, 'Josef Alzheimer', 'Jakub Strnad', 'JA-Spánek', ''),
(3, 2, 2, 16, 'Franta Zálesák', 'Jakub Strnad', 'FZ-Jecné zrno', ''),
(4, 1, 2, 41, 'Franta Zálesák', 'Karel Vokurka', 'FZ-Epilepsie', ''),
(5, 2, 1, 3, 'Josef Alzheimer', 'Jakub Strnad', 'JA-Obrna', ''),
(6, 2, 3, 33, 'Jaromír Zloun', 'Jakub Strnad', 'JZ-Lupenka', ''),
(7, 1, 3, 34, 'Jaromír Zloun', 'Karel Vokurka', 'JZ-Akne', '');

-- --------------------------------------------------------

--
-- Struktura tabulky `diagnosis`
--

CREATE TABLE `diagnosis` (
  `idDiagnosis` int(11) NOT NULL,
  `Name` varchar(50) COLLATE utf8_czech_ci NOT NULL,
  `Category` varchar(50) COLLATE utf8_czech_ci DEFAULT NULL,
  `Description` varchar(500) COLLATE utf8_czech_ci DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_czech_ci;

--
-- Vypisuji data pro tabulku `diagnosis`
--

INSERT INTO `diagnosis` (`idDiagnosis`, `Name`, `Category`, `Description`) VALUES
(1, 'G7 - Poruchy spánku', 'VI. - Nemoci nervové soustavy', ''),
(2, 'G20 - Parkinsonova nemoc', 'VI. - Nemoci nervové soustavy', NULL),
(3, 'G80 - Mozková obrna', 'VI. - Nemoci nervové soustavy', NULL),
(4, 'G41 - Status epilepticus', 'VI. - Nemoci nervové soustavy', NULL),
(5, 'G43 - Migréna', 'VI. - Nemoci nervové soustavy', NULL),
(6, 'G30 - Alzheimerova nemoc', 'VI. - Nemoci nervové soustavy', NULL),
(7, 'G35 - Roztroušená skleróza', 'VI. - Nemoci nervové soustavy', NULL),
(8, 'I02 - Revmatická chorea', 'IX. - Nemoci oběhové soustavy', NULL),
(9, 'I02 - Revmatická chorea', 'IX. - Nemoci oběhové soustavy', NULL),
(10, 'I20 - Angina pectoris', 'IX. - Nemoci oběhové soustavy', NULL),
(11, 'I26 - Plicní embolie', 'IX. - Nemoci oběhové soustavy', NULL),
(12, 'I42 - Kardiomyopatie', 'IX. - Nemoci oběhové soustavy', NULL),
(13, 'I63 - Mozkový infarkt', 'IX. - Nemoci oběhové soustavy', NULL),
(14, 'I50 - Selhání srdce', 'IX. - Nemoci oběhové soustavy', NULL),
(15, 'I70 - Ateroskleróza', 'IX. - Nemoci oběhové soustavy', NULL),
(16, 'H00 - Ječné zrno a chalazion', 'VII. - Nemoci oka', NULL),
(17, 'H10 - Zánět oční spojivky', 'VII. - Nemoci oka', NULL),
(18, 'H16 - Zánět rohovky', 'VII. - Nemoci oka', NULL),
(19, 'H30 - Záněty cévnatky a sítnice', 'VII. - Nemoci oka', NULL),
(20, 'H33 - Odchlípení a trhliny sítnice', 'VII. - Nemoci oka', NULL),
(21, 'H40 - Glaukom', 'VII. - Nemoci oka', NULL),
(22, 'H44 - Nemoci očního bulbu', 'VII. - Nemoci oka', NULL),
(23, 'K20 - Zánět jícnu – ezofagitida', 'XI. - Nemoci trávicí soustavy', NULL),
(24, 'K20 - Zánět jícnu – ezofagitida', 'XI. - Nemoci trávicí soustavy', NULL),
(25, 'K28 - Gastrojejunální vřed', 'XI. - Nemoci trávicí soustavy', NULL),
(26, 'K30 - Funkční dyspepsie', 'XI. - Nemoci trávicí soustavy', NULL),
(27, 'K40 - Tříselná kýla', 'XI. - Nemoci trávicí soustavy', NULL),
(28, 'K64 - Hemoroidy a perianální žilní trombóza', 'XI. - Nemoci trávicí soustavy', NULL),
(29, 'K80 - Žlučové kameny – cholelithiasis', 'XI. - Nemoci trávicí soustavy', NULL),
(30, 'K81 - Zánět žlučníku – cholecystitida', 'XI. - Nemoci trávicí soustavy', NULL),
(31, 'L20 - Atopická dermatitida', 'XII. - Nemoci kůže a podkožního vaziva', NULL),
(32, 'L20 - Atopická dermatitida', 'XII. - Nemoci kůže a podkožního vaziva', NULL),
(33, 'L40 - Lupénka – psoriáza', 'XII. - Nemoci kůže a podkožního vaziva', NULL),
(34, 'L70 - Trudovina – akné', 'XII. - Nemoci kůže a podkožního vaziva', NULL),
(35, 'M15 - Polyartróza', 'XIII. - Nemoci svalové a kosterní soustavy', NULL),
(36, 'M22 - Onemocnění čéšky – pately', 'XIII. - Nemoci svalové a kosterní soustavy', NULL),
(37, 'M41 - Skolióza', 'XIII. - Nemoci svalové a kosterní soustavy', NULL),
(38, 'M50 - Onemocnění krčních meziobratlových plotének', 'XIII. - Nemoci svalové a kosterní soustavy', NULL),
(39, 'M61 - Kalcifikace a osifikace svalu', 'XIII. - Nemoci svalové a kosterní soustavy', NULL),
(40, 'G30 - Alzheimerova nemoc', 'VI. - Nemoci nervové soustavy', NULL),
(41, 'G40 - Epilepsie – padoucnice', 'VI. - Nemoci nervové soustavy', NULL),
(42, 'G43 - Migréna', 'VI. - Nemoci nervové soustavy', NULL),
(43, 'G80 - Mozková obrna', 'VI. - Nemoci nervové soustavy', NULL);

-- --------------------------------------------------------

--
-- Struktura tabulky `diagnosisdrugs`
--

CREATE TABLE `diagnosisdrugs` (
  `idDiagnosis` int(11) NOT NULL,
  `idDrug` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_czech_ci;

--
-- Vypisuji data pro tabulku `diagnosisdrugs`
--

INSERT INTO `diagnosisdrugs` (`idDiagnosis`, `idDrug`) VALUES
(2, 6),
(2, 7),
(2, 1),
(3, 3),
(4, 10),
(4, 3),
(4, 4),
(5, 4),
(5, 6),
(5, 9),
(6, 2),
(6, 10),
(7, 2),
(7, 7),
(8, 6),
(8, 7),
(9, 2),
(9, 10),
(10, 7),
(10, 6),
(11, 4),
(11, 7),
(12, 9),
(13, 10),
(13, 4),
(13, 1),
(14, 3),
(14, 9),
(15, 4),
(15, 6),
(16, 4),
(16, 2),
(17, 2),
(17, 1),
(17, 4),
(18, 4),
(19, 3),
(19, 6),
(19, 7),
(20, 1),
(20, 10),
(21, 9),
(21, 10),
(21, 4),
(22, 1),
(22, 2),
(22, 3),
(23, 7),
(23, 9),
(23, 10),
(24, 2),
(24, 3),
(25, 4),
(25, 6),
(25, 1),
(26, 1),
(27, 10),
(27, 7),
(27, 3),
(28, 4),
(28, 10),
(29, 9),
(30, 3),
(30, 1),
(30, 2),
(31, 9),
(32, 4),
(32, 3),
(33, 1),
(34, 4),
(35, 7),
(38, 9),
(38, 1),
(39, 4),
(39, 10),
(39, 2),
(40, 2),
(40, 9),
(41, 2),
(42, 10),
(42, 4),
(43, 3),
(43, 1),
(1, 5),
(1, 9),
(1, 3);

-- --------------------------------------------------------

--
-- Struktura tabulky `doctor`
--

CREATE TABLE `doctor` (
  `idDoctor` int(11) NOT NULL,
  `idUser` int(11) NOT NULL,
  `Name` varchar(50) COLLATE utf8_czech_ci NOT NULL,
  `Surname` varchar(50) COLLATE utf8_czech_ci NOT NULL,
  `Username` varchar(50) COLLATE utf8_czech_ci NOT NULL,
  `PIN` varchar(50) COLLATE utf8_czech_ci NOT NULL,
  `Birth` datetime DEFAULT NULL,
  `Gender` varchar(10) COLLATE utf8_czech_ci NOT NULL,
  `Residence` varchar(50) COLLATE utf8_czech_ci NOT NULL,
  `Nationality` varchar(50) COLLATE utf8_czech_ci NOT NULL,
  `Cases` varchar(500) COLLATE utf8_czech_ci DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_czech_ci;

--
-- Vypisuji data pro tabulku `doctor`
--

INSERT INTO `doctor` (`idDoctor`, `idUser`, `Name`, `Surname`, `Username`, `PIN`, `Birth`, `Gender`, `Residence`, `Nationality`, `Cases`) VALUES
(1, 2, 'Karel', 'Vokurka', 'vokurkakarel', '946875/2578', '1994-09-21 00:00:00', 'Male', 'Praha', 'Czech Republic', NULL),
(2, 3, 'Jakub', 'Strnad', 'strnadjakub', '950505/5528', '1995-05-05 00:00:00', 'Male', 'Touzimska', 'Czech Republic', NULL);

-- --------------------------------------------------------

--
-- Struktura tabulky `drug`
--

CREATE TABLE `drug` (
  `idDrug` int(11) NOT NULL,
  `Name` varchar(50) COLLATE utf8_czech_ci NOT NULL,
  `Category` varchar(50) COLLATE utf8_czech_ci NOT NULL,
  `AdultDosage` varchar(500) COLLATE utf8_czech_ci DEFAULT NULL,
  `KinderDosage` varchar(500) COLLATE utf8_czech_ci DEFAULT NULL,
  `OwnDosage` varchar(500) COLLATE utf8_czech_ci DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_czech_ci;

--
-- Vypisuji data pro tabulku `drug`
--

INSERT INTO `drug` (`idDrug`, `Name`, `Category`, `AdultDosage`, `KinderDosage`, `OwnDosage`) VALUES
(1, 'Paralen 500', 'Pain', 'max. 8 tablets daily, 4 hours ', 'max. 4 tablets daily, 4-6 hours interval', NULL),
(2, 'Ibalgin Rapidcaps', 'Pain', 'max. 3 dose daily, take 1-2 tablets per one dose, 4 hours interval', 'max. 3 tablets daily, 6 hours interval', NULL),
(3, 'Aspirin C SPARKING TABLETS', 'Pain', 'usually 6 tablets daily, max. 10 tablets daily', 'max. 4 tablets daily', NULL),
(4, 'Olynth HA 0,1 %', 'Cold', 'max. one dosage 3x daily, both nostrils', 'max. one dosage 2x daily, both nostrils', NULL),
(5, 'Muconasal PLUS 1X10ML', 'Cold', 'max. one dosage 4x daily, both nostrils', 'max. one dosage 2x daily, both nostrils', NULL),
(6, 'ACC LONG sparkling tablets', 'Cough', 'usually 2 tablet per day', 'usually 1 tablet per day', NULL),
(7, 'Kinedryl', 'Nausea', '1 tablet 60 minutes before a way, interval 2-3 hours', '1/4 - 1/2 tablet 60 minutes before a way, interval 2-3 hours', NULL),
(8, 'Strepsils Mentol eukalyptus', 'Angina', 'max. 12 tablet daily, take one tablet and keep interval 2-3 hours', 'max. 8 tablet daily, take one tablet and keep interval 2-3 hours', NULL),
(9, 'Coldrex ', 'Flu', 'take 1-2 tablet, interval 4-6 hodin, max. 4 dosage daily', 'take 1 tablet, interval 4-6 hodin, max. 2 dosage daily', NULL),
(10, 'Bepanthen cream', 'Burns', '3x-5x daily usage of cream ', '1x-3x daily usage of cream ', NULL),
(11, 'Visine Classic', 'Eyes', '1 blob, 2x-3x daily', '1 blob, 2x-3x daily', NULL);

-- --------------------------------------------------------

--
-- Struktura tabulky `patient`
--

CREATE TABLE `patient` (
  `idPatient` int(11) NOT NULL,
  `Name` varchar(50) COLLATE utf8_czech_ci NOT NULL,
  `Surname` varchar(50) COLLATE utf8_czech_ci NOT NULL,
  `PIN` varchar(50) COLLATE utf8_czech_ci NOT NULL,
  `Birth` datetime NOT NULL,
  `Gender` varchar(10) COLLATE utf8_czech_ci NOT NULL,
  `Residence` varchar(50) COLLATE utf8_czech_ci NOT NULL,
  `Nationality` varchar(50) COLLATE utf8_czech_ci NOT NULL,
  `Anamnesis` varchar(1000) COLLATE utf8_czech_ci NOT NULL,
  `Insurence` varchar(500) COLLATE utf8_czech_ci NOT NULL,
  `Note` varchar(500) COLLATE utf8_czech_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_czech_ci;

--
-- Vypisuji data pro tabulku `patient`
--

INSERT INTO `patient` (`idPatient`, `Name`, `Surname`, `PIN`, `Birth`, `Gender`, `Residence`, `Nationality`, `Anamnesis`, `Insurence`, `Note`) VALUES
(1, 'Josef', 'Alzheimer', '901345/2048', '1990-09-19 00:00:00', 'Muž', 'U potoka', 'Czech Republic', 'prijat na interní kliniku FN Motol 14.1.2009 v 10,30 hod., pro nechutenství, váhový úbytek, prímes krve ve stolici.\r\nHospitalizace první.\r\nPríbuzní: syn Koutný Jan, bytem Praha 3, Chrudimská 5, tel.733 264 155.\r\nRA: \r\nOtec - zemrel za války ve 30 letech na TBC;\r\nMatka - zemrela v 77 letech na cévní mozkovou príhodu, lécila se pro hypertenzi, podrobila se strumektomii.\r\n2 bratri - jeden zemrel v 75 letech na IM, lécil se pro chronickou ischemickou chorobu srdecní, st.p.cévní mozkové príhode, druh', 'Zdravotní pojištovna ministerstva vnitra CR (211)', ''),
(2, 'Franta', 'Zálesák', '850225/1254', '1963-09-22 00:00:00', 'Muž', 'U kríže', 'Czech Republic', 'Prijat na interní kliniku FN Motol dne 8.1.1999 v 23,50 hod., pro 3 hodiny trvající retrosternální bolest\r\nHospitalizace druhá, naposledy v cervnu 1996.\r\nPríbuzní: manželka Ludmila, bytem dtto.\r\nRA:\r\nOtec - zemrel v 63 letech na recidivu infarktu myokardu. (první IM v 55 letech), lécený hypertonik, DM II. typu na diete.\r\nMatka - zemrela v 72 letech na generalizaci karcinomu mammy.\r\n2 sestry - 65 a 68 let, žijí, jedna z nich trpí od 60 let DM II. typu, je lécena dietou.\r\n2 deti - 35 a 38 let, zdr', 'Ceská prumyslová zdravotní pojištovna (205)', 'test'),
(3, 'Jaromír', 'Zloun', '800204/5527', '1979-09-13 00:00:00', 'Muž', 'Ostrava', 'Ceská Republika', 'prijat na interní kliniku FN Motol 14.1.2009 v 10,30 hod., pro nechutenství, váhový úbytek, prímes krve ve stolici.\r\nHospitalizace první.\r\nPríbuzní: syn Koutný Jan, bytem Praha 3, Chrudimská 5, tel.733 264 155.\r\nRA: \r\nOtec - zemrel za války ve 30 letech na TBC;\r\nMatka - zemrela v 77 letech na cévní mozkovou príhodu, lécila se pro hypertenzi, podrobila se strumektomii.\r\n2 bratri - jeden zemrel v 75 letech na IM, lécil se pro chronickou ischemickou chorobu srdecní, st.p.cévní mozkové príhode, druh', 'Všeobecná zdravotní pojištovna CR (111)', 'test');

-- --------------------------------------------------------

--
-- Struktura tabulky `user`
--

CREATE TABLE `user` (
  `idUser` int(11) NOT NULL,
  `Username` varchar(50) COLLATE utf8_czech_ci NOT NULL,
  `Password` varchar(50) COLLATE utf8_czech_ci DEFAULT NULL,
  `isAdmin` bit(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_czech_ci;

--
-- Vypisuji data pro tabulku `user`
--

INSERT INTO `user` (`idUser`, `Username`, `Password`, `isAdmin`) VALUES
(1, 'vorelpepa', 'vorel123', b'0'),
(2, 'vokurkakarel', 'karel123', b'0'),
(3, 'strnadjakub', 'strnad123', b'0'),
(4, 'Administrator', 'admin123', b'1');

-- --------------------------------------------------------

--
-- Struktura tabulky `visit`
--

CREATE TABLE `visit` (
  `idVisit` int(11) NOT NULL,
  `idCase` int(11) NOT NULL,
  `VisitDate` datetime NOT NULL,
  `Description` varchar(500) COLLATE utf8_czech_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_czech_ci;

--
-- Vypisuji data pro tabulku `visit`
--

INSERT INTO `visit` (`idVisit`, `idCase`, `VisitDate`, `Description`) VALUES
(1, 1, '2016-09-04 00:00:00', 'Zahájení případu, určení diagnozy a medikamentů.\r\nUrčena příští návštěva.'),
(2, 2, '2016-07-13 00:00:00', 'Zahájení případu, určení diagnozy a medikamentů.\r\nUrčena další návštěva.'),
(3, 3, '2016-09-21 00:00:00', 'Zahájení případu, určení diagnozy a medikamentů.\r\nUrčena další návštěva.'),
(4, 4, '2016-08-31 00:00:00', 'Zahájení případu, určení diagnozy a medikamentů.\nUrčena další návštěva.'),
(5, 2, '2016-10-20 00:00:00', 'Termín příští návštěvy.'),
(6, 1, '2016-09-22 00:00:00', 'Ukončení případu.'),
(7, 3, '2016-10-18 00:00:00', 'Termín příští návštěvy.'),
(8, 4, '2016-09-23 00:00:00', 'Ukončení případu.'),
(9, 5, '2018-11-15 00:18:11', 'Termín příští návštěvy.'),
(10, 1, '2019-01-13 00:00:00', 'Zahájení případu, určení diagnozy a medikamentů.\nUrčena další návštěva.'),
(11, 6, '2018-11-13 00:00:00', 'Zahájení případu, určení diagnozy a medikamentů.\nUrčena další návštěva.'),
(12, 7, '2018-11-27 00:00:00', 'Zahájení prípadu, urcení diagnozy a medikamentu.\r\nUrcena další návšteva.');

--
-- Klíče pro exportované tabulky
--

--
-- Klíče pro tabulku `case`
--
ALTER TABLE `case`
  ADD PRIMARY KEY (`idCase`),
  ADD KEY `idDoctor` (`idDoctor`),
  ADD KEY `idPatient` (`idPatient`),
  ADD KEY `idDiagnosis` (`idDiagnosis`);

--
-- Klíče pro tabulku `diagnosis`
--
ALTER TABLE `diagnosis`
  ADD PRIMARY KEY (`idDiagnosis`);

--
-- Klíče pro tabulku `diagnosisdrugs`
--
ALTER TABLE `diagnosisdrugs`
  ADD KEY `idDiagnosis` (`idDiagnosis`),
  ADD KEY `idDrug` (`idDrug`);

--
-- Klíče pro tabulku `doctor`
--
ALTER TABLE `doctor`
  ADD PRIMARY KEY (`idDoctor`),
  ADD KEY `idUser` (`idUser`);

--
-- Klíče pro tabulku `drug`
--
ALTER TABLE `drug`
  ADD PRIMARY KEY (`idDrug`);

--
-- Klíče pro tabulku `patient`
--
ALTER TABLE `patient`
  ADD PRIMARY KEY (`idPatient`);

--
-- Klíče pro tabulku `user`
--
ALTER TABLE `user`
  ADD PRIMARY KEY (`idUser`);

--
-- Klíče pro tabulku `visit`
--
ALTER TABLE `visit`
  ADD PRIMARY KEY (`idVisit`),
  ADD KEY `idCase` (`idCase`);

--
-- AUTO_INCREMENT pro tabulky
--

--
-- AUTO_INCREMENT pro tabulku `case`
--
ALTER TABLE `case`
  MODIFY `idCase` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;
--
-- AUTO_INCREMENT pro tabulku `diagnosis`
--
ALTER TABLE `diagnosis`
  MODIFY `idDiagnosis` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=44;
--
-- AUTO_INCREMENT pro tabulku `doctor`
--
ALTER TABLE `doctor`
  MODIFY `idDoctor` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
--
-- AUTO_INCREMENT pro tabulku `drug`
--
ALTER TABLE `drug`
  MODIFY `idDrug` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;
--
-- AUTO_INCREMENT pro tabulku `patient`
--
ALTER TABLE `patient`
  MODIFY `idPatient` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;
--
-- AUTO_INCREMENT pro tabulku `user`
--
ALTER TABLE `user`
  MODIFY `idUser` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;
--
-- AUTO_INCREMENT pro tabulku `visit`
--
ALTER TABLE `visit`
  MODIFY `idVisit` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;
--
-- Omezení pro exportované tabulky
--

--
-- Omezení pro tabulku `case`
--
ALTER TABLE `case`
  ADD CONSTRAINT `Key1` FOREIGN KEY (`idDoctor`) REFERENCES `doctor` (`idDoctor`),
  ADD CONSTRAINT `Key2` FOREIGN KEY (`idPatient`) REFERENCES `patient` (`idPatient`),
  ADD CONSTRAINT `Key3` FOREIGN KEY (`idDiagnosis`) REFERENCES `diagnosis` (`idDiagnosis`);

--
-- Omezení pro tabulku `diagnosisdrugs`
--
ALTER TABLE `diagnosisdrugs`
  ADD CONSTRAINT `Key1_DiagnosisDrugs` FOREIGN KEY (`idDiagnosis`) REFERENCES `diagnosis` (`idDiagnosis`),
  ADD CONSTRAINT `Key2_DiagnosisDrugs` FOREIGN KEY (`idDrug`) REFERENCES `drug` (`idDrug`);

--
-- Omezení pro tabulku `doctor`
--
ALTER TABLE `doctor`
  ADD CONSTRAINT `FkDoctoridUser` FOREIGN KEY (`idUser`) REFERENCES `user` (`idUser`);

--
-- Omezení pro tabulku `visit`
--
ALTER TABLE `visit`
  ADD CONSTRAINT `Key1_Visit` FOREIGN KEY (`idCase`) REFERENCES `case` (`idCase`);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
