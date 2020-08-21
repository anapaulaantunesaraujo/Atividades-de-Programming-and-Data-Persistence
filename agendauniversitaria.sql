-- phpMyAdmin SQL Dump
-- version 5.0.2
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Tempo de geração: 21-Ago-2020 às 03:14
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
-- Banco de dados: `agendauniversitaria`
--

-- --------------------------------------------------------

--
-- Estrutura da tabela `ag_aulas`
--

CREATE TABLE `ag_aulas` (
  `ID` int(11) NOT NULL,
  `DATA` varchar(16) NOT NULL,
  `OBSERVACAO` text CHARACTER SET utf8 NOT NULL,
  `PROFESSOR` int(11) NOT NULL,
  `DISCIPLINA` int(11) NOT NULL,
  `CURSO` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `ag_aulas`
--

INSERT INTO `ag_aulas` (`ID`, `DATA`, `OBSERVACAO`, `PROFESSOR`, `DISCIPLINA`, `CURSO`) VALUES
(1, '24/08/2020 19:00', 'Aula ao vivo no ambiente blackboard.', 3, 1, 1),
(2, '31/08/2020 19:00', 'Aula ao vivo no ambiente blackboard.', 3, 1, 1),
(3, '09/09/2020 19:00', 'Aula ao vivo no ambiente blackboard.', 3, 1, 1),
(4, '14/09/2020 19:00', 'Aula ao vivo no ambiente blackboard.', 3, 1, 1),
(5, '21/09/2020 19:00', 'Revisão de prova no ambiente blackboard.', 3, 1, 1),
(6, '26/09/2020 19:00', 'Avaliação no ambiente blackboard.', 3, 1, 1),
(7, '01/09/2020 21:00', 'Atividades Síncronas', 2, 2, 1),
(8, '22/09/2020 21:00', 'Atividades Síncronas', 2, 2, 1),
(9, '05/09/2020 19:00', 'Data da entrega - 1ª etapa', 2, 2, 1),
(10, '26/09/2020 19:00', 'Data da entrega - 2ª etapa', 2, 2, 1),
(11, '25/08/2020 19:00', 'Aulas ao vivo no ambiente blackboard', 1, 3, 1),
(12, '01/09/2020 19:00', 'Aulas ao vivo no ambiente blackboard', 1, 3, 1),
(13, '08/09/2020 19:00', 'Aulas ao vivo no ambiente blackboard', 1, 3, 1),
(14, '15/09/2020 19:00', 'Aulas ao vivo no ambiente blackboard', 1, 3, 1),
(15, '26/09/2020 19:00', 'Avaliação no ambiente blackboard', 1, 3, 1),
(16, '26/08/2020 19:00', 'Aula ao vivo pelo app zoom', 4, 4, 2),
(17, '02/09/2020 19:00', 'Aula ao vivo pelo app zoom', 4, 4, 2),
(18, '09/09/2020 19:00', 'Aula ao vivo pelo app zoom', 4, 4, 2),
(19, '16/09/2020 19:00', 'Aula ao vivo pelo app zoom', 4, 4, 2),
(20, '23/09/2020 19:00', 'Aula ao vivo pelo app zoom', 4, 4, 2);

-- --------------------------------------------------------

--
-- Estrutura da tabela `ag_curso`
--

CREATE TABLE `ag_curso` (
  `ID` int(11) NOT NULL,
  `NOME` varchar(200) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `ag_curso`
--

INSERT INTO `ag_curso` (`ID`, `NOME`) VALUES
(1, 'Análise e desenvolvimento de sistemas'),
(2, 'Inglês');

-- --------------------------------------------------------

--
-- Estrutura da tabela `ag_disciplina`
--

CREATE TABLE `ag_disciplina` (
  `ID` int(11) NOT NULL,
  `NOME` varchar(150) CHARACTER SET utf8 NOT NULL,
  `CURSO` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `ag_disciplina`
--

INSERT INTO `ag_disciplina` (`ID`, `NOME`, `CURSO`) VALUES
(1, 'Engenharia de Requisitos', 1),
(2, 'Hands on Work III', 1),
(3, 'Programming and Data Persistence', 1),
(4, 'Inglês - Book 02', 2);

-- --------------------------------------------------------

--
-- Estrutura da tabela `ag_municipio`
--

CREATE TABLE `ag_municipio` (
  `ID` int(11) NOT NULL,
  `NOME` varchar(100) CHARACTER SET utf8 NOT NULL,
  `UF` int(11) NOT NULL,
  `PAIS` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `ag_municipio`
--

INSERT INTO `ag_municipio` (`ID`, `NOME`, `UF`, `PAIS`) VALUES
(1, 'Itajaí', 22, 1),
(2, 'Florianópolis', 22, 1),
(3, 'Navegantes', 22, 1),
(4, 'Blumenau', 22, 1),
(5, 'Brusque', 22, 1),
(6, 'Balneário Camboriú', 22, 1),
(7, 'Camboriú', 22, 1),
(8, 'Tijucas', 22, 1),
(9, 'Penha', 22, 1),
(10, 'Ilhota', 22, 1);

-- --------------------------------------------------------

--
-- Estrutura da tabela `ag_pais`
--

CREATE TABLE `ag_pais` (
  `ID` int(11) NOT NULL,
  `NOME` varchar(100) CHARACTER SET utf8 NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `ag_pais`
--

INSERT INTO `ag_pais` (`ID`, `NOME`) VALUES
(1, 'Brasil'),
(2, 'Estados Unidos'),
(3, 'Espanha'),
(4, 'Mexico'),
(5, 'Canadá'),
(6, 'Chile'),
(7, 'Argentina'),
(8, 'Paraguai');

-- --------------------------------------------------------

--
-- Estrutura da tabela `ag_professor`
--

CREATE TABLE `ag_professor` (
  `ID` int(11) NOT NULL,
  `NOME` varchar(100) CHARACTER SET utf8 NOT NULL,
  `DISCIPLINA` int(11) NOT NULL,
  `MUNICIPIO` int(11) NOT NULL,
  `UF` int(11) NOT NULL,
  `PAIS` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `ag_professor`
--

INSERT INTO `ag_professor` (`ID`, `NOME`, `DISCIPLINA`, `MUNICIPIO`, `UF`, `PAIS`) VALUES
(1, 'Alex Luciano Roesler Rese', 3, 5, 22, 1),
(2, 'Alex Luciano Roesler Rese', 2, 5, 22, 1),
(3, 'Lucas Debatin', 1, 1, 22, 1),
(4, 'Kauana', 4, 1, 22, 1);

-- --------------------------------------------------------

--
-- Estrutura da tabela `ag_uf`
--

CREATE TABLE `ag_uf` (
  `ID` int(11) NOT NULL,
  `NOME` varchar(100) CHARACTER SET utf8 NOT NULL,
  `PAIS` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `ag_uf`
--

INSERT INTO `ag_uf` (`ID`, `NOME`, `PAIS`) VALUES
(1, 'RO', 1),
(2, 'AC', 1),
(3, 'AM', 1),
(4, 'RR', 1),
(5, 'PA', 1),
(6, 'AP', 1),
(7, 'TO', 1),
(8, 'MA', 1),
(9, 'PI', 1),
(10, 'CE', 1),
(11, 'RN', 1),
(12, 'PB', 1),
(13, 'PE', 1),
(14, 'AL', 1),
(15, 'SE', 1),
(16, 'BA', 1),
(17, 'MG', 1),
(18, 'ES', 1),
(19, 'RJ', 1),
(20, 'SP', 1),
(21, 'PR', 1),
(22, 'SC', 1),
(23, 'RS', 1),
(24, 'MS', 1),
(25, 'MT', 1),
(26, 'GO', 1),
(27, 'DF', 1);

--
-- Índices para tabelas despejadas
--

--
-- Índices para tabela `ag_aulas`
--
ALTER TABLE `ag_aulas`
  ADD PRIMARY KEY (`ID`);

--
-- Índices para tabela `ag_curso`
--
ALTER TABLE `ag_curso`
  ADD PRIMARY KEY (`ID`);

--
-- Índices para tabela `ag_disciplina`
--
ALTER TABLE `ag_disciplina`
  ADD PRIMARY KEY (`ID`);

--
-- Índices para tabela `ag_municipio`
--
ALTER TABLE `ag_municipio`
  ADD PRIMARY KEY (`ID`);

--
-- Índices para tabela `ag_pais`
--
ALTER TABLE `ag_pais`
  ADD PRIMARY KEY (`ID`);

--
-- Índices para tabela `ag_professor`
--
ALTER TABLE `ag_professor`
  ADD PRIMARY KEY (`ID`);

--
-- Índices para tabela `ag_uf`
--
ALTER TABLE `ag_uf`
  ADD PRIMARY KEY (`ID`);

--
-- AUTO_INCREMENT de tabelas despejadas
--

--
-- AUTO_INCREMENT de tabela `ag_aulas`
--
ALTER TABLE `ag_aulas`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=21;

--
-- AUTO_INCREMENT de tabela `ag_curso`
--
ALTER TABLE `ag_curso`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT de tabela `ag_disciplina`
--
ALTER TABLE `ag_disciplina`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT de tabela `ag_municipio`
--
ALTER TABLE `ag_municipio`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT de tabela `ag_pais`
--
ALTER TABLE `ag_pais`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT de tabela `ag_professor`
--
ALTER TABLE `ag_professor`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT de tabela `ag_uf`
--
ALTER TABLE `ag_uf`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=28;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
