CREATE SCHEMA `contatos`;

USE contatos;

CREATE TABLE `contatos`.`contatos` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `nome` VARCHAR(120) NOT NULL,
  `telefone` VARCHAR(45) NULL,
  `celular` VARCHAR(45) NULL,
  `email` VARCHAR(45) NULL,
  `tipo` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`id`)
);
