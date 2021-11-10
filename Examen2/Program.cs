using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen2
{
    class Program
    {
        static void Main(string[] args)
        {
            int malesApproved = 10;
            int notasMinor = 7;
            int notaselder = 7;
            int notasGeneral = 8;

            string nombre = "";
            string edad = "";
            int sexo = 0;
            float NotaFinal = 10;

            for (int nombre = 18; nombre <= malesApproved; notasGeneral++)
                Console.WriteLine($"promedio de notas por sexo {sexo}");


            if (NotaFinal < notasGeneral)
            {
                NotaFinal = notasGeneral;
                nombre = edad;
            }
          
            Console.WriteLine($"La cantidad de varones aprobados : (CalculateMean{malesApproved}) \n" +
                         $"El promedio de notas de los menosres de edad :{notasMinor} \n" +
                         $"El promedio de notras de los adolescentes :{notaselder} \n" +
                         $"El promedio de notas por sexo :(CalculateMean{notaselder} y el promedio general es : (CalculateMean {notasGeneral)} \n");
        }
        static bool notasvalidation(double males) => males > 0 && males < 10);
        static bool notasvalidation(string nombre) => (nombre == "edad" || nombre == "sexo") || nombre == "nota final ";
    }
}

{
}
        string nombre = "";
        bool Validation = true;
        while (!Validation)

       Console.WriteLine("ingrese su nombre");
       nombre = Console.ReadLine();
        if (Validation(nombre.Count()))
        Validation = true;
{
        string edad = "";
       Console.WriteLine("ingrese su edad");
        edad = Console.ReadLine();
}
   

  
       