using System;
using System.Collections.Generic;
using System.Text;

namespace Punto4
{
    class Empleado
    {
        private string nombre;
        private string direccion;
        private DateTime fechaNacimiento;
        private DateTime fechaIngreso;
        private string puestoTrabajo;
        private float sueldoBasico = 30000;
        private bool casado;
        private bool divorciado;
        private bool titulo;
        private int hijos;
        private DateTime fechaDivorcio;
        private string descripcionTitulo;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
        public DateTime FechaIngreso { get => fechaIngreso; set => fechaIngreso = value; }
        public string PuestoTrabajo { get => puestoTrabajo; set => puestoTrabajo = value; }
        public float SueldoBasico { get => sueldoBasico; set => sueldoBasico = value; }
        public bool Casado { get => casado; set => casado = value; }
        public bool Divorciado { get => divorciado; set => divorciado = value; }
        public bool Titulo { get => titulo; set => titulo = value; }
        public int Hijos { get => hijos; set => hijos = value; }
        public DateTime FechaDivorcio { get => fechaDivorcio; set => fechaDivorcio = value; }
        public string DescripcionTitulo { get => descripcionTitulo; set => descripcionTitulo = value; }


        public int edad()
        {
            return DateTime.Now.Year - FechaNacimiento.Year;
        }
        public int antiguedad()
        {
            return DateTime.Now.Year - FechaIngreso.Year;
        }

        public int? cantidadHijos()
        {

            if (Casado)
            {
                int cant = 0;
                Console.WriteLine("Ingrese la cantidad de hijos: ");
                cant = Convert.ToInt32(Console.ReadLine());
                Hijos = cant;
                return cant;
            }
            else
            {
                return null;
            }

        }

        public DateTime? Divorcio()
        {
            if (Divorciado)
            {
                DateTime fecha_divorcio;
                Console.WriteLine("Ingrese la fecha de divorcio (AAAA - MM - DD)");
                fecha_divorcio = new DateTime(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));
                FechaDivorcio = fecha_divorcio;
                return fecha_divorcio;
            }
            else
            {
                return null;
            }
        }

        public string tituloUniversitario()
        {
            if (Titulo)
            {
                string info = "";
                Console.WriteLine("Ingrese el titulo universitario: ");
                info = "TITULO: " + Console.ReadLine();
                Console.WriteLine("Ingrese la universidad: ");
                info += ", UNIVERSIDAD: " + Console.ReadLine();
                DescripcionTitulo = info;
                return info;
            }
            else
            {
                return null;
            }
        }

        public float salario()
        {
            float res = 0f;
            float adicional = 0f;
            int ant = antiguedad();

            while (ant <= 20)
            {
                adicional += SueldoBasico * 0.01f;
            }
            if (ant > 20)
            {
                adicional = SueldoBasico * 0.25f;
            }

            res = SueldoBasico + adicional - (SueldoBasico * 0.15f);
            return res;
        }
    }
}
