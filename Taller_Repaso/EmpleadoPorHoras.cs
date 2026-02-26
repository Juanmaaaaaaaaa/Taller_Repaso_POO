using System;
using System.Collections.Generic;

public class EmpleadoPorHoras : Empleado
{
    public int HorasTrabajadas { get; set; }
    public double ValorPorHora { get;  }

    public EmpleadoPorHoras(int id, string nombre, int horasTrabajadas) : base(id, nombre)
    {
        HorasTrabajadas = horasTrabajadas;
        ValorPorHora = 200;
    }

    public override double CalcularSalario()
    {
        return HorasTrabajadas * ValorPorHora;
    }

    public override void MostrarInformacion()
    {
        base.MostrarInformacion();
        Console.WriteLine("Tipo de empleado: Por Horas");
        Console.WriteLine("Salario: $" + CalcularSalario());
    }
}
