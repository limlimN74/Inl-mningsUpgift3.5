using System;
namespace InlämningsUpgifter_3._5
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv ett tal:");
            int tal1=int.Parse(Console.ReadLine());
            Console.WriteLine("Skrive ett till tall");
            int tal2=int.Parse(Console.ReadLine());


            Console.WriteLine("Välj ett räknesätt");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraktion");
            Console.WriteLine("3. Multiplikation");
            Console.WriteLine("4. Division");

            int val = int.Parse(Console.ReadLine());
            int resultat = 0;

            switch (val)
            {
                case 1:
                    resultat = tal1 + tal2;
                    break;
                case 2:
                    resultat = tal1 - tal2;
                    break;
                case 3:
                    resultat = tal1 * tal2;
                    break;
                case 4:
                    if (tal2 != 0)
                    {
                        resultat = tal1 / tal2;
                    }
                    else
                    {
                        Console.WriteLine("Division med 0 är inte tillåten.");
                    }
                    break;
            }

            Console.WriteLine($"Resultatet är: {resultat}");
        }
    }
}