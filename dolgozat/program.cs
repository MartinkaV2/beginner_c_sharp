using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dolgozatsajnos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 1.Feladat
            string[] etelek = { "pizza", "lasange", "palacsinta", "gyros", "paradicsomleves" };

            if (Array.Exists(etelek, etel => etel.Equals("pizza", StringComparison.OrdinalIgnoreCase)))
            {
                Console.WriteLine("A tömben van pizza");
            }
            else
            {
                Console.WriteLine("Nem található a tömbben pizza");
            }

            Console.WriteLine(string.Join(",", etelek));
            */

            /* 2.Feladat
            string[] nevek = { "The Witcher 3: Wild Hunt", "Minecraft", "Cyberpunk 2077",
                           "Among Us", "The Elder Scrolls V: Skyrim", "Valorant" };

            for (int i = 0; i < nevek.Length; i++)
            {
                if (nevek[i] == "Valorant")
                {
                    nevek[i] = "Fortnite";
                }
            }

            Console.WriteLine(string.Join(";", nevek));
            */

            /* 3.Feladat
            List<int> szamok = new List<int>();

            for (int i = 0; i < 9; i++)
            {
                Console.WriteLine("Adj meg egy számot:");
                int num = int.Parse(Console.ReadLine());
                szamok.Add(num);
            }

            int sum = szamok.Sum();
            int max = szamok.Max();

            Console.WriteLine(string.Join(", ", szamok));
            Console.WriteLine("A legnagyobb szám: " + max);

            */

            /* 4.Feladat
                    List<int> paros = new List<int>();

                    for (int i = 0; i < 5; i++)
                    {
                        Console.WriteLine("Adj meg egy számot:");
                        int num = int.Parse(Console.ReadLine());

                        if (num % 2 == 0)
                        {
                            paros.Add(num);
                            Console.WriteLine($"A szám páros: {num}.");
                    Console.WriteLine($"Listához adva: {paros.Count}");
                        }
                        else
                        {
                            Console.WriteLine($"A szám páratlan: {num}");
                        }
                    }

                    Console.WriteLine("A lista hossza: " + paros.Count);
            */        
            Console.ReadKey();
                }
            }
        }
