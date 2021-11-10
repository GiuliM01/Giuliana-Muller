using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            int num2;

            num = AskNumber();
            num2 = AskNumber();


            if (num == num2)
                Console.WriteLine($"El cuadrado del numero es {AskNum(num)}");
            if (num2 != 0)
            {
                if (Divisible(num, num2))
                Console.WriteLine($"La diferencia es {Rest(num, num2)}");
                Console.WriteLine($"Resta es : {GetRest(num, num2)}");

                if (GetRest(num, num2) > 3)
                Console.WriteLine($"El resto de {num} divido {num2} es Mayor a 3 ");
            }
        }
        static void AskNum()

        {
            Console.WriteLine("Ingresar numero");
        }

        static int AskNum(int num) => (num * num);
        static int Rest(int num, int num2) => num - num2;
        static bool Divisible(int num, int num2) => (GetRest(num, num2) == 0);
        static int GetRest(int num, int num2) => num % num2;
        static int AskNumber()
        {

        }
    }
}   