using System;
using System.Collections.Generic;
using NLog;

namespace Punto4
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion,cant;
            List<Empleado> empleados = new List<Empleado>();
            Logger log = LogManager.GetLogger("loggerRule");

            try
            {
                do
                {
                    Console.WriteLine("1 CARGAR EMPLEADOS - 2 MOSTRAR EMPLEADOS - 0 SALIR");
                    opcion = Convert.ToInt32(Console.ReadLine());

                    if (opcion == 1)
                    {
                        Console.WriteLine("Ingrese la cantidad de empleados: ");
                        cant = Convert.ToInt32(Console.ReadLine());
                        empleados = cargarEmpleados(empleados, cant);
                    }
                    else if (opcion == 2)
                    {
                        MostrarEmpleados(empleados);
                    }
                } while (opcion != 0);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Se ha detectado un error: "+ ex.Message);
                log.Info("Error al elegir una opcion");
            }



        }
       
        public static List<Empleado> cargarEmpleados(List<Empleado> empleados, int cant)
        {

            for (int i = 0; i < cant; i++)
            {
                Empleado empleado = new Empleado();
                Console.WriteLine("Nombre del empleado: "); empleado.Nombre = Console.ReadLine();
                Console.WriteLine("Direccion del empleado: "); empleado.Direccion = "libano";//Console.ReadLine();
                try
                {
                    Console.WriteLine("Nacimiento:  aaaa-mm-dd");
                    empleado.FechaNacimiento = new DateTime(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));
                    Console.WriteLine("Fecha ingreso: aaaa-mm-dd");
                    empleado.FechaIngreso = new DateTime(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));
                }
                catch (Exception e)
                {
                    Console.WriteLine("No se ingresó correctamente la fecha", e.Message);
                }
                
                Console.WriteLine("Puesto: "); empleado.PuestoTrabajo = "Gerente";
                Console.WriteLine("¿Es Casado? \n1-Si \n0-No");
                if (Convert.ToInt32(Console.ReadLine()) == 1)
                {
                    empleado.Casado = true;
                    empleado.cantidadHijos();
                }
                else
                {
                    empleado.Casado = false;
                }
                Console.WriteLine("Divorciado? \n1-Si\n0-No");
                if (Convert.ToInt32(Console.ReadLine()) == 1)
                {
                    empleado.Divorciado = true;
                    empleado.Divorcio();
                }
                else
                {
                    empleado.Divorciado = false;
                }
                Console.WriteLine("Titulo Universitario? \n1-Si\n0-No");
                if (Convert.ToInt32(Console.ReadLine()) == 1)
                {
                    empleado.Titulo = true;
                    empleado.tituloUniversitario();
                }
                else
                {
                    empleado.Titulo = false;
                }

                empleados.Add(empleado);
            }
            return empleados;
        }
        public static void MostrarEmpleados(List<Empleado> empleados)
        {

            foreach (Empleado e in empleados)
            {
                Console.WriteLine("--------------------------");
                Console.WriteLine("Nombre: {0}", e.Nombre);
                Console.WriteLine("Direccion: ", e.Direccion);
                Console.WriteLine("Nacimiento:  {0}/{1}/{2}", e.FechaNacimiento.Day, e.FechaNacimiento.Month, e.FechaNacimiento.Year);
                Console.WriteLine("Igreso:  {0}/{1}/{2}", e.FechaIngreso.Day, e.FechaIngreso.Month, e.FechaIngreso.Year);
                Console.WriteLine("Puesto: {0}", e.PuestoTrabajo);
                Console.WriteLine("SALARIO: {0}", e.salario());
                Console.WriteLine("CASADO: {0}, HIJOS: {1}", e.Casado, e.Hijos);
                Console.WriteLine("DIVORCIADO: {0}, FECHA DIVORCIO: {1} - {2} - {3}", e.Divorciado, e.FechaDivorcio.Day, e.FechaDivorcio.Month, e.FechaDivorcio.Year);
                Console.WriteLine(e.DescripcionTitulo);
                Console.WriteLine("\n\n");
            }

        }
    }
    }
}
