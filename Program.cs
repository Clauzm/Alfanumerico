using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alfanumerico
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Ingresa el dato");
            var dato = Console.ReadLine();

            Console.WriteLine("El dato es: " + dato);

            Analizar ana = new Analizar();
            ana.Resultado(dato);


        }     
           
    }
}
