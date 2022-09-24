using System;
using System.Collections.Generic;
using Dominio;

namespace Obligatorio_1_P2
{
    class Program
    {
        static Repository repository = Repository.Instance;
        private static string[] menuOptions = { "1. Agregar pais", "2. Buscar pais", "3. listar paises" };
        static void Main(string[] args)
        {
            int selectedOption = -1;
            while (selectedOption != 0)
            {
                DisplayOptions(menuOptions);
                selectedOption = evtInt();
                Console.Clear();
                if(selectedOption != 0)
                {
                    switch (selectedOption)
                    {
                        case 1:
                            Console.Clear();
                            AddCountry();
                            Console.WriteLine("");
                            break;
                        case 2:
                            Console.Clear();
                            GetCountry();
                            Console.WriteLine("");
                            break;
                        case 3:
                            Console.Clear();
                            GetAllCountries();
                            Console.WriteLine("");
                            break;
                        default:
                            Console.WriteLine("Invalid value, please try again");
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
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        static void GetAllCountries()
        {
            Console.WriteLine("Paises registrados");
            List<Country> countryList = repository.GetAllCountries();
            foreach(Country c in countryList)
            {
                Console.WriteLine(c.ToString());
            }
        }
    }
}
