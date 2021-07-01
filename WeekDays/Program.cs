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
            Console.WriteLine("Inserisci i giorni della settimana:\n(lun - mar - merc - gio - ven - sab - dom)\n");
            InsertDays(ref weekArray);
            
            
            void InsertDays(ref string[] weekArray)
            {
                int i = -1;
                do
                {
                    i++;
                    Console.WriteLine("Inserisci un giorno della settimana");
                    weekArray[i] = Console.ReadLine();
                    if (i > 0)
                    {
                        for (int j = 0; j < i; j++)
                        {
                            while (weekArray[i] != weekArray[j])
                            {
                                Console.WriteLine("Giorno della settimana già inserito!\nInserisci un giorno della settimana");
                                weekArray[i] = Console.ReadLine();
                            }
                        }
                    }
                } while (i < weekArray.Length);
            }

        }
    }
}
