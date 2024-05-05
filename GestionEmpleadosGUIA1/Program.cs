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

            // Número de empleado al que se cambiará el estado
            int NumeroEmpleadosCambiarEstado = 103;

            Empleado EmpleadoCambiarEstado = Empleado.BuscarEmpleado(ListaEmpleados, NumeroEmpleadosCambiarEstado);

            // Verificar si se encontró el empleado
            if (EmpleadoCambiarEstado != null)
            {
                EmpleadoCambiarEstado.CambiarEstado(true);

                EmpleadoCambiarEstado.MostrarDetalles();
            }
            else
            {
                // Si el empleado no se encuentra, mostrar un mensaje de error
                Console.WriteLine($"Empleado con número {NumeroEmpleadosCambiarEstado} no encontrado.");
            }

            // Aumentar el salario de un empleado por un cierto porcentaje
            int NumeroEmpleadoAumentoSalario = 101; 
            double Porcentaje = 10; 

            Empleado.BuscarEmpleado(ListaEmpleados, NumeroEmpleadoAumentoSalario)?.Aumento(ListaEmpleados, NumeroEmpleadoAumentoSalario, Porcentaje);

            Console.ReadLine();
        }
    }
}
