using MikesKrisztian_allatkert;
using System;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Kérlek, add meg az állatkert befogadóképességét: ");
        int befogadokepesseg = 6;
        do
        {
            befogadokepesseg = Convert.ToInt32(Console.ReadLine());
        } while (befogadokepesseg < 5 || befogadokepesseg > 14);

        Allat[] allatok = new Allat[]
        {
            new ViziAllat("odon", "Ponty", 3),
            new ViziAllat("Gyula", "Harcsa", 4),
            new SzarazfoldiAllat("Albert", "Nyúl", 6)
        };

        Console.BackgroundColor = ConsoleColor.DarkRed;
        for (int i = 0; i < allatok.Length; i++)
        {
            Console.Write(" ");
        }
        Console.BackgroundColor = ConsoleColor.DarkGreen;
        for (int i = 0; i < (befogadokepesseg - allatok.Length); i++)
        {
            Console.Write(" ");
        }
        Console.ResetColor();
        Console.Write("\n");

        for (int i = 0; i < allatok.Length; i++)
        {
            Console.WriteLine(allatok[i]);
        }

        Thread.Sleep(3000);
        int[] alaltPos = new int[allatok.Length];

        do
        {
            Console.Clear();
            for (int j = 0; j < allatok.Length; j++)
            {
                Console.SetCursorPosition(0, j);
                Console.Write(allatok[j].Nev.Length > 12 ? allatok[j].Nev[..10] : allatok[j].Nev.PadRight(10));
                Console.SetCursorPosition(101 + 12, j);
                Console.WriteLine("|");
                Console.SetCursorPosition(alaltPos[j] + allatok[j].Sebesseg, j);
                alaltPos[j] += allatok[j].Sebesseg;

                if (alaltPos[j] >= 100 + 12)
                {
                    Console.SetCursorPosition(0, j);
                    Console.Write(new string(' ', Console.WindowWidth));
                }
                else
                {
                    Console.Write("0");
                }
            }
            Thread.Sleep(330);
        } while (alaltPos.Any(pos => pos < 113));

        Console.Clear();

        Console.WriteLine("A verseny véget ért!");
        Console.WriteLine("Nyertes állat: " + allatok[Array.IndexOf(alaltPos, alaltPos.Max())].Nev);

        Thread.Sleep(1000);
    }
}
