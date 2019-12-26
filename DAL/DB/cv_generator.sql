DROP DATABASE IF EXISTS `cv_generator`;

CREATE DATABASE IF NOT EXISTS `cv_generator` DEFAULT CHARACTER SET utf8 COLLATE utf8_general_ci;
USE `cv_generator`;

CREATE TABLE `contact` (
  `id` int(11) NOT NULL,
  `nom` varchar(1000) DEFAULT NULL,
  `lien` varchar(1000) DEFAULT NULL,
  `id_utilisateur` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

INSERT INTO `contact` (`id`, `nom`, `lien`, `id_utilisateur`) VALUES
(2, 'Insta', 'instagram.com/p/conqui_hdr', 1);


CREATE TABLE `cv` (
  `id` int(11) NOT NULL,
  `titre` varchar(1000) DEFAULT NULL,
  `id_utilisateur` varchar(1000) DEFAULT NULL,
  `job` varchar(100) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

INSERT INTO `cv` (`id`, `titre`, `id_utilisateur`, `job`) VALUES
(1, 'CV Thalès', '1', 'Ingénieur test'),
(2, 'Thalès', '1', 'Ingénieur IA');

CREATE TABLE `element` (
  `id` int(11) NOT NULL,
  `titre` varchar(1000) DEFAULT NULL,
  `date_deb` varchar(1000) DEFAULT NULL,
  `date_fin` varchar(1000) DEFAULT NULL,
  `lieu` varchar(1000) DEFAULT NULL,
  `competences` varchar(1000) DEFAULT NULL,
  `active` tinyint(4) DEFAULT NULL,
  `hobbies` int(11) DEFAULT NULL,
  `id_section` int(11) DEFAULT NULL,
  `id_cv` int(11) DEFAULT NULL,
  `id_utilisateur` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

INSERT INTO `element` (`id`, `titre`, `date_deb`, `date_fin`, `lieu`, `competences`, `active`, `hobbies`, `id_section`, `id_cv`, `id_utilisateur`) VALUES
(1, 'Prépa PC Lycée Montaigne', '2017-09-03', '2019-07-30', 'Bordeaux', 'Assiduité au travail', 1, 0, 1, 1, 0),
(2, 'Stage I2C', '2017-09-03', '2019-07-30', 'Bordeaux', 'Travail en équipe', 1, 0, 2, 1, 0),
(3, 'Transpromo', '2019-04-09', '2019-08-14', 'Lyon', 'Gestion de projet', 1, 0, 3, 1, 0),
(51, 'Piano', NULL, NULL, NULL, NULL, 1, 1, 0, 0, 1),
(52, 'SQL', NULL, NULL, NULL, NULL, 1, 2, 0, 0, 1);

CREATE TABLE `langue` (
  `id` int(11) NOT NULL,
  `nom` varchar(1000) DEFAULT NULL,
  `certification` varchar(1000) DEFAULT NULL,
  `id_utilisateur` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

INSERT INTO `langue` (`id`, `nom`, `certification`, `id_utilisateur`) VALUES
(9, 'Anglais', 'IELTS 9', 1),
(10, 'Russe', 'Poutine/20', 1),
(11, 'Allemand', 'B4', 1);

CREATE TABLE `section` (
  `id` int(11) NOT NULL,
  `titre` varchar(1000) DEFAULT NULL,
  `id_cv` int(11) DEFAULT NULL,
  `id_utilisateur` int(11) DEFAULT NULL,
  `active` tinyint(1) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

INSERT INTO `section` (`id`, `titre`, `id_cv`, `id_utilisateur`, `active`) VALUES
(1, 'Etudes', 1, 0, 1),
(2, 'Expérience', 1, 0, 1),
(3, 'Projets', 1, 0, 1);

CREATE TABLE `utilisateur` (
  `id` int(11) NOT NULL,
  `nom` varchar(1000) DEFAULT NULL,
  `prenom` varchar(1000) DEFAULT NULL,
  `description` varchar(1000) DEFAULT NULL,
  `mail` varchar(1000) DEFAULT NULL,
  `tel` varchar(1000) DEFAULT NULL,
  `adresse` varchar(1000) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

INSERT INTO `utilisateur` (`id`, `nom`, `prenom`, `description`, `mail`, `tel`, `adresse`) VALUES
(1, 'Coussemacker', 'Yann', 'Eleve Ingenieur à l\'ENSC', 'ycoussemacker@ensc.fr', '06 06 06 06 06', '666 avenue pigalle'),
(7, 'Hacker', 'Boi', 'Je suis conqui', 'h_boi@ensc.fr', '666', '69 avenue Pigalle');

ALTER TABLE `contact`
  ADD PRIMARY KEY (`id`);

ALTER TABLE `cv`
  ADD PRIMARY KEY (`id`);

ALTER TABLE `element`
  ADD PRIMARY KEY (`id`);

ALTER TABLE `langue`
  ADD PRIMARY KEY (`id`);

ALTER TABLE `section`
  ADD PRIMARY KEY (`id`);

ALTER TABLE `utilisateur`
  ADD PRIMARY KEY (`id`);

ALTER TABLE `contact`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

ALTER TABLE `cv`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=16;

ALTER TABLE `element`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=57;

ALTER TABLE `langue`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;

ALTER TABLE `section`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=22;

ALTER TABLE `utilisateur`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=43;

COMMIT;