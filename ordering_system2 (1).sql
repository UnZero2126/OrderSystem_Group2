-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Dec 10, 2024 at 06:19 AM
-- Server version: 10.4.32-MariaDB
-- PHP Version: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `ordering_system2`
--

-- --------------------------------------------------------

--
-- Table structure for table `addons`
--

CREATE TABLE `addons` (
  `AOID` int(11) NOT NULL,
  `Name` varchar(255) NOT NULL,
  `Price` decimal(10,2) NOT NULL,
  `Qty` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `addons`
--

INSERT INTO `addons` (`AOID`, `Name`, `Price`, `Qty`) VALUES
(1, 'Soft Boiled Egg', 30.00, 1),
(2, 'Corn', 20.00, 1),
(3, 'Nori', 80.00, 1),
(4, 'Kimchi', 25.00, 1),
(5, 'Tofu', 30.00, 1);

-- --------------------------------------------------------

--
-- Table structure for table `appetizer`
--

CREATE TABLE `appetizer` (
  `AID` int(11) NOT NULL,
  `Name` varchar(255) NOT NULL,
  `Price` decimal(10,2) NOT NULL,
  `Qty` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `appetizer`
--

INSERT INTO `appetizer` (`AID`, `Name`, `Price`, `Qty`) VALUES
(1, 'Gyoza', 90.00, 3),
(2, 'Takoyaki', 112.00, 1),
(3, 'Edamame', 50.00, 1),
(4, 'Tempura', 160.00, 1),
(5, 'Siomai', 30.00, 1),
(6, 'Salad', 130.00, 1);

-- --------------------------------------------------------

--
-- Table structure for table `desserts`
--

CREATE TABLE `desserts` (
  `DID` int(11) NOT NULL,
  `Name` varchar(255) NOT NULL,
  `Price` decimal(10,2) NOT NULL,
  `SIze` varchar(2) NOT NULL,
  `Qty` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `desserts`
--

INSERT INTO `desserts` (`DID`, `Name`, `Price`, `SIze`, `Qty`) VALUES
(1, 'Mochi', 60.00, '', 1),
(2, 'Ice Cream', 40.00, 'S', 1),
(3, 'Ice Cream', 55.00, 'M', 1),
(4, 'Ice Cream', 65.00, 'L', 1),
(5, 'Bingsu\r\n', 30.00, 'S', 1),
(6, 'Bingsu', 45.00, 'M', 1),
(7, 'Bingsu', 60.00, 'L', 1);

-- --------------------------------------------------------

--
-- Table structure for table `drinks`
--

CREATE TABLE `drinks` (
  `DKID` int(11) NOT NULL,
  `Name` varchar(255) NOT NULL,
  `Price` decimal(10,2) NOT NULL,
  `Size` varchar(2) NOT NULL,
  `Qty` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `drinks`
--

INSERT INTO `drinks` (`DKID`, `Name`, `Price`, `Size`, `Qty`) VALUES
(1, 'Iced Tea', 25.00, 'S', 1),
(2, 'Iced Tea', 40.00, 'M ', 1),
(3, 'Iced Tea', 50.00, 'L', 1),
(4, 'Water', 0.00, '', 1),
(5, 'Pepsi', 25.00, 'S', 1),
(6, 'Pepsi', 40.00, 'M ', 1),
(7, 'Pepsi', 50.00, 'L', 1),
(8, 'Coca Cola', 30.00, 'S', 1),
(9, 'Coca Cola', 45.00, 'M', 1),
(10, 'Coca Cola', 60.00, 'L', 1),
(11, 'Mirinda', 25.00, 'S', 1),
(12, 'Mirinda', 40.00, 'M', 1),
(13, 'Mirinda', 50.00, 'L', 1),
(14, 'Sprite', 25.00, 'S', 1),
(15, 'Sprite', 35.00, 'M', 1),
(16, 'Sprite', 45.00, 'L', 1),
(17, 'Sake', 25.00, 'S', 1),
(18, 'Sake', 40.00, 'M', 1),
(19, 'Sake', 50.00, 'L', 1);

-- --------------------------------------------------------

--
-- Table structure for table `maincourse`
--

CREATE TABLE `maincourse` (
  `MCID` int(11) NOT NULL,
  `Name` varchar(100) NOT NULL,
  `Price` int(11) NOT NULL,
  `Size` varchar(2) NOT NULL,
  `Qty` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `maincourse`
--

INSERT INTO `maincourse` (`MCID`, `Name`, `Price`, `Size`, `Qty`) VALUES
(1, 'Shoyu Ramen', 220, 'S', 1),
(2, 'Shoyu Ramen', 255, 'M', 1),
(3, 'Shoyu Ramen', 270, 'L', 1),
(4, 'Miso Ramen', 180, 'S', 1),
(5, 'Miso Ramen', 220, 'M', 1),
(6, 'Miso Ramen', 250, 'L', 1),
(7, 'Shio Ramen', 250, 'S', 1),
(8, 'Shio Ramen', 280, 'M', 1),
(9, 'Shio Ramen', 340, 'L', 1),
(10, 'Tonkotsu Ramen', 140, 'S', 1),
(11, 'Tonkotsu Ramen', 170, 'M', 1),
(12, 'Tonkotsu Ramen', 200, 'L', 1),
(13, 'Curry Ramen', 130, 'S', 1),
(14, 'Curry Ramen', 155, 'M', 1),
(15, 'Curry Ramen', 170, 'L', 1),
(16, 'Chashu Ramen', 160, 'S', 1),
(17, 'Chashu Ramen', 190, 'M', 1),
(18, 'Chashu Ramen', 220, 'L', 1),
(19, 'Beef Ramen', 200, 'S', 1),
(20, 'Beef Ramen', 250, 'M', 1),
(21, 'Beef Ramen', 290, 'L', 1),
(22, 'Cold Ramen', 89, 'S', 1),
(23, 'Cold Ramen ', 119, 'M', 1),
(24, 'Cold Ramen ', 130, 'L', 1);

-- --------------------------------------------------------

--
-- Table structure for table `makeyourownramen`
--

CREATE TABLE `makeyourownramen` (
  `MID` int(11) NOT NULL,
  `Name` varchar(100) NOT NULL,
  `Price` decimal(10,2) NOT NULL,
  `Qty` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `makeyourownramen`
--

INSERT INTO `makeyourownramen` (`MID`, `Name`, `Price`, `Qty`) VALUES
(1, 'Straight Noodles', 70.00, 1),
(2, 'Wavy Noodles', 80.00, 1),
(3, 'Udon Noodles', 100.00, 1),
(4, 'Cold Ramen Noodles', 40.00, 1),
(5, 'Grilled Chicken', 100.00, 1),
(6, 'Ground Pork', 120.00, 1),
(7, 'Tofu', 20.00, 1),
(8, 'Beef', 110.00, 1),
(9, 'Egg', 15.00, 1),
(10, 'Shrimp', 40.00, 1),
(11, 'Karaage Chicken', 33.00, 1),
(12, 'Corn', 15.00, 1),
(13, 'Nori', 20.00, 1),
(14, 'Seaweed', 30.00, 1),
(15, 'Spinach', 20.00, 1),
(16, 'Green Onions', 10.00, 1),
(17, 'Pickled Ginger', 20.00, 1),
(18, 'Kimchi', 20.00, 1),
(19, 'Fish Cake', 30.00, 1),
(20, 'Cabbage', 20.00, 1),
(21, 'Fried Garlic Chips', 16.00, 1),
(22, 'Cheese', 23.00, 1),
(23, 'Sesame Seeds', 10.00, 1),
(24, 'Chili Oil', 5.00, 1),
(25, 'Garlic ', 10.00, 1),
(26, 'Soy Sauce', 5.00, 1),
(27, 'Vinegar', 5.00, 1),
(28, 'Black Pepper', 5.00, 1),
(29, 'Mushroom', 20.00, 1),
(30, 'Small', 150.00, 1),
(31, 'Medium', 200.00, 1),
(32, 'Large', 250.00, 1),
(33, 'Extra Large', 300.00, 1),
(34, 'Miso', 120.00, 1),
(39, 'Shoyu (Soy Sauce)', 120.00, 1),
(40, 'Shio', 100.00, 1),
(41, 'Tonkatsu', 110.00, 1),
(42, 'Curry Broth', 150.00, 1),
(43, 'Vegetable Broth', 90.00, 1);

-- --------------------------------------------------------

--
-- Table structure for table `signup`
--

CREATE TABLE `signup` (
  `SID` int(11) NOT NULL,
  `FirstName` varchar(255) NOT NULL,
  `LastName` varchar(255) NOT NULL,
  `PhoneNumber` int(11) NOT NULL,
  `Address` varchar(255) NOT NULL,
  `Email` varchar(255) NOT NULL,
  `Username` varchar(255) NOT NULL,
  `Password` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `signup`
--

INSERT INTO `signup` (`SID`, `FirstName`, `LastName`, `PhoneNumber`, `Address`, `Email`, `Username`, `Password`) VALUES
(1, 'Jann Railey', 'De Chavez', 0, 'Darasa', 'jannrailey852@gmail.com', 'Admin', 'admin'),
(2, 'Janmar', 'Brojan', 1234, 'Malvar', 'janmar@emal.com', 'jbrojan', 'jbrojanpass');

-- --------------------------------------------------------

--
-- Table structure for table `voucher`
--

CREATE TABLE `voucher` (
  `VID` int(11) NOT NULL,
  `Name` varchar(255) NOT NULL,
  `discountValue` decimal(10,0) NOT NULL,
  `discountType` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `voucher`
--

INSERT INTO `voucher` (`VID`, `Name`, `discountValue`, `discountType`) VALUES
(1, 'qwerty123', 15, 'Free Shipping'),
(2, 'abcde321', 20, 'Percentage');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `addons`
--
ALTER TABLE `addons`
  ADD PRIMARY KEY (`AOID`);

--
-- Indexes for table `appetizer`
--
ALTER TABLE `appetizer`
  ADD PRIMARY KEY (`AID`);

--
-- Indexes for table `desserts`
--
ALTER TABLE `desserts`
  ADD PRIMARY KEY (`DID`);

--
-- Indexes for table `drinks`
--
ALTER TABLE `drinks`
  ADD PRIMARY KEY (`DKID`);

--
-- Indexes for table `maincourse`
--
ALTER TABLE `maincourse`
  ADD PRIMARY KEY (`MCID`);

--
-- Indexes for table `makeyourownramen`
--
ALTER TABLE `makeyourownramen`
  ADD PRIMARY KEY (`MID`);

--
-- Indexes for table `signup`
--
ALTER TABLE `signup`
  ADD PRIMARY KEY (`SID`);

--
-- Indexes for table `voucher`
--
ALTER TABLE `voucher`
  ADD PRIMARY KEY (`VID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `addons`
--
ALTER TABLE `addons`
  MODIFY `AOID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `appetizer`
--
ALTER TABLE `appetizer`
  MODIFY `AID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT for table `desserts`
--
ALTER TABLE `desserts`
  MODIFY `DID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- AUTO_INCREMENT for table `drinks`
--
ALTER TABLE `drinks`
  MODIFY `DKID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=20;

--
-- AUTO_INCREMENT for table `maincourse`
--
ALTER TABLE `maincourse`
  MODIFY `MCID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=25;

--
-- AUTO_INCREMENT for table `makeyourownramen`
--
ALTER TABLE `makeyourownramen`
  MODIFY `MID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=44;

--
-- AUTO_INCREMENT for table `signup`
--
ALTER TABLE `signup`
  MODIFY `SID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `voucher`
--
ALTER TABLE `voucher`
  MODIFY `VID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
