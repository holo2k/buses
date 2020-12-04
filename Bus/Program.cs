using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bus
{
    class Program
    {
        static void Main(string[] args)
        {
            Bus b1 = new Bus("Никита", "Беликов", "BMW", "1990", "a192i", 14, 90000);
            Bus b2 = new Bus("Кирилл", "Чухарев", "BMW", "1999", "fg1452i", 14, 50000);
            Bus b3 = new Bus("Андрей", "Галеев", "Камаз", "2005", "6kt192i", 2, 40000);
            Bus b4 = new Bus("Данил", "Данилов", "Chevrolet", "1980", "46g2i", 10, 5000);
            Bus b5 = new Bus("Эдик", "Бонадрев", "Lada", "2010", "a112i", 15, 0);


            Console.WriteLine("Введите номер искомого маршрута :");
            string numberOfRoute = Console.ReadLine();
            Console.WriteLine("\nАвтобусы:\n");
            for (int i = 0; i < Bus.count; i++)
            {
                if (numberOfRoute == Bus.buses[i, 5])
                {
                    for (int j = 0; j < 7; j++)
                    {
                        Console.Write(Bus.buses[i, j] + " ");
                    }
                    Console.WriteLine();
                }     
            }
            Console.WriteLine();

            Console.WriteLine("Введите срок в годах, чтобы узнать, какие автобусы эксплуатируются дольше :");
            string term = Console.ReadLine();
            Console.WriteLine("\nАвтобусы:\n");
            for (int i = 0; i < Bus.count; i++)
            {
                int expTerm = 2020 - Int32.Parse(Bus.buses[i, 3]);
                if (expTerm > Int32.Parse(term))
                {
                    for (int j = 0; j < 7; j++)
                    {
                        Console.Write(Bus.buses[i, j] + " ");
                    }
                    Console.WriteLine();
                }    
            }
            Console.WriteLine();

            Console.WriteLine("Введите пробег, чтобы узнать, у какого автобуса больше :");
            string millage = Console.ReadLine();
            Console.WriteLine("\nАвтобусы:\n");
            for (int i = 0; i < Bus.count; i++)
            {
                if (int.Parse(millage) < int.Parse(Bus.buses[i, 6]))
                {
                    for (int j = 0; j < 7; j++)
                    {
                        Console.Write(Bus.buses[i, j] + " ");
                    }
                    Console.WriteLine();
                }   
            }
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
