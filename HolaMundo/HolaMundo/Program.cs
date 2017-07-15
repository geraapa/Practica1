using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolaMundo
{
    class Program
    {
        static void Main(string[] args)
        {
            int operacion;
            double valor1, valor2, resultado;
            bool entra;
            entra = true;
            operacion = 0;
            valor1 = 0.0;
            valor2 = 0.0;
            resultado = 0.0;
            //Calculadora 
            Console.WriteLine("CALCULADORA");

            Console.WriteLine("1.- Suma");
            Console.WriteLine("2.- Resta");
            Console.WriteLine("3.- Multiplicación");
            Console.WriteLine("4.- División");
            operacion = Int32.Parse(Console.ReadLine());
            Console.Clear();
            switch (operacion)
            {
                case 1: Console.WriteLine("Suma");
                        break;
                case 2: Console.WriteLine("Resta");
                        break;
                case 3: Console.WriteLine("Multiplicación");
                        break;
                case 4: Console.WriteLine("División");
                        break;
                default: Console.WriteLine("Opción no valida");
                         entra = false;
                         break;
            }
            if (entra)
            {
                Console.WriteLine("Ingresa el valor 1:");
                valor1 = Double.Parse(Console.ReadLine());
                Console.WriteLine("Ingresa el valor 2:");
                valor2 = Double.Parse(Console.ReadLine());
                switch (operacion)
                {
                    case 1: resultado = valor1 + valor2;
                            break;
                    case 2: resultado = valor1 - valor2;
                            break;
                    case 3: resultado = valor1 * valor2;
                            break;
                    case 4: if(valor2 == 0)
                            {
                                Console.WriteLine("No se puede dividir entre 0.");
                            }
                            else
                            {
                                resultado = valor1 / valor2;
                            }
                            break;
                }
                Console.WriteLine("El resultado es {0}", resultado);
                
            }
            
            Console.ReadLine();
        }
    }
}
