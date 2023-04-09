using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CORRREO_EN_ARRAY
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Escriba un nombre: ");

            String Nombre = Console.ReadLine();

            char[] Caracter = Nombre.ToCharArray();

            Console.Write("Escriba un Apellido: ");

            String Apellido = Console.ReadLine();

            char[] Caracter2 = Apellido.ToCharArray();

            Array.Reverse(Caracter2);

            String texto = "Su correo seria: ";

            for (int i = 0; i < 3; i++)

            {
                texto += Caracter[i];
            }

            texto += ".";

            for (int i = 0; i < 3; i++)
            {
                texto += Caracter2[i];
            }

            texto += "@upn.pe";

            Console.WriteLine(texto);
            Console.ReadKey();
        }
    }
}
