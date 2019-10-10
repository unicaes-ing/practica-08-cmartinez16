using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_8
{
    class Program
    {
        public struct Estudiante
        {
            public string nombre;
            public string carnet;
            public string carrera;
            private double CUM;

            public void setCUM ( double CUM)
            {
                if (CUM > 0 && CUM < 10.0)
                {
                    this.CUM = CUM;
                }
            }

            public double getCUM()
            {
                return CUM;
            }
        }
        static void Main(string[] args)
        {
            Estudiante estudiante1  = new Estudiante();
            Console.WriteLine("Ingrese el nombre del estudiante: ");
            estudiante1.nombre = Console.ReadLine();
            Console.WriteLine("Ingrese el carnet del estudiante: ");
            estudiante1.carnet = Console.ReadLine();
            Console.WriteLine("Ingresela carrera que cursa el estudiante: ");
            estudiante1.carrera = Console.ReadLine();
            Console.WriteLine("Ingrese el CUM del estudiante: ");
            estudiante1.setCUM(Convert.ToDouble(Console.ReadLine()));
            Console.Clear();
            Console.WriteLine("             Informacion del estudiante            ");
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("Nombre del estudiante: {0}", estudiante1.nombre);
            Console.WriteLine("N° de Carnet: {0}", estudiante1.carnet);
            Console.WriteLine("Carrera en curso: {0}", estudiante1.carrera);
            Console.WriteLine("CUM: {0}", estudiante1.getCUM());
            Console.ReadKey();


        }
        

    }
}
