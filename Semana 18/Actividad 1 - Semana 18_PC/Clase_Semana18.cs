
NotaEstudiante estudiante = new NotaEstudiante();

double[] promedioGrupo = new double[10];

for (int i = 0; i < promedioGrupo.Length; i++)
{
    Console.WriteLine("Estudiante No. " + (i + 1));
    promedioGrupo[i] = estudiante.calcularPromedio();
}

Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("El promedio de todos los estudiantes es de: " + promedioGrupo.Average());
Console.ForegroundColor = ConsoleColor.White;

class NotaEstudiante
{
    public double calcularPromedio()
    {
        string? nombre = "";
        bool nombreValido = false;
        int[] notas = new int[10];
        string[] materias = {"Precálculo", "Química", "Química (LAB)", "Pensamiento Computacional", "Pensamiento Computacional (LAB)",
        "Cálculo", "Bases de Investigación", "Estrategias de Razonamiento", "Magis Landivariano", "Intro. Ing. en Informática y Sistemas"};

        Console.WriteLine("Por favor, escriba el nombre del estudiante: ");

        while(nombreValido == false)
        {
            nombre = Console.ReadLine();
            if(nombre == "")
            {
                Console.WriteLine("NOMBRE NO VÁLIDO, por favor, escriba otro nombre:");

            }
            else
            {
                nombreValido = true;
            }
        }

        Console.WriteLine("Por favor, ingrese las 10 notas del estudiante: ");
        for (int i = 0; i < notas.Length; i++)
        {

            bool notaValida = false;

            while(notaValida == false)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write((i + 1) + ". ");
                Console.WriteLine(materias[i]);
                Console.ForegroundColor = ConsoleColor.White;

                string? entrada = Console.ReadLine();
                int notaIngresada;

                if(int.TryParse(entrada, out notaIngresada))
                {
                    if(notaIngresada >= 0 && notaIngresada <= 100)
                    {
                        notas[i] = notaIngresada;
                        notaValida = true;
                    }
                    else
                    {
                        Console.WriteLine("NOTA DEBE DE ESTAR EN EL RANGO DE 0 A 100. Por favor, ingrese otro dato");
                    }
                }
                else
                {
                    Console.WriteLine("NOTA NO VÁLIDA. Por favor, vuelva a ingresar la nota.");
                }
            }
        }

        Console.WriteLine("-------------------------------------------------------------------------");
        Console.WriteLine();
        Console.WriteLine(nombre);
        Console.WriteLine();
        for (int i = 0; i < notas.Length; i++)
        {
            bool materiaAprobada = false;
            if(notas[i] >= 65)
            {
                materiaAprobada = true;
            }
            else
            {
                materiaAprobada = false;
            }

            if(materiaAprobada == true)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write(materias[i] + ":");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(" APROBADA");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write(materias[i] + ":");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(" REPROBADA");
            }

            Console.ForegroundColor = ConsoleColor.White;
        }

        Console.WriteLine();
        Console.WriteLine("El promedio de " + nombre + " es de: " + notas.Average());
        Console.WriteLine();

        Console.WriteLine("-------------------------------------------------------------------------");
        return notas.Average();
    }
}

