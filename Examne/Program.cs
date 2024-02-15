
using Examne;

try
{
    Nota nota = new Nota();

    Console.WriteLine("Ingrese la nota del primer parcial: ");
    nota.NotaParcial1 = double.Parse(Console.ReadLine());

    Console.WriteLine("Ingrese la nota del segundo parcial: ");
    nota.NotaParcial2 = double.Parse(Console.ReadLine());

    Console.WriteLine("Ingrese la nota del tercer parcial: ");
    nota.NotaParcial3 = double.Parse(Console.ReadLine());

    double NotaFinal = nota.CalcularNotaFinal(nota.NotaParcial1, nota.NotaParcial2, nota.NotaParcial3);
    Console.Write(NotaFinal);
    Console.Write( nota.MensajeNota(NotaFinal));
} catch (FormatException)
{
    Console.WriteLine($"Usted esta ingresando un valor que no es valido");
}