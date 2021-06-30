using System;

namespace RepetedChar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inserisci una parola");
            string myString = Console.ReadLine();
            //char myChar = myString[0];
            for (int i = 0; i < myString.Length - 1; i++)
            {
                for (int j = i + 1; j < myString.Length - 2; j++)
                {
                    if (myString[i] != myString[j])
                    {
                        continue;
                    }
                    else
                    {
                        Console.WriteLine(myString[i]);
                    }

                }
            }
        }
    }
}
