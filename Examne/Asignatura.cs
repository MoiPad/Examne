using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examne
{
    public class Asignatura : Alumno
    {
        public string Nombre { get; set; }
        public string Horario { get; set; }
        public string Docente { get; set; }

        public  override void Imprimir() 
        {
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Numero de cuenta: {NumeroCuenta}");
            Console.WriteLine($"Email: {Email}");
            Console.WriteLine($"Nombre de la asignatura: {Nombre}");
            Console.WriteLine($"Horario: {Horario}");
            Console.WriteLine($"Docente: {Docente}");
        }

    }
}
