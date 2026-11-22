namespace GestionEmpleados;

internal class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("========================================================");
        Console.WriteLine("     SISTEMA DE GESTIÓN DE EMPLEADOS (LAB 6.6)          ");
        Console.WriteLine("========================================================");

        Console.Write("Ingrese el nombre del Departamento a crear: ");
        string nombreDep = Console.ReadLine() ?? "Sistemas";
        Departamento miDepto = new Departamento(nombreDep);

        bool ejecutando = true;

        do
        {
            Console.WriteLine("\n--------------------------------------------------------");
            Console.WriteLine($" MENÚ PRINCIPAL - DPTO. {miDepto.NombreDepartamento.ToUpper()}");
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("1. Registrar Empleado General");
            Console.WriteLine("2. Registrar Desarrollador de Software");
            Console.WriteLine("3. Listar Empleados Registrados");
            Console.WriteLine("4. Salir");
            Console.Write("Seleccione una opción: ");

            string opcion = Console.ReadLine() ?? "";

            switch (opcion)
            {
                case "1":
                    Console.WriteLine("\n--- Captura de Empleado General ---");
                    int idGen = CapturarEntero("ID: ");
                    string nombreGen = CapturarTexto("Nombre Completo: ");
                    decimal salarioGen = CapturarDecimal("Salario Base (RD$): ");

                    Empleado emp = new Empleado(idGen, nombreGen, salarioGen);
                    miDepto.RegistrarEmpleado(emp);
                    break;

                case "2":
                    Console.WriteLine("\n--- Captura de Desarrollador ---");
                    int idDev = CapturarEntero("ID: ");
                    string nombreDev = CapturarTexto("Nombre Completo: ");
                    decimal salarioDev = CapturarDecimal("Salario Base (RD$): ");
                    string lenguaje = CapturarTexto("Lenguaje Principal: ");

                    Desarrollador dev = new Desarrollador(idDev, nombreDev, salarioDev, lenguaje);
                    miDepto.RegistrarEmpleado(dev);
                    break;

                case "3":
                    miDepto.ListarEmpleadosRegistrados();
                    Pausar();
                    break;

                case "4":
                    Console.WriteLine("\n>> Finalizando aplicación. Sesión terminada.");
                    ejecutando = false;
                    break;

                default:
                    Console.WriteLine(">> Error: Opción no reconocida. Seleccione 1, 2, 3 o 4.");
                    break;
            }

        } while (ejecutando);
    }

    private static int CapturarEntero(string prompt)
    {
        int valor;
        Console.Write(prompt);
        while (!int.TryParse(Console.ReadLine(), out valor) || valor <= 0)
        {
            Console.Write(">> Error: Ingrese un entero positivo: ");
        }
        return valor;
    }

    private static decimal CapturarDecimal(string prompt)
    {
        decimal valor;
        Console.Write(prompt);
        while (!decimal.TryParse(Console.ReadLine(), out valor) || valor < 0)
        {
            Console.Write(">> Error: Ingrese un valor numérico positivo: ");
        }
        return valor;
    }

    private static string CapturarTexto(string prompt)
    {
        string texto;
        Console.Write(prompt);
        do
        {
            texto = Console.ReadLine() ?? "";
            if (string.IsNullOrWhiteSpace(texto))
                Console.Write(">> El campo no puede estar vacío. Reintente: ");
        } while (string.IsNullOrWhiteSpace(texto));
        return texto;
    }

    private static void Pausar()
    {
        Console.WriteLine("\nPresione Enter para volver al menú...");
        Console.ReadLine();
    }
}
