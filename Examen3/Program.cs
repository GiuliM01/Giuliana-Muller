using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen3
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantitySackFeed = 15;
            int quantitySackMeat = 10;

            float kg = 10;
            float kgTotal = 10;
            float kgTotalTasteMeat = 10;
            float kgBagMin = 500;

            string taste = "";
            string tasteLigth = "";

            for (int quantity = 1; quantity <= quantitySackFeed; quantity++)
            {
                Console.WriteLine($"Compra Numero {quantity}");

                taste = getTaste();
                

                kgTotal += kg;

                if (kg < kgBagMin)
                {
                    kgBagMin = kg;
                    tasteLigth = taste;
                }


                if (taste == "carne")
                {
                    quantitySackFeed++;
                    kgTotalTasteMeat += kg;
                }
            }
            Console.WriteLine($"Promedio de todos los kg totales es de :{CalculateMean(kgTotal, quantitySackFeed)} \n" +
                              $"La bolsa mas liviana es : {kgBagMin} y su sabor es de : {tasteLigth} \n" +
                              $"Cantidad de bolsas sabor carne es de: {quantitySackMeat} y el promedio de kilos es : {CalculateMean(kgTotalTasteMeat, quantitySackMeat)} \n");

        }
        static bool kilogramValidation(double kg) => (kg > 10 && kg < 500);
        static bool tasteValidation(string taste) => (taste == "CARNE" || taste == "VEGETAL" || taste == "POLLO");
        static double getKilogram()
        {
            string readline;
            double kg = 10;
            bool isValidation = false;

            while (!isValidation)
            {
                Console.WriteLine("Ingrese la cantidad de Kilogramos que desea");
                readline = Console.ReadLine();
                if (double.TryParse(readline, out kg))
                {
                    if (kilogramValidation(kg))
                        isValidation = true;
                    else
                    {
                        Console.WriteLine("FAIL!! --> No ingreso un peso valido");
                        clearConsole();
                    }

                }
                else
                {
                    Console.WriteLine("FAIL!! --> No ingreso un numero");

                }
            }

            return kg;
        }
        static string getTaste()
        {
            string taste = "";
            bool isValidation = false;
            while (!isValidation)
            {
                Console.WriteLine("Ingresee el sabor : CARNE-VEGETAL-POLLO");
                taste = Console.ReadLine();
                if (tasteValidation(taste.ToUpper()))
                    isValidation = true;
                else
                {
                  
                    clearConsole();
                }
            }

            return taste.ToUpper();
        }

        static double CalculateMean(double kgTotal, int quantitySack) => (kgTotal / quantitySack);
        static void clearConsole()
        {
            Console.Clear();
        }

    }
}
        
    
