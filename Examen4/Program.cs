using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen4
{
    class Program
    {
        static void Main(string[] args)
        {
            string color = "";
            int valor = 0;
            bool exit = false;
            string readlineExit = "";

            int Red = 0;
            int RedPriceMaxA = 0;
            int VehiclePrecioMinA = 0;

            double sumParcialVehicle = 0;
            double maxPrecioVehicle = 0;
            string colorMaxPrecioVehicle = "";

            while (!exit)
            {
                color = getColor();
                valor = getValor();
                sumParcialVehicle += valor;

                if (valor < 5000)
                    VehiclePrecioMinA++;

                if (color == "ROJO")
                {
                    Red++;
                    if (valor > 5000)
                        RedPriceMaxA++;
                }

                if (valor > maxPrecioVehicle)
                {
                    maxPrecioVehicle = valor;
                    colorMaxPrecioVehicle = color;
                }             
                if (readlineExit == "SI")
                    exit = true;
                clearConsole();
            }

            Console.WriteLine($"La cantidad de Vehiculos Rojos es : {Red} \n" +
                                       $"La cantidad de Vehiculos Rojos con Precio mayor a 5000 es : {RedPriceMaxA} \n" +
                                       $"La cantidad de Vehiculos con Precios menor a 5000 es : {VehiclePrecioMinA} \n" +
                                       $"El promedio de todos los Vehiculos es : {(sumParcialVehicle)} \n" +
                                       $"El Vehiculo mas caro  es de ${maxPrecioVehicle} y su color es {colorMaxPrecioVehicle} \n ");



        }
        static bool exitValidation(string exit) => (exit == "SI" || exit == "NO");
        static bool colorValidation(string color) => (color == "ROJO" || color == "VERDE" || color == "AMARILLO");
        static bool valorValidation(int number) => (number > 0 && number < 10000);
        static double average(double sumParcial, int cantTotal) => sumParcial / cantTotal;

        static string getColor()
        {
            string color = "";
            bool Validation = false;
            while (!Validation)
            {
                Console.WriteLine("Ingrese el Color : ROJO-VERDE-O-AMARILLO");
                color = Console.ReadLine();
                if (colorValidation(color.ToUpper()))
                    Validation = true;
                else
                {
                    clearConsole();
             
                }
            }
            return color.ToUpper();
        }
        static int getValor()
        {
            string readline = "";
            int valor = 0;
            bool Validation = false;
            while (!Validation)
            {
                Console.WriteLine("Ingresar un valor entre 0-10000");
                readline = Console.ReadLine();
                if (int.TryParse(readline, out valor))
                {
                    if (valorValidation(valor))
                        Validation = true;
                    else
                    {

                        Console.WriteLine("Ingrese un color");
                    }
                }
                else
                {
                    clearConsole();
                         Console.WriteLine("Ingrese un formato valido ");
                }
            }
            return valor;
        }
        static void clearConsole()
        {

            Console.Clear();
        }
       
    }
}
