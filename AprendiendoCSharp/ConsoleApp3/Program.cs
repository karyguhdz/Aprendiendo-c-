using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entrada
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Se declara una variable para preguntar la informacion
             * y otra para recibir el valor equivalente*/
            string valor;
            int receptora = 0;
            Console.WriteLine("Escribe algo..");
            valor = Console.ReadLine();
            //revisa si el valor capturado se puede convertir en int
            if (int.TryParse(valor, out receptora))
            {
                //Si la conversion es posible
                Console.WriteLine(string.Format("Dato entero {0}. Muy bien!", receptora));
            }

            else
            {
                //si no manda un mensaje
                Console.WriteLine("Dato no es entero. intentar de nuevo");
            }

            Console.WriteLine("");
            Console.WriteLine("Presiona intro para continuar");
            Console.ReadKey();
        }
    }
}