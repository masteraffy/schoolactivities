-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Nov 22, 2022 at 09:43 AM
-- Server version: 10.4.24-MariaDB
-- PHP Version: 8.1.6

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `itc124b2022`
--

-- --------------------------------------------------------

--
-- Table structure for table `tblaccounts`
--

CREATE TABLE `tblaccounts` (
  `USERNAME` varchar(45) COLLATE latin1_bin NOT NULL,
  `PASSWORD` varchar(45) COLLATE latin1_bin NOT NULL,
  `USERTYPE` varchar(45) COLLATE latin1_bin NOT NULL,
  `STATUS` varchar(45) COLLATE latin1_bin DEFAULT NULL,
  `DATECREATED` varchar(45) COLLATE latin1_bin DEFAULT NULL,
  `TIMECREATED` varchar(45) COLLATE latin1_bin DEFAULT NULL,
  `CREATEDBY` varchar(45) COLLATE latin1_bin DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_bin;

--
-- Dumping data for table `tblaccounts`
--

INSERT INTO `tblaccounts` (`USERNAME`, `PASSWORD`, `USERTYPE`, `STATUS`, `DATECREATED`, `TIMECREATED`, `CREATEDBY`) VALUES
('JOHNREY', '123456', 'ADMINISTRATOR', 'ACTIVE', NULL, NULL, NULL),
('JOSHUA', '123456', 'TECHNICAL', 'ACTIVE', '11/22/2022', '4:39:12 pm', 'JOHNREY');

-- --------------------------------------------------------

--
-- Table structure for table `tbldeletelogs`
--

CREATE TABLE `tbldeletelogs` (
  `DATELOG` varchar(45) COLLATE latin1_bin NOT NULL,
  `TIMELOG` varchar(45) COLLATE latin1_bin NOT NULL,
  `ID` varchar(45) COLLATE latin1_bin NOT NULL,
  `PERFORMEDBY` varchar(45) COLLATE latin1_bin NOT NULL,
  `MODULE` varchar(45) COLLATE latin1_bin NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_bin;

--
-- Dumping data for table `tbldeletelogs`
--

INSERT INTO `tbldeletelogs` (`DATELOG`, `TIMELOG`, `ID`, `PERFORMEDBY`, `MODULE`) VALUES
('22/11/2022', '4:38:45 pm', 'JOSHUA', 'RAFFY', 'Accounts Management');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `tblaccounts`
--
ALTER TABLE `tblaccounts`
  ADD PRIMARY KEY (`USERNAME`);

--
-- Indexes for table `tbldeletelogs`
--
ALTER TABLE `tbldeletelogs`
  ADD PRIMARY KEY (`DATELOG`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
