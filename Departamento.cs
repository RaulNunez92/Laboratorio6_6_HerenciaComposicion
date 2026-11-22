namespace GestionEmpleados;

public class Departamento
{
    public string NombreDepartamento { get; }

    // APLICACIÓN DE COMPOSICIÓN:
    // El departamento TIENE UNA colección de empleados encapsulada
    private readonly List<Empleado> _listaEmpleados;

    public Departamento(string nombreDepartamento)
    {
        NombreDepartamento = nombreDepartamento;
        _listaEmpleados = new List<Empleado>();
    }

    public void RegistrarEmpleado(Empleado nuevoEmpleado)
    {
        _listaEmpleados.Add(nuevoEmpleado);
        Console.WriteLine($">> Éxito: {nuevoEmpleado.Nombre} agregado al departamento de {NombreDepartamento}.");
    }

    // Método requerido para listar la nómina
    public void ListarEmpleadosRegistrados()
    {
        Console.WriteLine("\n========================================================");
        Console.WriteLine($" LISTADO DE NÓMINA: DEPARTAMENTO DE {NombreDepartamento.ToUpper()}");
        Console.WriteLine($" Total colaboradores: {_listaEmpleados.Count}");
        Console.WriteLine("========================================================");

        if (_listaEmpleados.Count == 0)
        {
            Console.WriteLine(">> No hay empleados registrados en este departamento.");
            return;
        }

        // Proceso cíclico para recorrer la colección
        foreach (Empleado emp in _listaEmpleados)
        {
            emp.MostrarDetalles(); // Despacho dinámico polimórfico
        }
    }
}