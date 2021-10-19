-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Host: localhost
-- Generation Time: Oct 19, 2021 at 02:52 PM
-- Server version: 10.4.21-MariaDB
-- PHP Version: 8.0.11

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `sql_form`
--

-- --------------------------------------------------------

--
-- Table structure for table `form`
--

CREATE TABLE `form` (
  `form_id` int(5) NOT NULL,
  `form_type_id` int(5) NOT NULL,
  `site_name` varchar(255) NOT NULL,
  `cmpltd_by` varchar(255) NOT NULL,
  `date` date NOT NULL,
  `work_area` varchar(255) NOT NULL,
  `job_desc` varchar(255) NOT NULL,
  `supervisor` varchar(255) NOT NULL,
  `inspector` varchar(255) NOT NULL,
  `type` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `form`
--

INSERT INTO `form` (`form_id`, `form_type_id`, `site_name`, `cmpltd_by`, `date`, `work_area`, `job_desc`, `supervisor`, `inspector`, `type`) VALUES
(1, 1, 'Weetabix Burton AP1 / Main', 'John Cord', '2021-09-04', 'AP6 foyer', 'Running and fitting telecom cables', 'Graham Cragg', 'John Cord', 'Install');

-- --------------------------------------------------------

--
-- Table structure for table `form_data`
--

CREATE TABLE `form_data` (
  `form_data_id` int(5) NOT NULL,
  `form_data_type_id` int(5) NOT NULL,
  `form_id` int(5) NOT NULL,
  `interventions` int(5) NOT NULL,
  `comment` varchar(255) DEFAULT NULL,
  `completed` varchar(255) DEFAULT NULL,
  `action_taken` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `form_data`
--

INSERT INTO `form_data` (`form_data_id`, `form_data_type_id`, `form_id`, `interventions`, `comment`, `completed`, `action_taken`) VALUES
(25, 1, 1, 0, NULL, NULL, NULL),
(26, 2, 1, 0, NULL, NULL, NULL),
(27, 3, 1, 0, NULL, NULL, NULL),
(28, 4, 1, 0, NULL, NULL, NULL),
(29, 5, 1, 0, NULL, NULL, NULL),
(30, 6, 1, 1, 'A frame \"men at work\" signs in place', 'Yes', 'Good practice'),
(31, 7, 1, 1, 'Documentation all in order and signed ', 'Yes', 'Commended Guys'),
(32, 8, 1, 0, NULL, NULL, NULL),
(33, 9, 1, 0, NULL, NULL, NULL),
(34, 10, 1, 0, NULL, NULL, NULL),
(35, 11, 1, 1, 'Good housekeeping', 'Yes', 'n//a'),
(36, 12, 1, 0, NULL, NULL, NULL),
(37, 13, 1, 0, NULL, NULL, NULL),
(38, 14, 1, 0, NULL, NULL, NULL),
(39, 15, 1, 0, NULL, NULL, NULL),
(40, 16, 1, 0, NULL, NULL, NULL),
(41, 17, 1, 0, NULL, NULL, NULL),
(42, 18, 1, 0, NULL, NULL, NULL),
(43, 19, 1, 0, NULL, NULL, NULL),
(44, 20, 1, 0, NULL, NULL, NULL),
(45, 21, 1, 0, NULL, NULL, NULL),
(46, 22, 1, 0, NULL, NULL, NULL),
(47, 23, 1, 0, NULL, NULL, NULL),
(48, 24, 1, 0, NULL, NULL, NULL);

-- --------------------------------------------------------

--
-- Table structure for table `form_data_type`
--

CREATE TABLE `form_data_type` (
  `form_data_type_id` int(5) NOT NULL,
  `data_type_name` varchar(255) NOT NULL,
  `section_id` int(5) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `form_data_type`
--

INSERT INTO `form_data_type` (`form_data_type_id`, `data_type_name`, `section_id`) VALUES
(1, 'Work At Height', 1),
(2, 'Lifting Operations - Crane, Fork Lift Truck, Hoists etc', 1),
(3, 'Certification - Daily Check sheets for MEWP and FLT', 1),
(4, 'Confined Space Work', 1),
(5, 'Electrical Work', 1),
(6, 'Site Set Up & Appearance, Signage', 2),
(7, 'Paperwork(Permits, Risk Assessments, Method Statement', 2),
(8, 'Certification - Training, Insurance Inspection, Induction Current', 2),
(9, 'Hot Work', 3),
(10, 'Isolation and Lock Offs', 3),
(11, 'Fire Exits and Escape Routes', 3),
(12, 'Awareness - Fire Exit, Assembly Point', 3),
(13, 'Waste Management', 4),
(14, 'Product Contamination ', 4),
(15, 'COSHH & Asbestos', 4),
(16, 'PPE', 5),
(17, 'Manual Handling', 5),
(18, 'Other Contractors', 5),
(19, 'Power Tools, Cables & Other Equipment', 6),
(20, 'Voltage Detector Checked', 6),
(21, 'Tools Used Fit For Purpose', 6),
(22, 'Company Vehicles', 7),
(23, 'Fire Precautions', 7),
(24, 'Workshop Conditions', 7);

-- --------------------------------------------------------

--
-- Table structure for table `form_type`
--

CREATE TABLE `form_type` (
  `form_type_id` int(5) NOT NULL,
  `form_name` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `form_type`
--

INSERT INTO `form_type` (`form_type_id`, `form_name`) VALUES
(1, 'Health,Safety,Quality and Environmental Site Inspection');

-- --------------------------------------------------------

--
-- Table structure for table `section`
--

CREATE TABLE `section` (
  `section_id` int(5) NOT NULL,
  `section_name` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `section`
--

INSERT INTO `section` (`section_id`, `section_name`) VALUES
(1, 'Working Standards'),
(2, 'Quality'),
(3, 'Site Rules'),
(4, 'Environmental'),
(5, 'Protection Of Individuals'),
(6, 'Tools, Cables & Other Equipment'),
(7, 'Miscellaneous ');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `form`
--
ALTER TABLE `form`
  ADD PRIMARY KEY (`form_id`),
  ADD KEY `form_type_id` (`form_type_id`);

--
-- Indexes for table `form_data`
--
ALTER TABLE `form_data`
  ADD PRIMARY KEY (`form_data_id`),
  ADD KEY `form_data_type_id` (`form_data_type_id`),
  ADD KEY `form_id` (`form_id`);

--
-- Indexes for table `form_data_type`
--
ALTER TABLE `form_data_type`
  ADD PRIMARY KEY (`form_data_type_id`),
  ADD KEY `section_id` (`section_id`);

--
-- Indexes for table `form_type`
--
ALTER TABLE `form_type`
  ADD PRIMARY KEY (`form_type_id`);

--
-- Indexes for table `section`
--
ALTER TABLE `section`
  ADD PRIMARY KEY (`section_id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `form`
--
ALTER TABLE `form`
  MODIFY `form_id` int(5) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT for table `form_data`
--
ALTER TABLE `form_data`
  MODIFY `form_data_id` int(5) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=49;

--
-- AUTO_INCREMENT for table `form_data_type`
--
ALTER TABLE `form_data_type`
  MODIFY `form_data_type_id` int(5) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=25;

--
-- AUTO_INCREMENT for table `form_type`
--
ALTER TABLE `form_type`
  MODIFY `form_type_id` int(5) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT for table `section`
--
ALTER TABLE `section`
  MODIFY `section_id` int(5) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `form`
--
ALTER TABLE `form`
  ADD CONSTRAINT `form_ibfk_1` FOREIGN KEY (`form_type_id`) REFERENCES `form_type` (`form_type_id`);

--
-- Constraints for table `form_data`
--
ALTER TABLE `form_data`
  ADD CONSTRAINT `form_data_ibfk_1` FOREIGN KEY (`form_data_type_id`) REFERENCES `form_data_type` (`form_data_type_id`),
  ADD CONSTRAINT `form_data_ibfk_2` FOREIGN KEY (`form_id`) REFERENCES `form` (`form_id`) ON DELETE CASCADE;

--
-- Constraints for table `form_data_type`
--
ALTER TABLE `form_data_type`
  ADD CONSTRAINT `form_data_type_ibfk_1` FOREIGN KEY (`section_id`) REFERENCES `section` (`section_id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
