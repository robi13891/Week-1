using System;

namespace CheckedArrayInsertion
{
    class Program
    {
        static void Main(string[] args)
        {
            // dichiarazione array
            int[] myArray = new int[3];
            string temp;
            InsertNumbers(ref myArray);

            void InsertNumbers(ref int[] myArray)
            {
                Console.WriteLine("Inizializzazione vettore di numeri interi non nulli");


                for (int i = 0; i < myArray.Length; i++)
                {
                    Console.WriteLine("Inserisci un numero");
                    temp = Console.ReadLine();
                    myArray[i] = CheckIns(temp);
                    if (myArray[i] == 0)
                    {
                        i--;
                    }
                }



            }

            int CheckIns(string temp)
            {
                bool isSuccessful = int.TryParse(temp, out int n);
                while (!(isSuccessful && n != 0))
                {
                    Console.WriteLine("Inserimento non corretto!");
                    break;
                    
                }
                return n;
            }




            //stampa vettore
            Console.WriteLine("Vettore:");
            for (int j = 0; j < myArray.Length; j++)
            {
                Console.Write( myArray[j] + " ");
            }

        }
    }
}



    

