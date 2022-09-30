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
                "1. Agregar periodista",
                "2. Asignar monto de referencia",
                "3. Listar partidos por jugador",
                "4. Listar jugadores expulsados",
                "5. Partido con mas goles efectuados (selección)",
                "6. Listar Jugadores que hayan convertido"
            };
        static void Main(string[] args)
        {
            int selectedOption = -1;
            while (selectedOption != 0)
            {
                DisplayOptions(menuOptions);
                selectedOption = evtInt();
                Console.Clear();
                if (selectedOption != 0)
                {
                    switch (selectedOption)
                    {
                        case 1:
                            Console.Clear();
                            AddJournalist();
                            Console.WriteLine("");
                            break;
                        case 2:
                            Console.Clear();
                            AsignReferenceValue();
                            Console.WriteLine("");
                            break;
                        case 3:
                            Console.Clear();
                            MatchesByPlayer();
                            Console.WriteLine("");
                            break;
                        case 4:
                            Console.Clear();
                            PlayersExpelled();
                            Console.WriteLine("");
                            break;
                        case 5:
                            Console.Clear();
                            MatchWithMoreGoals();
                            Console.WriteLine("");
                            break;
                        case 6:
                            Console.Clear();
                            PlayersWhoScored();
                            Console.WriteLine("");
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

        #region Events
        static int evtInt()
        {
            int result;
            while (!int.TryParse(Console.ReadLine(), out result))
            {
                Console.WriteLine("Invalid value, please try again");
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

        #region Country
        static void AddCountry()
        {
            Boolean valid = false;
            while (!valid)
            {
                string name = evtString("Ingrese el nombre del pais.");
                string alphaThree = evtString("Ingrese el alhpaThree del pais.");
                Country newCountry = new Country(name, alphaThree);
                if (newCountry.Validate())
                {
                    valid = true;
                    Console.WriteLine(repository.AddCountry(newCountry));
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Los datos ingresados no son correctos, intente denuevo.");
                }
            }
        }
        static void GetCountry()
        {
            string name = evtString("Ingrese el nombre del pais que desea buscar");
            try
            {
                Country newCountry = repository.GetCountry(name);
                Console.WriteLine(newCountry.ToString());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        static void GetAllCountries()
        {
            Console.WriteLine("Paises registrados");
            List<Country> countryList = repository.GetAllCountries();
            foreach (Country c in countryList)
            {
                Console.WriteLine(c.ToString());
            }
        }
        #endregion

        // 1.
        static void AddJournalist()
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
                    Console.WriteLine(repository.AddJournalist(newJournalist));
                    Console.WriteLine("El periodista ha sido ingresado con éxito.");
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Los datos ingresados no son correctos, intente nuevamente.");
                }
            }
        }
        // 2.
        static void AsignReferenceValue()
        {
            Console.WriteLine("Indique el monto de referencia");
            int newReferenceValue = evtInt();
            Repository.referenceValue = newReferenceValue;
            Console.WriteLine($"El nuevo monto de referencia es: {Repository.referenceValue}");
        }
        // 3.
        static void MatchesByPlayer()
        {
            string myPlayer = evtString("Ingrese el nombre del jugador");
            List<Match> matchList = repository.GetAllMatches();
            int totalMatches = 0;
            /*
            foreach (Match m in matchList)
            {
                if () totalMatches++;                
            }
            */
        }
        // 4.
        static void PlayersExpelled()
        {
            List<Match> matchList = repository.GetAllMatches();
        }
        // 5.
        static void MatchWithMoreGoals()
        {
            List<Match> matchList = repository.GetAllMatches();
        }
        // 6.
        static void PlayersWhoScored()
        {
            List<Match> matchList = repository.GetAllMatches();
        }


    }
}
