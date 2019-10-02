using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiplo
{
    class Program
    {
        static void Main(string[] args)
        {
            string _numero;
            int numero;
            bool esMultiplo3, esMultiplo5, esMultiplo7;
            try
            {
                Console.Write("Dame un numero entero: ");
                _numero = Console.ReadLine();
                numero = Convert.ToInt32(_numero);
                //Si un nuerp tiene residuo de cero conforme el numero es su multiplo
                esMultiplo3 = ((numero % 3) == 0);
                esMultiplo5 = ((numero % 5) == 0);
                esMultiplo7 = ((numero % 7) == 0);
                if ((esMultiplo3 & esMultiplo5) | esMultiplo7)
                {
                    Console.WriteLine("Correcto.");
                }
                else
                {
                    Console.WriteLine("Incorrecto");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("El dato proporcionado causa errores.");
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("");
                Console.WriteLine("Presiona cualquier letra para continuar");
                Console.ReadKey();
            }

        }
    }
}
