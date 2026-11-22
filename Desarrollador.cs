namespace GestionEmpleados;

// Desarrollador "ES UN" Empleado
public class Desarrollador : Empleado
{
    public string LenguajePrincipal { get; private set; }

    // Requisito: Uso obligatorio de ': base(...)' para invocar el constructor padre
    public Desarrollador(int id, string nombre, decimal salarioBase, string lenguajePrincipal)
        : base(id, nombre, salarioBase)
    {
        LenguajePrincipal = lenguajePrincipal;
    }

    public override void MostrarDetalles()
    {
        Console.WriteLine($"[ID: #{Id}] {Nombre} (Dev) | Salario: RD$ {SalarioBase:N2} | Stack: {LenguajePrincipal}");
    }
}