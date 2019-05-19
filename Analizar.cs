using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Alfanumerico
{
    public class Analizar
   {
        public int Resultado(string cadena)
        {
            
            char[] caracteres = cadena.ToCharArray();
            int contador = 0;
            int contadorDos = 0;

            for (int i = 0; i < caracteres.Length; i++)
            {
                if (caracteres[i] > 'A' && caracteres[i] < 'Z' || caracteres[i] > 'a' && caracteres[i] < 'z')
                    contador++;

                if (caracteres[i] > '1' && caracteres[i] < '9')
                    contadorDos++;
            }

            Console.WriteLine("Las palabras son: " + contador);
            Console.WriteLine("Los numeros son: " + contadorDos);
            Console.ReadKey();          

            return 0;

        }

        

    }

}

