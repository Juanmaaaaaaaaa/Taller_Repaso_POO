using System;

public class EmpleadoPorHoras : Empleado
{
    public int HorasTrabajadas { get; set; }
    public double ValorPorHora { get; set; }

    public EmpleadoPorHoras(int id, string nombre, int horasTrabajadas, double valorPorHora) : base(id, nombre)
    {
        HorasTrabajadas = horasTrabajadas;
        ValorPorHora = valorPorHora;
    }

    public override double CalculaSalario()
    {
        return HorasTrabajadas * ValorPorHora;
    }

    public override void MostrarInformacion()
    {
        base.MostrarInformacion();
        Console.WriteLine("Tipo: Por Horas");
        Console.WriteLine("Salario: $" + CalculoSalario());
    }
}
