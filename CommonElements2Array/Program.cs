using System;

//Scrivere una routine che, dati due array, verifichi quali sono gli elementi in comune,
//ovvero presenti in entrambi gli array, e stampare solo gli elementi in comune. 
//Se non ci sono elementi in comune, stampare 'Non ci sono elementi in comune'.

//Es. array1 = {1,2,4}, array2 = {1,2,3} --> output 1,2

namespace CommonElements2Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray1 = { 1, 1, 1 };
            int[] myArray2 = { 1, 1, 4 };

            CommonElements(myArray1, myArray2);

            void CommonElements(int[] myArray1 , int [] myArray2)
            {
                int found;
                for (int i = 0; i < myArray1.Length; i++)
                {
                    found = Array.IndexOf(myArray2, myArray1[i]);
                    if (found != -1)
                    {
                        Console.WriteLine(myArray2[found]);
                    }
                }
            }
            
            


        }
    }
}
