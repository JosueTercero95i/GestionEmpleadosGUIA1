using System;
using System.Collections.Generic;

namespace GestionEmpleadosGUIA1
{
    internal class Empleado
    {
        // variables miembro de la clase empleado
        private string nombre;
        private int numeroempleado;
        private decimal salario;
        private bool activo; //estado del empleado

        // Constructor de la clase Empleado
        public Empleado(string nombre, int numeroempleado, decimal salario, bool activo = true)
        {
            // Inicialización de los atributos con los valores proporcionados
            this.nombre = nombre;
            this.numeroempleado = numeroempleado;
            this.salario = salario;
            this.activo = activo;
        }

        // Método para mostrar los detalles del empleado
        public void MostrarDetalles()
        {
            // Determina el estado del empleado (Activo o Inactivo)
            string estado = (activo) ? "Activo" : "Inactivo";
            Console.WriteLine($"Nombre: {nombre}, Numero Empleado: {numeroempleado}, Salario: {salario:C}, Estado: {estado}");
        }

        // Método para obtener el número de empleado
        public int ObtenerNumeroEmpleado()
        {
            return this.numeroempleado;
        }

        // Método para cambiar el estado del empleado (Activar o Desactivar)
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

        // Método estático para buscar un empleado por su número en una lista de empleados
        public static Empleado BuscarEmpleado(List<Empleado> empleados, int NumeroEmpleado)
        {
            foreach (var emp in empleados)
            {
                if (emp.ObtenerNumeroEmpleado() == NumeroEmpleado)
                {
                    return emp;
                }
            }
            return null; // Retorna null si el empleado no se encuentra en la lista
        }

        // Método para aplicar un aumento al salario de un empleado
        public void Aumento(List<Empleado> ListaEmpleados, int numeroEmpleado, double Aumento)
        {
            Empleado empleado = BuscarEmpleado(ListaEmpleados, numeroEmpleado);
            if (empleado != null) //comprueba
            {
                decimal aumento = salario * Convert.ToDecimal(Aumento / 100); // Calcula el aumento
                salario += aumento; // Incrementa el salario con el aumento calculado
                // Muestra un mensaje indicando el aumento y el nuevo salario
                Console.WriteLine($"El salario de {nombre} ha sido aumentado en {Aumento}%.");
                Console.WriteLine($"Nuevo salario: {salario:C}");
            }
            else
            {
                Console.WriteLine($"Empleado con número {numeroEmpleado} no encontrado."); 
            }
        }
    }
}
