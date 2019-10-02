using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversiones
{
    class Program
    {
        static void Main(string[] args)
        {
            /*En C# las variables se declaran declarando el tipo de dato
             * seguido del nombre y si asi se maraca un valor*/
            string numero = "1234";
            /*Se muestra la representacion de la variable*/
            Console.WriteLine(numero.GetType().ToString());
            //Se convierte a int y se muestra el tipo
            int intNumero = Convert.ToInt32(numero);
            Console.WriteLine(intNumero.GetType().ToString());
            //StringFormat permite hacer macro substituciones
            Console.WriteLine(string.Format("El numero es {0}", intNumero));
            Console.ReadLine();


        }
    }
}
