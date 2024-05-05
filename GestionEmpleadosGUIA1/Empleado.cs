using System;
using System.Collections.Generic;

namespace GestionEmpleadosGUIA1
{
    internal class Empleado
    {
        private string nombre;
        private int numeroempleado;
        private decimal salario;
        private bool activo;

        public Empleado(string nombre, int numeroempleado, decimal salario, bool activo = true)
        {
            this.nombre = nombre;
            this.numeroempleado = numeroempleado;
            this.salario = salario;
            this.activo = activo;
        }

        public void MostrarDetalles()
        {
            string estado = (activo) ? "Activo" : "Inactivo";
            Console.WriteLine($"Nombre: {nombre}, Numero Empleado: {numeroempleado}, Salario: {salario:C}, Estado: {estado}");
        }

        public int ObtenerNumeroEmpleado()
        {
            return this.numeroempleado;
        }

        public void CambiarEstado(bool NuevoEstado)
        {
            if (NuevoEstado)
            {
                activo = true;
                Console.WriteLine("Empleado Activado");
            }
            else
            {
                activo = false;
                Console.WriteLine("Empleado Desactivado");
            }
        }

        public static Empleado BuscarEmpleado(List<Empleado> empleados, int NumeroEmpleado)
        {
            foreach (var emp in empleados)
            {
                if (emp.ObtenerNumeroEmpleado() == NumeroEmpleado)
                {
                    return emp;
                }
            }
            return null;
        }

   
    }
}
