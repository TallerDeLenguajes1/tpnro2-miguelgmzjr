using System;

namespace Problema2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un numero: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese otro numero: ");
            int b = Convert.ToInt32(Console.ReadLine());

            int resultado;

            try
            {
                resultado = a / b;
                Console.WriteLine("El resultado es: " + resultado);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Se ha producido un error!!");
                Console.WriteLine(ex.ToString());
                //throw;
            }
            Console.ReadKey();
        }
    }
}
