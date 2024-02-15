
using Examne;

Asignatura asignatura = new Asignatura();
Console.WriteLine("Nombre del alumno: ");
asignatura.Nombre = Console.ReadLine();
Console.WriteLine("Nnumero de cuenta: ");
asignatura.NumeroCuenta = Console.ReadLine();
Console.WriteLine("Correo electronico: ");
asignatura.Email = Console.ReadLine();

Console.WriteLine(new string ('-', 40));

Console.WriteLine("Nombre de la asignatura: ");
asignatura.Nombre = Console.ReadLine();
Console.WriteLine("Horario : ");
asignatura.Horario = Console.ReadLine();
Console.WriteLine("Nombre del docente: ");
asignatura.Docente = Console.ReadLine();

Console.WriteLine(new string('-', 40));

try
{
    Nota nota = new Nota();

    Console.Write("Ingrese la nota del primer parcial: ");
    nota.NotaParcial1 = double.Parse(Console.ReadLine());

    if (nota.NotaParcial1 > 30)
    {
        Console.WriteLine(" La nota del primer parcial no debe ser mayor a 30.");
    }
    else
    {
        Console.Write("Ingrese la nota del segundo parcial: ");
        nota.NotaParcial2 = double.Parse(Console.ReadLine());

        if (nota.NotaParcial2 > 30)
        {
            Console.WriteLine("La nota del segundo parcial no debe ser mayor a 30.");
        }
        else
        {
            Console.Write("Ingrese la nota del tercer parcial: ");
            nota.NotaParcial3 = double.Parse(Console.ReadLine());

            if (nota.NotaParcial3 > 40)
            {
                Console.WriteLine("La nota del tercer parcial no debe ser mayor a 40.");
            }
            else
            {
                Console.WriteLine(new string('*',40));
                double NotaFinal = nota.CalcularNotaFinal(nota.NotaParcial1, nota.NotaParcial2, nota.NotaParcial3);
                asignatura.Imprimir();
                Console.Write("Su nota: " + NotaFinal + " % ") ;
                Console.Write(nota.MensajeNota(NotaFinal));
                Console.WriteLine();
                Console.WriteLine(new string('*', 40));
            }
        }
    }
}
catch (FormatException)
{
    Console.WriteLine("Error: Ingrese un valor válido.");
}
