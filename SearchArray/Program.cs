using System;

namespace SearchArray
{
    class Program
    {
        static void Main(string[] args)

        {
            int[] myArray = { 1 , 2 , 3 };
            int n = 2;
            SearchArray(myArray, n);
            void SearchArray(int[] myArray , int n)
            {
                bool isTrue = true;
                int i = 0;
                while (i < myArray.Length)
                {
                    if (myArray[i] != n)
                    {
                        i++;
                    }
                    else
                    {
                        Console.WriteLine("Il numero è presente");
                        isTrue = false;
                        break;
                    }
                }
                if (isTrue)
                {
                    Console.WriteLine("Il numero non è presente");
                }
            }
        }
    }
}
