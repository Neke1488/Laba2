using CountryLab;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountryLab
{
    class Menu
    {
        public static void Run()
        {
            List<Country> country = new List<Country>();
            while (true)
            {
                Console.Clear();
                Console.WriteLine(" * 1: Страны");
                Console.WriteLine(" * 2: Добавить страну");
                Console.WriteLine(" * 3: Поиск по странам");
                Console.WriteLine(" * 4: Выход");
                Console.Write("Введите номер: ");
                char key = Console.ReadKey(true).KeyChar;
                switch (key)
                {
                    case '1': PrintCountry(country); break;
                    case '2': AddCountry(country); break;
                    case '3': SearchCountry(country); break;
                    case '4': Environment.Exit(0); break;
                    default: break;
                }
            }
        }

        public static void PrintCountry(List<Country> country)
        {
            Console.Clear();
            foreach (var item in country)
            {
                Console.WriteLine(item.ToString());
            }
            Console.ReadKey(true);
        }

        public static void AddCountry(List<Country> country)
        {
            char choice;
            do
            {
                Console.Clear();
                Console.WriteLine("Выберите страну");
                Console.WriteLine("1. Республика");
                Console.WriteLine("2. Монархия");
                Console.WriteLine("3. Королевство");
                Console.WriteLine("4. Государство");

                choice = Console.ReadKey(true).KeyChar;
            }
            while (choice != '1' && choice != '2' && choice != '3' && choice != '4');


            string Name;
            do
            {
                Console.Clear();
                Console.Write("Введите название: ");
                Name = Console.ReadLine();
            }
            while (string.IsNullOrEmpty(Name));

            int Population;
            do
            {
                Console.Clear();
                Console.Write("Введите население: ");
            }
            while (!int.TryParse(Console.ReadLine(), out Population));

            int territory;
            do
            {
                Console.Clear();
                Console.Write("Введите территорию страны: ");
            }
            while (!int.TryParse(Console.ReadLine(), out territory));


            switch (choice)
            {
                case '1': country.Add(new Republic(Name, Population, territory)); break;
                case '2': country.Add(new Monarchy(Name, Population, territory)); break;
                case '3': country.Add(new Kingdom(Name, Population, territory)); break;
                case '4': country.Add(new State(Name, Population, territory)); break;
                default: throw new Exception("Ошибка ввода!!!");
            }

        }

        public static void SearchCountry(List<Country> country)
        {
            Console.Clear();
            Console.Write("Введите текст для поиска: ");
            string searchText = Console.ReadLine();

            foreach (var item in country)
            {
                if (item.ToString().ToUpper().Contains(searchText.ToUpper()))
                {
                    Console.WriteLine(item.ToString());
                }
            }
            Console.ReadKey(true);
        }
    }
}
