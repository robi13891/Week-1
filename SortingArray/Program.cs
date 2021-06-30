using System;

namespace SortingArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = { 2, 1, 3, 7, 5 };
            int temp;
            for (int i = 0 ; i < myArray.Length ; i++)
            {
                for (int j = i + 1 ; j < myArray.Length ; j++) 
                {
                    if (myArray[i] > myArray[j])
                    {
                        temp = myArray[i];
                        myArray[i] = myArray[j];
                        myArray[j] = temp;
                    }
                }
            }
            for (int k = 0; k < myArray.Length; k++)
            {
                Console.Write(myArray[k] + " ");
            }
        }
    }
}
