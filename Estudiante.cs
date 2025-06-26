using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudiantesPorAsignatura
{
    public abstract class Estudiante
    {
        public string Nombre { get; set; }
        public string Matricula { get; set; }
        public double NotaExamen { get; set; }
        public double NotaPractica { get; set; }

        public abstract double CalcularNotaFinal();

        public virtual string MostrarDatos()
        {
            return $"{Nombre} - {Matricula}";
        }
    }

    // Estudiante presencial
    public class EstudiantePresencial : Estudiante
    {
        public override double CalcularNotaFinal()
        {
            return (NotaExamen * 0.6) + (NotaPractica * 0.4);
        }
    }

    // Estudiante que esta a distancia
    public class EstudianteADistancia : Estudiante
    {
        public override double CalcularNotaFinal()
        {
            return (NotaExamen * 0.5) + (NotaPractica * 0.5);
        }
    }
}
