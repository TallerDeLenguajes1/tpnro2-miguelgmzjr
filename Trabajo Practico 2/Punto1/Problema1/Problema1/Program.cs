using System;

namespace Problema1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Ingrese un numero para calcular el cuadrado: ");

            try
            {
                int num = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Resultado: " + num * num);
            }
            catch (Exception ex)
            {
                Console.Write("Se produjo un error!!\n");
                Console.Write(ex.ToString());
            }
        }
    }
}
