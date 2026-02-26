using System;

public abstract class Empleado
{
    public int Id { get; set; }
    public string Nombre { get; set; }
    public Empleado(int id, string nombre)
	{
        Id = id;
        Nombre = nombre;

    }
    public abstract int CalcularSalario()
    {

    }
    public void MostrarInformacion()
    {
        Console.WriteLine("ID: " + Id);
        Console.WriteLine("Nombre: " + Nombre);
    }

}


