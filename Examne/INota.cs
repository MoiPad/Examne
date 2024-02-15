using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examne
{
    public interface INota
    {
        public double CalcularNotaFinal(double Nota1, double Nota2, double Nota3);


        public string MensajeNota(double NotaFinal);
    
    
    }
}
