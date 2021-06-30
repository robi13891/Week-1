using System;

namespace CharOnString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inserisci una parola");
            string myString = Console.ReadLine();
            Console.WriteLine("Inserisci una lettera");
            //char myChar = Console.ReadKey().KeyChar;
            char myChar = char.Parse(Console.ReadLine());
            int count = 0;
            for(int i = 0 ; i < myString.Length ; i++)
            {
                if (myString[i] == myChar)
                {
                    count++;
                }
            }
            Console.Write("Numero di occorrenze trovate: " + count);

        }
    }
}
