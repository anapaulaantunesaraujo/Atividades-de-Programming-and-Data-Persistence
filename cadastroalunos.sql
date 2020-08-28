-- phpMyAdmin SQL Dump
-- version 5.0.2
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Tempo de geração: 29-Ago-2020 às 00:47
-- Versão do servidor: 10.4.13-MariaDB
-- versão do PHP: 7.4.8

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Banco de dados: `notas_alunos`
--

-- --------------------------------------------------------

--
-- Estrutura da tabela `cadastroalunos`
--

CREATE TABLE `cadastroalunos` (
  `ID` int(20) NOT NULL,
  `NOME` varchar(150) NOT NULL,
  `IDADE` int(3) NOT NULL,
  `SERIE` int(2) NOT NULL,
  `NOTA` float NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `cadastroalunos`
--

INSERT INTO `cadastroalunos` (`ID`, `NOME`, `IDADE`, `SERIE`, `NOTA`) VALUES
(1, 'Pedro', 10, 1, 10),
(2, 'João', 12, 2, 9),
(3, 'Maria', 9, 2, 10),
(4, 'Carlos', 8, 3, 8),
(5, 'Roberto', 6, 2, 9);

--
-- Índices para tabelas despejadas
--

--
-- Índices para tabela `cadastroalunos`
--
ALTER TABLE `cadastroalunos`
  ADD PRIMARY KEY (`ID`);

--
-- AUTO_INCREMENT de tabelas despejadas
--

--
-- AUTO_INCREMENT de tabela `cadastroalunos`
--
ALTER TABLE `cadastroalunos`
  MODIFY `ID` int(20) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
