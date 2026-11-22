namespace GestionEmpleados;

public class Empleado
{
    // Encapsulamiento con propiedades
    public int Id { get; protected set; }
    public string Nombre { get; protected set; }
    public decimal SalarioBase { get; protected set; }

    // Constructor base
    public Empleado(int id, string nombre, decimal salarioBase)
    {
        Id = id;
        Nombre = nombre;
        SalarioBase = salarioBase;
    }

    // Método virtual para permitir sobreescritura polimórfica
    public virtual void MostrarDetalles()
    {
        Console.WriteLine($"[ID: #{Id}] {Nombre} | Salario Base: RD$ {SalarioBase:N2}");
    }
}