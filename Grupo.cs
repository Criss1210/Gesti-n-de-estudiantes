using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudiantesPorAsignatura
{
    public class Grupo
    {
        public string NombreGrupo { get; set; }
        public List<Estudiante> Estudiantes { get; set; } = new List<Estudiante>();

        public OperationResult AgregarEstudiante(Estudiante estudiante)
        {
            Estudiantes.Add(estudiante);
            return new OperationResult("Estudiante agregado correctamente", true, estudiante);
        }

        public void MostrarCalificaciones()
        {
            foreach (var estudiante in Estudiantes)
            {
                Console.WriteLine($"{estudiante.MostrarDatos()} - Nota final: {estudiante.CalcularNotaFinal()}");
            }
        }

        public double CalcularPorcentajeAprobados()
        {
            if (Estudiantes.Count == 0) return 0;

            int aprobados = Estudiantes.Count(e => e.CalcularNotaFinal() >= 70);
            return (aprobados * 100.0) / Estudiantes.Count;
        }
    }
}
