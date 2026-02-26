using System;
using System.Collections.Generic;

public class EmpleadoTiempoCompleto : Empleado
{
	public double SalarioFijo { get; }
	
	public EmpleadoTiempoCompleto(int id, string nombre, double salarioFijo)
		: base(id, nombre)

	{
		SalarioFijo = 3000000;
	}

    public override double CalcularSalario()
    {
		return SalarioFijo;
	}

	public override void MostrarInformacion()
	{
		base.MostrarInformacion();
		Console.WriteLine("Tipo de empleado: Tiempo Completo");
		Console.WriteLine("Salario $" + CalcularSalario());
	}
}
