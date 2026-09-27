using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Ingrese su nombre");
           string name = Console.ReadLine();

            Console.WriteLine("Bienvenido "  + name );

            double resultado = 0;
            Console.WriteLine("ingrese el primer numero");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("ingrese la operacion + - * /");
            string operacion = Console.ReadLine();

            Console.WriteLine("ingrese el segundo numero");
            double num2 = Convert.ToDouble(Console.ReadLine());
            
                switch (operacion)
                {

            
                case "+":

                resultado = num1 + num2;
                    break;

                case "-":

                    resultado = num1 + num2;
                    break;
                case "*":

                    resultado = num1 * num2;
                    break;

                case "/":
                    
                    if (num2 != 0)
                    {
                        resultado = num1 / num2;
                    }

                    else
                    {
                        Console.WriteLine("el valor es invalido, no es posible dividir entre 0");
                    }
                    break;


                default:
                    Console.WriteLine("El valor es invalido");

                    break;


            }

            Console.WriteLine("el reusltado es " + resultado);

        }
    }
}
