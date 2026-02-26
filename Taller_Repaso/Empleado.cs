using System;
using System.Collections.Generic;

public abstract class Empleado
{
    public int Id { get; set; }
    public string Nombre { get; set; }

    public Empleado(int id, string nombre)
	{
        Id = id;
        Nombre = nombre;

    }

    public abstract double CalcularSalario();

    public virtual void MostrarInformacion()
    {
        Console.WriteLine("ID: " + Id);
        Console.WriteLine("Nombre: " + Nombre);
    }

}


