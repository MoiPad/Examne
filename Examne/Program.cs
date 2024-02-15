
using Examne;

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
                double NotaFinal = nota.CalcularNotaFinal(nota.NotaParcial1, nota.NotaParcial2, nota.NotaParcial3);
                Console.Write(NotaFinal);
                Console.Write(nota.MensajeNota(NotaFinal));
            }
        }
    }
}
catch (FormatException)
{
    Console.WriteLine("Error: Ingrese un valor válido.");
}
