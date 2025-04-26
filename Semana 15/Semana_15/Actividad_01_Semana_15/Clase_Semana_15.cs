class Clase_Semana15
{
    static void Main()
    {
        Console.WriteLine("Por favor, ingrese sus datos: ");
        Console.Write("Nombre: ");
        string? nombre = Console.ReadLine();
        Console.WriteLine();

        Console.Write("Edad: ");
        string? entrada = Console.ReadLine();
        int edad;
        if(int.TryParse(entrada, out edad) == false)
        {
            Console.WriteLine("Dato no válido");
            return;
        }
        Console.WriteLine();

        Console.Write("Carrera: ");
        string? carrera = Console.ReadLine();
        Console.WriteLine();

        Console.Write("Carnet: ");
        entrada = Console.ReadLine();
        int carnet;
        if(int.TryParse(entrada, out carnet) == false)
        {
            Console.WriteLine("Dato no válido");
            return;
        }
        Console.WriteLine();

        Console.Write("Nota de admisión: ");
        entrada = Console.ReadLine();
        int notaAdmision;
        if(int.TryParse(entrada, out notaAdmision) == false)
        {
            Console.WriteLine("Dato no válido");
            return;
        }
        Console.WriteLine();

        Estudiante estudiante = new Estudiante(nombre, edad, carrera, carnet, notaAdmision);

        Console.WriteLine("-----------------------------------------------------");
        estudiante.MostrarResumen();
        Console.WriteLine("-----------------------------------------------------");
        if(estudiante.PuedeMatricular() == true)
        {
            Console.WriteLine("Usted puede matricularse.");
        }
        else
        {
            Console.WriteLine("Usted no puede matricularse.");
        }
    }
}

public class Estudiante
{
    string? Nombre;
    int Edad;
    string? Carrera;
    int Carnet;
    int NotaAdmision;

    public Estudiante(string? nombre, int edad, string? carrera, int carnet, int notaAdmision)
    {
        Nombre = nombre;
        Edad = edad;
        Carrera = carrera;
        Carnet = carnet;
        NotaAdmision= notaAdmision;
    }

    public void MostrarResumen()
    {
        Console.WriteLine("Nombre: " + Nombre);
        Console.WriteLine("Edad: " + Edad);
        Console.WriteLine("Carrera: " + Carrera);
        Console.WriteLine("Carnet: " + Carnet);
        Console.WriteLine("Nota de admisión: " + NotaAdmision);
    }

    public bool PuedeMatricular()
    {
        string carnetString = Carnet.ToString();

        if(NotaAdmision > 75 &&  carnetString.EndsWith("2025"))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}