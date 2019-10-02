using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tabla
{
    class Program
    {
        static void Main(string[] args)
        {
            //Una interfaz de datos se capturan como string
            String _numero;
            int numero;

            //El dato string se convierte equivalente numerico 

            Console.Write("Dame un numero del 1 al 9:  ");
            _numero = Console.ReadLine();
            numero = Convert.ToInt32(_numero);

            // se genera un ciclo

            for (int i = 0; 1 < 10; i++)
            {
                Console.WriteLine(
                    string.Format("{0} x {1} = {2}",
                    numero, i, numero * i));
            }
            //  Pausa
            Console.WriteLine("");
            Console.WriteLine("presiona INTRO para continuar");
            Console.ReadKey();
        }
    }
}
