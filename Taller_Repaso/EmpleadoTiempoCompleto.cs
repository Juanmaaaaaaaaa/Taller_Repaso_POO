using System;

public class EmpleadoTiempoCompleto : Empleado
{
	public double SalarioFijo { get; set}
	{
	public EmpleadoTiempoCompleto(int id, string nombre, double salarioFijo)
		: base(id, nombre)

	{
		salarioFijo = salarioFijo;
	}

    public override double CalcularSalario()
    {
		return SalarioFijo;
	}

	public override void MostrarInformación()
	{
		base.MostrarInformacion();
		console.WriteLine("Tipo de empleado: Tiempo Completo");
		console.WriteLine("Salario $" + CalcularSalario());
	}
}
