using System;
using System.Collections.Generic;
using Dominio;

namespace Obligatorio_1_P2
{
    class Program
    {
        static Repository repository = Repository.Instance;
        private static string[] menuOptions =
            {
                "-----------------------------------",
                "1. Agregar periodista",
                "2. Asignar monto de referencia",
                "3. Listar partidos por jugador",
                "4. Listar jugadores expulsados",
                "5. Partido con mas goles efectuados (selección)",
                "6. Listar Jugadores que hayan convertido",
                "-----------------------------------"
            };
        static void Main(string[] args)
        {
            int selectedOption = -1;
            while (selectedOption != 0)
            {
                DisplayOptions(menuOptions);
                selectedOption = evtInt("");
                Console.Clear();
                if (selectedOption != 0)
                {
                    switch (selectedOption)
                    {
                        case 1:
                            Console.Clear();
                            AddJournalist();
                            break;
                        case 2:
                            Console.Clear();
                            AsignReferenceValue();
                            break;
                        case 3:
                            Console.Clear();
                            MatchesByPlayer();
                            break;
                        case 4:
                            Console.Clear();
                            PlayersExpelled();
                            break;
                        case 5:
                            Console.Clear();
                            MatchWithMoreGoals();
                            break;
                        case 6:
                            Console.Clear();
                            PlayersWhoScored();
                            break;
                        default:
                            Console.WriteLine("El valor ingresado no es válido, intente nuevamente");
                            break;
                    }
                }
            }
        }
        static void DisplayOptions(string[] recievedOptions)
        {
            foreach (string option in recievedOptions)
            {
                Console.WriteLine(option);
            }
        }

        #region Evts
        static int evtInt(String message)
        {
            Console.WriteLine(message);
            int result;
            while (!int.TryParse(Console.ReadLine(), out result))
            {
                Console.WriteLine("Valor invalido, intente denuevo, ingrese numeros.");
            }
            return result;
        }
        static string evtString(string mensaje)
        {
            Console.WriteLine(mensaje);
            string texto = Console.ReadLine();
            return texto;
        }
        #endregion
        //1
        public static void AddJournalist()
        {
            Boolean valid = false;
            while (!valid)
            {
                string name = evtString("Ingrese el nombre completo del periodista.");
                string mail = evtString("Ingrese el mail.");
                string password = evtString("Ingrese la contraseña.");
                Journalist newJournalist = new Journalist(name, mail, password);
                if (newJournalist.Validate())
                {
                    valid = true;
                    repository.AddJournalist(newJournalist);
                    Console.WriteLine("El periodista ha sido ingresado con éxito.");
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Los datos ingresados no son correctos, intente nuevamente.");
                }
            }
        }
        //2
        public static void AsignReferenceValue()
        {
            int newReferenceValue = evtInt("Indique el monto de referencia");
            if (newReferenceValue <= 0) Console.WriteLine("El monto de referencia debe ser un valor mayor a 0");
            repository.ReferenceValue = newReferenceValue;
            Console.WriteLine($"El nuevo monto de referencia es: {repository.ReferenceValue}");
        }
        //3 faltan to strings para que se vea lindo
        public static void MatchesByPlayer()
        {
            int myPlayer = evtInt("Ingrese el id del jugador");
            try
            {
                List<Match> matchList = repository.GetMatchesByPlayer(myPlayer);
                if (matchList.Count > 0)
                {
                    Console.WriteLine($"El jugador de id {myPlayer} ha jugado en los siguientes partidos: ");
                    foreach (Match m in matchList)
                    {
                        Console.WriteLine(m);
                    }
                }
                else
                {
                    Console.WriteLine($"El jugador de id {myPlayer} no ha participado en ningun partido");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        //4
        public static void PlayersExpelled()
        {
            List<Player> playerList = repository.GetExpelledPlayers();
            playerList.Sort();
            if (playerList.Count > 0)
            {
                foreach (Player p in playerList)
                {
                    //cambiar a to string
                    Console.WriteLine(p.Name);
                }
            }
            else
            {
                Console.WriteLine("No se encontraron jugadores expulsados");
            }
        }

        // 5.
        public static void MatchWithMoreGoals()
        {
            try
            {
                string team = evtString("Ingrese un equipo.");
                Match match = repository.GetMoreGoalsMatch(team);
                int numberOfGoals = 0;
                foreach(Event e in match.Events)
                {
                    if(e.Incident == Event.EventType.Goal)
                    {
                        numberOfGoals++;
                    }
                }
                Console.WriteLine($"El partido con mas goles fue el de {match.LocalTeam.Country.Name} contra {match.VisitingTeam.Country.Name} en el {match.ExpectedDate} con una cantidad de goles: {numberOfGoals}");
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }

        // 6.
        public static void PlayersWhoScored()
        {
            List<Player> players = repository.GetAllPlayersThatScored();
            foreach (Player p in players)
            {
                Console.WriteLine($"Jugador: {p.Name}, Valor de mercado: {p.MarketValue}, Categoría financiera: {repository.GetPlayerCategory(p)}");
            }
        }
    }
}
