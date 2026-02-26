using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Empleado> empleados = new List<Empleado>();
        empleados.Add(new EmpleadoTiempoCompleto(1, "Carolina", 3000));
        empleados.Add(new EmpleadoPorHoras(2, "Juan", 40, 25));
        empleados.Add(new EmpleadoTiempoCompleto(3, "Sara", 4500));
        empleados.Add(new EmpleadoPorHoras(4, "Luis", 30, 20));

        foreach (Empleado emp in empleados)
        {
            Console.WriteLine("---");
            emp.MostrarInformacion();
        }
    }

}
