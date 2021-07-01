using System;

//Scrivere una routine che chiede all'utente di scrivere i giorni della settimana (Es. Lun Mar Mer Gio Ven Sab Dom).
//Se l'utente ha già inserito un giorno, stampare 'Hai già inserito questo giorno' e far inserire  nuovo.
//Infine, stampare i giorni nell'ordine in cui l'utente li ha inseriti. 



namespace WeekDays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] weekArray = new string[7];
            Console.WriteLine("Inserisci i giorni della settimana:\n(lun - mart - merc - gio - ven - sab - dom)\n");
            for (int i = 0; i < weekArray.Length; i++)
            {
                Console.WriteLine("Inserisci un giorno della settimana");
                string temp = Console.ReadLine();
                CheckDay(weekArray, i, ref temp);
                weekArray[i] = temp;
                for (int k = 0; k < weekArray.Length; k++)
                {
                    Console.Write(weekArray[k] + " ");
                }
                

            } 

            // Routine
            void CheckDay(string[] weekArray, int i, ref string temp )
            {
                for(int j = 0; j <= i; j++)

                {
                    while (weekArray[j] != weekArray[i])
                    {
                        Console.WriteLine("Giorno già inserito!");
                        Console.WriteLine("Inserisci un giorno della settimana");
                        temp = Console.ReadLine();
                    }
                }

            }
            
        }

    }
}

