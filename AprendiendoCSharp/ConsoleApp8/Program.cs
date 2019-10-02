﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acumulado
{
    class Program
    {
        static void Main(string[] args)
        { 

            string _numero;
            int numero;
            int acumulado = 0;
            Console.WriteLine("Capture loa enteros a acumular.");
            Console.WriteLine("Dejar vacio y dar INTRO, para salir");
            Console.WriteLine("");

            while (true)
            {
                Console.Write("Dame un numero entero: ");
                _numero = Console.ReadLine();
                if (_numero == "")
                {
                    break;
                }
                else
                {
                    if (int.TryParse(_numero, out numero))
                    {
                        acumulado += numero;
                        Console.WriteLine(String.Format("Monto acumulado: {0}", acumulado));
                    }
                    else
                    {
                        Console.WriteLine("El dato proporcionado no es un numero entero.");
                        Console.WriteLine("Intenta de nuevo");
                    }
                }
            }
            //Pausa
            Console.WriteLine("");
            Console.WriteLine("Presiona INTRO para continuar");
            Console.ReadKey();

        }
    }
}
