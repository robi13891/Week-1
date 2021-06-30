using System;

namespace AscendentArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = { 1, 2, 3, 4, 5 };
            bool isTrue = true;
            for (int i = 0; i < 4; i++)
            {
                if (myArray[i] > myArray[i + 1])
                {
                    Console.WriteLine("Il vettore non è ordinato");
                    isTrue = false;
                    break;
                }
                
            }
            if (isTrue)
            {
                Console.WriteLine("Il vettore è ordinato in modo crescente");
            }
            

        }
    }
}
