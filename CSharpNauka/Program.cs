using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpNauka
{
    class Program
    {

        static void Main(string[] args)
        {

            ValueTypes();

            for (; ;)
            {
                Greeting();
                AgeCheck();
                Settings();
            }
        }

        private static void ValueTypes()
        {
            int maxInt = int.MaxValue;
            int minInt = int.MinValue;
            long maxLong = long.MaxValue;
            long minLong = long.MinValue;

            Console.WriteLine("maxInt =" + maxInt ) ;
            Console.WriteLine("minInt =" + minInt);
            Console.WriteLine("maxLong =" + maxLong);
            Console.WriteLine("minLong =" + minLong);
        }


        /// <summary>
        /// Opcje dodtkowe
        /// </summary>
        private static void Settings()
        {
            Console.ReadKey();
            Console.Clear();
            Console.ResetColor();
        }


        /// <summary>
        /// Sprawdzenie wieku i wyświetlenie stosownego komunikatu.
        /// </summary>
        private static void AgeCheck()
        {
            Console.Write("Wpisz ile masz lat: ");

            int age;
            bool result = int.TryParse(Console.ReadLine(), out age);

            if (age > 18)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Napijesz się piwa, wódki a może wina?");
            }
            else if (result == false)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Błąd! Podaj prawidłową wartość!");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Napijesz się herbaty?");
            }
        }

        /// <summary>
        /// Powitanie użytkownika po podaniu imienia.
        /// </summary>
        private static void Greeting()
        {
            Console.Write("Wpisz swoje Imię: ");

            string name = Console.ReadLine();

            Console.WriteLine("Witaj " + name);
        }
    }
}
