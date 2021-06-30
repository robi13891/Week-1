using System;

namespace CommonElements2Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray1 = { 1, 2, 3 };
            int[] myArray2 = { 1, 1, 4 };

            //inizio prova
            for (int i = 0; i < myArray1.Length; i++)
            {
                for (int j = 0; j < myArray2.Length; j++)
                {
                    if (myArray1[i] == myArray2[j])
                    {
                        Console.WriteLine(myArray1[i]);
                    }
                }
            }
            //fine prova



        }
    }
}
