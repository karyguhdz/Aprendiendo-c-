using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aleatorio
{
    class Program
    {
        /*La letra F se pone pq se trata de un valor float*/
        static public float numero1 = 24.5F;
        static void Main(string[] args)
        {
            //Declaracion de las variables dentro de un metodo
            float numero2 = 0.0F;
            //Valor aleatorio
            Random numAleatorio = new Random();
            numero2 = (float)numAleatorio.Next(1, 11);
            Console.WriteLine(string.Format("La suma de {0} y {1} es {2}", numero1, numero2, numero1 + numero2));
            Console.ReadLine();
        }
    }
}