

namespace Examne
{
    internal class Nota : INota
    {
        public double NotaParcial1 { get; set;}
        public double NotaParcial2 { get; set;}
        public double NotaParcial3 { get; set;}

        public Nota() { }

        public Nota(double NotaParcial1, double NotaParcial2, double NotaParcial3) 
        {
            this.NotaParcial1 = NotaParcial1;
            this.NotaParcial2 = NotaParcial2;
            this.NotaParcial3 = NotaParcial3;
        }

        public double CalcularNotaFinal(double Nota1, double Nota2, double Nota3)
        {
            double resultado = (Nota1 + Nota2 + Nota3) / 3;
            return resultado;
        }

        public string MensajeNota(double NotaFinal)
        {
            if (NotaFinal >= 0 && NotaFinal <= 59)
            {
                return "Reprobado";
            }
            else if (NotaFinal >= 60 && NotaFinal <= 79)
            {
                return "Bueno";
            }
            else if (NotaFinal >= 80 && NotaFinal <= 89)
            {
                return "Muy Bueno";
            }
            else if (NotaFinal >= 90 && NotaFinal <= 100)
            {
                return "Sobresaliente";
            }
            else
            {
                return "a nota ingresada no esta en el rango";
            }
        }
    }
}
