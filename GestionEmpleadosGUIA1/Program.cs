using System;
using System.Collections.Generic;

namespace GestionEmpleadosGUIA1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Aplicacion de gestion de empleados");

            // Creación de una lista de empleados
            List<Empleado> ListaEmpleados = new List<Empleado>();

            ListaEmpleados.Add(new Empleado("Juan", 101, 30000));
            ListaEmpleados.Add(new Empleado("Maria", 102, 35000));
            ListaEmpleados.Add(new Empleado("Pedro", 103, 32000, false));

            foreach (var empleado in ListaEmpleados)
            {
                empleado.MostrarDetalles();
            }

            Console.ReadLine(); 
        }
    }
}
