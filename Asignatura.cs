using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudiantesPorAsignatura
{
    public class Asignatura
    {
        public string Nombre { get; set; }
        public List<Grupo> Grupos { get; set; } = new List<Grupo>();
    }
}
