using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones_24_05_2022
{
    //Alumno: Santy Francisco Martinez Castellanos
    //N.Control: 21211989

    class Program
    {
        static void Main(string[] args)
        {

           int num;

           int cuadrado;

            try
            {

                Console.Write("Introduce un numero entero:");
                num = int.Parse(Console.ReadLine());
                cuadrado = num * num;
                if (cuadrado > 100000000)
                {
                    throw new Exception("El resultado es muy grande");
                }

                Console.WriteLine("Numero al cuadrado: {0}", cuadrado);
            }

            catch(OverflowException)
            {
                Console.WriteLine("Numero demasiado grande");
            }

            catch(FormatException )
            {
                Console.WriteLine("No cumple con el formato adecuado");
            }

           
            catch(Exception e)
            {
                Console.WriteLine("Error: {0}", e.Message);
            }

            
            
        }
    }
}
