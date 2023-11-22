using System;
namespace random
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur många tal vill du skriva in?");
            int nrOfNr = int.Parse(Console.ReadLine());

            //En array skapas
            int[] nrs = new int[nrOfNr];

            //Input
            Console.WriteLine($"Skriv in {nrOfNr} heltal:");
            for (int i = 0; i < nrOfNr; i++)
            {
                nrs[i] = int.Parse(Console.ReadLine());
            }

            //Utskrift
            for (int i = 0; i < nrOfNr; i++)
            {
                Console.WriteLine($"Tal {i+1}: {nrs[i]}.");
            }
        }
    }
}

/*Skapa ett program där användaren själv ska få välja hur många heltal hen vill skriva
in i en array. Efter att användaren har skrivit in alla tal ska programmet skriva ut dem
och numrera dem med start på 1. Det skulle t.ex. kunna se ut så här om användaren
väljer att skriva in tre tal.
Hur många heltal vill du skriva in?
3
Skriv in 3 heltal
10
-20
42
Här är talen du skrev in
Tal 1: 10
Tal 2: -20
Tal 3: 42*/