﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
    public class Repository
    {
        #region Attributes
        public static Repository instance;
        public static int referenceValue = 50000000;
        private List<Country> countries = new List<Country>();
        private List<Team> teams = new List<Team>();
        private List<Player> players = new List<Player>();
        private List<Journalist> journalists = new List<Journalist>();
        private List<Match> matches = new List<Match>();
        #endregion

        #region Singleton
        public static Repository Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Repository();
                }
                return instance;
            }
        }
        #endregion

        #region Properties
        public int ReferenceValue { get => referenceValue; set => referenceValue = value; }
        public List<Country> Countries { get => countries; }
        public List<Team> Teams { get => teams; }
        public List<Player> Players { get => players; }
        public List<Match> Matches { get => matches; }
        public List<Journalist> Journalists { get => journalists; }
        #endregion

        #region Data Preload
        private Repository()
        {
            #region Countries
            AddCountry(new Country("Catar", "QAT"));
            AddCountry(new Country("Alemania", "DEU"));
            AddCountry(new Country("Dinamarca", "DNK"));
            AddCountry(new Country("Brasil", "BRA"));
            AddCountry(new Country("Francia", "FRA"));
            AddCountry(new Country("Bélgica", "BEL"));
            AddCountry(new Country("Croacia", "HRV"));
            AddCountry(new Country("España", "ESP"));
            AddCountry(new Country("Serbia", "SRB"));
            AddCountry(new Country("Inglaterra", "GBR"));
            AddCountry(new Country("Suiza", "CHE"));
            AddCountry(new Country("Países Bajos", "NLD"));
            AddCountry(new Country("Argentina", "ARG"));
            AddCountry(new Country("Irán", "IRN"));
            AddCountry(new Country("Corea del Sur", "KOR"));
            AddCountry(new Country("Japón", "JPN"));
            AddCountry(new Country("Arabia Saudita", "SAU"));
            AddCountry(new Country("Ecuador", "ECU"));
            AddCountry(new Country("Uruguay", "URY"));
            AddCountry(new Country("Canadá", "CAN"));
            AddCountry(new Country("Ghana", "GHA"));
            AddCountry(new Country("Senegal", "SEN"));
            AddCountry(new Country("Marruecos", "MAR"));
            AddCountry(new Country("Túnez", "TUN"));
            AddCountry(new Country("Portugal", "PRT"));
            AddCountry(new Country("Polonia", "POL"));
            AddCountry(new Country("Camerún", "CMR"));
            AddCountry(new Country("México", "MEX"));
            AddCountry(new Country("Estados Unidos", "USA"));
            AddCountry(new Country("Gales", "WLS"));
            AddCountry(new Country("Australia", "AUS"));
            AddCountry(new Country("Costa Rica", "CRI"));
            #endregion

            #region Players
            AddPlayer(new Player(1, "23", "Emiliano Martínez", DateTime.Parse("1992-09-02"), 1.95, "derecho", 28000000, "EUR", GetCountry("Argentina"), "Portero"));
            AddPlayer(new Player(2, "12", "Gerónimo Rulli", DateTime.Parse("1992-05-20"), 1.89, "derecho", 6000000, "EUR", GetCountry("Argentina"), "Portero"));
            AddPlayer(new Player(3, "1", "Franco Armani", DateTime.Parse("1986-10-16"), 1.89, "derecho", 3500000, "EUR", GetCountry("Argentina"), "Portero"));
            AddPlayer(new Player(4, "13", "Cristian Romero", DateTime.Parse("1998-04-27"), 1.85, "derecho", 48000000, "EUR", GetCountry("Argentina"), "Defensa central"));
            AddPlayer(new Player(5, "16", "Lisandro Martínez", DateTime.Parse("1998-01-18"), 1.75, "izquierdo", 32000000, "EUR", GetCountry("Argentina"), "Defensa central"));
            AddPlayer(new Player(6, "25", "Marcos Senesi", DateTime.Parse("1997-05-10"), 1.85, "izquierdo", 17000000, "EUR", GetCountry("Argentina"), "Defensa central"));
            AddPlayer(new Player(7, "114", "Lucas Martínez Quarta", DateTime.Parse("1996-05-10"), 1.83, "derecho", 12000000, "EUR", GetCountry("Argentina"), "Defensa central"));
            AddPlayer(new Player(8, "6", "Germán Pezzella", DateTime.Parse("1991-06-27"), 1.87, "derecho", 5000000, "EUR", GetCountry("Argentina"), "Defensa central"));
            AddPlayer(new Player(9, "19", "Nicolás Otamendi", DateTime.Parse("1988-02-12"), 1.83, "derecho", 3500000, "EUR", GetCountry("Argentina"), "Defensa central"));
            AddPlayer(new Player(10, "8", "Marcos Acuña", DateTime.Parse("1991-10-28"), 1.72, "izquierdo", 18000000, "EUR", GetCountry("Argentina"), "Lateral izquierdo"));
            AddPlayer(new Player(11, "3", "Nicolás Tagliafico", DateTime.Parse("1992-08-31"), 1.72, "izquierdo", 11000000, "EUR", GetCountry("Argentina"), "Lateral izquierdo"));
            AddPlayer(new Player(12, "2", "Juan Foyth", DateTime.Parse("1998-01-12"), 1.87, "derecho", 25000000, "EUR", GetCountry("Argentina"), "Lateral derecho"));
            AddPlayer(new Player(13, "26", "Nahuel Molina", DateTime.Parse("1998-04-06"), 1.75, "derecho", 20000000, "EUR", GetCountry("Argentina"), "Lateral derecho"));
            AddPlayer(new Player(14, "4", "Gonzalo Montiel", DateTime.Parse("1997-01-01"), 1.76, "derecho", 14000000, "EUR", GetCountry("Argentina"), "Lateral derecho"));
            AddPlayer(new Player(15, "18", "Guido Rodríguez", DateTime.Parse("1994-04-12"), 1.85, "derecho", 25000000, "EUR", GetCountry("Argentina"), "Pivote"));
            AddPlayer(new Player(16, "NDF", "Leandro Paredes", DateTime.Parse("1994-06-29"), 1.8, "derecho", 17000000, "EUR", GetCountry("Argentina"), "Pivote"));
            AddPlayer(new Player(17, "7", "Rodrigo de Paul", DateTime.Parse("1994-05-24"), 1.8, "derecho", 40000000, "EUR", GetCountry("Argentina"), "Mediocentro"));
            AddPlayer(new Player(18, "20", "Giovani Lo Celso", DateTime.Parse("1996-04-09"), 1.77, "izquierdo", 22000000, "EUR", GetCountry("Argentina"), "Mediocentro"));
            AddPlayer(new Player(19, "14", "Exequiel Palacios", DateTime.Parse("1998-10-05"), 1.77, "derecho", 15000000, "EUR", GetCountry("Argentina"), "Mediocentro"));
            AddPlayer(new Player(20, "5", "Alexis Mac Allister", DateTime.Parse("1998-12-24"), 1.74, "derecho", 16000000, "EUR", GetCountry("Argentina"), "Mediocentro ofensivo"));
            AddPlayer(new Player(21, "17", "Papu Gómez", DateTime.Parse("1988-02-15"), 1.67, "derecho", 6000000, "EUR", GetCountry("Argentina"), "Mediocentro ofensivo"));
            AddPlayer(new Player(22, "15", "Nicolás González", DateTime.Parse("1998-04-06"), 1.8, "izquierdo", 25000000, "EUR", GetCountry("Argentina"), "Extremo izquierdo"));
            AddPlayer(new Player(23, "10", "Lionel Messi", DateTime.Parse("1987-06-24"), 1.7, "izquierdo", 50000000, "EUR", GetCountry("Argentina"), "Extremo derecho"));
            AddPlayer(new Player(24, "11", "Ángel Di María", DateTime.Parse("1988-02-14"), 1.8, "izquierdo", 12000000, "EUR", GetCountry("Argentina"), "Extremo derecho"));
            AddPlayer(new Player(25, "21", "Paulo Dybala", DateTime.Parse("1993-11-15"), 1.77, "izquierdo", 35000000, "EUR", GetCountry("Argentina"), "Mediapunta"));
            AddPlayer(new Player(26, "19", "Joaquín Correa", DateTime.Parse("1994-08-13"), 1.88, "derecho", 23000000, "EUR", GetCountry("Argentina"), "Mediapunta"));
            AddPlayer(new Player(27, "22", "Lautaro Martínez", DateTime.Parse("1997-08-22"), 1.74, "derecho", 75000000, "EUR", GetCountry("Argentina"), "Delantero centro"));
            AddPlayer(new Player(28, "9", "Julián Álvarez", DateTime.Parse("2000-01-31"), 1.7, "derecho", 23000000, "EUR", GetCountry("Argentina"), "Delantero centro"));
            AddPlayer(new Player(29, "22", "Meshaal Barsham", DateTime.Parse("1998-02-14"), 1.8, "derecho", 450000, "EUR", GetCountry("Catar"), "Portero"));
            AddPlayer(new Player(30, "1", "Saad Al-Sheeb", DateTime.Parse("1990-02-19"), 1.84, "derecho", 200000, "EUR", GetCountry("Catar"), "Portero"));
            AddPlayer(new Player(31, "21", "Yousef Hassan", DateTime.Parse("1996-05-24"), 0, "NDF", 150000, "EUR", GetCountry("Catar"), "Portero"));
            AddPlayer(new Player(32, "5", "Tarek Salman", DateTime.Parse("1997-12-05"), 1.79, "derecho", 550000, "EUR", GetCountry("Catar"), "Defensa central"));
            AddPlayer(new Player(33, "2", "Pedro Miguel", DateTime.Parse("1990-08-06"), 1.82, "derecho", 500000, "EUR", GetCountry("Catar"), "Defensa central"));
            AddPlayer(new Player(34, "15", "Bassam Al-Rawi", DateTime.Parse("1997-12-16"), 1.75, "derecho", 500000, "EUR", GetCountry("Catar"), "Defensa central"));
            AddPlayer(new Player(35, "16", "Boualem Khoukhi", DateTime.Parse("1990-07-09"), 1.8, "derecho", 500000, "EUR", GetCountry("Catar"), "Defensa central"));
            AddPlayer(new Player(36, "3", "Abdelkarim Hassan", DateTime.Parse("1993-08-28"), 1.86, "izquierdo", 775000, "EUR", GetCountry("Catar"), "Lateral izquierdo"));
            AddPlayer(new Player(37, "14", "Homam Ahmed", DateTime.Parse("1999-08-25"), 1.86, "izquierdo", 500000, "EUR", GetCountry("Catar"), "Lateral izquierdo"));
            AddPlayer(new Player(38, "13", "Musab Khoder", DateTime.Parse("1993-01-01"), 1.74, "derecho", 325000, "EUR", GetCountry("Catar"), "Lateral derecho"));
            AddPlayer(new Player(39, "12", "Karim Boudiaf", DateTime.Parse("1990-09-16"), 1.87, "derecho", 450000, "EUR", GetCountry("Catar"), "Pivote"));
            AddPlayer(new Player(40, "23", "Assim Madibo", DateTime.Parse("1996-10-22"), 1.68, "derecho", 300000, "EUR", GetCountry("Catar"), "Pivote"));
            AddPlayer(new Player(41, "115", "Salem Al-Hajri", DateTime.Parse("1996-04-10"), 1.83, "derecho", 250000, "EUR", GetCountry("Catar"), "Pivote"));
            AddPlayer(new Player(42, "167", "Ahmed Fadel", DateTime.Parse("1993-04-07"), 0, "NDF", 175000, "EUR", GetCountry("Catar"), "Pivote"));
            AddPlayer(new Player(43, "154", "Abdulaziz Hatem", DateTime.Parse("1990-10-28"), 1.83, "izquierdo", 500000, "EUR", GetCountry("Catar"), "Mediocentro"));
            AddPlayer(new Player(44, "4", "Mohammed Waad", DateTime.Parse("1999-09-18"), 1.83, "izquierdo", 300000, "EUR", GetCountry("Catar"), "Mediocentro"));
            AddPlayer(new Player(45, "20", "Abdullah Al-Ahrak", DateTime.Parse("1997-05-10"), 1.75, "derecho", 500000, "EUR", GetCountry("Catar"), "Mediocentro ofensivo"));
            AddPlayer(new Player(46, "8", "Ali Asad", DateTime.Parse("1993-01-19"), 1.75, "derecho", 250000, "EUR", GetCountry("Catar"), "Mediocentro ofensivo"));
            AddPlayer(new Player(47, "11", "Akram Afif", DateTime.Parse("1996-11-18"), 1.77, "derecho", 5500000, "EUR", GetCountry("Catar"), "Extremo izquierdo"));
            AddPlayer(new Player(48, "NDF", "Abdelrahman Moustafa", DateTime.Parse("1997-04-05"), 1.68, "derecho", 375000, "EUR", GetCountry("Catar"), "Extremo izquierdo"));
            AddPlayer(new Player(49, "18", "Khalid Muneer Mazeed", DateTime.Parse("1998-02-24"), 1.74, "NDF", 350000, "EUR", GetCountry("Catar"), "Extremo izquierdo"));
            AddPlayer(new Player(50, "41", "Hasan Al-Haydos", DateTime.Parse("1990-12-11"), 1.74, "derecho", 1300000, "EUR", GetCountry("Catar"), "Extremo derecho"));
            AddPlayer(new Player(51, "NDF", "Hazem Ahmed", DateTime.Parse("1998-02-02"), 0, "izquierdo", 400000, "EUR", GetCountry("Catar"), "Extremo derecho"));
            AddPlayer(new Player(52, "17", "Ismaeel Mohammed", DateTime.Parse("1990-04-05"), 1.68, "derecho", 250000, "EUR", GetCountry("Catar"), "Extremo derecho"));
            AddPlayer(new Player(53, "19", "Almoez Ali", DateTime.Parse("1996-08-19"), 1.8, "derecho", 2800000, "EUR", GetCountry("Catar"), "Delantero centro"));
            AddPlayer(new Player(54, "7", "Ahmed Alaaeldin", DateTime.Parse("1993-01-31"), 1.77, "derecho", 700000, "EUR", GetCountry("Catar"), "Delantero centro"));
            AddPlayer(new Player(55, "NDF", "Mohammed Muntari", DateTime.Parse("1993-12-20"), 1.94, "derecho", 350000, "EUR", GetCountry("Catar"), "Delantero centro"));
            AddPlayer(new Player(56, "1", "Manuel Neuer", DateTime.Parse("1986-03-27"), 1.93, "derecho", 15000000, "EUR", GetCountry("Alemania"), "Portero"));
            AddPlayer(new Player(57, "12", "Kevin Trapp", DateTime.Parse("1990-07-08"), 1.89, "derecho", 7000000, "EUR", GetCountry("Alemania"), "Portero"));
            AddPlayer(new Player(58, "22", "Oliver Baumann", DateTime.Parse("1990-06-02"), 1.87, "derecho", 4500000, "EUR", GetCountry("Alemania"), "Portero"));
            AddPlayer(new Player(59, "2", "Antonio Rüdiger", DateTime.Parse("1993-03-03"), 1.9, "derecho", 40000000, "EUR", GetCountry("Alemania"), "Defensa central"));
            AddPlayer(new Player(60, "15", "Niklas Süle", DateTime.Parse("1995-09-03"), 1.95, "derecho", 35000000, "EUR", GetCountry("Alemania"), "Defensa central"));
            AddPlayer(new Player(61, "23", "Nico Schlotterbeck", DateTime.Parse("1999-12-01"), 1.91, "izquierdo", 33000000, "EUR", GetCountry("Alemania"), "Defensa central"));
            AddPlayer(new Player(62, "4", "Jonathan Tah", DateTime.Parse("1996-02-11"), 1.95, "derecho", 25000000, "EUR", GetCountry("Alemania"), "Defensa central"));
            AddPlayer(new Player(63, "5", "Thilo Kehrer", DateTime.Parse("1996-09-21"), 1.86, "derecho", 22000000, "EUR", GetCountry("Alemania"), "Defensa central"));
            AddPlayer(new Player(64, "16", "Lukas Klostermann", DateTime.Parse("1996-06-03"), 1.89, "derecho", 18000000, "EUR", GetCountry("Alemania"), "Defensa central"));
            AddPlayer(new Player(65, "3", "David Raum", DateTime.Parse("1998-04-22"), 1.8, "izquierdo", 20000000, "EUR", GetCountry("Alemania"), "Lateral izquierdo"));
            AddPlayer(new Player(66, "17", "Benjamin Henrichs", DateTime.Parse("1997-02-23"), 1.85, "derecho", 14000000, "EUR", GetCountry("Alemania"), "Lateral derecho"));
            AddPlayer(new Player(67, "6", "Joshua Kimmich", DateTime.Parse("1995-02-08"), 1.77, "derecho", 80000000, "EUR", GetCountry("Alemania"), "Pivote"));
            AddPlayer(new Player(68, "2", "Anton Stach", DateTime.Parse("1998-11-15"), 1.94, "ambidiestro", 13000000, "EUR", GetCountry("Alemania"), "Pivote"));
            AddPlayer(new Player(69, "8", "Leon Goretzka ", DateTime.Parse("1995-02-06"), 1.89, "derecho", 65000000, "EUR", GetCountry("Alemania"), "Mediocentro"));
            AddPlayer(new Player(70, "21", "Ilkay Gündogan", DateTime.Parse("1990-10-24"), 1.8, "derecho", 25000000, "EUR", GetCountry("Alemania"), "Mediocentro"));
            AddPlayer(new Player(71, "7", "Kai Havertz", DateTime.Parse("1999-06-11"), 1.9, "izquierdo", 70000000, "EUR", GetCountry("Alemania"), "Mediocentro ofensivo"));
            AddPlayer(new Player(72, "14", "Jamal Musiala", DateTime.Parse("2003-02-26"), 1.83, "derecho", 65000000, "EUR", GetCountry("Alemania"), "Mediocentro ofensivo"));
            AddPlayer(new Player(73, "20", "Julian Brandt", DateTime.Parse("1996-05-02"), 1.85, "derecho", 25000000, "EUR", GetCountry("Alemania"), "Mediocentro ofensivo"));
            AddPlayer(new Player(74, "18", "Jonas Hofmann", DateTime.Parse("1992-07-14"), 1.76, "derecho", 13000000, "EUR", GetCountry("Alemania"), "Mediocentro ofensivo"));
            AddPlayer(new Player(75, "19", "Leroy Sané", DateTime.Parse("1996-01-11"), 1.83, "izquierdo", 60000000, "EUR", GetCountry("Alemania"), "Extremo izquierdo"));
            AddPlayer(new Player(76, "10", "Serge Gnabry", DateTime.Parse("1995-07-14"), 1.76, "derecho", 65000000, "EUR", GetCountry("Alemania"), "Extremo derecho"));
            AddPlayer(new Player(77, "13", "Thomas Müller", DateTime.Parse("1989-09-13"), 1.85, "derecho", 22000000, "EUR", GetCountry("Alemania"), "Mediapunta"));
            AddPlayer(new Player(78, "9", "Timo Werner", DateTime.Parse("1996-03-06"), 1.8, "derecho", 35000000, "EUR", GetCountry("Alemania"), "Delantero centro"));
            AddPlayer(new Player(79, "10", "Karim Adeyemi", DateTime.Parse("2002-01-18"), 1.8, "izquierdo", 35000000, "EUR", GetCountry("Alemania"), "Delantero centro"));
            AddPlayer(new Player(80, "11", "Lukas Nmecha", DateTime.Parse("1998-12-14"), 1.85, "derecho", 18000000, "EUR", GetCountry("Alemania"), "Delantero centro"));
            AddPlayer(new Player(81, "1", "Kasper Schmeichel", DateTime.Parse("1986-11-05"), 1.89, "derecho", 4000000, "EUR", GetCountry("Dinamarca"), "Portero"));
            AddPlayer(new Player(82, "16", "Daniel Iversen", DateTime.Parse("1997-07-19"), 1.91, "NDF", 2000000, "EUR", GetCountry("Dinamarca"), "Portero"));
            AddPlayer(new Player(83, "22", "Peter Vindahl", DateTime.Parse("1998-02-16"), 1.95, "derecho", 900000, "EUR", GetCountry("Dinamarca"), "Portero"));
            AddPlayer(new Player(84, "6", "Andreas Christensen", DateTime.Parse("1996-04-10"), 1.87, "derecho", 35000000, "EUR", GetCountry("Dinamarca"), "Defensa central"));
            AddPlayer(new Player(85, "2", "Joachim Andersen", DateTime.Parse("1996-05-31"), 1.92, "derecho", 25000000, "EUR", GetCountry("Dinamarca"), "Defensa central"));
            AddPlayer(new Player(86, "3", "Jannik Vestergaard", DateTime.Parse("1992-08-03"), 1.99, "ambidiestro", 13000000, "EUR", GetCountry("Dinamarca"), "Defensa central"));
            AddPlayer(new Player(87, "4", "Victor Nelsson", DateTime.Parse("1998-10-14"), 1.85, "derecho", 12000000, "EUR", GetCountry("Dinamarca"), "Defensa central"));
            AddPlayer(new Player(88, "20", "Nicolai Boilesen", DateTime.Parse("1992-02-16"), 1.86, "izquierdo", 1000000, "EUR", GetCountry("Dinamarca"), "Defensa central"));
            AddPlayer(new Player(89, "13", "Rasmus Kristensen", DateTime.Parse("1997-07-11"), 1.87, "derecho", 15000000, "EUR", GetCountry("Dinamarca"), "Lateral derecho"));
            AddPlayer(new Player(90, "5", "Joakim Maehle", DateTime.Parse("1997-05-20"), 1.85, "derecho", 14000000, "EUR", GetCountry("Dinamarca"), "Lateral derecho"));
            AddPlayer(new Player(91, "17", "Jens Stryger Larsen", DateTime.Parse("1991-02-21"), 1.8, "ambidiestro", 2000000, "EUR", GetCountry("Dinamarca"), "Lateral derecho"));
            AddPlayer(new Player(92, "8", "Morten Hjulmand", DateTime.Parse("1999-06-25"), 1.85, "derecho", 6500000, "EUR", GetCountry("Dinamarca"), "Pivote"));
            AddPlayer(new Player(93, "23", "Pierre-Emile Höjbjerg", DateTime.Parse("1995-08-05"), 1.85, "derecho", 40000000, "EUR", GetCountry("Dinamarca"), "Mediocentro"));
            AddPlayer(new Player(94, "15", "Philip Billing", DateTime.Parse("1996-06-11"), 1.93, "izquierdo", 18000000, "EUR", GetCountry("Dinamarca"), "Mediocentro"));
            AddPlayer(new Player(95, "7", "Mathias Jensen", DateTime.Parse("1996-01-01"), 1.8, "derecho", 10000000, "EUR", GetCountry("Dinamarca"), "Mediocentro"));
            AddPlayer(new Player(96, "18", "Daniel Wass", DateTime.Parse("1989-05-31"), 1.78, "derecho", 6000000, "EUR", GetCountry("Dinamarca"), "Mediocentro"));
            AddPlayer(new Player(97, "11", "Andreas Skov Olsen", DateTime.Parse("1999-12-29"), 1.87, "izquierdo", 12000000, "EUR", GetCountry("Dinamarca"), "Interior derecho"));
            AddPlayer(new Player(98, "10", "Christian Eriksen", DateTime.Parse("1992-02-14"), 1.82, "derecho", 20000000, "EUR", GetCountry("Dinamarca"), "Mediocentro ofensivo"));
            AddPlayer(new Player(99, "14", "Mikkel Damsgaard", DateTime.Parse("2000-07-03"), 1.8, "derecho", 15000000, "EUR", GetCountry("Dinamarca"), "Extremo izquierdo"));
            AddPlayer(new Player(100, "12", "Robert Skov", DateTime.Parse("1996-05-20"), 1.85, "izquierdo", 7000000, "EUR", GetCountry("Dinamarca"), "Extremo derecho"));
            AddPlayer(new Player(101, "19", "Jonas Wind", DateTime.Parse("1999-02-07"), 1.9, "derecho", 14000000, "EUR", GetCountry("Dinamarca"), "Delantero centro"));
            AddPlayer(new Player(102, "21", "Andreas Cornelius", DateTime.Parse("1993-03-16"), 1.93, "izquierdo", 9000000, "EUR", GetCountry("Dinamarca"), "Delantero centro"));
            AddPlayer(new Player(103, "9", "Martin Braithwaite", DateTime.Parse("1991-06-05"), 1.77, "derecho", 6000000, "EUR", GetCountry("Dinamarca"), "Delantero centro"));
            AddPlayer(new Player(104, "1", "Alisson", DateTime.Parse("1992-10-02"), 1.91, "derecho", 50000000, "EUR", GetCountry("Brasil"), "Portero"));
            AddPlayer(new Player(105, "23", "Ederson", DateTime.Parse("1993-08-17"), 1.88, "izquierdo", 45000000, "EUR", GetCountry("Brasil"), "Portero"));
            AddPlayer(new Player(106, "12", "Weverton", DateTime.Parse("1987-12-13"), 1.89, "derecho", 4500000, "EUR", GetCountry("Brasil"), "Portero"));
            AddPlayer(new Player(107, "4", "Marquinhos", DateTime.Parse("1994-05-14"), 1.83, "derecho", 70000000, "EUR", GetCountry("Brasil"), "Defensa central"));
            AddPlayer(new Player(108, "2", "Éder Militão", DateTime.Parse("1998-01-18"), 1.86, "derecho", 60000000, "EUR", GetCountry("Brasil"), "Defensa central"));
            AddPlayer(new Player(109, "22", "Gabriel Magalhães", DateTime.Parse("1997-12-19"), 1.9, "izquierdo", 38000000, "EUR", GetCountry("Brasil"), "Defensa central"));
            AddPlayer(new Player(110, "NDF", "Léo Ortiz", DateTime.Parse("1996-01-03"), 1.85, "derecho", 7500000, "EUR", GetCountry("Brasil"), "Defensa central"));
            AddPlayer(new Player(111, "3", "Thiago Silva", DateTime.Parse("1984-09-22"), 1.81, "derecho", 2500000, "EUR", GetCountry("Brasil"), "Defensa central"));
            AddPlayer(new Player(112, "16", "Alex Telles", DateTime.Parse("1992-12-15"), 1.81, "izquierdo", 18000000, "EUR", GetCountry("Brasil"), "Lateral izquierdo"));
            AddPlayer(new Player(113, "14", "Guilherme Arana", DateTime.Parse("1997-04-14"), 1.76, "izquierdo", 14000000, "EUR", GetCountry("Brasil"), "Lateral izquierdo"));
            AddPlayer(new Player(114, "6", "Alex Sandro", DateTime.Parse("1991-01-26"), 1.81, "izquierdo", 6000000, "EUR", GetCountry("Brasil"), "Lateral izquierdo"));
            AddPlayer(new Player(115, "2", "Danilo", DateTime.Parse("1991-07-15"), 1.84, "derecho", 13000000, "EUR", GetCountry("Brasil"), "Lateral derecho"));
            AddPlayer(new Player(116, "13", "Dani Alves", DateTime.Parse("1983-05-06"), 1.72, "derecho", 1000000, "EUR", GetCountry("Brasil"), "Lateral derecho"));
            AddPlayer(new Player(117, "15", "Fabinho", DateTime.Parse("1993-10-23"), 1.88, "derecho", 60000000, "EUR", GetCountry("Brasil"), "Pivote"));
            AddPlayer(new Player(118, "5", "Casemiro", DateTime.Parse("1992-02-23"), 1.85, "derecho", 40000000, "EUR", GetCountry("Brasil"), "Pivote"));
            AddPlayer(new Player(119, "17", "Bruno Guimarães", DateTime.Parse("1997-11-16"), 1.82, "derecho", 40000000, "EUR", GetCountry("Brasil"), "Pivote"));
            AddPlayer(new Player(120, "14", "Danilo", DateTime.Parse("2001-04-29"), 1.77, "izquierdo", 22000000, "EUR", GetCountry("Brasil"), "Pivote"));
            AddPlayer(new Player(121, "8", "Fred", DateTime.Parse("1993-03-05"), 1.69, "izquierdo", 20000000, "EUR", GetCountry("Brasil"), "Mediocentro"));
            AddPlayer(new Player(122, "7", "Lucas Paquetá", DateTime.Parse("1997-08-27"), 1.8, "izquierdo", 35000000, "EUR", GetCountry("Brasil"), "Mediocentro ofensivo"));
            AddPlayer(new Player(123, "20", "Vinicius Junior", DateTime.Parse("2000-07-12"), 1.76, "derecho", 100000000, "EUR", GetCountry("Brasil"), "Extremo izquierdo"));
            AddPlayer(new Player(124, "10", "Neymar", DateTime.Parse("1992-02-05"), 1.75, "derecho", 75000000, "EUR", GetCountry("Brasil"), "Extremo izquierdo"));
            AddPlayer(new Player(125, "22", "Gabriel Martinelli", DateTime.Parse("2001-06-18"), 1.76, "derecho", 40000000, "EUR", GetCountry("Brasil"), "Extremo izquierdo"));
            AddPlayer(new Player(126, "11", "Philippe Coutinho", DateTime.Parse("1992-06-12"), 1.72, "derecho", 20000000, "EUR", GetCountry("Brasil"), "Extremo izquierdo"));
            AddPlayer(new Player(127, "23", "Rodrygo", DateTime.Parse("2001-01-09"), 1.74, "derecho", 60000000, "EUR", GetCountry("Brasil"), "Extremo derecho"));
            AddPlayer(new Player(128, "19", "Raphinha", DateTime.Parse("1996-12-14"), 1.76, "izquierdo", 45000000, "EUR", GetCountry("Brasil"), "Extremo derecho"));
            AddPlayer(new Player(129, "18", "Gabriel Jesus", DateTime.Parse("1997-04-03"), 1.75, "derecho", 50000000, "EUR", GetCountry("Brasil"), "Delantero centro"));
            AddPlayer(new Player(130, "9", "Richarlison", DateTime.Parse("1997-05-10"), 1.84, "derecho", 48000000, "EUR", GetCountry("Brasil"), "Delantero centro"));
            AddPlayer(new Player(131, "21", "Matheus Cunha", DateTime.Parse("1999-05-27"), 1.84, "derecho", 30000000, "EUR", GetCountry("Brasil"), "Delantero centro"));
            AddPlayer(new Player(132, "16", "Mike Maignan", DateTime.Parse("1995-07-03"), 1.91, "derecho", 35000000, "EUR", GetCountry("Francia"), "Portero"));
            AddPlayer(new Player(133, "23", "Alphonse Areola", DateTime.Parse("1993-02-27"), 1.95, "derecho", 8000000, "EUR", GetCountry("Francia"), "Portero"));
            AddPlayer(new Player(134, "1", "Hugo Lloris", DateTime.Parse("1986-12-26"), 1.88, "izquierdo", 7000000, "EUR", GetCountry("Francia"), "Portero"));
            AddPlayer(new Player(135, "5", "Jules Koundé", DateTime.Parse("1998-11-12"), 1.78, "derecho", 60000000, "EUR", GetCountry("Francia"), "Defensa central"));
            AddPlayer(new Player(136, "21", "Lucas Hernández", DateTime.Parse("1996-02-14"), 1.84, "izquierdo", 50000000, "EUR", GetCountry("Francia"), "Defensa central"));
            AddPlayer(new Player(137, "4", "Raphaël Varane", DateTime.Parse("1993-04-25"), 1.91, "derecho", 48000000, "EUR", GetCountry("Francia"), "Defensa central"));
            AddPlayer(new Player(138, "3", "Presnel Kimpembe", DateTime.Parse("1995-08-13"), 1.83, "izquierdo", 40000000, "EUR", GetCountry("Francia"), "Defensa central"));
            AddPlayer(new Player(139, "4", "Ibrahima Konaté", DateTime.Parse("1999-05-25"), 1.94, "derecho", 40000000, "EUR", GetCountry("Francia"), "Defensa central"));
            AddPlayer(new Player(140, "17", "William Saliba", DateTime.Parse("2001-03-24"), 1.92, "derecho", 30000000, "EUR", GetCountry("Francia"), "Defensa central"));
            AddPlayer(new Player(141, "22", "Theo Hernández", DateTime.Parse("1997-10-06"), 1.84, "izquierdo", 55000000, "EUR", GetCountry("Francia"), "Lateral izquierdo"));
            AddPlayer(new Player(142, "18", "Lucas Digne", DateTime.Parse("1993-07-20"), 1.78, "izquierdo", 25000000, "EUR", GetCountry("Francia"), "Lateral izquierdo"));
            AddPlayer(new Player(143, "2", "Benjamin Pavard", DateTime.Parse("1996-03-28"), 1.86, "derecho", 30000000, "EUR", GetCountry("Francia"), "Lateral derecho"));
            AddPlayer(new Player(144, "15", "Jonathan Clauss", DateTime.Parse("1992-09-25"), 1.78, "derecho", 15000000, "EUR", GetCountry("Francia"), "Lateral derecho"));
            AddPlayer(new Player(145, "8", "Aurélien Tchouameni", DateTime.Parse("2000-01-27"), 1.88, "derecho", 60000000, "EUR", GetCountry("Francia"), "Pivote"));
            AddPlayer(new Player(146, "13", "N'Golo Kanté ", DateTime.Parse("1991-03-29"), 1.68, "derecho", 40000000, "EUR", GetCountry("Francia"), "Pivote"));
            AddPlayer(new Player(147, "13", "Boubacar Kamara", DateTime.Parse("1999-11-23"), 1.84, "derecho", 25000000, "EUR", GetCountry("Francia"), "Pivote"));
            AddPlayer(new Player(148, "6", "Mattéo Guendouzi", DateTime.Parse("1999-04-14"), 1.85, "derecho", 25000000, "EUR", GetCountry("Francia"), "Mediocentro"));
            AddPlayer(new Player(149, "14", "Adrien Rabiot", DateTime.Parse("1995-04-03"), 1.88, "izquierdo", 17000000, "EUR", GetCountry("Francia"), "Mediocentro"));
            AddPlayer(new Player(150, "20", "Moussa Diaby", DateTime.Parse("1999-07-07"), 1.7, "izquierdo", 60000000, "EUR", GetCountry("Francia"), "Extremo izquierdo"));
            AddPlayer(new Player(151, "11", "Kingsley Coman ", DateTime.Parse("1996-06-13"), 1.8, "derecho", 60000000, "EUR", GetCountry("Francia"), "Extremo derecho"));
            AddPlayer(new Player(152, "12", "Christopher Nkunku", DateTime.Parse("1997-11-14"), 1.75, "derecho", 80000000, "EUR", GetCountry("Francia"), "Mediapunta"));
            AddPlayer(new Player(153, "7", "Antoine Griezmann", DateTime.Parse("1991-03-21"), 1.76, "izquierdo", 35000000, "EUR", GetCountry("Francia"), "Mediapunta"));
            AddPlayer(new Player(154, "10", "Kylian Mbappé", DateTime.Parse("1998-12-20"), 1.78, "derecho", 160000000, "EUR", GetCountry("Francia"), "Delantero centro"));
            AddPlayer(new Player(155, "19", "Karim Benzema", DateTime.Parse("1987-12-19"), 1.85, "derecho", 30000000, "EUR", GetCountry("Francia"), "Delantero centro"));
            AddPlayer(new Player(156, "9", "Wissam Ben Yedder", DateTime.Parse("1990-08-12"), 1.7, "ambidiestro", 25000000, "EUR", GetCountry("Francia"), "Delantero centro"));
            AddPlayer(new Player(157, "13", "Koen Casteels", DateTime.Parse("1992-06-25"), 1.97, "izquierdo", 11000000, "EUR", GetCountry("Bélgica"), "Portero"));
            AddPlayer(new Player(158, "1", "Matz Sels", DateTime.Parse("1992-02-26"), 1.88, "derecho", 8000000, "EUR", GetCountry("Bélgica"), "Portero"));
            AddPlayer(new Player(159, "12", "Simon Mignolet", DateTime.Parse("1988-03-06"), 1.93, "derecho", 3500000, "EUR", GetCountry("Bélgica"), "Portero"));
            AddPlayer(new Player(160, "3", "Arthur Theate", DateTime.Parse("2000-05-25"), 1.86, "izquierdo", 15000000, "EUR", GetCountry("Bélgica"), "Defensa central"));
            AddPlayer(new Player(161, "NDF", "Wout Faes", DateTime.Parse("1998-04-03"), 1.87, "derecho", 10000000, "EUR", GetCountry("Bélgica"), "Defensa central"));
            AddPlayer(new Player(162, "2", "Toby Alderweireld ", DateTime.Parse("1989-03-02"), 1.87, "derecho", 7000000, "EUR", GetCountry("Bélgica"), "Defensa central"));
            AddPlayer(new Player(163, "4", "Brandon Mechele", DateTime.Parse("1993-01-28"), 1.9, "derecho", 6000000, "EUR", GetCountry("Bélgica"), "Defensa central"));
            AddPlayer(new Player(164, "5", "Jan Vertonghen", DateTime.Parse("1987-04-24"), 1.89, "izquierdo", 2000000, "EUR", GetCountry("Bélgica"), "Defensa central"));
            AddPlayer(new Player(165, "21", "Timothy Castagne", DateTime.Parse("1995-12-05"), 1.85, "derecho", 28000000, "EUR", GetCountry("Bélgica"), "Lateral derecho"));
            AddPlayer(new Player(166, "15", "Thomas Foket", DateTime.Parse("1994-09-25"), 1.77, "derecho", 5000000, "EUR", GetCountry("Bélgica"), "Lateral derecho"));
            AddPlayer(new Player(167, "19", "Leander Dendoncker", DateTime.Parse("1995-04-15"), 1.88, "derecho", 28000000, "EUR", GetCountry("Bélgica"), "Pivote"));
            AddPlayer(new Player(168, "6", "Axel Witsel", DateTime.Parse("1989-01-12"), 1.86, "derecho", 4000000, "EUR", GetCountry("Bélgica"), "Pivote"));
            AddPlayer(new Player(169, "8", "Youri Tielemans", DateTime.Parse("1997-05-07"), 1.76, "derecho", 55000000, "EUR", GetCountry("Bélgica"), "Mediocentro"));
            AddPlayer(new Player(170, "7", "Dennis Praet", DateTime.Parse("1994-05-14"), 1.81, "derecho", 13000000, "EUR", GetCountry("Bélgica"), "Mediocentro"));
            AddPlayer(new Player(171, "11", "Charles De Ketelaere", DateTime.Parse("2001-03-10"), 1.92, "izquierdo", 30000000, "EUR", GetCountry("Bélgica"), "Mediocentro ofensivo"));
            AddPlayer(new Player(172, "20", "Hans Vanaken", DateTime.Parse("1992-08-24"), 1.95, "derecho", 16000000, "EUR", GetCountry("Bélgica"), "Mediocentro ofensivo"));
            AddPlayer(new Player(173, "17", "Leandro Trossard", DateTime.Parse("1994-12-04"), 1.72, "derecho", 20000000, "EUR", GetCountry("Bélgica"), "Extremo izquierdo"));
            AddPlayer(new Player(174, "16", "Thorgan Hazard", DateTime.Parse("1993-03-29"), 1.75, "derecho", 15000000, "EUR", GetCountry("Bélgica"), "Extremo izquierdo"));
            AddPlayer(new Player(175, "10", "Eden Hazard", DateTime.Parse("1991-01-07"), 1.75, "derecho", 12000000, "EUR", GetCountry("Bélgica"), "Extremo izquierdo"));
            AddPlayer(new Player(176, "22", "Alexis Saelemaekers", DateTime.Parse("1999-06-27"), 1.8, "derecho", 17000000, "EUR", GetCountry("Bélgica"), "Extremo derecho"));
            AddPlayer(new Player(177, "18", "Adnan Januzaj", DateTime.Parse("1995-02-05"), 1.86, "izquierdo", 12000000, "EUR", GetCountry("Bélgica"), "Extremo derecho"));
            AddPlayer(new Player(178, "23", "Michy Batshuayi", DateTime.Parse("1993-10-02"), 1.85, "derecho", 10000000, "EUR", GetCountry("Bélgica"), "Delantero centro"));
            AddPlayer(new Player(179, "9", "Loïs Openda", DateTime.Parse("2000-02-16"), 1.75, "derecho", 7500000, "EUR", GetCountry("Bélgica"), "Delantero centro"));
            AddPlayer(new Player(180, "14", "Dries Mertens", DateTime.Parse("1987-05-06"), 1.69, "derecho", 4000000, "EUR", GetCountry("Bélgica"), "Delantero centro"));
            AddPlayer(new Player(181, "1", "Dominik Livakovic", DateTime.Parse("1995-01-09"), 1.88, "derecho", 8500000, "EUR", GetCountry("Croacia"), "Portero"));
            AddPlayer(new Player(182, "23", "Ivica Ivusic", DateTime.Parse("1995-02-01"), 1.95, "derecho", 4500000, "EUR", GetCountry("Croacia"), "Portero"));
            AddPlayer(new Player(183, "12", "Nediljko Labrovic", DateTime.Parse("1999-10-10"), 1.96, "derecho", 2000000, "EUR", GetCountry("Croacia"), "Portero"));
            AddPlayer(new Player(184, "5", "Duje Caleta-Car", DateTime.Parse("1996-09-17"), 1.92, "derecho", 16000000, "EUR", GetCountry("Croacia"), "Defensa central"));
            AddPlayer(new Player(185, "6", "Josip Sutalo", DateTime.Parse("2000-02-28"), 1.88, "derecho", 8000000, "EUR", GetCountry("Croacia"), "Defensa central"));
            AddPlayer(new Player(186, "2", "Marin Pongracic", DateTime.Parse("1997-09-11"), 1.93, "derecho", 6000000, "EUR", GetCountry("Croacia"), "Defensa central"));
            AddPlayer(new Player(187, "20", "Martin Erlic", DateTime.Parse("1998-01-24"), 1.93, "derecho", 5500000, "EUR", GetCountry("Croacia"), "Defensa central"));
            AddPlayer(new Player(188, "21", "Domagoj Vida", DateTime.Parse("1989-04-29"), 1.84, "derecho", 1900000, "EUR", GetCountry("Croacia"), "Defensa central"));
            AddPlayer(new Player(189, "19", "Borna Sosa", DateTime.Parse("1998-01-21"), 1.87, "izquierdo", 23000000, "EUR", GetCountry("Croacia"), "Lateral izquierdo"));
            AddPlayer(new Player(190, "3", "Borna Barisic", DateTime.Parse("1992-11-10"), 1.86, "izquierdo", 6000000, "EUR", GetCountry("Croacia"), "Lateral izquierdo"));
            AddPlayer(new Player(191, "22", "Josip Juranovic", DateTime.Parse("1995-08-16"), 1.73, "derecho", 7000000, "EUR", GetCountry("Croacia"), "Lateral derecho"));
            AddPlayer(new Player(192, "2", "Sime Vrsaljko ", DateTime.Parse("1992-01-10"), 1.81, "derecho", 5000000, "EUR", GetCountry("Croacia"), "Lateral derecho"));
            AddPlayer(new Player(193, "3", "Josip Stanisic", DateTime.Parse("2000-04-02"), 1.87, "ambidiestro", 4000000, "EUR", GetCountry("Croacia"), "Lateral derecho"));
            AddPlayer(new Player(194, "11", "Marcelo Brozovic", DateTime.Parse("1992-11-16"), 1.81, "ambidiestro", 40000000, "EUR", GetCountry("Croacia"), "Pivote"));
            AddPlayer(new Player(195, "16", "Kristijan Jakic", DateTime.Parse("1997-05-14"), 1.81, "derecho", 9000000, "EUR", GetCountry("Croacia"), "Pivote"));
            AddPlayer(new Player(196, "8", "Mateo Kovacic", DateTime.Parse("1994-05-06"), 1.76, "derecho", 42000000, "EUR", GetCountry("Croacia"), "Mediocentro"));
            AddPlayer(new Player(197, "14", "Luka Sucic", DateTime.Parse("2002-09-08"), 1.85, "izquierdo", 20000000, "EUR", GetCountry("Croacia"), "Mediocentro"));
            AddPlayer(new Player(198, "10", "Luka Modric", DateTime.Parse("1985-09-09"), 1.72, "ambidiestro", 10000000, "EUR", GetCountry("Croacia"), "Mediocentro"));
            AddPlayer(new Player(199, "15", "Mario Pasalic", DateTime.Parse("1995-02-09"), 1.88, "derecho", 28000000, "EUR", GetCountry("Croacia"), "Mediocentro ofensivo"));
            AddPlayer(new Player(200, "13", "Nikola Vlasic", DateTime.Parse("1997-10-04"), 1.78, "derecho", 22000000, "EUR", GetCountry("Croacia"), "Mediocentro ofensivo"));
            AddPlayer(new Player(201, "4", "Lovro Majer", DateTime.Parse("1998-01-17"), 1.76, "izquierdo", 20000000, "EUR", GetCountry("Croacia"), "Mediocentro ofensivo"));
            AddPlayer(new Player(202, "19", "Luka Ivanusec", DateTime.Parse("1998-11-26"), 1.75, "derecho", 12500000, "EUR", GetCountry("Croacia"), "Mediocentro ofensivo"));
            AddPlayer(new Player(203, "7", "Josip Brekalo", DateTime.Parse("1998-06-23"), 1.75, "derecho", 15000000, "EUR", GetCountry("Croacia"), "Extremo izquierdo"));
            AddPlayer(new Player(204, "18", "Mislav Orsic", DateTime.Parse("1992-12-29"), 1.79, "ambidiestro", 10000000, "EUR", GetCountry("Croacia"), "Extremo izquierdo"));
            AddPlayer(new Player(205, "9", "Andrej Kramaric", DateTime.Parse("1991-06-19"), 1.77, "derecho", 12000000, "EUR", GetCountry("Croacia"), "Delantero centro"));
            AddPlayer(new Player(206, "NDF", "Marko Livaja", DateTime.Parse("1993-08-26"), 1.84, "derecho", 7500000, "EUR", GetCountry("Croacia"), "Delantero centro"));
            AddPlayer(new Player(207, "17", "Ante Budimir", DateTime.Parse("1991-07-22"), 1.9, "izquierdo", 6000000, "EUR", GetCountry("Croacia"), "Delantero centro"));
            AddPlayer(new Player(208, "NDF", "Petar Musa", DateTime.Parse("1998-03-04"), 1.9, "derecho", 5000000, "EUR", GetCountry("Croacia"), "Delantero centro"));
            AddPlayer(new Player(209, "23", "Unai Simón ", DateTime.Parse("1997-06-11"), 1.9, "derecho", 25000000, "EUR", GetCountry("España"), "Portero"));
            AddPlayer(new Player(210, "13", "David Raya", DateTime.Parse("1995-09-15"), 1.83, "derecho", 22000000, "EUR", GetCountry("España"), "Portero"));
            AddPlayer(new Player(211, "1", "Robert Sánchez", DateTime.Parse("1997-11-18"), 1.97, "derecho", 16000000, "EUR", GetCountry("España"), "Portero"));
            AddPlayer(new Player(212, "4", "Pau Torres", DateTime.Parse("1997-01-16"), 1.91, "izquierdo", 50000000, "EUR", GetCountry("España"), "Defensa central"));
            AddPlayer(new Player(213, "3", "Iñigo Martínez", DateTime.Parse("1991-05-17"), 1.82, "izquierdo", 25000000, "EUR", GetCountry("España"), "Defensa central"));
            AddPlayer(new Player(214, "14", "Eric García", DateTime.Parse("2001-01-09"), 1.82, "derecho", 18000000, "EUR", GetCountry("España"), "Defensa central"));
            AddPlayer(new Player(215, "15", "Diego Llorente", DateTime.Parse("1993-08-16"), 1.86, "derecho", 18000000, "EUR", GetCountry("España"), "Defensa central"));
            AddPlayer(new Player(216, "17", "Marcos Alonso", DateTime.Parse("1990-12-28"), 1.89, "izquierdo", 12000000, "EUR", GetCountry("España"), "Lateral izquierdo"));
            AddPlayer(new Player(217, "18", "Jordi Alba", DateTime.Parse("1989-03-21"), 1.7, "izquierdo", 9000000, "EUR", GetCountry("España"), "Lateral izquierdo"));
            AddPlayer(new Player(218, "20", "Daniel Carvajal", DateTime.Parse("1992-01-11"), 1.73, "derecho", 18000000, "EUR", GetCountry("España"), "Lateral derecho"));
            AddPlayer(new Player(219, "2", "César Azpilicueta", DateTime.Parse("1989-08-28"), 1.78, "derecho", 9000000, "EUR", GetCountry("España"), "Lateral derecho"));
            AddPlayer(new Player(220, "16", "Rodri", DateTime.Parse("1996-06-22"), 1.91, "derecho", 80000000, "EUR", GetCountry("España"), "Pivote"));
            AddPlayer(new Player(221, "5", "Sergio Busquets", DateTime.Parse("1988-07-16"), 1.89, "derecho", 9000000, "EUR", GetCountry("España"), "Pivote"));
            AddPlayer(new Player(222, "9", "Gavi", DateTime.Parse("2004-08-05"), 1.73, "derecho", 60000000, "EUR", GetCountry("España"), "Mediocentro"));
            AddPlayer(new Player(223, "19", "Carlos Soler", DateTime.Parse("1997-01-02"), 1.8, "derecho", 50000000, "EUR", GetCountry("España"), "Mediocentro"));
            AddPlayer(new Player(224, "6", "Marcos Llorente", DateTime.Parse("1995-01-30"), 1.84, "derecho", 45000000, "EUR", GetCountry("España"), "Mediocentro"));
            AddPlayer(new Player(225, "8", "Koke", DateTime.Parse("1992-01-08"), 1.76, "derecho", 25000000, "EUR", GetCountry("España"), "Mediocentro"));
            AddPlayer(new Player(226, "21", "Dani Olmo", DateTime.Parse("1998-05-07"), 1.79, "derecho", 40000000, "EUR", GetCountry("España"), "Mediocentro ofensivo"));
            AddPlayer(new Player(227, "12", "Ansu Fati", DateTime.Parse("2002-10-31"), 1.78, "derecho", 60000000, "EUR", GetCountry("España"), "Extremo izquierdo"));
            AddPlayer(new Player(228, "11", "Ferran Torres", DateTime.Parse("2000-02-29"), 1.84, "derecho", 45000000, "EUR", GetCountry("España"), "Extremo izquierdo"));
            AddPlayer(new Player(229, "10", "Marco Asensio", DateTime.Parse("1996-01-21"), 1.82, "izquierdo", 40000000, "EUR", GetCountry("España"), "Extremo derecho"));
            AddPlayer(new Player(230, "22", "Pablo Sarabia", DateTime.Parse("1992-05-11"), 1.74, "izquierdo", 25000000, "EUR", GetCountry("España"), "Extremo derecho"));
            AddPlayer(new Player(231, "7", "Álvaro Morata", DateTime.Parse("1992-10-23"), 1.87, "derecho", 25000000, "EUR", GetCountry("España"), "Delantero centro"));
            AddPlayer(new Player(232, "14", "Raúl de Tomás", DateTime.Parse("1994-10-17"), 1.8, "derecho", 25000000, "EUR", GetCountry("España"), "Delantero centro"));
            AddPlayer(new Player(233, "12", "Predrag Rajković ", DateTime.Parse("1995-10-31"), 1.92, "derecho", 9000000, "EUR", GetCountry("Serbia"), "Portero"));
            AddPlayer(new Player(234, "1", "Marko Dmitrović", DateTime.Parse("1992-01-24"), 1.94, "izquierdo", 5000000, "EUR", GetCountry("Serbia"), "Portero"));
            AddPlayer(new Player(235, "23", "Vanja Milinković-Savić", DateTime.Parse("1997-02-20"), 2.02, "derecho", 2500000, "EUR", GetCountry("Serbia"), "Portero"));
            AddPlayer(new Player(236, "4", "Nikola Milenković", DateTime.Parse("1997-10-12"), 1.95, "derecho", 20000000, "EUR", GetCountry("Serbia"), "Defensa central"));
            AddPlayer(new Player(237, "2", "Strahinja Pavlovic", DateTime.Parse("2001-05-24"), 1.94, "izquierdo", 5000000, "EUR", GetCountry("Serbia"), "Defensa central"));
            AddPlayer(new Player(238, "5", "Strahinja Erakovic", DateTime.Parse("2001-01-22"), 1.86, "derecho", 5000000, "EUR", GetCountry("Serbia"), "Defensa central"));
            AddPlayer(new Player(239, "15", "Milos Veljkovic", DateTime.Parse("1995-09-26"), 1.88, "derecho", 4000000, "EUR", GetCountry("Serbia"), "Defensa central"));
            AddPlayer(new Player(240, "3", "Erhan Masovic", DateTime.Parse("1998-11-22"), 1.89, "ambidiestro", 2500000, "EUR", GetCountry("Serbia"), "Defensa central"));
            AddPlayer(new Player(241, "13", "Stefan Mitrović", DateTime.Parse("1990-05-22"), 1.89, "ambidiestro", 1800000, "EUR", GetCountry("Serbia"), "Defensa central"));
            AddPlayer(new Player(242, "19", "Mihailo Ristic", DateTime.Parse("1995-10-31"), 1.8, "izquierdo", 3500000, "EUR", GetCountry("Serbia"), "Lateral izquierdo"));
            AddPlayer(new Player(243, "14", "Aleksa Terzić", DateTime.Parse("1999-08-17"), 1.84, "izquierdo", 1500000, "EUR", GetCountry("Serbia"), "Lateral izquierdo"));
            AddPlayer(new Player(244, "3", "Filip Mladenovic", DateTime.Parse("1991-08-15"), 1.8, "izquierdo", 1200000, "EUR", GetCountry("Serbia"), "Lateral izquierdo"));
            AddPlayer(new Player(245, "6", "Nemanja Maksimović", DateTime.Parse("1995-01-26"), 1.89, "derecho", 14000000, "EUR", GetCountry("Serbia"), "Pivote"));
            AddPlayer(new Player(246, "18", "Uroš Račić", DateTime.Parse("1998-03-17"), 1.93, "ambidiestro", 7000000, "EUR", GetCountry("Serbia"), "Pivote"));
            AddPlayer(new Player(247, "8", "Nemanja Gudelj", DateTime.Parse("1991-11-16"), 1.87, "derecho", 4000000, "EUR", GetCountry("Serbia"), "Pivote"));
            AddPlayer(new Player(248, "20", "Sergej Milinković-Savić", DateTime.Parse("1995-02-27"), 1.91, "derecho", 70000000, "EUR", GetCountry("Serbia"), "Mediocentro"));
            AddPlayer(new Player(249, "16", "Saša Lukić", DateTime.Parse("1996-08-13"), 1.83, "derecho", 15000000, "EUR", GetCountry("Serbia"), "Mediocentro"));
            AddPlayer(new Player(250, "6", "Ivan Ilić", DateTime.Parse("2001-03-17"), 1.85, "izquierdo", 14000000, "EUR", GetCountry("Serbia"), "Mediocentro"));
            AddPlayer(new Player(251, "22", "Marko Grujic", DateTime.Parse("1996-04-13"), 1.91, "derecho", 12000000, "EUR", GetCountry("Serbia"), "Mediocentro"));
            AddPlayer(new Player(252, "17", "Filip Kostic", DateTime.Parse("1992-11-01"), 1.84, "izquierdo", 24000000, "EUR", GetCountry("Serbia"), "Interior izquierdo"));
            AddPlayer(new Player(253, "22", "Darko Lazović", DateTime.Parse("1990-09-15"), 1.81, "derecho", 4000000, "EUR", GetCountry("Serbia"), "Interior izquierdo"));
            AddPlayer(new Player(254, "21", "Filip Djuricic", DateTime.Parse("1992-01-30"), 1.81, "derecho", 4000000, "EUR", GetCountry("Serbia"), "Mediocentro ofensivo"));
            AddPlayer(new Player(255, "10", "Dusan Tadić", DateTime.Parse("1988-11-20"), 1.81, "izquierdo", 12000000, "EUR", GetCountry("Serbia"), "Extremo izquierdo"));
            AddPlayer(new Player(256, "7", "Nemanja Radonjić", DateTime.Parse("1996-02-15"), 1.85, "ambidiestro", 4000000, "EUR", GetCountry("Serbia"), "Extremo izquierdo"));
            AddPlayer(new Player(257, "14", "Andrija Zivkovic", DateTime.Parse("1996-07-11"), 1.69, "izquierdo", 6000000, "EUR", GetCountry("Serbia"), "Extremo derecho"));
            AddPlayer(new Player(258, "18", "Dušan Vlahović", DateTime.Parse("2000-01-28"), 1.9, "izquierdo", 85000000, "EUR", GetCountry("Serbia"), "Delantero centro"));
            AddPlayer(new Player(259, "9", "Aleksandar Mitrović", DateTime.Parse("1994-09-16"), 1.89, "derecho", 20000000, "EUR", GetCountry("Serbia"), "Delantero centro"));
            AddPlayer(new Player(260, "11", "Luka Jović", DateTime.Parse("1997-12-23"), 1.82, "ambidiestro", 16000000, "EUR", GetCountry("Serbia"), "Delantero centro"));
            AddPlayer(new Player(261, "9", "Djordje Jovanovic", DateTime.Parse("1999-02-15"), 1.87, "derecho", 2500000, "EUR", GetCountry("Serbia"), "Delantero centro"));
            AddPlayer(new Player(262, "NDF", "Aaron Ramsdale", DateTime.Parse("1998-05-14"), 1.9, "derecho", 28000000, "EUR", GetCountry("Inglaterra"), "Portero"));
            AddPlayer(new Player(263, "NDF", "Jordan Pickford", DateTime.Parse("1994-03-07"), 1.85, "izquierdo", 20000000, "EUR", GetCountry("Inglaterra"), "Portero"));
            AddPlayer(new Player(264, "NDF", "Nick Pope", DateTime.Parse("1992-04-19"), 1.98, "derecho", 15000000, "EUR", GetCountry("Inglaterra"), "Portero"));
            AddPlayer(new Player(265, "NDF", "Fikayo Tomori", DateTime.Parse("1997-12-19"), 1.85, "derecho", 50000000, "EUR", GetCountry("Inglaterra"), "Defensa central"));
            AddPlayer(new Player(266, "NDF", "Ben White", DateTime.Parse("1997-10-08"), 1.86, "derecho", 40000000, "EUR", GetCountry("Inglaterra"), "Defensa central"));
            AddPlayer(new Player(267, "NDF", "Harry Maguire", DateTime.Parse("1993-03-05"), 1.94, "derecho", 38000000, "EUR", GetCountry("Inglaterra"), "Defensa central"));
            AddPlayer(new Player(268, "NDF", "Marc Guéhi", DateTime.Parse("2000-07-13"), 1.82, "derecho", 32000000, "EUR", GetCountry("Inglaterra"), "Defensa central"));
            AddPlayer(new Player(269, "NDF", "John Stones ", DateTime.Parse("1994-05-28"), 1.88, "derecho", 28000000, "EUR", GetCountry("Inglaterra"), "Defensa central"));
            AddPlayer(new Player(270, "NDF", "Conor Coady", DateTime.Parse("1993-02-25"), 1.85, "derecho", 25000000, "EUR", GetCountry("Inglaterra"), "Defensa central"));
            AddPlayer(new Player(271, "NDF", "Trent Alexander-Arnold", DateTime.Parse("1998-10-07"), 1.8, "derecho", 80000000, "EUR", GetCountry("Inglaterra"), "Lateral derecho"));
            AddPlayer(new Player(272, "NDF", "Reece James", DateTime.Parse("1999-12-08"), 1.8, "derecho", 60000000, "EUR", GetCountry("Inglaterra"), "Lateral derecho"));
            AddPlayer(new Player(273, "NDF", "James Justin", DateTime.Parse("1998-02-23"), 1.83, "derecho", 25000000, "EUR", GetCountry("Inglaterra"), "Lateral derecho"));
            AddPlayer(new Player(274, "NDF", "Kyle Walker", DateTime.Parse("1990-05-28"), 1.83, "derecho", 18000000, "EUR", GetCountry("Inglaterra"), "Lateral derecho"));
            AddPlayer(new Player(275, "NDF", "Kieran Trippier", DateTime.Parse("1990-09-19"), 1.73, "derecho", 15000000, "EUR", GetCountry("Inglaterra"), "Lateral derecho"));
            AddPlayer(new Player(276, "NDF", "Declan Rice ", DateTime.Parse("1999-01-14"), 1.88, "derecho", 80000000, "EUR", GetCountry("Inglaterra"), "Pivote"));
            AddPlayer(new Player(277, "NDF", "Kalvin Phillips", DateTime.Parse("1995-12-02"), 1.79, "derecho", 50000000, "EUR", GetCountry("Inglaterra"), "Pivote"));
            AddPlayer(new Player(278, "NDF", "Phil Foden", DateTime.Parse("2000-05-28"), 1.71, "izquierdo", 90000000, "EUR", GetCountry("Inglaterra"), "Mediocentro"));
            AddPlayer(new Player(279, "NDF", "Jude Bellingham", DateTime.Parse("2003-06-29"), 1.86, "derecho", 80000000, "EUR", GetCountry("Inglaterra"), "Mediocentro"));
            AddPlayer(new Player(280, "NDF", "James Ward-Prowse", DateTime.Parse("1994-11-01"), 1.77, "derecho", 32000000, "EUR", GetCountry("Inglaterra"), "Mediocentro"));
            AddPlayer(new Player(281, "NDF", "Conor Gallagher", DateTime.Parse("2000-02-06"), 1.82, "derecho", 25000000, "EUR", GetCountry("Inglaterra"), "Mediocentro"));
            AddPlayer(new Player(282, "NDF", "Bukayo Saka", DateTime.Parse("2001-09-05"), 1.78, "izquierdo", 65000000, "EUR", GetCountry("Inglaterra"), "Interior derecho"));
            AddPlayer(new Player(283, "NDF", "Mason Mount", DateTime.Parse("1999-01-10"), 1.8, "derecho", 75000000, "EUR", GetCountry("Inglaterra"), "Mediocentro ofensivo"));
            AddPlayer(new Player(284, "NDF", "Raheem Sterling", DateTime.Parse("1994-12-08"), 1.7, "derecho", 70000000, "EUR", GetCountry("Inglaterra"), "Extremo izquierdo"));
            AddPlayer(new Player(285, "NDF", "Jack Grealish", DateTime.Parse("1995-09-10"), 1.8, "derecho", 70000000, "EUR", GetCountry("Inglaterra"), "Extremo izquierdo"));
            AddPlayer(new Player(286, "NDF", "Jarrod Bowen", DateTime.Parse("1996-12-20"), 1.82, "izquierdo", 42000000, "EUR", GetCountry("Inglaterra"), "Extremo derecho"));
            AddPlayer(new Player(287, "NDF", "Harry Kane", DateTime.Parse("1993-07-28"), 1.88, "derecho", 90000000, "EUR", GetCountry("Inglaterra"), "Delantero centro"));
            AddPlayer(new Player(288, "NDF", "Tammy Abraham", DateTime.Parse("1997-10-02"), 1.94, "derecho", 50000000, "EUR", GetCountry("Inglaterra"), "Delantero centro"));
            AddPlayer(new Player(289, "21", "Gregor Kobel", DateTime.Parse("1997-12-06"), 1.94, "derecho", 22000000, "EUR", GetCountry("Suiza"), "Portero"));
            AddPlayer(new Player(290, "12", "Jonas Omlin", DateTime.Parse("1994-01-10"), 1.9, "derecho", 8000000, "EUR", GetCountry("Suiza"), "Portero"));
            AddPlayer(new Player(291, "1", "Yann Sommer", DateTime.Parse("1988-12-17"), 1.83, "derecho", 5000000, "EUR", GetCountry("Suiza"), "Portero"));
            AddPlayer(new Player(292, "12", "Yvon Mvogo", DateTime.Parse("1994-06-06"), 1.89, "derecho", 2800000, "EUR", GetCountry("Suiza"), "Portero"));
            AddPlayer(new Player(293, "5", "Manuel Akanji", DateTime.Parse("1995-07-19"), 1.88, "derecho", 30000000, "EUR", GetCountry("Suiza"), "Defensa central"));
            AddPlayer(new Player(294, "4", "Nico Elvedi", DateTime.Parse("1996-09-30"), 1.89, "derecho", 18000000, "EUR", GetCountry("Suiza"), "Defensa central"));
            AddPlayer(new Player(295, "22", "Fabian Schär", DateTime.Parse("1991-12-20"), 1.86, "derecho", 7000000, "EUR", GetCountry("Suiza"), "Defensa central"));
            AddPlayer(new Player(296, "NDF", "Leonidas Stergiou", DateTime.Parse("2002-03-03"), 1.81, "derecho", 6000000, "EUR", GetCountry("Suiza"), "Defensa central"));
            AddPlayer(new Player(297, "13", "Ricardo Rodríguez", DateTime.Parse("1992-08-25"), 1.8, "izquierdo", 3400000, "EUR", GetCountry("Suiza"), "Defensa central"));
            AddPlayer(new Player(298, "18", "Eray Cömert", DateTime.Parse("1998-02-04"), 1.83, "derecho", 1500000, "EUR", GetCountry("Suiza"), "Defensa central"));
            AddPlayer(new Player(299, "2", "Kevin Mbabu", DateTime.Parse("1995-04-19"), 1.84, "derecho", 9000000, "EUR", GetCountry("Suiza"), "Lateral derecho"));
            AddPlayer(new Player(300, "16", "Jordan Lotomba", DateTime.Parse("1998-09-29"), 1.77, "derecho", 7000000, "EUR", GetCountry("Suiza"), "Lateral derecho"));
            AddPlayer(new Player(301, "3", "Silvan Widmer", DateTime.Parse("1993-03-05"), 1.83, "derecho", 5000000, "EUR", GetCountry("Suiza"), "Lateral derecho"));
            AddPlayer(new Player(302, "10", "Granit Xhaka", DateTime.Parse("1992-09-27"), 1.86, "izquierdo", 20000000, "EUR", GetCountry("Suiza"), "Pivote"));
            AddPlayer(new Player(303, "6", "Fabian Frei", DateTime.Parse("1989-01-08"), 1.83, "derecho", 500000, "EUR", GetCountry("Suiza"), "Pivote"));
            AddPlayer(new Player(304, "15", "Djibril Sow", DateTime.Parse("1997-02-06"), 1.84, "derecho", 22000000, "EUR", GetCountry("Suiza"), "Mediocentro"));
            AddPlayer(new Player(305, "8", "Remo Freuler", DateTime.Parse("1992-04-15"), 1.8, "derecho", 20000000, "EUR", GetCountry("Suiza"), "Mediocentro"));
            AddPlayer(new Player(306, "20", "Michel Aebischer", DateTime.Parse("1997-01-06"), 1.83, "derecho", 3500000, "EUR", GetCountry("Suiza"), "Mediocentro"));
            AddPlayer(new Player(307, "14", "Mattia Bottani", DateTime.Parse("1991-05-24"), 1.7, "derecho", 500000, "EUR", GetCountry("Suiza"), "Mediocentro ofensivo"));
            AddPlayer(new Player(308, "17", "Rubén Vargas ", DateTime.Parse("1998-08-05"), 1.79, "derecho", 8000000, "EUR", GetCountry("Suiza"), "Extremo izquierdo"));
            AddPlayer(new Player(309, "14", "Steven Zuber", DateTime.Parse("1991-08-17"), 1.82, "derecho", 2500000, "EUR", GetCountry("Suiza"), "Extremo izquierdo"));
            AddPlayer(new Player(310, "11", "Renato Steffen", DateTime.Parse("1991-11-03"), 1.7, "izquierdo", 2000000, "EUR", GetCountry("Suiza"), "Extremo izquierdo"));
            AddPlayer(new Player(311, "23", "Xherdan Shaqiri", DateTime.Parse("1991-10-10"), 1.69, "izquierdo", 7000000, "EUR", GetCountry("Suiza"), "Extremo derecho"));
            AddPlayer(new Player(312, "5", "Noah Okafor", DateTime.Parse("2000-05-24"), 1.85, "derecho", 18000000, "EUR", GetCountry("Suiza"), "Delantero centro"));
            AddPlayer(new Player(313, "7", "Breel Embolo", DateTime.Parse("1997-02-14"), 1.87, "derecho", 15000000, "EUR", GetCountry("Suiza"), "Delantero centro"));
            AddPlayer(new Player(314, "9", "Haris Seferovic", DateTime.Parse("1992-02-22"), 1.89, "izquierdo", 8000000, "EUR", GetCountry("Suiza"), "Delantero centro"));
            AddPlayer(new Player(315, "NDF", "Zeki Amdouni", DateTime.Parse("2000-12-04"), 1.85, "NDF", 2000000, "EUR", GetCountry("Suiza"), "Delantero centro"));
            AddPlayer(new Player(316, "19", "Mario Gavranovic", DateTime.Parse("1989-11-24"), 1.75, "derecho", 1500000, "EUR", GetCountry("Suiza"), "Delantero centro"));
            AddPlayer(new Player(317, "13", "Mark Flekken", DateTime.Parse("1993-06-13"), 1.94, "ambidiestro", 7000000, "EUR", GetCountry("Países Bajos"), "Portero"));
            AddPlayer(new Player(318, "1", "Jasper Cillessen", DateTime.Parse("1989-04-22"), 1.87, "derecho", 3000000, "EUR", GetCountry("Países Bajos"), "Portero"));
            AddPlayer(new Player(319, "23", "Kjell Scherpen", DateTime.Parse("2000-01-23"), 2.04, "derecho", 2200000, "EUR", GetCountry("Países Bajos"), "Portero"));
            AddPlayer(new Player(320, "3", "Matthijs de Ligt", DateTime.Parse("1999-08-12"), 1.89, "derecho", 70000000, "EUR", GetCountry("Países Bajos"), "Defensa central"));
            AddPlayer(new Player(321, "NDF", "Jurrien Timber", DateTime.Parse("2001-06-17"), 1.82, "derecho", 35000000, "EUR", GetCountry("Países Bajos"), "Defensa central"));
            AddPlayer(new Player(322, "6", "Stefan de Vrij", DateTime.Parse("1992-02-05"), 1.89, "derecho", 28000000, "EUR", GetCountry("Países Bajos"), "Defensa central"));
            AddPlayer(new Player(323, "NDF", "Nathan Aké", DateTime.Parse("1995-02-18"), 1.8, "izquierdo", 25000000, "EUR", GetCountry("Países Bajos"), "Defensa central"));
            AddPlayer(new Player(324, "2", "Jordan Teze", DateTime.Parse("1999-09-30"), 1.83, "derecho", 8000000, "EUR", GetCountry("Países Bajos"), "Defensa central"));
            AddPlayer(new Player(325, "4", "Bruno Martins Indi", DateTime.Parse("1992-02-08"), 1.85, "izquierdo", 2200000, "EUR", GetCountry("Países Bajos"), "Defensa central"));
            AddPlayer(new Player(326, "NDF", "Ernest Faber", DateTime.Parse("1971-08-27"), 1.84, "derecho", 0, "EUR", GetCountry("Países Bajos"), "Defensa central"));
            AddPlayer(new Player(327, "5", "Tyrell Malacia", DateTime.Parse("1999-08-17"), 1.69, "izquierdo", 17000000, "EUR", GetCountry("Países Bajos"), "Lateral izquierdo"));
            AddPlayer(new Player(328, "17", "Daley Blind", DateTime.Parse("1990-03-09"), 1.8, "izquierdo", 9000000, "EUR", GetCountry("Países Bajos"), "Lateral izquierdo"));
            AddPlayer(new Player(329, "15", "Hans Hateboer", DateTime.Parse("1994-01-09"), 1.85, "derecho", 13000000, "EUR", GetCountry("Países Bajos"), "Lateral derecho"));
            AddPlayer(new Player(330, "20", "Teun Koopmeiners", DateTime.Parse("1998-02-28"), 1.83, "izquierdo", 25000000, "EUR", GetCountry("Países Bajos"), "Pivote"));
            AddPlayer(new Player(331, "18", "Jerdy Schouten", DateTime.Parse("1997-01-12"), 1.85, "derecho", 9000000, "EUR", GetCountry("Países Bajos"), "Pivote"));
            AddPlayer(new Player(332, "21", "Frenkie de Jong", DateTime.Parse("1997-05-12"), 1.8, "derecho", 60000000, "EUR", GetCountry("Países Bajos"), "Mediocentro"));
            AddPlayer(new Player(333, "22", "Denzel Dumfries", DateTime.Parse("1996-04-18"), 1.88, "derecho", 25000000, "EUR", GetCountry("Países Bajos"), "Interior derecho"));
            AddPlayer(new Player(334, "11", "Steven Berghuis", DateTime.Parse("1991-12-19"), 1.82, "izquierdo", 14000000, "EUR", GetCountry("Países Bajos"), "Mediocentro ofensivo"));
            AddPlayer(new Player(335, "14", "Davy Klaassen", DateTime.Parse("1993-02-21"), 1.79, "derecho", 14000000, "EUR", GetCountry("Países Bajos"), "Mediocentro ofensivo"));
            AddPlayer(new Player(336, "8", "Guus Til", DateTime.Parse("1997-12-22"), 1.86, "derecho", 7500000, "EUR", GetCountry("Países Bajos"), "Mediocentro ofensivo"));
            AddPlayer(new Player(337, "9", "Cody Gakpo", DateTime.Parse("1999-05-07"), 1.89, "derecho", 30000000, "EUR", GetCountry("Países Bajos"), "Extremo izquierdo"));
            AddPlayer(new Player(338, "12", "Noa Lang", DateTime.Parse("1999-06-17"), 1.73, "derecho", 22000000, "EUR", GetCountry("Países Bajos"), "Extremo izquierdo"));
            AddPlayer(new Player(339, "7", "Steven Bergwijn", DateTime.Parse("1997-10-08"), 1.78, "derecho", 18000000, "EUR", GetCountry("Países Bajos"), "Extremo izquierdo"));
            AddPlayer(new Player(340, "10", "Memphis Depay", DateTime.Parse("1994-02-13"), 1.76, "derecho", 35000000, "EUR", GetCountry("Países Bajos"), "Delantero centro"));
            AddPlayer(new Player(341, "19", "Wout Weghorst", DateTime.Parse("1992-08-07"), 1.97, "derecho", 14000000, "EUR", GetCountry("Países Bajos"), "Delantero centro"));
            AddPlayer(new Player(342, "16", "Vincent Janssen", DateTime.Parse("1994-06-15"), 1.84, "izquierdo", 2500000, "EUR", GetCountry("Países Bajos"), "Delantero centro"));
            AddPlayer(new Player(343, "22", "Amir Abedzadeh", DateTime.Parse("1993-04-26"), 1.87, "derecho", 1500000, "EUR", GetCountry("Irán"), "Portero"));
            AddPlayer(new Player(344, "1", "Alireza Beiranvand", DateTime.Parse("1992-09-21"), 1.94, "derecho", 1000000, "EUR", GetCountry("Irán"), "Portero"));
            AddPlayer(new Player(345, "30", "Payam Niazmand", DateTime.Parse("1995-04-06"), 1.94, "derecho", 500000, "EUR", GetCountry("Irán"), "Portero"));
            AddPlayer(new Player(346, "12", "Hossein Hosseini", DateTime.Parse("1992-06-30"), 1.89, "derecho", 450000, "EUR", GetCountry("Irán"), "Portero"));
            AddPlayer(new Player(347, "19", "Majid Hosseini", DateTime.Parse("1996-06-20"), 1.87, "derecho", 3000000, "EUR", GetCountry("Irán"), "Defensa central"));
            AddPlayer(new Player(348, "4", "Aref Gholami", DateTime.Parse("1997-04-19"), 1.83, "derecho", 600000, "EUR", GetCountry("Irán"), "Defensa central"));
            AddPlayer(new Player(349, "29", "Armin Sohrabian", DateTime.Parse("1995-07-26"), 1.81, "izquierdo", 550000, "EUR", GetCountry("Irán"), "Defensa central"));
            AddPlayer(new Player(350, "13", "Aref Aghasi", DateTime.Parse("1997-01-02"), 1.84, "izquierdo", 450000, "EUR", GetCountry("Irán"), "Defensa central"));
            AddPlayer(new Player(351, "21", "Omid Noorafkan", DateTime.Parse("1997-04-09"), 1.82, "izquierdo", 1200000, "EUR", GetCountry("Irán"), "Lateral izquierdo"));
            AddPlayer(new Player(352, "3", "Ehsan Hajsafi", DateTime.Parse("1990-02-25"), 1.78, "izquierdo", 800000, "EUR", GetCountry("Irán"), "Lateral izquierdo"));
            AddPlayer(new Player(353, "16", "Abolfazl Jalali", DateTime.Parse("1998-06-26"), 1.77, "izquierdo", 250000, "EUR", GetCountry("Irán"), "Lateral izquierdo"));
            AddPlayer(new Player(354, "2", "Sadegh Moharrami", DateTime.Parse("1996-03-01"), 1.74, "derecho", 1500000, "EUR", GetCountry("Irán"), "Lateral derecho"));
            AddPlayer(new Player(355, "5", "Saleh Hardani", DateTime.Parse("1998-09-14"), 1.76, "derecho", 700000, "EUR", GetCountry("Irán"), "Lateral derecho"));
            AddPlayer(new Player(356, "26", "Mehdi Shiri", DateTime.Parse("1991-01-31"), 1.76, "derecho", 250000, "EUR", GetCountry("Irán"), "Lateral derecho"));
            AddPlayer(new Player(357, "18", "Milad Sarlak", DateTime.Parse("1995-03-26"), 1.81, "derecho", 900000, "EUR", GetCountry("Irán"), "Pivote"));
            AddPlayer(new Player(358, "6", "Saeid Ezatolahi", DateTime.Parse("1996-10-01"), 1.9, "derecho", 800000, "EUR", GetCountry("Irán"), "Pivote"));
            AddPlayer(new Player(359, "14", "Omid Ebrahimi", DateTime.Parse("1987-09-16"), 1.78, "derecho", 325000, "EUR", GetCountry("Irán"), "Pivote"));
            AddPlayer(new Player(360, "8", "Ahmad Nourollahi", DateTime.Parse("1993-02-01"), 1.85, "derecho", 1500000, "EUR", GetCountry("Irán"), "Mediocentro"));
            AddPlayer(new Player(361, "23", "Mehdi Mehdipour", DateTime.Parse("1994-10-25"), 1.82, "derecho", 775000, "EUR", GetCountry("Irán"), "Mediocentro"));
            AddPlayer(new Player(362, "28", "Seyed Mehdi Hosseini", DateTime.Parse("1993-09-16"), 1.72, "derecho", 350000, "EUR", GetCountry("Irán"), "Mediocentro"));
            AddPlayer(new Player(363, "15", "Amirhossein Hosseinzadeh", DateTime.Parse("2000-10-30"), 1.78, "derecho", 850000, "EUR", GetCountry("Irán"), "Mediocentro ofensivo"));
            AddPlayer(new Player(364, "24", "Soroosh Rafiei", DateTime.Parse("1990-03-24"), 1.75, "derecho", 500000, "EUR", GetCountry("Irán"), "Mediocentro ofensivo"));
            AddPlayer(new Player(365, "27", "Mehdi Torabi", DateTime.Parse("1994-09-10"), 1.85, "derecho", 1000000, "EUR", GetCountry("Irán"), "Extremo izquierdo"));
            AddPlayer(new Player(366, "7", "Alireza Jahanbakhsh", DateTime.Parse("1993-08-11"), 0, "NDF", 3500000, "EUR", GetCountry("Irán"), "Extremo derecho"));
            AddPlayer(new Player(367, "17", "Ali Gholizadeh", DateTime.Parse("1996-03-10"), 1.76, "izquierdo", 3000000, "EUR", GetCountry("Irán"), "Extremo derecho"));
            AddPlayer(new Player(368, "25", "Saeid Sadeghi", DateTime.Parse("1994-04-25"), 1.8, "derecho", 900000, "EUR", GetCountry("Irán"), "Extremo derecho"));
            AddPlayer(new Player(369, "20", "Sardar Azmoun", DateTime.Parse("1995-01-01"), 1.86, "ambidiestro", 22000000, "EUR", GetCountry("Irán"), "Delantero centro"));
            AddPlayer(new Player(370, "9", "Mehdi Taremi", DateTime.Parse("1992-07-18"), 1.87, "derecho", 20000000, "EUR", GetCountry("Irán"), "Delantero centro"));
            AddPlayer(new Player(371, "10", "Allahyar Sayyadmanesh", DateTime.Parse("2001-06-29"), 1.82, "derecho", 2500000, "EUR", GetCountry("Irán"), "Delantero centro"));
            AddPlayer(new Player(372, "11", "Ali Alipour", DateTime.Parse("1995-11-11"), 1.81, "ambidiestro", 1500000, "EUR", GetCountry("Irán"), "Delantero centro"));
            AddPlayer(new Player(373, "21", "Hyeon-woo Jo", DateTime.Parse("1991-09-25"), 1.89, "derecho", 1400000, "EUR", GetCountry("Corea del Sur"), "Portero"));
            AddPlayer(new Player(374, "12", "Bum-keun Song", DateTime.Parse("1997-10-15"), 1.94, "NDF", 950000, "EUR", GetCountry("Corea del Sur"), "Portero"));
            AddPlayer(new Player(375, "1", "Dong-jun Kim", DateTime.Parse("1994-12-19"), 1.89, "NDF", 550000, "EUR", GetCountry("Corea del Sur"), "Portero"));
            AddPlayer(new Player(376, "18", "Ji-soo Park", DateTime.Parse("1994-06-13"), 1.87, "derecho", 750000, "EUR", GetCountry("Corea del Sur"), "Defensa central"));
            AddPlayer(new Player(377, "20", "Kyung-won Kwon", DateTime.Parse("1992-01-31"), 1.89, "izquierdo", 750000, "EUR", GetCountry("Corea del Sur"), "Defensa central"));
            AddPlayer(new Player(378, "4", "Yu-min Cho", DateTime.Parse("1996-11-17"), 1.84, "derecho", 625000, "EUR", GetCountry("Corea del Sur"), "Defensa central"));
            AddPlayer(new Player(379, "19", "Young-gwon Kim", DateTime.Parse("1990-02-27"), 1.86, "izquierdo", 600000, "EUR", GetCountry("Corea del Sur"), "Defensa central"));
            AddPlayer(new Player(380, "24", "Ju-sung Kim ", DateTime.Parse("2000-12-12"), 1.88, "izquierdo", 500000, "EUR", GetCountry("Corea del Sur"), "Defensa central"));
            AddPlayer(new Player(381, "3", "Jin-su Kim", DateTime.Parse("1992-06-13"), 1.77, "izquierdo", 600000, "EUR", GetCountry("Corea del Sur"), "Lateral izquierdo"));
            AddPlayer(new Player(382, "14", "Chul Hong", DateTime.Parse("1990-09-17"), 1.76, "izquierdo", 525000, "EUR", GetCountry("Corea del Sur"), "Lateral izquierdo"));
            AddPlayer(new Player(383, "15", "Moon-hwan Kim", DateTime.Parse("1995-08-01"), 1.73, "derecho", 950000, "EUR", GetCountry("Corea del Sur"), "Lateral derecho"));
            AddPlayer(new Player(384, "2", "Jong-gyu Yoon", DateTime.Parse("1998-03-20"), 1.73, "derecho", 600000, "EUR", GetCountry("Corea del Sur"), "Lateral derecho"));
            AddPlayer(new Player(385, "16", "Dong-hyeon Kim", DateTime.Parse("1997-06-11"), 1.82, "derecho", 700000, "EUR", GetCountry("Corea del Sur"), "Pivote"));
            AddPlayer(new Player(386, "6", "In-beom Hwang ", DateTime.Parse("1996-09-20"), 1.77, "NDF", 3000000, "EUR", GetCountry("Corea del Sur"), "Mediocentro"));
            AddPlayer(new Player(387, "8", "Seung-ho Paik", DateTime.Parse("1997-03-17"), 1.82, "NDF", 925000, "EUR", GetCountry("Corea del Sur"), "Mediocentro"));
            AddPlayer(new Player(388, "5", "Yeong-jae Lee", DateTime.Parse("1994-09-13"), 1.74, "izquierdo", 850000, "EUR", GetCountry("Corea del Sur"), "Mediocentro"));
            AddPlayer(new Player(389, "10", "Jin-gyu Kim", DateTime.Parse("1997-02-24"), 1.76, "derecho", 600000, "EUR", GetCountry("Corea del Sur"), "Mediocentro"));
            AddPlayer(new Player(390, "25", "Gi-hyuk Lee", DateTime.Parse("2000-07-07"), 1.84, "NDF", 200000, "EUR", GetCountry("Corea del Sur"), "Mediocentro"));
            AddPlayer(new Player(391, "23", "Young-jun Goh", DateTime.Parse("2001-07-09"), 1.68, "derecho", 500000, "EUR", GetCountry("Corea del Sur"), "Mediocentro ofensivo"));
            AddPlayer(new Player(392, "13", "Min-kyu Song", DateTime.Parse("1999-09-12"), 1.81, "derecho", 1300000, "EUR", GetCountry("Corea del Sur"), "Extremo izquierdo"));
            AddPlayer(new Player(393, "7", "Sang-ho Na", DateTime.Parse("1996-08-12"), 1.73, "derecho", 900000, "EUR", GetCountry("Corea del Sur"), "Extremo izquierdo"));
            AddPlayer(new Player(394, "22", "Chang-hoon Kwon", DateTime.Parse("1994-06-30"), 1.73, "izquierdo", 1500000, "EUR", GetCountry("Corea del Sur"), "Extremo derecho"));
            AddPlayer(new Player(395, "11", "Won-sang Um", DateTime.Parse("1999-01-06"), 1.71, "derecho", 1000000, "EUR", GetCountry("Corea del Sur"), "Extremo derecho"));
            AddPlayer(new Player(396, "17", "Young-wook Cho", DateTime.Parse("1999-02-05"), 1.78, "derecho", 700000, "EUR", GetCountry("Corea del Sur"), "Extremo derecho"));
            AddPlayer(new Player(397, "26", "Seong-jin Kang", DateTime.Parse("2003-03-26"), 1.8, "derecho", 425000, "EUR", GetCountry("Corea del Sur"), "Extremo derecho"));
            AddPlayer(new Player(398, "9", "Gue-sung Cho ", DateTime.Parse("1998-01-25"), 1.88, "derecho", 800000, "EUR", GetCountry("Corea del Sur"), "Delantero centro"));
            AddPlayer(new Player(399, "1", "Keisuke Osako", DateTime.Parse("1999-07-28"), 1.87, "derecho", 850000, "EUR", GetCountry("Japón"), "Portero"));
            AddPlayer(new Player(400, "12", "Kosei Tani", DateTime.Parse("2000-11-22"), 1.9, "derecho", 800000, "EUR", GetCountry("Japón"), "Portero"));
            AddPlayer(new Player(401, "23", "Zion Suzuki", DateTime.Parse("2002-08-21"), 1.9, "derecho", 300000, "EUR", GetCountry("Japón"), "Portero"));
            AddPlayer(new Player(402, "3", "Shogo Taniguchi", DateTime.Parse("1991-07-15"), 1.83, "derecho", 1700000, "EUR", GetCountry("Japón"), "Defensa central"));
            AddPlayer(new Player(403, "4", "Shinnosuke Nakatani", DateTime.Parse("1996-03-24"), 1.84, "derecho", 1300000, "EUR", GetCountry("Japón"), "Defensa central"));
            AddPlayer(new Player(404, "5", "Shinnosuke Hatanaka", DateTime.Parse("1995-08-25"), 1.84, "ambidiestro", 1000000, "EUR", GetCountry("Japón"), "Defensa central"));
            AddPlayer(new Player(405, "6", "Tomoki Iwata", DateTime.Parse("1997-04-07"), 1.76, "derecho", 1000000, "EUR", GetCountry("Japón"), "Defensa central"));
            AddPlayer(new Player(406, "19", "Sho Sasaki", DateTime.Parse("1989-10-02"), 1.76, "derecho", 900000, "EUR", GetCountry("Japón"), "Defensa central"));
            AddPlayer(new Player(407, "22", "Hayato Araki", DateTime.Parse("1996-08-07"), 1.86, "derecho", 900000, "EUR", GetCountry("Japón"), "Defensa central"));
            AddPlayer(new Player(408, "24", "Takuma Ominami", DateTime.Parse("1997-12-13"), 1.84, "derecho", 800000, "EUR", GetCountry("Japón"), "Defensa central"));
            AddPlayer(new Player(409, "13", "Daiki Sugioka", DateTime.Parse("1998-09-08"), 1.82, "izquierdo", 550000, "EUR", GetCountry("Japón"), "Lateral izquierdo"));
            AddPlayer(new Player(410, "2", "Miki Yamane", DateTime.Parse("1993-12-22"), 1.78, "derecho", 1300000, "EUR", GetCountry("Japón"), "Lateral derecho"));
            AddPlayer(new Player(411, "25", "Ryuta Koike", DateTime.Parse("1995-08-29"), 1.69, "derecho", 900000, "EUR", GetCountry("Japón"), "Lateral derecho"));
            AddPlayer(new Player(412, "26", "Joel Chima Fujita", DateTime.Parse("2002-02-16"), 1.73, "derecho", 700000, "EUR", GetCountry("Japón"), "Pivote"));
            AddPlayer(new Player(413, "15", "Kento Hashimoto", DateTime.Parse("1993-08-16"), 1.83, "derecho", 2200000, "EUR", GetCountry("Japón"), "Mediocentro"));
            AddPlayer(new Player(414, "18", "Kota Mizunuma", DateTime.Parse("1990-02-22"), 1.76, "derecho", 850000, "EUR", GetCountry("Japón"), "Interior derecho"));
            AddPlayer(new Player(415, "8", "Tsukasa Morishima", DateTime.Parse("1997-04-25"), 1.73, "derecho", 1300000, "EUR", GetCountry("Japón"), "Mediocentro ofensivo"));
            AddPlayer(new Player(416, "14", "Yasuto Wakizaka", DateTime.Parse("1995-06-11"), 1.72, "derecho", 1000000, "EUR", GetCountry("Japón"), "Mediocentro ofensivo"));
            AddPlayer(new Player(417, "7", "Gakuto Notsuda", DateTime.Parse("1994-06-06"), 1.75, "izquierdo", 700000, "EUR", GetCountry("Japón"), "Mediocentro ofensivo"));
            AddPlayer(new Player(418, "16", "Yuki Soma", DateTime.Parse("1997-02-25"), 1.66, "derecho", 900000, "EUR", GetCountry("Japón"), "Extremo izquierdo"));
            AddPlayer(new Player(419, "10", "Yuto Iwasaki", DateTime.Parse("1998-06-11"), 1.72, "derecho", 500000, "EUR", GetCountry("Japón"), "Extremo izquierdo"));
            AddPlayer(new Player(420, "21", "Makoto Mitsuta", DateTime.Parse("1999-07-20"), 1.7, "derecho", 450000, "EUR", GetCountry("Japón"), "Extremo derecho"));
            AddPlayer(new Player(421, "17", "Ryo Miyaichi ", DateTime.Parse("1992-12-14"), 1.83, "derecho", 400000, "EUR", GetCountry("Japón"), "Extremo derecho"));
            AddPlayer(new Player(422, "9", "Takuma Nishimura", DateTime.Parse("1996-10-22"), 1.78, "derecho", 800000, "EUR", GetCountry("Japón"), "Mediapunta"));
            AddPlayer(new Player(423, "11", "Shuto Machino", DateTime.Parse("1999-09-30"), 1.84, "ambidiestro", 700000, "EUR", GetCountry("Japón"), "Delantero centro"));
            AddPlayer(new Player(424, "20", "Mao Hosoya", DateTime.Parse("2001-09-07"), 1.77, "derecho", 550000, "EUR", GetCountry("Japón"), "Delantero centro"));
            AddPlayer(new Player(425, "NDF", "Mohammed Al-Rubaie", DateTime.Parse("1997-08-14"), 1.9, "derecho", 1200000, "EUR", GetCountry("Arabia Saudita"), "Portero"));
            AddPlayer(new Player(426, "NDF", "Mohammed Al-Owais", DateTime.Parse("1991-10-10"), 1.85, "izquierdo", 900000, "EUR", GetCountry("Arabia Saudita"), "Portero"));
            AddPlayer(new Player(427, "NDF", "Fawaz Al-Qarni", DateTime.Parse("1992-04-02"), 1.85, "derecho", 350000, "EUR", GetCountry("Arabia Saudita"), "Portero"));
            AddPlayer(new Player(428, "NDF", "Amin Al-Bukhari", DateTime.Parse("1997-05-02"), 1.94, "derecho", 175000, "EUR", GetCountry("Arabia Saudita"), "Portero"));
            AddPlayer(new Player(429, "NDF", "Ziyad Al-Sahafi", DateTime.Parse("1994-10-17"), 1.82, "derecho", 1500000, "EUR", GetCountry("Arabia Saudita"), "Defensa central"));
            AddPlayer(new Player(430, "NDF", "Abdulelah Al-Amri", DateTime.Parse("1997-01-15"), 1.83, "derecho", 1000000, "EUR", GetCountry("Arabia Saudita"), "Defensa central"));
            AddPlayer(new Player(431, "NDF", "Ali Al-Oujami", DateTime.Parse("1996-04-25"), 1.75, "derecho", 750000, "EUR", GetCountry("Arabia Saudita"), "Defensa central"));
            AddPlayer(new Player(432, "12", "Hassan Tambakti", DateTime.Parse("1999-02-09"), 1.82, "derecho", 600000, "EUR", GetCountry("Arabia Saudita"), "Defensa central"));
            AddPlayer(new Player(433, "NDF", "Ali Al-Boleahi", DateTime.Parse("1989-11-21"), 1.78, "izquierdo", 400000, "EUR", GetCountry("Arabia Saudita"), "Defensa central"));
            AddPlayer(new Player(434, "NDF", "Yasser Al-Shahrani", DateTime.Parse("1992-05-25"), 1.71, "derecho", 2000000, "EUR", GetCountry("Arabia Saudita"), "Lateral izquierdo"));
            AddPlayer(new Player(435, "NDF", "Sultan Al-Ghannam", DateTime.Parse("1994-05-06"), 1.73, "derecho", 3500000, "EUR", GetCountry("Arabia Saudita"), "Lateral derecho"));
            AddPlayer(new Player(436, "NDF", "Mohammed Al-Burayk", DateTime.Parse("1992-09-15"), 1.7, "derecho", 2000000, "EUR", GetCountry("Arabia Saudita"), "Lateral derecho"));
            AddPlayer(new Player(437, "NDF", "Nasser Al-Dawsari", DateTime.Parse("1998-12-19"), 1.78, "izquierdo", 350000, "EUR", GetCountry("Arabia Saudita"), "Pivote"));
            AddPlayer(new Player(438, "NDF", "Ali Al-Hassan", DateTime.Parse("1997-03-04"), 1.76, "derecho", 300000, "EUR", GetCountry("Arabia Saudita"), "Pivote"));
            AddPlayer(new Player(439, "NDF", "Abdullah Otayf", DateTime.Parse("1992-08-03"), 1.77, "derecho", 300000, "EUR", GetCountry("Arabia Saudita"), "Pivote"));
            AddPlayer(new Player(440, "NDF", "Mohamed Kanno", DateTime.Parse("1994-09-22"), 1.92, "derecho", 1800000, "EUR", GetCountry("Arabia Saudita"), "Mediocentro"));
            AddPlayer(new Player(441, "NDF", "Salman Al-Faraj", DateTime.Parse("1989-08-01"), 1.8, "izquierdo", 750000, "EUR", GetCountry("Arabia Saudita"), "Mediocentro"));
            AddPlayer(new Player(442, "NDF", "Sami Al-Najei", DateTime.Parse("1997-02-07"), 1.81, "izquierdo", 900000, "EUR", GetCountry("Arabia Saudita"), "Mediocentro ofensivo"));
            AddPlayer(new Player(443, "NDF", "Abdulrahman Ghareeb", DateTime.Parse("1997-03-31"), 1.64, "derecho", 3000000, "EUR", GetCountry("Arabia Saudita"), "Extremo izquierdo"));
            AddPlayer(new Player(444, "NDF", "Salem Al-Dawsari", DateTime.Parse("1991-08-19"), 1.71, "derecho", 2800000, "EUR", GetCountry("Arabia Saudita"), "Extremo izquierdo"));
            AddPlayer(new Player(445, "NDF", "Khalid Al-Ghannam", DateTime.Parse("2000-11-08"), 1.71, "derecho", 1000000, "EUR", GetCountry("Arabia Saudita"), "Extremo izquierdo"));
            AddPlayer(new Player(446, "NDF", "Abdulaziz Al-Bishi", DateTime.Parse("1994-03-11"), 1.72, "derecho", 2500000, "EUR", GetCountry("Arabia Saudita"), "Extremo derecho"));
            AddPlayer(new Player(447, "20", "Abdulrahman Al-Obood", DateTime.Parse("1995-06-10"), 1.74, "derecho", 1500000, "EUR", GetCountry("Arabia Saudita"), "Extremo derecho"));
            AddPlayer(new Player(448, "NDF", "Hattan Bahebri", DateTime.Parse("1992-07-16"), 1.7, "derecho", 900000, "EUR", GetCountry("Arabia Saudita"), "Extremo derecho"));
            AddPlayer(new Player(449, "NDF", "Firas Al-Buraikan", DateTime.Parse("2000-05-14"), 1.81, "izquierdo", 1200000, "EUR", GetCountry("Arabia Saudita"), "Delantero centro"));
            AddPlayer(new Player(450, "NDF", "Abdullah Al-Hamdan", DateTime.Parse("1999-09-12"), 1.84, "ambidiestro", 375000, "EUR", GetCountry("Arabia Saudita"), "Delantero centro"));
            AddPlayer(new Player(451, "12", "Moisés Ramírez", DateTime.Parse("2000-09-09"), 1.85, "derecho", 800000, "EUR", GetCountry("Ecuador"), "Portero"));
            AddPlayer(new Player(452, "1", "Hernán Galíndez", DateTime.Parse("1987-03-30"), 1.88, "derecho", 600000, "EUR", GetCountry("Ecuador"), "Portero"));
            AddPlayer(new Player(453, "22", "Alexander Domínguez", DateTime.Parse("1987-06-05"), 1.96, "derecho", 350000, "EUR", GetCountry("Ecuador"), "Portero"));
            AddPlayer(new Player(454, "3", "Piero Hincapié", DateTime.Parse("2002-01-09"), 1.84, "izquierdo", 17000000, "EUR", GetCountry("Ecuador"), "Defensa central"));
            AddPlayer(new Player(455, "2", "Félix Torres", DateTime.Parse("1997-01-11"), 1.87, "derecho", 5000000, "EUR", GetCountry("Ecuador"), "Defensa central"));
            AddPlayer(new Player(456, "14", "Jackson Porozo", DateTime.Parse("2000-08-04"), 1.92, "derecho", 3000000, "EUR", GetCountry("Ecuador"), "Defensa central"));
            AddPlayer(new Player(457, "4", "Robert Arboleda ", DateTime.Parse("1991-10-22"), 1.87, "derecho", 2000000, "EUR", GetCountry("Ecuador"), "Defensa central"));
            AddPlayer(new Player(458, "14", "Xavier Arreaga", DateTime.Parse("1994-09-28"), 1.83, "NDF", 1500000, "EUR", GetCountry("Ecuador"), "Defensa central"));
            AddPlayer(new Player(459, "7", "Pervis Estupiñán", DateTime.Parse("1998-01-21"), 1.75, "izquierdo", 20000000, "EUR", GetCountry("Ecuador"), "Lateral izquierdo"));
            AddPlayer(new Player(460, "18", "Diego Palacios", DateTime.Parse("1999-07-12"), 1.69, "izquierdo", 3500000, "EUR", GetCountry("Ecuador"), "Lateral izquierdo"));
            AddPlayer(new Player(461, "6", "Byron Castillo", DateTime.Parse("1998-11-10"), 1.67, "derecho", 2800000, "EUR", GetCountry("Ecuador"), "Lateral derecho"));
            AddPlayer(new Player(462, "17", "Angelo Preciado", DateTime.Parse("1998-02-18"), 1.73, "derecho", 2500000, "EUR", GetCountry("Ecuador"), "Lateral derecho"));
            AddPlayer(new Player(463, "8", "Carlos Gruezo", DateTime.Parse("1995-04-19"), 1.71, "derecho", 3200000, "EUR", GetCountry("Ecuador"), "Pivote"));
            AddPlayer(new Player(464, "20", "Jhegson Méndez", DateTime.Parse("1997-04-26"), 1.71, "derecho", 1500000, "EUR", GetCountry("Ecuador"), "Pivote"));
            AddPlayer(new Player(465, "5", "Dixon Arroyo", DateTime.Parse("1992-06-01"), 1.79, "derecho", 900000, "EUR", GetCountry("Ecuador"), "Pivote"));
            AddPlayer(new Player(466, "5", "José Cifuentes", DateTime.Parse("1999-03-12"), 1.75, "derecho", 6500000, "EUR", GetCountry("Ecuador"), "Mediocentro"));
            AddPlayer(new Player(467, "23", "Moisés Caicedo", DateTime.Parse("2001-11-02"), 1.78, "derecho", 6000000, "EUR", GetCountry("Ecuador"), "Mediocentro"));
            AddPlayer(new Player(468, "21", "Alan Franco", DateTime.Parse("1998-08-21"), 1.74, "derecho", 2500000, "EUR", GetCountry("Ecuador"), "Mediocentro"));
            AddPlayer(new Player(469, "16", "Jeremy Sarmiento", DateTime.Parse("2002-06-16"), 1.83, "derecho", 3000000, "EUR", GetCountry("Ecuador"), "Mediocentro ofensivo"));
            AddPlayer(new Player(470, "10", "Romario Ibarra", DateTime.Parse("1994-09-24"), 1.76, "derecho", 1800000, "EUR", GetCountry("Ecuador"), "Extremo izquierdo"));
            AddPlayer(new Player(471, "5", "Alexander Alvarado ", DateTime.Parse("1999-04-21"), 1.65, "derecho", 1200000, "EUR", GetCountry("Ecuador"), "Extremo izquierdo"));
            AddPlayer(new Player(472, "19", "Gonzalo Plata", DateTime.Parse("2000-11-01"), 1.78, "izquierdo", 6000000, "EUR", GetCountry("Ecuador"), "Extremo derecho"));
            AddPlayer(new Player(473, "15", "Ángel Mena", DateTime.Parse("1988-01-21"), 1.68, "izquierdo", 1800000, "EUR", GetCountry("Ecuador"), "Extremo derecho"));
            AddPlayer(new Player(474, "11", "Michael Estrada", DateTime.Parse("1996-04-07"), 1.88, "derecho", 3000000, "EUR", GetCountry("Ecuador"), "Delantero centro"));
            AddPlayer(new Player(475, "13", "Enner Valencia", DateTime.Parse("1989-11-04"), 1.77, "derecho", 2400000, "EUR", GetCountry("Ecuador"), "Delantero centro"));
            AddPlayer(new Player(476, "11", "Jordy Caicedo", DateTime.Parse("1997-11-18"), 1.87, "derecho", 2000000, "EUR", GetCountry("Ecuador"), "Delantero centro"));
            AddPlayer(new Player(477, "9", "Leonardo Campana", DateTime.Parse("2000-07-24"), 1.88, "izquierdo", 1200000, "EUR", GetCountry("Ecuador"), "Delantero centro"));
            AddPlayer(new Player(478, "10", "Djorkaeff Reasco", DateTime.Parse("1999-01-18"), 1.72, "derecho", 700000, "EUR", GetCountry("Ecuador"), "Delantero centro"));
            AddPlayer(new Player(479, "12", "Sergio Rochet", DateTime.Parse("1993-03-23"), 1.9, "derecho", 3000000, "EUR", GetCountry("Uruguay"), "Portero"));
            AddPlayer(new Player(480, "23", "Sebastián Sosa", DateTime.Parse("1986-08-19"), 1.81, "derecho", 2000000, "EUR", GetCountry("Uruguay"), "Portero"));
            AddPlayer(new Player(481, "1", "Fernando Muslera", DateTime.Parse("1986-06-16"), 1.9, "derecho", 1800000, "EUR", GetCountry("Uruguay"), "Portero"));
            AddPlayer(new Player(482, "2", "José María Giménez ", DateTime.Parse("1995-01-20"), 1.85, "derecho", 50000000, "EUR", GetCountry("Uruguay"), "Defensa central"));
            AddPlayer(new Player(483, "4", "Ronald Araújo", DateTime.Parse("1999-03-07"), 1.88, "derecho", 50000000, "EUR", GetCountry("Uruguay"), "Defensa central"));
            AddPlayer(new Player(484, "19", "Sebastián Coates", DateTime.Parse("1990-10-07"), 1.96, "derecho", 8000000, "EUR", GetCountry("Uruguay"), "Defensa central"));
            AddPlayer(new Player(485, "3", "Diego Godín", DateTime.Parse("1986-02-16"), 1.87, "derecho", 1000000, "EUR", GetCountry("Uruguay"), "Defensa central"));
            AddPlayer(new Player(486, "22", "Martín Cáceres", DateTime.Parse("1987-04-07"), 1.8, "derecho", 900000, "EUR", GetCountry("Uruguay"), "Defensa central"));
            AddPlayer(new Player(487, "16", "Mathías Olivera", DateTime.Parse("1997-10-31"), 1.85, "izquierdo", 15000000, "EUR", GetCountry("Uruguay"), "Lateral izquierdo"));
            AddPlayer(new Player(488, "17", "Matías Viña", DateTime.Parse("1997-11-09"), 1.8, "izquierdo", 7500000, "EUR", GetCountry("Uruguay"), "Lateral izquierdo"));
            AddPlayer(new Player(489, "4", "Guillermo Varela", DateTime.Parse("1993-03-24"), 1.73, "derecho", 2500000, "EUR", GetCountry("Uruguay"), "Lateral derecho"));
            AddPlayer(new Player(490, "4", "Luis Suárez", DateTime.Parse("1987-01-24"), 1.82, "derecho", 28000000, "EUR", GetCountry("Uruguay"), "Delantero centro"));
            AddPlayer(new Player(491, "13", "Damián Suárez", DateTime.Parse("1988-04-27"), 1.73, "derecho", 1500000, "EUR", GetCountry("Uruguay"), "Lateral derecho"));
            AddPlayer(new Player(492, "14", "Lucas Torreira", DateTime.Parse("1996-02-11"), 1.66, "derecho", 20000000, "EUR", GetCountry("Uruguay"), "Pivote"));
            AddPlayer(new Player(493, "6", "Manuel Ugarte", DateTime.Parse("2001-04-11"), 1.82, "derecho", 15000000, "EUR", GetCountry("Uruguay"), "Pivote"));
            AddPlayer(new Player(494, "15", "Federico Valverde", DateTime.Parse("1998-07-22"), 1.82, "derecho", 70000000, "EUR", GetCountry("Uruguay"), "Mediocentro"));
            AddPlayer(new Player(495, "20", "Mauro Arambarri", DateTime.Parse("1995-09-30"), 1.75, "derecho", 15000000, "EUR", GetCountry("Uruguay"), "Mediocentro"));
            AddPlayer(new Player(496, "7", "Nicolás de la Cruz", DateTime.Parse("1997-06-01"), 1.67, "derecho", 13000000, "EUR", GetCountry("Uruguay"), "Mediocentro"));
            AddPlayer(new Player(497, "11", "Fernando Gorriarán", DateTime.Parse("1994-11-27"), 1.68, "derecho", 8000000, "EUR", GetCountry("Uruguay"), "Mediocentro"));
            AddPlayer(new Player(498, "5", "Matías Vecino", DateTime.Parse("1991-08-24"), 1.87, "derecho", 3500000, "EUR", GetCountry("Uruguay"), "Mediocentro"));
            AddPlayer(new Player(499, "10", "Giorgian de Arrascaeta", DateTime.Parse("1994-06-01"), 1.74, "derecho", 17000000, "EUR", GetCountry("Uruguay"), "Mediocentro ofensivo"));
            AddPlayer(new Player(500, "8", "Diego Rossi", DateTime.Parse("1998-03-05"), 1.7, "derecho", 14500000, "EUR", GetCountry("Uruguay"), "Extremo izquierdo"));
            AddPlayer(new Player(501, "8", "Facundo Pellistri", DateTime.Parse("2001-12-20"), 1.74, "derecho", 2500000, "EUR", GetCountry("Uruguay"), "Extremo derecho"));
            AddPlayer(new Player(502, "NDF", "Agustín Canobbio", DateTime.Parse("1998-10-01"), 1.75, "derecho", 2000000, "EUR", GetCountry("Uruguay"), "Extremo derecho"));
            AddPlayer(new Player(503, "NDF", "Augusto Scarone", DateTime.Parse("2004-06-03"), 1.7, "izquierdo", 300000, "EUR", GetCountry("Uruguay"), "Mediapunta"));
            AddPlayer(new Player(504, "11", "Darwin Núñez", DateTime.Parse("1999-06-24"), 1.87, "derecho", 55000000, "EUR", GetCountry("Uruguay"), "Delantero centro"));
            AddPlayer(new Player(505, "18", "Maxi Gómez", DateTime.Parse("1996-08-14"), 1.86, "derecho", 12000000, "EUR", GetCountry("Uruguay"), "Delantero centro"));
            AddPlayer(new Player(506, "21", "Edinson Cavani", DateTime.Parse("1987-02-14"), 1.84, "derecho", 4000000, "EUR", GetCountry("Uruguay"), "Delantero centro"));
            AddPlayer(new Player(507, "NDF", "Maxime Crépeau", DateTime.Parse("1994-05-11"), 1.85, "derecho", 2000000, "EUR", GetCountry("Canadá"), "Portero"));
            AddPlayer(new Player(508, "18", "Milan Borjan", DateTime.Parse("1987-10-23"), 1.96, "derecho", 1500000, "EUR", GetCountry("Canadá"), "Portero"));
            AddPlayer(new Player(509, "NDF", "Dayne St. Clair", DateTime.Parse("1997-05-09"), 1.91, "izquierdo", 1000000, "EUR", GetCountry("Canadá"), "Portero"));
            AddPlayer(new Player(510, "NDF", "Kamal Miller", DateTime.Parse("1997-05-16"), 1.83, "izquierdo", 2500000, "EUR", GetCountry("Canadá"), "Defensa central"));
            AddPlayer(new Player(511, "NDF", "Doneil Henry", DateTime.Parse("1993-04-20"), 1.88, "derecho", 750000, "EUR", GetCountry("Canadá"), "Defensa central"));
            AddPlayer(new Player(512, "NDF", "Scott Kennedy", DateTime.Parse("1997-03-31"), 1.9, "izquierdo", 600000, "EUR", GetCountry("Canadá"), "Defensa central"));
            AddPlayer(new Player(513, "NDF", "Steven Vitória", DateTime.Parse("1987-01-11"), 1.95, "derecho", 100000, "EUR", GetCountry("Canadá"), "Defensa central"));
            AddPlayer(new Player(514, "19", "Alphonso Davies", DateTime.Parse("2000-11-02"), 1.83, "izquierdo", 70000000, "EUR", GetCountry("Canadá"), "Lateral izquierdo"));
            AddPlayer(new Player(515, "NDF", "Sam Adekugbe", DateTime.Parse("1995-01-16"), 1.76, "izquierdo", 2000000, "EUR", GetCountry("Canadá"), "Lateral izquierdo"));
            AddPlayer(new Player(516, "NDF", "Raheem Edwards", DateTime.Parse("1995-07-17"), 1.72, "NDF", 450000, "EUR", GetCountry("Canadá"), "Lateral izquierdo"));
            AddPlayer(new Player(517, "NDF", "Alistair Johnston", DateTime.Parse("1998-10-08"), 1.8, "NDF", 3000000, "EUR", GetCountry("Canadá"), "Lateral derecho"));
            AddPlayer(new Player(518, "NDF", "Richie Laryea", DateTime.Parse("1995-01-07"), 1.75, "derecho", 2500000, "EUR", GetCountry("Canadá"), "Lateral derecho"));
            AddPlayer(new Player(519, "NDF", "Stephen Eustaquio", DateTime.Parse("1996-12-21"), 1.77, "derecho", 5000000, "EUR", GetCountry("Canadá"), "Pivote"));
            AddPlayer(new Player(520, "NDF", "Samuel Piette", DateTime.Parse("1994-11-12"), 1.71, "derecho", 2500000, "EUR", GetCountry("Canadá"), "Pivote"));
            AddPlayer(new Player(521, "NDF", "Mark-Anthony Kaye", DateTime.Parse("1994-12-02"), 1.85, "izquierdo", 5000000, "EUR", GetCountry("Canadá"), "Mediocentro"));
            AddPlayer(new Player(522, "NDF", "Jonathan Osorio", DateTime.Parse("1992-06-12"), 1.75, "ambidiestro", 3500000, "EUR", GetCountry("Canadá"), "Mediocentro"));
            AddPlayer(new Player(523, "13", "Atiba Hutchinson", DateTime.Parse("1983-02-08"), 1.87, "derecho", 275000, "EUR", GetCountry("Canadá"), "Mediocentro"));
            AddPlayer(new Player(524, "NDF", "Cyle Larin", DateTime.Parse("1995-04-17"), 1.88, "derecho", 10000000, "EUR", GetCountry("Canadá"), "Extremo izquierdo"));
            AddPlayer(new Player(525, "NDF", "Junior Hoilett", DateTime.Parse("1990-06-05"), 1.74, "derecho", 800000, "EUR", GetCountry("Canadá"), "Extremo izquierdo"));
            AddPlayer(new Player(526, "NDF", "Luca Koleosho", DateTime.Parse("2004-09-15"), 0, "derecho", 0, "EUR", GetCountry("Canadá"), "Extremo izquierdo"));
            AddPlayer(new Player(527, "NDF", "Tajon Buchanan ", DateTime.Parse("1999-02-08"), 1.83, "derecho", 9500000, "EUR", GetCountry("Canadá"), "Extremo derecho"));
            AddPlayer(new Player(528, "NDF", "Jonathan David", DateTime.Parse("2000-01-14"), 1.8, "ambidiestro", 45000000, "EUR", GetCountry("Canadá"), "Delantero centro"));
            AddPlayer(new Player(529, "NDF", "Iké Ugbo", DateTime.Parse("1998-09-21"), 1.84, "derecho", 5000000, "EUR", GetCountry("Canadá"), "Delantero centro"));
            AddPlayer(new Player(530, "NDF", "Lucas Cavallini", DateTime.Parse("1992-12-28"), 1.82, "izquierdo", 3000000, "EUR", GetCountry("Canadá"), "Delantero centro"));
            AddPlayer(new Player(531, "NDF", "Charles-Andreas Brym", DateTime.Parse("1998-08-08"), 1.85, "izquierdo", 325000, "EUR", GetCountry("Canadá"), "Delantero centro"));
            AddPlayer(new Player(532, "12", "Lawrence Ati Zigi", DateTime.Parse("1996-11-29"), 1.89, "derecho", 2500000, "EUR", GetCountry("Ghana"), "Portero"));
            AddPlayer(new Player(533, "NDF", "Abdul Nurudeen", DateTime.Parse("1999-02-08"), 1.9, "derecho", 600000, "EUR", GetCountry("Ghana"), "Portero"));
            AddPlayer(new Player(534, "16", "Joe Wollacott", DateTime.Parse("1996-09-08"), 1.9, "NDF", 300000, "EUR", GetCountry("Ghana"), "Portero"));
            AddPlayer(new Player(535, "NDF", "Ibrahim Danlad", DateTime.Parse("2002-12-02"), 1.77, "derecho", 100000, "EUR", GetCountry("Ghana"), "Portero"));
            AddPlayer(new Player(536, "18", "Daniel Amartey", DateTime.Parse("1994-12-21"), 1.86, "derecho", 10000000, "EUR", GetCountry("Ghana"), "Defensa central"));
            AddPlayer(new Player(537, "6", "Joseph Aidoo", DateTime.Parse("1995-09-29"), 1.77, "derecho", 7000000, "EUR", GetCountry("Ghana"), "Defensa central"));
            AddPlayer(new Player(538, "26", "Abdul Mumin", DateTime.Parse("1998-06-06"), 1.88, "derecho", 3000000, "EUR", GetCountry("Ghana"), "Defensa central"));
            AddPlayer(new Player(539, "NDF", "Patric Pfeiffer", DateTime.Parse("1999-08-20"), 1.96, "derecho", 2000000, "EUR", GetCountry("Ghana"), "Defensa central"));
            AddPlayer(new Player(540, "NDF", "Alidu Seidu", DateTime.Parse("2000-06-04"), 1.73, "derecho", 2000000, "EUR", GetCountry("Ghana"), "Defensa central"));
            AddPlayer(new Player(541, "NDF", "Jonathan Mensah", DateTime.Parse("1990-07-13"), 1.88, "derecho", 800000, "EUR", GetCountry("Ghana"), "Defensa central"));
            AddPlayer(new Player(542, "NDF", "Stephan Ambrosius", DateTime.Parse("1998-12-18"), 1.83, "derecho", 800000, "EUR", GetCountry("Ghana"), "Defensa central"));
            AddPlayer(new Player(543, "14", "Gideon Mensah", DateTime.Parse("1998-07-18"), 1.78, "izquierdo", 2500000, "EUR", GetCountry("Ghana"), "Lateral izquierdo"));
            AddPlayer(new Player(544, "NDF", "Abdul-Rahman Baba", DateTime.Parse("1994-07-02"), 1.79, "izquierdo", 2200000, "EUR", GetCountry("Ghana"), "Lateral izquierdo"));
            AddPlayer(new Player(545, "NDF", "Andy Yiadom", DateTime.Parse("1991-12-02"), 1.8, "derecho", 1200000, "EUR", GetCountry("Ghana"), "Lateral derecho"));
            AddPlayer(new Player(546, "3", "Denis Odoi", DateTime.Parse("1988-05-27"), 1.78, "derecho", 700000, "EUR", GetCountry("Ghana"), "Lateral derecho"));
            AddPlayer(new Player(547, "10", "Elisha Owusu", DateTime.Parse("1997-11-07"), 1.82, "derecho", 2500000, "EUR", GetCountry("Ghana"), "Pivote"));
            AddPlayer(new Player(548, "NDF", "Edmund Addo", DateTime.Parse("2000-05-17"), 1.8, "derecho", 1100000, "EUR", GetCountry("Ghana"), "Pivote"));
            AddPlayer(new Player(549, "20", "Mohammed Kudus", DateTime.Parse("2000-08-02"), 1.77, "izquierdo", 10000000, "EUR", GetCountry("Ghana"), "Mediocentro"));
            AddPlayer(new Player(550, "21", "Iddrisu Baba", DateTime.Parse("1996-01-22"), 1.82, "derecho", 3500000, "EUR", GetCountry("Ghana"), "Mediocentro"));
            AddPlayer(new Player(551, "NDF", "Mubarak Wakaso", DateTime.Parse("1990-07-25"), 1.71, "izquierdo", 2000000, "EUR", GetCountry("Ghana"), "Mediocentro"));
            AddPlayer(new Player(552, "8", "Daniel-Kofi Kyereh", DateTime.Parse("1996-03-08"), 1.79, "derecho", 3000000, "EUR", GetCountry("Ghana"), "Mediocentro ofensivo"));
            AddPlayer(new Player(553, "7", "Issahaku Fatawu", DateTime.Parse("2004-03-08"), 1.77, "izquierdo", 500000, "EUR", GetCountry("Ghana"), "Mediocentro ofensivo"));
            AddPlayer(new Player(554, "NDF", "Augustine Okrah", DateTime.Parse("1993-09-14"), 1.72, "izquierdo", 150000, "EUR", GetCountry("Ghana"), "Mediocentro ofensivo"));
            AddPlayer(new Player(555, "22", "Kamaldeen Sulemana", DateTime.Parse("2002-02-15"), 1.75, "derecho", 18000000, "EUR", GetCountry("Ghana"), "Extremo izquierdo"));
            AddPlayer(new Player(556, "10", "André Ayew", DateTime.Parse("1989-12-17"), 1.76, "izquierdo", 2500000, "EUR", GetCountry("Ghana"), "Extremo izquierdo"));
            AddPlayer(new Player(557, "15", "Joseph Paintsil", DateTime.Parse("1998-02-01"), 1.69, "derecho", 2500000, "EUR", GetCountry("Ghana"), "Extremo izquierdo"));
            AddPlayer(new Player(558, "22", "Christopher Antwi-Adjei", DateTime.Parse("1994-02-07"), 1.74, "derecho", 1000000, "EUR", GetCountry("Ghana"), "Extremo izquierdo"));
            AddPlayer(new Player(559, "NDF", "Daniel Afriyie", DateTime.Parse("2001-06-26"), 1.76, "NDF", 150000, "EUR", GetCountry("Ghana"), "Extremo izquierdo"));
            AddPlayer(new Player(560, "11", "Osman Bukari", DateTime.Parse("1998-12-13"), 1.7, "ambidiestro", 3000000, "EUR", GetCountry("Ghana"), "Extremo derecho"));
            AddPlayer(new Player(561, "19", "Yaw Yeboah", DateTime.Parse("1997-03-28"), 1.75, "izquierdo", 1800000, "EUR", GetCountry("Ghana"), "Extremo derecho"));
            AddPlayer(new Player(562, "NDF", "Braydon Manu", DateTime.Parse("1997-03-28"), 1.7, "ambidiestro", 550000, "EUR", GetCountry("Ghana"), "Extremo derecho"));
            AddPlayer(new Player(563, "9", "Jordan Ayew", DateTime.Parse("1991-09-11"), 1.82, "derecho", 6000000, "EUR", GetCountry("Ghana"), "Delantero centro"));
            AddPlayer(new Player(564, "13", "Felix Afena-Gyan", DateTime.Parse("2003-01-19"), 1.75, "derecho", 6000000, "EUR", GetCountry("Ghana"), "Delantero centro"));
            AddPlayer(new Player(565, "15", "Antoine Semenyo", DateTime.Parse("2000-01-07"), 1.78, "derecho", 2500000, "EUR", GetCountry("Ghana"), "Delantero centro"));
            AddPlayer(new Player(566, "NDF", "Benjamin Tetteh", DateTime.Parse("1997-07-10"), 1.93, "derecho", 2300000, "EUR", GetCountry("Ghana"), "Delantero centro"));
            AddPlayer(new Player(567, "NDF", "Ransford-Yeboah Königsdörffer", DateTime.Parse("2001-09-13"), 1.83, "derecho", 1300000, "EUR", GetCountry("Ghana"), "Delantero centro"));
            AddPlayer(new Player(568, "17", "Kwasi Wriedt", DateTime.Parse("1994-07-10"), 1.88, "izquierdo", 900000, "EUR", GetCountry("Ghana"), "Delantero centro"));
            AddPlayer(new Player(569, "16", "Edouard Mendy", DateTime.Parse("1992-03-01"), 1.94, "derecho", 32000000, "EUR", GetCountry("Senegal"), "Portero"));
            AddPlayer(new Player(570, "NDF", "Alfred Gomis", DateTime.Parse("1993-09-05"), 1.96, "derecho", 8000000, "EUR", GetCountry("Senegal"), "Portero"));
            AddPlayer(new Player(571, "NDF", "Seny Dieng", DateTime.Parse("1994-11-23"), 1.93, "derecho", 1000000, "EUR", GetCountry("Senegal"), "Portero"));
            AddPlayer(new Player(572, "3", "Kalidou Koulibaly", DateTime.Parse("1991-06-20"), 1.86, "derecho", 35000000, "EUR", GetCountry("Senegal"), "Defensa central"));
            AddPlayer(new Player(573, "22", "Abdou Diallo", DateTime.Parse("1996-05-04"), 1.87, "izquierdo", 18000000, "EUR", GetCountry("Senegal"), "Defensa central"));
            AddPlayer(new Player(574, "4", "Pape Abou Cissé", DateTime.Parse("1995-09-14"), 1.98, "derecho", 8000000, "EUR", GetCountry("Senegal"), "Defensa central"));
            AddPlayer(new Player(575, "14", "Abdoulaye Seck", DateTime.Parse("1992-06-04"), 1.92, "derecho", 3000000, "EUR", GetCountry("Senegal"), "Defensa central"));
            AddPlayer(new Player(576, "12", "Fodé Ballo-Touré", DateTime.Parse("1997-01-03"), 1.82, "izquierdo", 3500000, "EUR", GetCountry("Senegal"), "Lateral izquierdo"));
            AddPlayer(new Player(577, "2", "Saliou Ciss", DateTime.Parse("1989-09-15"), 1.74, "izquierdo", 400000, "EUR", GetCountry("Senegal"), "Lateral izquierdo"));
            AddPlayer(new Player(578, "12", "Youssouf Sabaly", DateTime.Parse("1993-03-05"), 1.73, "derecho", 3000000, "EUR", GetCountry("Senegal"), "Lateral derecho"));
            AddPlayer(new Player(579, "2", "Alpha Diounkou", DateTime.Parse("2001-10-10"), 1.84, "derecho", 300000, "EUR", GetCountry("Senegal"), "Lateral derecho"));
            AddPlayer(new Player(580, "26", "Pape Gueye", DateTime.Parse("1999-01-24"), 1.83, "izquierdo", 12000000, "EUR", GetCountry("Senegal"), "Pivote"));
            AddPlayer(new Player(581, "6", "Nampalys Mendy", DateTime.Parse("1992-06-23"), 1.67, "derecho", 4000000, "EUR", GetCountry("Senegal"), "Pivote"));
            AddPlayer(new Player(582, "8", "Cheikhou Kouyaté", DateTime.Parse("1989-12-21"), 1.89, "derecho", 4000000, "EUR", GetCountry("Senegal"), "Pivote"));
            AddPlayer(new Player(583, "25", "Mamadou Loum", DateTime.Parse("1996-12-30"), 1.88, "derecho", 4000000, "EUR", GetCountry("Senegal"), "Pivote"));
            AddPlayer(new Player(584, "17", "Pape Matar Sarr", DateTime.Parse("2002-09-14"), 1.84, "derecho", 15000000, "EUR", GetCountry("Senegal"), "Mediocentro"));
            AddPlayer(new Player(585, "5", "Idrissa Gueye", DateTime.Parse("1989-09-26"), 1.74, "derecho", 12000000, "EUR", GetCountry("Senegal"), "Mediocentro"));
            AddPlayer(new Player(586, "24", "Moustapha Name", DateTime.Parse("1995-05-05"), 1.85, "ambidiestro", 2000000, "EUR", GetCountry("Senegal"), "Mediocentro"));
            AddPlayer(new Player(587, "NDF", "Iliman Ndiaye", DateTime.Parse("2000-03-06"), 1.8, "NDF", 1500000, "EUR", GetCountry("Senegal"), "Mediocentro ofensivo"));
            AddPlayer(new Player(588, "10", "Sadio Mané", DateTime.Parse("1992-04-10"), 1.74, "derecho", 70000000, "EUR", GetCountry("Senegal"), "Extremo izquierdo"));
            AddPlayer(new Player(589, "18", "Ismaïla Sarr", DateTime.Parse("1998-02-25"), 1.85, "derecho", 27000000, "EUR", GetCountry("Senegal"), "Extremo derecho"));
            AddPlayer(new Player(590, "NDF", "Demba Seck", DateTime.Parse("2001-02-10"), 1.9, "izquierdo", 3000000, "EUR", GetCountry("Senegal"), "Extremo derecho"));
            AddPlayer(new Player(591, "9", "Boulaye Dia", DateTime.Parse("1996-11-16"), 1.8, "derecho", 12000000, "EUR", GetCountry("Senegal"), "Delantero centro"));
            AddPlayer(new Player(592, "11", "Habib Diallo", DateTime.Parse("1995-06-18"), 1.86, "derecho", 12000000, "EUR", GetCountry("Senegal"), "Delantero centro"));
            AddPlayer(new Player(593, "19", "Famara Diédhiou", DateTime.Parse("1992-12-15"), 1.89, "derecho", 4000000, "EUR", GetCountry("Senegal"), "Delantero centro"));
            AddPlayer(new Player(594, "7", "Keita Baldé", DateTime.Parse("1995-03-08"), 1.81, "ambidiestro", 3000000, "EUR", GetCountry("Senegal"), "Delantero centro"));
            AddPlayer(new Player(595, "22", "Diogo Costa", DateTime.Parse("1999-09-19"), 1.86, "derecho", 25000000, "EUR", GetCountry("Portugal"), "Portero"));
            AddPlayer(new Player(596, "12", "Rui Silva", DateTime.Parse("1994-02-07"), 1.91, "izquierdo", 15000000, "EUR", GetCountry("Portugal"), "Portero"));
            AddPlayer(new Player(597, "1", "Rui Patrício", DateTime.Parse("1988-02-15"), 1.9, "izquierdo", 6000000, "EUR", GetCountry("Portugal"), "Portero"));
            AddPlayer(new Player(598, "5", "David Carmo", DateTime.Parse("1999-07-19"), 1.96, "izquierdo", 15000000, "EUR", GetCountry("Portugal"), "Defensa central"));
            AddPlayer(new Player(599, "4", "Domingos Duarte", DateTime.Parse("1995-03-10"), 1.92, "derecho", 8000000, "EUR", GetCountry("Portugal"), "Defensa central"));
            AddPlayer(new Player(600, "3", "Pepe", DateTime.Parse("1983-02-26"), 1.87, "derecho", 1000000, "EUR", GetCountry("Portugal"), "Defensa central"));
            AddPlayer(new Player(601, "19", "Nuno Mendes", DateTime.Parse("2002-06-19"), 1.76, "izquierdo", 40000000, "EUR", GetCountry("Portugal"), "Lateral izquierdo"));
            AddPlayer(new Player(602, "20", "João Cancelo ", DateTime.Parse("1994-05-27"), 1.82, "derecho", 65000000, "EUR", GetCountry("Portugal"), "Lateral derecho"));
            AddPlayer(new Player(603, "2", "Diogo Dalot", DateTime.Parse("1999-03-18"), 1.83, "derecho", 20000000, "EUR", GetCountry("Portugal"), "Lateral derecho"));
            AddPlayer(new Player(604, "18", "Rúben Neves", DateTime.Parse("1997-03-13"), 1.8, "derecho", 40000000, "EUR", GetCountry("Portugal"), "Pivote"));
            AddPlayer(new Player(605, "6", "João Palhinha", DateTime.Parse("1995-07-09"), 1.9, "derecho", 25000000, "EUR", GetCountry("Portugal"), "Pivote"));
            AddPlayer(new Player(606, "14", "William Carvalho", DateTime.Parse("1992-04-07"), 1.87, "derecho", 16000000, "EUR", GetCountry("Portugal"), "Pivote"));
            AddPlayer(new Player(607, "13", "Danilo Pereira", DateTime.Parse("1991-09-09"), 1.88, "derecho", 14000000, "EUR", GetCountry("Portugal"), "Pivote"));
            AddPlayer(new Player(608, "23", "Matheus Nunes", DateTime.Parse("1998-08-27"), 1.83, "derecho", 35000000, "EUR", GetCountry("Portugal"), "Mediocentro"));
            AddPlayer(new Player(609, "11", "Vitinha", DateTime.Parse("2000-02-13"), 1.72, "derecho", 30000000, "EUR", GetCountry("Portugal"), "Mediocentro"));
            AddPlayer(new Player(610, "16", "Otávio", DateTime.Parse("1995-02-09"), 1.72, "derecho", 30000000, "EUR", GetCountry("Portugal"), "Interior derecho"));
            AddPlayer(new Player(611, "8", "Bruno Fernandes", DateTime.Parse("1994-09-08"), 1.79, "derecho", 85000000, "EUR", GetCountry("Portugal"), "Mediocentro ofensivo"));
            AddPlayer(new Player(612, "10", "Bernardo Silva", DateTime.Parse("1994-08-10"), 1.73, "izquierdo", 80000000, "EUR", GetCountry("Portugal"), "Mediocentro ofensivo"));
            AddPlayer(new Player(613, "15", "Rafael Leão", DateTime.Parse("1999-06-10"), 1.88, "derecho", 70000000, "EUR", GetCountry("Portugal"), "Extremo izquierdo"));
            AddPlayer(new Player(614, "21", "Diogo Jota", DateTime.Parse("1996-12-04"), 1.78, "derecho", 60000000, "EUR", GetCountry("Portugal"), "Extremo izquierdo"));
            AddPlayer(new Player(615, "17", "Gonçalo Guedes", DateTime.Parse("1996-11-29"), 1.79, "derecho", 40000000, "EUR", GetCountry("Portugal"), "Extremo izquierdo"));
            AddPlayer(new Player(616, "7", "Ricardo Horta", DateTime.Parse("1994-09-15"), 1.73, "derecho", 20000000, "EUR", GetCountry("Portugal"), "Extremo izquierdo"));
            AddPlayer(new Player(617, "9", "André Silva", DateTime.Parse("1995-11-06"), 1.85, "derecho", 32000000, "EUR", GetCountry("Portugal"), "Delantero centro"));
            AddPlayer(new Player(618, "1", "Wojciech Szczesny ", DateTime.Parse("1990-04-18"), 1.96, "derecho", 15000000, "EUR", GetCountry("Polonia"), "Portero"));
            AddPlayer(new Player(619, "22", "Bartlomiej Dragowski", DateTime.Parse("1997-08-19"), 1.91, "derecho", 6000000, "EUR", GetCountry("Polonia"), "Portero"));
            AddPlayer(new Player(620, "1", "Kamil Grabara ", DateTime.Parse("1999-01-08"), 1.95, "derecho", 4000000, "EUR", GetCountry("Polonia"), "Portero"));
            AddPlayer(new Player(621, "12", "Lukasz Skorupski", DateTime.Parse("1991-05-05"), 1.87, "derecho", 4000000, "EUR", GetCountry("Polonia"), "Portero"));
            AddPlayer(new Player(622, "5", "Jan Bednarek", DateTime.Parse("1996-04-12"), 1.89, "derecho", 22000000, "EUR", GetCountry("Polonia"), "Defensa central"));
            AddPlayer(new Player(623, "3", "Mateusz Wieteska", DateTime.Parse("1997-02-11"), 1.87, "derecho", 1300000, "EUR", GetCountry("Polonia"), "Defensa central"));
            AddPlayer(new Player(624, "NDF", "Marcin Kaminski", DateTime.Parse("1992-01-15"), 1.92, "izquierdo", 1000000, "EUR", GetCountry("Polonia"), "Defensa central"));
            AddPlayer(new Player(625, "15", "Kamil Glik", DateTime.Parse("1988-02-03"), 1.9, "derecho", 1000000, "EUR", GetCountry("Polonia"), "Defensa central"));
            AddPlayer(new Player(626, "19", "Tymoteusz Puchacz ", DateTime.Parse("1999-01-23"), 1.8, "izquierdo", 2300000, "EUR", GetCountry("Polonia"), "Lateral izquierdo"));
            AddPlayer(new Player(627, "13", "Kamil Pestka", DateTime.Parse("1998-08-22"), 1.89, "izquierdo", 900000, "EUR", GetCountry("Polonia"), "Lateral izquierdo"));
            AddPlayer(new Player(628, "2", "Matty Cash", DateTime.Parse("1997-08-07"), 1.85, "derecho", 25000000, "EUR", GetCountry("Polonia"), "Lateral derecho"));
            AddPlayer(new Player(629, "4", "Tomasz Kedziora", DateTime.Parse("1994-06-11"), 1.84, "derecho", 4500000, "EUR", GetCountry("Polonia"), "Lateral derecho"));
            AddPlayer(new Player(630, "18", "Bartosz Bereszynski", DateTime.Parse("1992-07-12"), 1.83, "derecho", 4000000, "EUR", GetCountry("Polonia"), "Lateral derecho"));
            AddPlayer(new Player(631, "25", "Robert Gumny", DateTime.Parse("1998-06-04"), 1.82, "derecho", 2500000, "EUR", GetCountry("Polonia"), "Lateral derecho"));
            AddPlayer(new Player(632, "10", "Grzegorz Krychowiak", DateTime.Parse("1990-01-29"), 1.87, "derecho", 8000000, "EUR", GetCountry("Polonia"), "Pivote"));
            AddPlayer(new Player(633, "NDF", "Krystian Bielik", DateTime.Parse("1998-01-04"), 1.89, "derecho", 4000000, "EUR", GetCountry("Polonia"), "Pivote"));
            AddPlayer(new Player(634, "4", "Jakub Kiwior", DateTime.Parse("2000-02-15"), 1.89, "izquierdo", 3000000, "EUR", GetCountry("Polonia"), "Pivote"));
            AddPlayer(new Player(635, "6", "Jacek Goralski", DateTime.Parse("1992-09-21"), 1.72, "derecho", 1600000, "EUR", GetCountry("Polonia"), "Pivote"));
            AddPlayer(new Player(636, "8", "Szymon Zurkowski ", DateTime.Parse("1997-09-25"), 1.85, "derecho", 7000000, "EUR", GetCountry("Polonia"), "Mediocentro"));
            AddPlayer(new Player(637, "8", "Karol Linetty", DateTime.Parse("1995-02-02"), 1.76, "derecho", 3500000, "EUR", GetCountry("Polonia"), "Mediocentro"));
            AddPlayer(new Player(638, "14", "Mateusz Klich", DateTime.Parse("1990-06-13"), 1.83, "derecho", 3000000, "EUR", GetCountry("Polonia"), "Mediocentro"));
            AddPlayer(new Player(639, "17", "Damian Szymanski", DateTime.Parse("1995-06-16"), 1.82, "derecho", 1800000, "EUR", GetCountry("Polonia"), "Mediocentro"));
            AddPlayer(new Player(640, "21", "Nicola Zalewski ", DateTime.Parse("2002-01-23"), 1.75, "ambidiestro", 12000000, "EUR", GetCountry("Polonia"), "Interior izquierdo"));
            AddPlayer(new Player(641, "19", "Przemyslaw Frankowski", DateTime.Parse("1995-04-12"), 1.76, "derecho", 8000000, "EUR", GetCountry("Polonia"), "Interior izquierdo"));
            AddPlayer(new Player(642, "NDF", "Patryk Kun", DateTime.Parse("1995-04-20"), 1.65, "ambidiestro", 1200000, "EUR", GetCountry("Polonia"), "Interior izquierdo"));
            AddPlayer(new Player(643, "20", "Piotr Zielinski", DateTime.Parse("1994-05-20"), 1.8, "ambidiestro", 40000000, "EUR", GetCountry("Polonia"), "Mediocentro ofensivo"));
            AddPlayer(new Player(644, "17", "Sebastian Szymanski", DateTime.Parse("1999-05-10"), 1.74, "izquierdo", 14000000, "EUR", GetCountry("Polonia"), "Mediocentro ofensivo"));
            AddPlayer(new Player(645, "2", "Jakub Kaminski", DateTime.Parse("2002-06-05"), 1.79, "derecho", 10000000, "EUR", GetCountry("Polonia"), "Extremo izquierdo"));
            AddPlayer(new Player(646, "NDF", "Kamil Józwiak", DateTime.Parse("1998-04-22"), 1.76, "derecho", 2500000, "EUR", GetCountry("Polonia"), "Extremo izquierdo"));
            AddPlayer(new Player(647, "NDF", "Przemyslaw Placheta", DateTime.Parse("1998-03-23"), 1.78, "izquierdo", 1800000, "EUR", GetCountry("Polonia"), "Extremo izquierdo"));
            AddPlayer(new Player(648, "11", "Kamil Grosicki", DateTime.Parse("1988-06-08"), 1.8, "derecho", 800000, "EUR", GetCountry("Polonia"), "Extremo izquierdo"));
            AddPlayer(new Player(649, "NDF", "Konrad Michalak", DateTime.Parse("1997-09-19"), 1.76, "derecho", 1700000, "EUR", GetCountry("Polonia"), "Extremo derecho"));
            AddPlayer(new Player(650, "9", "Robert Lewandowski", DateTime.Parse("1988-08-21"), 1.85, "derecho", 45000000, "EUR", GetCountry("Polonia"), "Delantero centro"));
            AddPlayer(new Player(651, "NDF", "Arkadiusz Milik", DateTime.Parse("1994-02-28"), 1.86, "izquierdo", 16000000, "EUR", GetCountry("Polonia"), "Delantero centro"));
            AddPlayer(new Player(652, "23", "Krzysztof Piatek", DateTime.Parse("1995-07-01"), 1.83, "derecho", 12000000, "EUR", GetCountry("Polonia"), "Delantero centro"));
            AddPlayer(new Player(653, "7", "Adam Buksa ", DateTime.Parse("1996-07-12"), 1.93, "izquierdo", 9000000, "EUR", GetCountry("Polonia"), "Delantero centro"));
            AddPlayer(new Player(654, "16", "Karol Swiderski", DateTime.Parse("1997-01-23"), 1.84, "izquierdo", 5000000, "EUR", GetCountry("Polonia"), "Delantero centro"));
            AddPlayer(new Player(655, "NDF", "Bechir Ben Said", DateTime.Parse("1994-11-29"), 1.94, "NDF", 850000, "EUR", GetCountry("Túnez"), "Portero"));
            AddPlayer(new Player(656, "16", "Aymen Dahmen", DateTime.Parse("1997-01-28"), 1.88, "derecho", 850000, "EUR", GetCountry("Túnez"), "Portero"));
            AddPlayer(new Player(657, "1", "Mohamed Sedki Debchi", DateTime.Parse("1999-10-28"), 1.95, "derecho", 500000, "EUR", GetCountry("Túnez"), "Portero"));
            AddPlayer(new Player(658, "3", "Montassar Talbi", DateTime.Parse("1998-05-26"), 1.9, "derecho", 1200000, "EUR", GetCountry("Túnez"), "Defensa central"));
            AddPlayer(new Player(659, "6", "Nader Ghandri", DateTime.Parse("1995-02-18"), 1.96, "derecho", 650000, "EUR", GetCountry("Túnez"), "Defensa central"));
            AddPlayer(new Player(660, "24", "Alaa Ghram", DateTime.Parse("2001-07-24"), 0, "derecho", 450000, "EUR", GetCountry("Túnez"), "Defensa central"));
            AddPlayer(new Player(661, "2", "Bilel Ifa", DateTime.Parse("1990-03-09"), 1.85, "derecho", 250000, "EUR", GetCountry("Túnez"), "Defensa central"));
            AddPlayer(new Player(662, "NDF", "Adam Ben Lamin", DateTime.Parse("2001-06-02"), 1.84, "derecho", 200000, "EUR", GetCountry("Túnez"), "Defensa central"));
            AddPlayer(new Player(663, "4", "Ali Abdi", DateTime.Parse("1993-12-20"), 1.83, "izquierdo", 1500000, "EUR", GetCountry("Túnez"), "Lateral izquierdo"));
            AddPlayer(new Player(664, "12", "Ali Maâloul", DateTime.Parse("1990-01-01"), 1.75, "izquierdo", 1500000, "EUR", GetCountry("Túnez"), "Lateral izquierdo"));
            AddPlayer(new Player(665, "21", "Rami Kaib", DateTime.Parse("1997-05-08"), 1.78, "NDF", 700000, "EUR", GetCountry("Túnez"), "Lateral izquierdo"));
            AddPlayer(new Player(666, "20", "Mohamed Dräger", DateTime.Parse("1996-06-25"), 1.81, "derecho", 1300000, "EUR", GetCountry("Túnez"), "Lateral derecho"));
            AddPlayer(new Player(667, "8", "Anis Slimane", DateTime.Parse("2001-03-16"), 1.88, "ambidiestro", 3500000, "EUR", GetCountry("Túnez"), "Mediocentro"));
            AddPlayer(new Player(668, "14", "Aïssa Laïdouni", DateTime.Parse("1996-12-13"), 1.83, "derecho", 3500000, "EUR", GetCountry("Túnez"), "Mediocentro"));
            AddPlayer(new Player(669, "15", "Mohamed Ali Ben Romdhane", DateTime.Parse("1999-09-06"), 1.85, "derecho", 2700000, "EUR", GetCountry("Túnez"), "Mediocentro"));
            AddPlayer(new Player(670, "13", "Ferjani Sassi", DateTime.Parse("1992-03-18"), 1.85, "derecho", 2000000, "EUR", GetCountry("Túnez"), "Mediocentro"));
            AddPlayer(new Player(671, "10", "Hannibal Mejbri", DateTime.Parse("2003-01-21"), 1.84, "derecho", 6000000, "EUR", GetCountry("Túnez"), "Mediocentro ofensivo"));
            AddPlayer(new Player(672, "18", "Firas Ben Larbi", DateTime.Parse("1996-05-27"), 1.71, "izquierdo", 3000000, "EUR", GetCountry("Túnez"), "Mediocentro ofensivo"));
            AddPlayer(new Player(673, "8", "Mootez Zaddem", DateTime.Parse("2001-01-05"), 1.85, "derecho", 500000, "EUR", GetCountry("Túnez"), "Mediocentro ofensivo"));
            AddPlayer(new Player(674, "23", "Naïm Sliti", DateTime.Parse("1992-07-27"), 1.73, "derecho", 7500000, "EUR", GetCountry("Túnez"), "Extremo izquierdo"));
            AddPlayer(new Player(675, "7", "Youssef Msakni", DateTime.Parse("1990-10-28"), 1.79, "derecho", 1200000, "EUR", GetCountry("Túnez"), "Extremo izquierdo"));
            AddPlayer(new Player(676, "NDF", "Elias Achouri", DateTime.Parse("1999-02-10"), 1.77, "derecho", 300000, "EUR", GetCountry("Túnez"), "Extremo derecho"));
            AddPlayer(new Player(677, "17", "Issam Jebali", DateTime.Parse("1991-12-25"), 1.86, "ambidiestro", 500000, "EUR", GetCountry("Túnez"), "Mediapunta"));
            AddPlayer(new Player(678, "19", "Seifeddine Jaziri", DateTime.Parse("1993-02-12"), 1.8, "derecho", 1000000, "EUR", GetCountry("Túnez"), "Delantero centro"));
            AddPlayer(new Player(679, "NDF", "Taha Yassine Khenissi", DateTime.Parse("1992-01-06"), 1.8, "derecho", 500000, "EUR", GetCountry("Túnez"), "Delantero centro"));
            AddPlayer(new Player(680, "1", "Bono", DateTime.Parse("1991-04-05"), 1.92, "izquierdo", 18000000, "EUR", GetCountry("Marruecos"), "Portero"));
            AddPlayer(new Player(681, "12", "Munir", DateTime.Parse("1989-05-10"), 1.9, "derecho", 1500000, "EUR", GetCountry("Marruecos"), "Portero"));
            AddPlayer(new Player(682, "NDF", "Anas Zniti", DateTime.Parse("1988-10-28"), 1.82, "derecho", 1200000, "EUR", GetCountry("Marruecos"), "Portero"));
            AddPlayer(new Player(683, "5", "Nayef Aguerd ", DateTime.Parse("1996-03-30"), 1.88, "izquierdo", 12000000, "EUR", GetCountry("Marruecos"), "Defensa central"));
            AddPlayer(new Player(684, "6", "Romain Saïss", DateTime.Parse("1990-03-26"), 1.88, "izquierdo", 8000000, "EUR", GetCountry("Marruecos"), "Defensa central"));
            AddPlayer(new Player(685, "NDF", "Achraf Dari", DateTime.Parse("1999-05-06"), 1.88, "derecho", 1800000, "EUR", GetCountry("Marruecos"), "Defensa central"));
            AddPlayer(new Player(686, "24", "Samy Mmaee", DateTime.Parse("1996-09-08"), 1.88, "derecho", 1300000, "EUR", GetCountry("Marruecos"), "Defensa central"));
            AddPlayer(new Player(687, "NDF", "Jawad El Yamiq", DateTime.Parse("1992-02-29"), 1.93, "derecho", 1200000, "EUR", GetCountry("Marruecos"), "Defensa central"));
            AddPlayer(new Player(688, "18", "Soufiane Chakla", DateTime.Parse("1993-09-02"), 1.88, "derecho", 800000, "EUR", GetCountry("Marruecos"), "Defensa central"));
            AddPlayer(new Player(689, "3", "Adam Masina", DateTime.Parse("1994-01-02"), 1.91, "izquierdo", 3000000, "EUR", GetCountry("Marruecos"), "Lateral izquierdo"));
            AddPlayer(new Player(690, "NDF", "Yahia Attiyat Allah", DateTime.Parse("1995-03-02"), 1.76, "izquierdo", 1000000, "EUR", GetCountry("Marruecos"), "Lateral izquierdo"));
            AddPlayer(new Player(691, "2", "Achraf Hakimi", DateTime.Parse("1998-11-04"), 1.81, "derecho", 65000000, "EUR", GetCountry("Marruecos"), "Lateral derecho"));
            AddPlayer(new Player(692, "NDF", "Noussair Mazraoui", DateTime.Parse("1997-11-14"), 1.83, "derecho", 20000000, "EUR", GetCountry("Marruecos"), "Lateral derecho"));
            AddPlayer(new Player(693, "20", "Sofiane Alakouch", DateTime.Parse("1998-07-29"), 1.75, "derecho", 1500000, "EUR", GetCountry("Marruecos"), "Lateral derecho"));
            AddPlayer(new Player(694, "NDF", "Mohamed Chibi", DateTime.Parse("1993-01-21"), 1.79, "derecho", 825000, "EUR", GetCountry("Marruecos"), "Lateral derecho"));
            AddPlayer(new Player(695, "4", "Sofyan Amrabat", DateTime.Parse("1996-08-21"), 1.85, "derecho", 10000000, "EUR", GetCountry("Marruecos"), "Pivote"));
            AddPlayer(new Player(696, "NDF", "Yahya Jabrane", DateTime.Parse("1991-06-18"), 1.87, "derecho", 1700000, "EUR", GetCountry("Marruecos"), "Pivote"));
            AddPlayer(new Player(697, "7", "Imrân Louza", DateTime.Parse("1999-05-01"), 1.78, "izquierdo", 9000000, "EUR", GetCountry("Marruecos"), "Mediocentro"));
            AddPlayer(new Player(698, "8", "Azzedine Ounahi", DateTime.Parse("2000-04-19"), 1.82, "derecho", 3000000, "EUR", GetCountry("Marruecos"), "Mediocentro"));
            AddPlayer(new Player(699, "NDF", "Adel Taarabt", DateTime.Parse("1989-05-24"), 1.78, "derecho", 2500000, "EUR", GetCountry("Marruecos"), "Mediocentro"));
            AddPlayer(new Player(700, "11", "Fayçal Fajr", DateTime.Parse("1988-08-01"), 1.79, "derecho", 1800000, "EUR", GetCountry("Marruecos"), "Mediocentro"));
            AddPlayer(new Player(701, "NDF", "Amine Harit", DateTime.Parse("1997-06-18"), 1.8, "derecho", 10000000, "EUR", GetCountry("Marruecos"), "Mediocentro ofensivo"));
            AddPlayer(new Player(702, "15", "Selim Amallah", DateTime.Parse("1996-11-15"), 1.86, "derecho", 5000000, "EUR", GetCountry("Marruecos"), "Mediocentro ofensivo"));
            AddPlayer(new Player(703, "13", "Ilias Chair", DateTime.Parse("1997-10-30"), 1.72, "derecho", 4000000, "EUR", GetCountry("Marruecos"), "Mediocentro ofensivo"));
            AddPlayer(new Player(704, "NDF", "Aymen Barkok", DateTime.Parse("1998-05-21"), 1.89, "derecho", 1800000, "EUR", GetCountry("Marruecos"), "Mediocentro ofensivo"));
            AddPlayer(new Player(705, "28", "Tarik Tissoudali ", DateTime.Parse("1993-04-02"), 1.82, "derecho", 7500000, "EUR", GetCountry("Marruecos"), "Extremo izquierdo"));
            AddPlayer(new Player(706, "NDF", "Soufiane Rahimi", DateTime.Parse("1996-06-02"), 1.8, "derecho", 4500000, "EUR", GetCountry("Marruecos"), "Extremo izquierdo"));
            AddPlayer(new Player(707, "NDF", "Zakaria Aboukhlal", DateTime.Parse("2000-02-18"), 1.79, "ambidiestro", 2000000, "EUR", GetCountry("Marruecos"), "Extremo derecho"));
            AddPlayer(new Player(708, "19", "Youssef En-Nesyri", DateTime.Parse("1997-06-01"), 1.89, "izquierdo", 25000000, "EUR", GetCountry("Marruecos"), "Delantero centro"));
            AddPlayer(new Player(709, "10", "Munir El Haddadi", DateTime.Parse("1995-09-01"), 1.75, "izquierdo", 8000000, "EUR", GetCountry("Marruecos"), "Delantero centro"));
            AddPlayer(new Player(710, "9", "Ayoub El Kaabi", DateTime.Parse("1993-06-25"), 1.82, "izquierdo", 5000000, "EUR", GetCountry("Marruecos"), "Delantero centro"));
            AddPlayer(new Player(711, "24", "André Onana", DateTime.Parse("1996-04-02"), 1.9, "derecho", 12000000, "EUR", GetCountry("Camerún"), "Portero"));
            AddPlayer(new Player(712, "16", "Devis Epassy", DateTime.Parse("1993-02-02"), 1.89, "derecho", 600000, "EUR", GetCountry("Camerún"), "Portero"));
            AddPlayer(new Player(713, "23", "Simon Omossola", DateTime.Parse("1998-05-05"), 1.89, "derecho", 400000, "EUR", GetCountry("Camerún"), "Portero"));
            AddPlayer(new Player(714, "21", "Jean-Charles Castelletto", DateTime.Parse("1995-01-26"), 1.86, "ambidiestro", 4000000, "EUR", GetCountry("Camerún"), "Defensa central"));
            AddPlayer(new Player(715, "5", "Michael Ngadeu", DateTime.Parse("1990-11-23"), 1.9, "derecho", 3500000, "EUR", GetCountry("Camerún"), "Defensa central"));
            AddPlayer(new Player(716, "NDF", "Christopher Wooh", DateTime.Parse("2001-09-18"), 1.91, "derecho", 3000000, "EUR", GetCountry("Camerún"), "Defensa central"));
            AddPlayer(new Player(717, "NDF", "Duplexe Tchamba", DateTime.Parse("1998-07-10"), 1.91, "izquierdo", 400000, "EUR", GetCountry("Camerún"), "Defensa central"));
            AddPlayer(new Player(718, "25", "Nouhou", DateTime.Parse("1997-06-23"), 1.78, "NDF", 2500000, "EUR", GetCountry("Camerún"), "Lateral izquierdo"));
            AddPlayer(new Player(719, "6", "Ambroise Oyongo", DateTime.Parse("1991-06-22"), 1.76, "izquierdo", 1800000, "EUR", GetCountry("Camerún"), "Lateral izquierdo"));
            AddPlayer(new Player(720, "17", "Olivier Mbaizo", DateTime.Parse("1997-08-15"), 1.78, "NDF", 1500000, "EUR", GetCountry("Camerún"), "Lateral derecho"));
            AddPlayer(new Player(721, "19", "Collins Fai", DateTime.Parse("1992-08-13"), 1.65, "derecho", 900000, "EUR", GetCountry("Camerún"), "Lateral derecho"));
            AddPlayer(new Player(722, "8", "André Zambo Anguissa", DateTime.Parse("1995-11-16"), 1.84, "derecho", 30000000, "EUR", GetCountry("Camerún"), "Pivote"));
            AddPlayer(new Player(723, "18", "Martin Hongla", DateTime.Parse("1998-03-16"), 1.81, "derecho", 4000000, "EUR", GetCountry("Camerún"), "Pivote"));
            AddPlayer(new Player(724, "14", "Samuel Oum Gouet", DateTime.Parse("1997-12-14"), 1.85, "derecho", 2000000, "EUR", GetCountry("Camerún"), "Pivote"));
            AddPlayer(new Player(725, "8", "Gaël Ondoua", DateTime.Parse("1995-11-04"), 1.85, "izquierdo", 1000000, "EUR", GetCountry("Camerún"), "Pivote"));
            AddPlayer(new Player(726, "NDF", "Olivier Ntcham", DateTime.Parse("1996-02-09"), 1.8, "derecho", 3000000, "EUR", GetCountry("Camerún"), "Mediocentro"));
            AddPlayer(new Player(727, "15", "Pierre Kunde", DateTime.Parse("1995-07-26"), 1.8, "derecho", 2000000, "EUR", GetCountry("Camerún"), "Mediocentro"));
            AddPlayer(new Player(728, "12", "Karl Toko Ekambi", DateTime.Parse("1992-09-14"), 1.85, "derecho", 15000000, "EUR", GetCountry("Camerún"), "Extremo izquierdo"));
            AddPlayer(new Player(729, "3", "Nicolas Moumi Ngamaleu", DateTime.Parse("1994-07-09"), 1.81, "derecho", 4700000, "EUR", GetCountry("Camerún"), "Extremo izquierdo"));
            AddPlayer(new Player(730, "NDF", "Georges-Kevin N'Koudou", DateTime.Parse("1995-02-13"), 1.72, "derecho", 4200000, "EUR", GetCountry("Camerún"), "Extremo izquierdo"));
            AddPlayer(new Player(731, "10", "Vincent Aboubakar", DateTime.Parse("1992-01-22"), 1.84, "derecho", 7000000, "EUR", GetCountry("Camerún"), "Delantero centro"));
            AddPlayer(new Player(732, "20", "Ignatius Ganago", DateTime.Parse("1999-02-16"), 1.79, "derecho", 5000000, "EUR", GetCountry("Camerún"), "Delantero centro"));
            AddPlayer(new Player(733, "13", "Eric Maxim Choupo-Moting", DateTime.Parse("1989-03-23"), 1.91, "derecho", 3000000, "EUR", GetCountry("Camerún"), "Delantero centro"));
            AddPlayer(new Player(734, "NDF", "Léandre Tawamba", DateTime.Parse("1989-12-20"), 1.89, "derecho", 2000000, "EUR", GetCountry("Camerún"), "Delantero centro"));
            AddPlayer(new Player(735, "9", "Kévin Soni", DateTime.Parse("1998-04-17"), 1.83, "izquierdo", 800000, "EUR", GetCountry("Camerún"), "Delantero centro"));
            AddPlayer(new Player(736, "1", "Carlos Acevedo", DateTime.Parse("1996-04-19"), 1.85, "derecho", 5000000, "EUR", GetCountry("México"), "Portero"));
            AddPlayer(new Player(737, "12", "Rodolfo Cota", DateTime.Parse("1987-07-03"), 1.83, "derecho", 1500000, "EUR", GetCountry("México"), "Portero"));
            AddPlayer(new Player(738, "13", "David Ochoa", DateTime.Parse("2001-01-16"), 1.88, "NDF", 800000, "EUR", GetCountry("México"), "Portero"));
            AddPlayer(new Player(739, "3", "Jesús Angulo", DateTime.Parse("1998-01-30"), 1.78, "izquierdo", 6000000, "EUR", GetCountry("México"), "Defensa central"));
            AddPlayer(new Player(740, "15", "Israel Reyes", DateTime.Parse("2000-05-23"), 1.79, "derecho", 3500000, "EUR", GetCountry("México"), "Defensa central"));
            AddPlayer(new Player(741, "4", "Julio Domínguez", DateTime.Parse("1987-11-08"), 1.77, "derecho", 1400000, "EUR", GetCountry("México"), "Defensa central"));
            AddPlayer(new Player(742, "19", "Érick Aguirre", DateTime.Parse("1997-02-23"), 1.71, "derecho", 5000000, "EUR", GetCountry("México"), "Lateral izquierdo"));
            AddPlayer(new Player(743, "23", "Jesús Gallardo", DateTime.Parse("1994-08-15"), 1.76, "izquierdo", 3000000, "EUR", GetCountry("México"), "Lateral izquierdo"));
            AddPlayer(new Player(744, "2", "Kevin Álvarez", DateTime.Parse("1999-01-15"), 1.76, "derecho", 5000000, "EUR", GetCountry("México"), "Lateral derecho"));
            AddPlayer(new Player(745, "5", "Julián Araujo", DateTime.Parse("2001-08-13"), 1.75, "derecho", 4500000, "EUR", GetCountry("México"), "Lateral derecho"));
            AddPlayer(new Player(746, "18", "Luis Chávez", DateTime.Parse("1996-01-15"), 1.78, "izquierdo", 5000000, "EUR", GetCountry("México"), "Pivote"));
            AddPlayer(new Player(747, "18", "Erik Lira", DateTime.Parse("2000-05-08"), 1.72, "derecho", 4000000, "EUR", GetCountry("México"), "Pivote"));
            AddPlayer(new Player(748, "6", "Érick Sánchez", DateTime.Parse("1999-09-27"), 1.67, "derecho", 7000000, "EUR", GetCountry("México"), "Mediocentro"));
            AddPlayer(new Player(749, "7", "Luis Romo", DateTime.Parse("1995-06-05"), 1.84, "derecho", 7000000, "EUR", GetCountry("México"), "Mediocentro"));
            AddPlayer(new Player(750, "16", "Fernando Beltrán", DateTime.Parse("1998-05-08"), 1.68, "derecho", 4500000, "EUR", GetCountry("México"), "Mediocentro"));
            AddPlayer(new Player(751, "10", "Orbelín Pineda", DateTime.Parse("1996-03-24"), 1.69, "derecho", 4000000, "EUR", GetCountry("México"), "Mediocentro"));
            AddPlayer(new Player(752, "8", "Sebastián Córdova", DateTime.Parse("1997-06-12"), 1.74, "NDF", 5000000, "EUR", GetCountry("México"), "Mediocentro ofensivo"));
            AddPlayer(new Player(753, "20", "Rodolfo Pizarro", DateTime.Parse("1994-02-15"), 1.75, "derecho", 4000000, "EUR", GetCountry("México"), "Mediocentro ofensivo"));
            AddPlayer(new Player(754, "17", "Marcelo Flores", DateTime.Parse("2003-10-01"), 1.64, "derecho", 1500000, "EUR", GetCountry("México"), "Mediocentro ofensivo"));
            AddPlayer(new Player(755, "22", "Uriel Antuna", DateTime.Parse("1997-08-21"), 1.74, "derecho", 5000000, "EUR", GetCountry("México"), "Extremo derecho"));
            AddPlayer(new Player(756, "11", "Diego Lainez", DateTime.Parse("2000-06-09"), 1.68, "izquierdo", 2500000, "EUR", GetCountry("México"), "Extremo derecho"));
            AddPlayer(new Player(757, "9", "Santiago Giménez", DateTime.Parse("2001-04-18"), 1.83, "izquierdo", 4000000, "EUR", GetCountry("México"), "Delantero centro"));
            AddPlayer(new Player(758, "21", "Henry Martín", DateTime.Parse("1992-11-18"), 1.77, "derecho", 3500000, "EUR", GetCountry("México"), "Delantero centro"));
            AddPlayer(new Player(759, "1", "Matt Turner", DateTime.Parse("1994-06-24"), 1.91, "derecho", 5000000, "EUR", GetCountry("Estados Unidos"), "Portero"));
            AddPlayer(new Player(760, "NDF", "Sean Johnson", DateTime.Parse("1989-05-31"), 1.9, "derecho", 1500000, "EUR", GetCountry("Estados Unidos"), "Portero"));
            AddPlayer(new Player(761, "18", "Ethan Horvath", DateTime.Parse("1995-06-09"), 1.95, "derecho", 800000, "EUR", GetCountry("Estados Unidos"), "Portero"));
            AddPlayer(new Player(762, "20", "Cameron Carter-Vickers", DateTime.Parse("1997-12-31"), 1.83, "derecho", 7000000, "EUR", GetCountry("Estados Unidos"), "Defensa central"));
            AddPlayer(new Player(763, "3", "Walker Zimmerman", DateTime.Parse("1993-05-19"), 1.9, "derecho", 3500000, "EUR", GetCountry("Estados Unidos"), "Defensa central"));
            AddPlayer(new Player(764, "12", "Erik Palmer-Brown", DateTime.Parse("1997-04-24"), 1.86, "derecho", 3000000, "EUR", GetCountry("Estados Unidos"), "Defensa central"));
            AddPlayer(new Player(765, "15", "Aaron Long", DateTime.Parse("1992-10-12"), 1.86, "derecho", 3000000, "EUR", GetCountry("Estados Unidos"), "Defensa central"));
            AddPlayer(new Player(766, "5", "Antonee Robinson", DateTime.Parse("1997-08-08"), 1.83, "izquierdo", 8000000, "EUR", GetCountry("Estados Unidos"), "Lateral izquierdo"));
            AddPlayer(new Player(767, "24", "George Bello", DateTime.Parse("2002-01-22"), 1.7, "izquierdo", 3000000, "EUR", GetCountry("Estados Unidos"), "Lateral izquierdo"));
            AddPlayer(new Player(768, "29", "Joe Scally", DateTime.Parse("2002-12-31"), 1.84, "derecho", 8000000, "EUR", GetCountry("Estados Unidos"), "Lateral derecho"));
            AddPlayer(new Player(769, "22", "Reggie Cannon", DateTime.Parse("1998-06-11"), 1.8, "derecho", 4000000, "EUR", GetCountry("Estados Unidos"), "Lateral derecho"));
            AddPlayer(new Player(770, "2", "DeAndre Yedlin", DateTime.Parse("1993-07-09"), 1.73, "derecho", 2500000, "EUR", GetCountry("Estados Unidos"), "Lateral derecho"));
            AddPlayer(new Player(771, "4", "Tyler Adams", DateTime.Parse("1999-02-14"), 1.75, "derecho", 17000000, "EUR", GetCountry("Estados Unidos"), "Pivote"));
            AddPlayer(new Player(772, "23", "Kellyn Acosta", DateTime.Parse("1995-07-24"), 1.77, "derecho", 3000000, "EUR", GetCountry("Estados Unidos"), "Pivote"));
            AddPlayer(new Player(773, "8", "Weston McKennie ", DateTime.Parse("1998-08-28"), 1.77, "derecho", 25000000, "EUR", GetCountry("Estados Unidos"), "Mediocentro"));
            AddPlayer(new Player(774, "6", "Yunus Musah", DateTime.Parse("2002-11-29"), 1.78, "derecho", 15000000, "EUR", GetCountry("Estados Unidos"), "Mediocentro"));
            AddPlayer(new Player(775, "16", "Cristian Roldán", DateTime.Parse("1995-06-03"), 1.73, "NDF", 5500000, "EUR", GetCountry("Estados Unidos"), "Mediocentro"));
            AddPlayer(new Player(776, "14", "Luca de la Torre", DateTime.Parse("1998-05-23"), 1.77, "derecho", 850000, "EUR", GetCountry("Estados Unidos"), "Mediocentro"));
            AddPlayer(new Player(777, "11", "Brenden Aaronson", DateTime.Parse("2000-10-22"), 1.78, "derecho", 25000000, "EUR", GetCountry("Estados Unidos"), "Mediocentro ofensivo"));
            AddPlayer(new Player(778, "17", "Malik Tillman", DateTime.Parse("2002-05-28"), 1.87, "derecho", 1500000, "EUR", GetCountry("Estados Unidos"), "Mediocentro ofensivo"));
            AddPlayer(new Player(779, "13", "Jordan Morris", DateTime.Parse("1994-10-26"), 1.81, "derecho", 5000000, "EUR", GetCountry("Estados Unidos"), "Extremo izquierdo"));
            AddPlayer(new Player(780, "10", "Christian Pulisic", DateTime.Parse("1998-09-18"), 1.77, "derecho", 42000000, "EUR", GetCountry("Estados Unidos"), "Extremo derecho"));
            AddPlayer(new Player(781, "7", "Paul Arriola", DateTime.Parse("1995-02-05"), 1.67, "derecho", 3000000, "EUR", GetCountry("Estados Unidos"), "Extremo derecho"));
            AddPlayer(new Player(782, "21", "Timothy Weah", DateTime.Parse("2000-02-22"), 1.85, "derecho", 12000000, "EUR", GetCountry("Estados Unidos"), "Delantero centro"));
            AddPlayer(new Player(783, "9", "Jesús Ferreira", DateTime.Parse("2000-12-24"), 1.73, "NDF", 6000000, "EUR", GetCountry("Estados Unidos"), "Delantero centro"));
            AddPlayer(new Player(784, "19", "Haji Wright", DateTime.Parse("1998-03-27"), 1.93, "derecho", 2500000, "EUR", GetCountry("Estados Unidos"), "Delantero centro"));
            AddPlayer(new Player(785, "12", "Danny Ward", DateTime.Parse("1993-06-22"), 1.89, "derecho", 6000000, "EUR", GetCountry("Gales"), "Portero"));
            AddPlayer(new Player(786, "21", "Adam Davies", DateTime.Parse("1992-07-17"), 1.85, "derecho", 700000, "EUR", GetCountry("Gales"), "Portero"));
            AddPlayer(new Player(787, "1", "Wayne Hennessey", DateTime.Parse("1987-01-24"), 1.97, "derecho", 500000, "EUR", GetCountry("Gales"), "Portero"));
            AddPlayer(new Player(788, "NDF", "Tom King", DateTime.Parse("1995-03-09"), 1.94, "derecho", 200000, "EUR", GetCountry("Gales"), "Portero"));
            AddPlayer(new Player(789, "15", "Ethan Ampadu", DateTime.Parse("2000-09-14"), 1.83, "derecho", 13000000, "EUR", GetCountry("Gales"), "Defensa central"));
            AddPlayer(new Player(790, "6", "Joe Rodon", DateTime.Parse("1997-10-22"), 1.92, "derecho", 8000000, "EUR", GetCountry("Gales"), "Defensa central"));
            AddPlayer(new Player(791, "5", "Chris Mepham", DateTime.Parse("1997-11-05"), 1.9, "derecho", 4000000, "EUR", GetCountry("Gales"), "Defensa central"));
            AddPlayer(new Player(792, "NDF", "Oliver Denham", DateTime.Parse("2002-05-04"), 1.82, "derecho", 0, "EUR", GetCountry("Gales"), "Defensa central"));
            AddPlayer(new Player(793, "4", "Ben Davies", DateTime.Parse("1993-04-24"), 1.81, "izquierdo", 20000000, "EUR", GetCountry("Gales"), "Lateral izquierdo"));
            AddPlayer(new Player(794, "17", "Rhys Norrington-Davies", DateTime.Parse("1999-04-22"), 1.81, "izquierdo", 1500000, "EUR", GetCountry("Gales"), "Lateral izquierdo"));
            AddPlayer(new Player(795, "3", "Neco Williams", DateTime.Parse("2001-04-13"), 1.77, "derecho", 8000000, "EUR", GetCountry("Gales"), "Lateral derecho"));
            AddPlayer(new Player(796, "14", "Connor Roberts", DateTime.Parse("1995-09-23"), 1.75, "derecho", 2500000, "EUR", GetCountry("Gales"), "Lateral derecho"));
            AddPlayer(new Player(797, "2", "Chris Gunter", DateTime.Parse("1989-07-21"), 1.8, "derecho", 800000, "EUR", GetCountry("Gales"), "Lateral derecho"));
            AddPlayer(new Player(798, "NDF", "Matt Smith", DateTime.Parse("1999-11-22"), 1.75, "derecho", 450000, "EUR", GetCountry("Gales"), "Pivote"));
            AddPlayer(new Player(799, "10", "Aaron Ramsey", DateTime.Parse("1990-12-26"), 1.82, "derecho", 3000000, "EUR", GetCountry("Gales"), "Mediocentro"));
            AddPlayer(new Player(800, "7", "Joe Allen", DateTime.Parse("1990-03-14"), 1.68, "derecho", 1200000, "EUR", GetCountry("Gales"), "Mediocentro"));
            AddPlayer(new Player(801, "NDF", "Dylan Levitt", DateTime.Parse("2000-11-17"), 1.8, "derecho", 650000, "EUR", GetCountry("Gales"), "Mediocentro"));
            AddPlayer(new Player(802, "16", "Joe Morrell ", DateTime.Parse("1997-01-03"), 1.85, "derecho", 400000, "EUR", GetCountry("Gales"), "Mediocentro"));
            AddPlayer(new Player(803, "NDF", "Wes Burns", DateTime.Parse("1994-11-23"), 1.73, "derecho", 800000, "EUR", GetCountry("Gales"), "Interior derecho"));
            AddPlayer(new Player(804, "NDF", "Rubin Colwill", DateTime.Parse("2002-04-27"), 1.89, "NDF", 1500000, "EUR", GetCountry("Gales"), "Mediocentro ofensivo"));
            AddPlayer(new Player(805, "18", "Jonathan Williams", DateTime.Parse("1993-10-09"), 1.68, "izquierdo", 800000, "EUR", GetCountry("Gales"), "Mediocentro ofensivo"));
            AddPlayer(new Player(806, "20", "Daniel James", DateTime.Parse("1997-11-10"), 1.7, "derecho", 18000000, "EUR", GetCountry("Gales"), "Extremo derecho"));
            AddPlayer(new Player(807, "8", "Harry Wilson ", DateTime.Parse("1997-03-22"), 1.73, "izquierdo", 17000000, "EUR", GetCountry("Gales"), "Extremo derecho"));
            AddPlayer(new Player(808, "23", "Rabbi Matondo", DateTime.Parse("2000-09-09"), 1.75, "derecho", 4000000, "EUR", GetCountry("Gales"), "Extremo derecho"));
            AddPlayer(new Player(809, "11", "Gareth Bale ", DateTime.Parse("1989-07-16"), 1.85, "izquierdo", 3000000, "EUR", GetCountry("Gales"), "Extremo derecho"));
            AddPlayer(new Player(810, "22", "Sorba Thomas", DateTime.Parse("1999-01-25"), 1.85, "derecho", 2000000, "EUR", GetCountry("Gales"), "Extremo derecho"));
            AddPlayer(new Player(811, "9", "Brennan Johnson", DateTime.Parse("2001-05-23"), 1.79, "derecho", 15000000, "EUR", GetCountry("Gales"), "Mediapunta"));
            AddPlayer(new Player(812, "13", "Kieffer Moore", DateTime.Parse("1992-08-08"), 1.95, "derecho", 5000000, "EUR", GetCountry("Gales"), "Delantero centro"));
            AddPlayer(new Player(813, "19", "Mark Harris", DateTime.Parse("1998-12-29"), 1.82, "derecho", 1200000, "EUR", GetCountry("Gales"), "Delantero centro"));
            AddPlayer(new Player(814, "1", "Mathew Ryan", DateTime.Parse("1992-04-08"), 1.84, "derecho", 5000000, "EUR", GetCountry("Australia"), "Portero"));
            AddPlayer(new Player(815, "12", "Andrew Redmayne", DateTime.Parse("1989-01-13"), 1.94, "NDF", 700000, "EUR", GetCountry("Australia"), "Portero"));
            AddPlayer(new Player(816, "18", "Danny Vukovic", DateTime.Parse("1985-03-27"), 1.87, "derecho", 150000, "EUR", GetCountry("Australia"), "Portero"));
            AddPlayer(new Player(817, "19", "Harry Souttar ", DateTime.Parse("1998-10-22"), 2.01, "derecho", 5000000, "EUR", GetCountry("Australia"), "Defensa central"));
            AddPlayer(new Player(818, "2", "Milos Degenek", DateTime.Parse("1994-04-28"), 1.87, "derecho", 2500000, "EUR", GetCountry("Australia"), "Defensa central"));
            AddPlayer(new Player(819, "NDF", "Bailey Wright", DateTime.Parse("1992-07-28"), 1.86, "derecho", 800000, "EUR", GetCountry("Australia"), "Defensa central"));
            AddPlayer(new Player(820, "20", "Trent Sainsbury", DateTime.Parse("1992-01-05"), 1.84, "derecho", 750000, "EUR", GetCountry("Australia"), "Defensa central"));
            AddPlayer(new Player(821, "20", "Kye Rowles", DateTime.Parse("1998-06-24"), 1.83, "izquierdo", 600000, "EUR", GetCountry("Australia"), "Defensa central"));
            AddPlayer(new Player(822, "23", "Gianni Stensness ", DateTime.Parse("1999-02-07"), 1.85, "derecho", 600000, "EUR", GetCountry("Australia"), "Defensa central"));
            AddPlayer(new Player(823, "16", "Aziz Behich", DateTime.Parse("1990-12-16"), 1.7, "izquierdo", 775000, "EUR", GetCountry("Australia"), "Lateral izquierdo"));
            AddPlayer(new Player(824, "NDF", "Jason Davidson", DateTime.Parse("1991-06-29"), 1.82, "izquierdo", 500000, "EUR", GetCountry("Australia"), "Lateral izquierdo"));
            AddPlayer(new Player(825, "NDF", "Joel King", DateTime.Parse("2000-10-30"), 1.8, "izquierdo", 500000, "EUR", GetCountry("Australia"), "Lateral izquierdo"));
            AddPlayer(new Player(826, "2", "Nathaniel Atkinson", DateTime.Parse("1999-06-13"), 1.81, "derecho", 1000000, "EUR", GetCountry("Australia"), "Lateral derecho"));
            AddPlayer(new Player(827, "5", "Fran Karacic", DateTime.Parse("1996-05-12"), 1.85, "derecho", 1000000, "EUR", GetCountry("Australia"), "Lateral derecho"));
            AddPlayer(new Player(828, "4", "Rhyan Grant", DateTime.Parse("1991-02-26"), 1.74, "derecho", 750000, "EUR", GetCountry("Australia"), "Lateral derecho"));
            AddPlayer(new Player(829, "8", "James Jeggo", DateTime.Parse("1992-02-12"), 1.78, "derecho", 800000, "EUR", GetCountry("Australia"), "Pivote"));
            AddPlayer(new Player(830, "8", "Connor Metcalfe", DateTime.Parse("1999-11-05"), 1.83, "izquierdo", 800000, "EUR", GetCountry("Australia"), "Pivote"));
            AddPlayer(new Player(831, "NDF", "Kenny Dougall", DateTime.Parse("1993-05-07"), 1.82, "derecho", 600000, "EUR", GetCountry("Australia"), "Pivote"));
            AddPlayer(new Player(832, "13", "Aaron Mooy", DateTime.Parse("1990-09-15"), 1.74, "derecho", 5000000, "EUR", GetCountry("Australia"), "Mediocentro"));
            AddPlayer(new Player(833, "10", "Ajdin Hrustic", DateTime.Parse("1996-07-05"), 1.83, "izquierdo", 3000000, "EUR", GetCountry("Australia"), "Mediocentro"));
            AddPlayer(new Player(834, "NDF", "Riley McGree", DateTime.Parse("1998-11-02"), 1.78, "izquierdo", 2500000, "EUR", GetCountry("Australia"), "Mediocentro"));
            AddPlayer(new Player(835, "22", "Jackson Irvine", DateTime.Parse("1993-03-07"), 1.89, "derecho", 2000000, "EUR", GetCountry("Australia"), "Mediocentro"));
            AddPlayer(new Player(836, "23", "Tom Rogic", DateTime.Parse("1992-12-16"), 1.88, "derecho", 1700000, "EUR", GetCountry("Australia"), "Mediocentro ofensivo"));
            AddPlayer(new Player(837, "17", "Denis Genreau", DateTime.Parse("1999-05-21"), 1.75, "derecho", 1200000, "EUR", GetCountry("Australia"), "Mediocentro ofensivo"));
            AddPlayer(new Player(838, "NDF", "Awer Mabil", DateTime.Parse("1995-09-15"), 1.79, "derecho", 1800000, "EUR", GetCountry("Australia"), "Extremo izquierdo"));
            AddPlayer(new Player(839, "19", "Craig Goodwin", DateTime.Parse("1991-12-16"), 1.8, "izquierdo", 1200000, "EUR", GetCountry("Australia"), "Extremo izquierdo"));
            AddPlayer(new Player(840, "7", "Mathew Leckie", DateTime.Parse("1991-02-04"), 1.81, "derecho", 1000000, "EUR", GetCountry("Australia"), "Extremo izquierdo"));
            AddPlayer(new Player(841, "NDF", "Ben Folami", DateTime.Parse("1999-06-08"), 1.8, "ambidiestro", 500000, "EUR", GetCountry("Australia"), "Extremo izquierdo"));
            AddPlayer(new Player(842, "6", "Martin Boyle", DateTime.Parse("1993-04-25"), 1.72, "derecho", 2500000, "EUR", GetCountry("Australia"), "Extremo derecho"));
            AddPlayer(new Player(843, "21", "Marco Tilio", DateTime.Parse("2001-08-23"), 1.7, "izquierdo", 900000, "EUR", GetCountry("Australia"), "Extremo derecho"));
            AddPlayer(new Player(844, "NDF", "Nick D'Agostino", DateTime.Parse("1998-02-25"), 1.75, "derecho", 800000, "EUR", GetCountry("Australia"), "Extremo derecho"));
            AddPlayer(new Player(845, "9", "Jamie Maclaren", DateTime.Parse("1993-07-29"), 1.79, "derecho", 1500000, "EUR", GetCountry("Australia"), "Delantero centro"));
            AddPlayer(new Player(846, "NDF", "Adam Taggart", DateTime.Parse("1993-06-02"), 1.77, "derecho", 800000, "EUR", GetCountry("Australia"), "Delantero centro"));
            AddPlayer(new Player(847, "15", "Mitchell Duke", DateTime.Parse("1991-01-18"), 1.86, "derecho", 700000, "EUR", GetCountry("Australia"), "Delantero centro"));
            AddPlayer(new Player(848, "14", "Bruno Fornaroli ", DateTime.Parse("1987-09-07"), 1.74, "derecho", 600000, "EUR", GetCountry("Australia"), "Delantero centro"));
            AddPlayer(new Player(849, "1", "Keylor Navas", DateTime.Parse("1986-12-15"), 1.85, "derecho", 8000000, "EUR", GetCountry("Costa Rica"), "Portero"));
            AddPlayer(new Player(850, "18", "Aaron Cruz", DateTime.Parse("1991-05-25"), 1.87, "derecho", 275000, "EUR", GetCountry("Costa Rica"), "Portero"));
            AddPlayer(new Player(851, "23", "Leonel Moreira", DateTime.Parse("1990-04-02"), 1.76, "derecho", 275000, "EUR", GetCountry("Costa Rica"), "Portero"));
            AddPlayer(new Player(852, "3", "Juan Pablo Vargas", DateTime.Parse("1995-06-06"), 1.92, "izquierdo", 1000000, "EUR", GetCountry("Costa Rica"), "Defensa central"));
            AddPlayer(new Player(853, "15", "Francisco Calvo", DateTime.Parse("1992-07-08"), 1.8, "izquierdo", 1000000, "EUR", GetCountry("Costa Rica"), "Defensa central"));
            AddPlayer(new Player(854, "6", "Óscar Duarte", DateTime.Parse("1989-06-03"), 1.86, "derecho", 800000, "EUR", GetCountry("Costa Rica"), "Defensa central"));
            AddPlayer(new Player(855, "19", "Kendall Waston", DateTime.Parse("1988-01-01"), 1.96, "derecho", 225000, "EUR", GetCountry("Costa Rica"), "Defensa central"));
            AddPlayer(new Player(856, "16", "Ian Lawrence", DateTime.Parse("2002-05-28"), 1.79, "izquierdo", 250000, "EUR", GetCountry("Costa Rica"), "Lateral izquierdo"));
            AddPlayer(new Player(857, "8", "Bryan Oviedo", DateTime.Parse("1990-02-18"), 1.72, "izquierdo", 200000, "EUR", GetCountry("Costa Rica"), "Lateral izquierdo"));
            AddPlayer(new Player(858, "4", "Keysher Fuller ", DateTime.Parse("1994-07-12"), 1.83, "derecho", 225000, "EUR", GetCountry("Costa Rica"), "Lateral derecho"));
            AddPlayer(new Player(859, "22", "Carlos Martínez", DateTime.Parse("1999-03-30"), 1.76, "derecho", 225000, "EUR", GetCountry("Costa Rica"), "Lateral derecho"));
            AddPlayer(new Player(860, "14", "Orlando Galo", DateTime.Parse("2000-08-11"), 1.76, "derecho", 300000, "EUR", GetCountry("Costa Rica"), "Pivote"));
            AddPlayer(new Player(861, "20", "Daniel Chacón", DateTime.Parse("2001-04-11"), 1.83, "derecho", 300000, "EUR", GetCountry("Costa Rica"), "Pivote"));
            AddPlayer(new Player(862, "17", "Yeltsin Tejeda", DateTime.Parse("1992-03-17"), 1.79, "derecho", 275000, "EUR", GetCountry("Costa Rica"), "Pivote"));
            AddPlayer(new Player(863, "5", "Celso Borges", DateTime.Parse("1988-05-27"), 1.82, "derecho", 225000, "EUR", GetCountry("Costa Rica"), "Mediocentro"));
            AddPlayer(new Player(864, "13", "Gerson Torres", DateTime.Parse("1997-08-28"), 1.76, "izquierdo", 325000, "EUR", GetCountry("Costa Rica"), "Interior derecho"));
            AddPlayer(new Player(865, "21", "Brandon Aguilera", DateTime.Parse("2003-06-28"), 1.81, "izquierdo", 325000, "EUR", GetCountry("Costa Rica"), "Mediocentro ofensivo"));
            AddPlayer(new Player(866, "10", "Bryan Ruiz", DateTime.Parse("1985-08-18"), 1.87, "izquierdo", 200000, "EUR", GetCountry("Costa Rica"), "Mediocentro ofensivo"));
            AddPlayer(new Player(867, "9", "Jewison Bennette", DateTime.Parse("2004-06-15"), 1.75, "izquierdo", 275000, "EUR", GetCountry("Costa Rica"), "Extremo izquierdo"));
            AddPlayer(new Player(868, "12", "Joel Campbell", DateTime.Parse("1992-06-26"), 1.78, "izquierdo", 2500000, "EUR", GetCountry("Costa Rica"), "Extremo derecho"));
            AddPlayer(new Player(869, "2", "Carlos Mora", DateTime.Parse("2001-03-18"), 1.78, "derecho", 275000, "EUR", GetCountry("Costa Rica"), "Extremo derecho"));
            AddPlayer(new Player(870, "7", "Anthony Contreras", DateTime.Parse("2000-01-29"), 1.8, "derecho", 350000, "EUR", GetCountry("Costa Rica"), "Delantero centro"));
            AddPlayer(new Player(871, "11", "Johan Venegas", DateTime.Parse("1988-11-27"), 1.83, "derecho", 325000, "EUR", GetCountry("Costa Rica"), "Delantero centro"));
            #endregion

            #region Teams
            PreloadTeams();
            #endregion

            #region Journalists
            AddJournalist(new Journalist("Aitor Tilla", "haytortilla@gmail.com", "Tortillero"));
            #endregion

            #region Group Stage Matches

            #region Group A

            // Partido 1
            AddMatch(new GroupMatch(GetTeam(GetCountry("Catar")), GetTeam(GetCountry("Ecuador")), new DateTime(2022, 11, 20), GroupMatch.Groups.A));
            AddEvent(GetMatch(0), new Event(Event.EventType.Goal, 15, GetPlayerById(29)));
            AddEvent(GetMatch(0), new Event(Event.EventType.YellowCard, 25, GetPlayerById(451)));
            AddEvent(GetMatch(0), new Event(Event.EventType.RedCard, 75, GetPlayerById(30)));
            // Partido 2
            AddMatch(new GroupMatch(GetTeam(GetCountry("Senegal")), GetTeam(GetCountry("Países Bajos")), new DateTime(2022, 11, 21), GroupMatch.Groups.A));
            AddEvent(GetMatch(1), new Event(Event.EventType.Goal, 25, GetPlayerById(569)));
            AddEvent(GetMatch(1), new Event(Event.EventType.YellowCard, 65, GetPlayerById(317)));
            AddEvent(GetMatch(1), new Event(Event.EventType.RedCard, 85, GetPlayerById(570)));
            // Partido 3
            AddMatch(new GroupMatch(GetTeam(GetCountry("Catar")), GetTeam(GetCountry("Senegal")), new DateTime(2022, 11, 25), GroupMatch.Groups.A));
            AddEvent(GetMatch(2), new Event(Event.EventType.Goal, 35, GetPlayerById(31)));
            AddEvent(GetMatch(2), new Event(Event.EventType.YellowCard, 55, GetPlayerById(571)));
            AddEvent(GetMatch(2), new Event(Event.EventType.RedCard, 75, GetPlayerById(32)));
            // Partido 4
            AddMatch(new GroupMatch(GetTeam(GetCountry("Países Bajos")), GetTeam(GetCountry("Ecuador")), new DateTime(2022, 11, 25), GroupMatch.Groups.A));
            AddEvent(GetMatch(3), new Event(Event.EventType.Goal, 35, GetPlayerById(318)));
            AddEvent(GetMatch(3), new Event(Event.EventType.YellowCard, 55, GetPlayerById(452)));
            AddEvent(GetMatch(3), new Event(Event.EventType.RedCard, 75, GetPlayerById(319)));
            // Partido 5
            AddMatch(new GroupMatch(GetTeam(GetCountry("Ecuador")), GetTeam(GetCountry("Senegal")), new DateTime(2022, 11, 29), GroupMatch.Groups.A));
            AddEvent(GetMatch(4), new Event(Event.EventType.Goal, 35, GetPlayerById(453)));
            AddEvent(GetMatch(4), new Event(Event.EventType.YellowCard, 55, GetPlayerById(572)));
            AddEvent(GetMatch(4), new Event(Event.EventType.RedCard, 75, GetPlayerById(454)));
            // Partido 6
            AddMatch(new GroupMatch(GetTeam(GetCountry("Países Bajos")), GetTeam(GetCountry("Catar")), new DateTime(2022, 11, 29), GroupMatch.Groups.A));
            AddEvent(GetMatch(5), new Event(Event.EventType.Goal, 35, GetPlayerById(320)));
            AddEvent(GetMatch(5), new Event(Event.EventType.YellowCard, 55, GetPlayerById(33)));
            AddEvent(GetMatch(5), new Event(Event.EventType.RedCard, 75, GetPlayerById(321)));

            #endregion

            #region Group H

            // Partido 1
            AddMatch(new GroupMatch(GetTeam(GetCountry("Uruguay")), GetTeam(GetCountry("Corea del Sur")), new DateTime(2022, 11, 24), GroupMatch.Groups.H));
            AddEvent(GetMatch(6), new Event(Event.EventType.Goal, 35, GetPlayerById(479)));
            AddEvent(GetMatch(6), new Event(Event.EventType.YellowCard, 55, GetPlayerById(373)));
            AddEvent(GetMatch(6), new Event(Event.EventType.RedCard, 75, GetPlayerById(480)));
            // Partido 2
            AddMatch(new GroupMatch(GetTeam(GetCountry("Portugal")), GetTeam(GetCountry("Ghana")), new DateTime(2022, 11, 24), GroupMatch.Groups.H));
            AddEvent(GetMatch(7), new Event(Event.EventType.Goal, 35, GetPlayerById(595)));
            AddEvent(GetMatch(7), new Event(Event.EventType.YellowCard, 55, GetPlayerById(532)));
            AddEvent(GetMatch(7), new Event(Event.EventType.RedCard, 75, GetPlayerById(596)));
            // Partido 3
            AddMatch(new GroupMatch(GetTeam(GetCountry("Corea del Sur")), GetTeam(GetCountry("Ghana")), new DateTime(2022, 11, 28), GroupMatch.Groups.H));
            AddEvent(GetMatch(8), new Event(Event.EventType.Goal, 35, GetPlayerById(374)));
            AddEvent(GetMatch(8), new Event(Event.EventType.YellowCard, 55, GetPlayerById(533)));
            AddEvent(GetMatch(8), new Event(Event.EventType.RedCard, 75, GetPlayerById(375)));
            // Partido 4
            AddMatch(new GroupMatch(GetTeam(GetCountry("Portugal")), GetTeam(GetCountry("Uruguay")), new DateTime(2022, 11, 28), GroupMatch.Groups.H));
            AddEvent(GetMatch(9), new Event(Event.EventType.Goal, 35, GetPlayerById(597)));
            AddEvent(GetMatch(9), new Event(Event.EventType.YellowCard, 55, GetPlayerById(481)));
            AddEvent(GetMatch(9), new Event(Event.EventType.RedCard, 75, GetPlayerById(598)));
            // Partido 5
            AddMatch(new GroupMatch(GetTeam(GetCountry("Corea del Sur")), GetTeam(GetCountry("Portugal")), new DateTime(2022, 12, 02), GroupMatch.Groups.H));
            AddEvent(GetMatch(10), new Event(Event.EventType.Goal, 35, GetPlayerById(376)));
            AddEvent(GetMatch(10), new Event(Event.EventType.YellowCard, 55, GetPlayerById(599)));
            AddEvent(GetMatch(10), new Event(Event.EventType.RedCard, 75, GetPlayerById(377)));
            // Partido 6
            AddMatch(new GroupMatch(GetTeam(GetCountry("Ghana")), GetTeam(GetCountry("Uruguay")), new DateTime(2022, 12, 02), GroupMatch.Groups.H));
            AddEvent(GetMatch(11), new Event(Event.EventType.Goal, 35, GetPlayerById(534)));
            AddEvent(GetMatch(11), new Event(Event.EventType.YellowCard, 55, GetPlayerById(482)));
            AddEvent(GetMatch(11), new Event(Event.EventType.RedCard, 75, GetPlayerById(535)));

            #endregion

            #region Playoffs Matches

            // Partido A1 vs H2  
            AddMatch(new PlayOffsMatch(GetTeam(GetCountry("Países Bajos")), GetTeam(GetCountry("Uruguay")), new DateTime(2022, 12, 03), true, false, PlayOffsMatch.StageType.RoundOf16));
            AddEvent(GetMatch(12), new Event(Event.EventType.Goal, 35, GetPlayerById(483)));
            AddEvent(GetMatch(12), new Event(Event.EventType.Goal, 55, GetPlayerById(484)));
            AddEvent(GetMatch(12), new Event(Event.EventType.Goal, 75, GetPlayerById(322)));
            AddEvent(GetMatch(12), new Event(Event.EventType.YellowCard, 80, GetPlayerById(485)));
            AddEvent(GetMatch(12), new Event(Event.EventType.RedCard, 85, GetPlayerById(323)));
            // Partido H1 vs A2
            AddMatch(new PlayOffsMatch(GetTeam(GetCountry("Corea del Sur")), GetTeam(GetCountry("Catar")), new DateTime(2022, 12, 03), false, false, PlayOffsMatch.StageType.RoundOf16));
            AddEvent(GetMatch(13), new Event(Event.EventType.Goal, 35, GetPlayerById(578)));
            AddEvent(GetMatch(13), new Event(Event.EventType.Goal, 55, GetPlayerById(34)));
            AddEvent(GetMatch(13), new Event(Event.EventType.Goal, 75, GetPlayerById(579)));
            AddEvent(GetMatch(13), new Event(Event.EventType.YellowCard, 80, GetPlayerById(580)));
            AddEvent(GetMatch(13), new Event(Event.EventType.RedCard, 85, GetPlayerById(35)));
            // Partido A vs H
            AddMatch(new PlayOffsMatch(GetTeam(GetCountry("Uruguay")), GetTeam(GetCountry("Corea del Sur")), new DateTime(2022, 12, 09), true, true, PlayOffsMatch.StageType.Quarters));
            AddEvent(GetMatch(14), new Event(Event.EventType.Goal, 45, GetPlayerById(486)));
            AddEvent(GetMatch(14), new Event(Event.EventType.Goal, 55, GetPlayerById(581)));
            AddEvent(GetMatch(14), new Event(Event.EventType.Goal, 85, GetPlayerById(486)));
            AddEvent(GetMatch(14), new Event(Event.EventType.Goal, 95, GetPlayerById(582)));
            AddEvent(GetMatch(14), new Event(Event.EventType.YellowCard, 100, GetPlayerById(488)));

            #endregion

            #endregion
        }

        #endregion

        #region Methods       

        #region Country
        public List<Country> GetAllCountries()
        {
            return Countries;
        }
        public Country GetCountry(string name)
        {
            foreach (Country c in countries)
            {
                //ToLower() return a copy of an object in lower case, we do this in order to not take in consideration the lower case at the time of comparing
                if (c.Name.ToLower() == name.ToLower())
                {
                    return c;
                }
            }
            throw new Exception("El país que estabas buscando no esta registrado");
        }

        public string AddCountry(Country country)
        {
            if (country.Validate())
            {
                try
                {
                    GetCountry(country.Name);
                    return "Este país ya está registrado";
                }
                catch
                {
                    countries.Add(country);
                    return "País registrado con éxito";
                }
            }
            return "El país que se intento registrar no es válido";
        }
        #endregion

        #region Player
        public List<Player> GetAllPlayers()
        {
            return Players;
        }

        public Player GetPlayer(string name)
        {
            foreach (Player p in players)
            {
                if (p.Name == name)
                {
                    return p;
                }
            }
            throw new Exception("El jugador no existe");
        }
        public Player GetPlayerById(int id)
        {
            foreach (Player p in players)
            {
                if (p.Id == id)
                {
                    return p;
                }
            }
            throw new Exception("El jugador no existe");
        }

        public string AddPlayer(Player player)
        {
            if (player.Validate())
            {
                try
                {
                    GetPlayer(player.Name);
                    return "El jugador ya está registrado";
                }
                catch
                {
                    players.Add(player);
                    return "Jugador registrado con éxito";
                }
            }
            return "El jugador que se intento registrar no es válido";
        }

        public List<Player> GetPlayersByCountry(Country country)
        {
            List<Player> playersFromCountry = new List<Player>();
            foreach (Player p in players)
            {
                if (p.Country.Name == country.Name)
                {
                    playersFromCountry.Add(p);
                }
            }
            return playersFromCountry;
        }

        public List<Player> GetExpelledPlayers()
        {
            List<Player> expelledPlayers = new List<Player>();
            foreach (Match m in matches)
            {
                foreach (Event e in m.Events)
                {
                    if (e.Incident == Event.EventType.RedCard)
                    {
                        if (!expelledPlayers.Contains(e.Player))
                        {
                            expelledPlayers.Add(e.Player);
                        }
                    }
                }
            }
            return expelledPlayers;
        }

        public string GetPlayerCategory(Player player)
        {
            if (player.MarketValue >= referenceValue) return "VIP";
            else return "Estándar";
        }
        #endregion

        public void ChangeReferenceValue(int newValue)
        {
            if(newValue > 0)
            {
                this.ReferenceValue = newValue;
            }
            else
            {
                throw new Exception("El monto ingresado no es valido");
            }
        }

        #region Team
        public List<Team> GetAllTeams()
        {
            return Teams;
        }
        public Team GetTeam(Country country)
        {
            foreach (Team t in teams)
            {
                if (t.Country.Name == country.Name)
                {
                    return t;
                }
            }
            throw new Exception("El equipo que estabas buscando no fue registrado");
        }
        public string AddTeam(Team team)
        {
            if (team.Validate())
            {
                try
                {
                    GetTeam(team.Country);
                    return "El equipo ya está registrado";
                }
                catch
                {
                    teams.Add(team);
                    return "El equipo fue registrado con éxito";
                }
            }
            return "El equipo que se intento registrar no es válido";
        }
        private Team CreateTeam(Country country)
        {
            List<Player> teamPlayers = PlayersOff(country);
            Team team = new Team(country, teamPlayers);
            return team;
        }
        private void PreloadTeams()
        {
            foreach (Country c in Countries)
            {
                // Se crea una seleccion por cada país en la lista.
                Team newTeam = CreateTeam(c);
                AddTeam(newTeam);
            }
        }
        private List<Player> PlayersOff(Country country)
        {
            List<Player> myPlayers = new List<Player>();
            foreach (Player p in Players)
            {
                if (p.Country.Equals(country))
                {
                    myPlayers.Add(p);
                }
            }
            return myPlayers;
        }
        #endregion

        #region Match
        public List<Match> GetAllMatches()
        {
            return Matches;
        }

        public Match GetMatch(int id)
        {
            foreach (Match m in matches)
            {
                if (m.Id == id)
                {
                    return m;
                }
            }
            throw new Exception("El partido que estabas buscando no fue registrado");
        }

        public string AddMatch(Match match)
        {
            if (match.Validate())
            {
                try
                {
                    GetMatch(match.Id);
                    return "El partido ya está registrado";
                }
                catch
                {
                    matches.Add(match);
                    return "El partido fue registrado con éxito";
                }
            }
            return "El partido que se intento registrar no es válido";
        }
        public List<Match> GetMatchesByPlayer(int playerId)
        {
            List<Match> matchList = new List<Match>();
            try
            {
                Player player = GetPlayerById(playerId);
                foreach (Match m in matches)
                {
                    foreach (Player p in m.LocalTeam.Players)
                    {
                        if (p.Id == playerId)
                        {
                            matchList.Add(m);
                        }
                    }
                    foreach (Player p in m.VisitingTeam.Players)
                    {
                        if (p.Id == playerId)
                        {
                            matchList.Add(m);
                        }
                    }
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return matchList;
        }
        public Match GetMoreGoalsMatch(string team)
        {
            Match matchWithMoreGoals = new GroupMatch();
            int maxGoals = -1;
            foreach(Match m in Matches)
            {
                if(m.VisitingTeam.Country.Name.ToLower() == team.ToLower() || m.LocalTeam.Country.Name.ToLower() == team.ToLower())
                {
                    int goalsInMatch = 0;
                    foreach(Event e in m.Events)
                    {
                        if (e.Incident == Event.EventType.Goal) goalsInMatch++;
                    }
                    if(goalsInMatch > maxGoals)
                    {
                        matchWithMoreGoals = m;
                        maxGoals = goalsInMatch;
                    }
                }
            }
            if(matchWithMoreGoals.LocalTeam != null)
            {
                return matchWithMoreGoals;
            }
            else
            {
                throw new Exception("El equipo seleccionado no tiene partidos jugados");
            }
        }

        #endregion

        #region Journalist
        public List<Journalist> GetAllJournalists()
        {
            return Journalists;
        }

        public Journalist GetJournalist(string name)
        {
            foreach (Journalist j in journalists)
            {
                if (j.Name == name)
                {
                    return j;
                }
            }
            throw new Exception("El periodista que estabas buscando no fue registrado");
        }
        public string AddJournalist(Journalist journalist)
        {
            if (journalist.Validate())
            {
                try
                {
                    GetJournalist(journalist.Name);
                    return "El periodista ya está registrado";
                }
                catch
                {
                    journalists.Add(journalist);
                    return "El periodista fue ingresado con éxito";
                }
            }
            return "El periodista que se intento ingresar no es válido.";
        }
        #endregion

        #region Event
        public List<Player> GetAllPlayersThatScored()
        {
            List<Player> scorers = new List<Player>();
            foreach(Match m in Matches)
            {
                foreach(Event e in m.Events)
                {
                    if(e.Incident == Event.EventType.Goal)
                    {
                        //making sure we dont duplicate players in the list
                        if (!scorers.Contains(e.Player))
                        {
                            scorers.Add(e.Player);
                        }
                    }
                    //if the event is not a goal we dont capture the player
                }
            }
            return scorers;
        }        
        public void AddEvent(Match match, Event anEvent)
        {
            if (anEvent.Validate())
            {
                match.Events.Add(anEvent);
            }

        }
        #endregion

        #endregion
    }
}

