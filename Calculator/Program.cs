using System;

namespace Week1
{
    class Program
    {
        static void Main(string[] args)
        {
            int again;
            do
            {
                Console.WriteLine("Inserisci il primo numero");
                int firstNum = int.Parse(Console.ReadLine());
                Console.WriteLine("Inserisci il secondo numero");
                int secondNum = int.Parse(Console.ReadLine());
                Console.WriteLine("\n1 somma\n2 sottrazione\n3 moltiplicazione\n4 divisione");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine(firstNum + secondNum);
                        break;
                    case 2:
                        Console.WriteLine(firstNum - secondNum);
                        break;
                    case 3:
                        Console.WriteLine(firstNum * secondNum);
                        break;
                    case 4:
                        if (secondNum != 0)
                        {
                            Console.WriteLine(firstNum / secondNum);
                        }
                        else
                        {
                            Console.WriteLine("Operazione non definita");
                        }
                        break;

                    default:
                        Console.WriteLine("La scelta non è associata ad alcuna operazione");
                        break;

                }
                Console.WriteLine("Premi 0 per uscire, oppure 1 per continuare");
                again = int.Parse(Console.ReadLine());
                
            } while (again!=0);
        }
    }
}
