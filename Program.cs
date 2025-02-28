using MikesKrisztian_allatkert;

internal class Program
{
    private static void Main(string[] args)
    {
        System.Console.Write("kerlek add meg az alatkert befogadokepesseget: ");
        int befogadokepesseg = 6;
        do
        {
            befogadokepesseg = Convert.ToInt32(Console.ReadLine());
        } while (befogadokepesseg < 5 || befogadokepesseg > 14);

        Allat[] allatok = new Allat[6]{
            new("Lion", "Panthera leo", "Szárazföldi meleg éghajlatban", 8),
            new("Penguin", "Aptenodytes forsteri", "Vízben", 3),
            new("Polar Bear", "Ursus maritimus", "Szárazföldi hideg éghajlatban", 7),
            new("Olive Tree Frog", "Hyla cinerea", "Szárazföldi mediterrán éghajlatban", 5),
            new("Elephant", "Loxodonta africana", "Szárazföldi meleg éghajlatban", 6),
            new("Toucan", "Ramphastos toco", "Szárazföldi trópusi éghajlatban", 2)
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
        int[] alaltPos = [12, 12, 12, 12, 12, 12];

        do
        {
            Console.Clear();
            for (int j = 0; j < allatok.Length; j++)
            {
                Console.SetCursorPosition(0, j);
                Console.Write(allatok[j].Nev.Length > 12 ? allatok[j].Nev.Substring(0, 10) : allatok[j].Nev.PadRight(10));
                Console.SetCursorPosition(101+12, j);
                System.Console.WriteLine("|");
                Console.SetCursorPosition(alaltPos[j] + allatok[j].Sebesseg, j);
                alaltPos[j] += allatok[j].Sebesseg;

                if (alaltPos[j] >= 100+12)
                {
                    Console.SetCursorPosition(0, j);
                    Console.Write(new string(' ', Console.WindowWidth));
                    Console.SetCursorPosition(5, 50);
                    Console.Write("A(z) " + allatok[j].Nev + " célba ért!                    ");
                }
                else
                {
                    Console.Write("0");
                }

            }
            Thread.Sleep(330);
        } while (alaltPos.Any(pos => pos < 113));

        Console.Clear();

        System.Console.WriteLine("A verseny véget ért!");
        System.Console.WriteLine("nyertes allat: " + allatok[alaltPos.ToList().IndexOf(alaltPos.Max())].Nev);

        Thread.Sleep(1000);
    }
}
