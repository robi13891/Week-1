using System;

//Scrivere un programma completo. L'utente inserisce un numero tra 2 e 12
//Il computer lancia 2 dadi, quindi sorteggia 2 numeri random tra 1 e 6.
//Se la somma dei due numeri random è pari al numero scelto dall'utente, l'utente vince
//Se l'utente vince, stampare 'hai vinto', altrimenti 'hai perso'.
//Finita la partita l'utente deve poter rigiocare. 

// Requisiti:
//verificare che l'utente inserisca un intero e che sia compreso tra 2 e 12.
//se la verifica non va a buon fine, l'utente deve potere inserire nuovamente qualcosa.
//Creare un metodo per l'inserimento dei numeri e la verifica, uno per il controllo della vittoria (da chiamare nel main)

namespace DiceGame
{
    class Program
    {
        static void Main(string[] args)
        {
            // Programma

            int keepGoing = 1;
            do
            {
                //scelta utente
                int userNumber = InsertNumber();

                // scelta computer
                Random random = new Random();
                int[] dice = new int[2];
                dice[0] = random.Next(1, 6);
                Console.WriteLine("Primo dado: " + dice[0]);
                dice[1] = random.Next(1, 6);
                Console.WriteLine("Secondo dado:" + dice[1]);
                Console.WriteLine("Somma dadi: " + (dice[0] + dice[1]) );

                //verifica risultato
                if (CheckResult(userNumber, dice))
                {
                    Console.WriteLine("Hai vinto!");
                }
                else
                {
                    Console.WriteLine("Hai perso!");
                }
                Console.WriteLine("\nSe non vuoi più giocare premi 0, altrimenti premi un tasto qualunque.");
                keepGoing = int.Parse(Console.ReadLine());


            } while (keepGoing != 0);

            // Metodi

            int InsertNumber()
            {
                Console.WriteLine("Inserisci un numero compreso tra 2 e 12");
                bool isSucc = int.TryParse(Console.ReadLine(), out int n);
                while (!(isSucc && n >= 2 && n <= 12) )
                {
                    Console.WriteLine("Inserimento non corretto!");
                    Console.WriteLine("Inserisci un numero compreso tra 2 e 12");
                    isSucc = int.TryParse(Console.ReadLine(), out n);
                }
                return n;
            }

            bool CheckResult(int userNumber , int[] dice)
            {
                bool win=false;
                if ( userNumber == dice[0] + dice[1] )
                {
                    win = true;
                    return win;
                }
                else
                {
                    return win;
                }
            }

        }
    }
}
