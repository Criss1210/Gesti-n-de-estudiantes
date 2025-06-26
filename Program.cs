using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudiantesPorAsignatura
{
    class Program
    {
        static void Main(string[] args)
        {


            Grupo grupo = new Grupo { NombreGrupo = "Grupo A" };
            int opcion;

            do
            {
                Console.Clear();
                Console.WriteLine("===== Menú de Gestión de Estudiantes =====");
                Console.WriteLine("1. Agregar estudiante al grupo");
                Console.WriteLine("2. Registrar calificaciones");
                Console.WriteLine("3. Mostrar calificaciones del grupo");
                Console.WriteLine("4. Calcular porcentaje de aprobados");
                Console.WriteLine("0. Salir");
                Console.Write("Seleccione una opción: ");

                if (!int.TryParse(Console.ReadLine(), out opcion))
                {
                    Console.WriteLine("Opción inválida. Presione Enter para continuar...");
                    Console.ReadLine();
                    continue;
                }

                switch (opcion)
                {
                    case 1:
                        AgregarEstudiante(grupo);
                        break;
                    case 2:
                        RegistrarCalificaciones(grupo);
                        break;
                    case 3:
                        grupo.MostrarCalificaciones();
                        Console.ReadLine();
                        break;
                    case 4:
                        Console.WriteLine($"Porcentaje de aprobados: {grupo.CalcularPorcentajeAprobados()}%");
                        Console.ReadLine();
                        break;
                    case 0:
                        Console.WriteLine("Saliendo...");
                        break;
                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }

            } while (opcion != 0);


        }






        static void AgregarEstudiante(Grupo grupo)
        {
            Console.Write("Nombre: ");
            string nombre = Console.ReadLine();

            Console.Write("Matrícula: ");
            string matricula = Console.ReadLine();

            Console.Write("Tipo (1=Presencial, 2=A distancia): ");
            int tipo = int.Parse(Console.ReadLine());

            Estudiante estudiante;
            if (tipo == 1)
                estudiante = new EstudiantePresencial();
            else
                estudiante = new EstudianteADistancia();

            estudiante.Nombre = nombre;
            estudiante.Matricula = matricula;

            var resultado = grupo.AgregarEstudiante(estudiante);
            Console.WriteLine(resultado.Message);
            Console.ReadLine();
        }





        static void RegistrarCalificaciones(Grupo grupo)
        {
            Console.Write("Ingrese matrícula del estudiante: ");
            string matricula = Console.ReadLine();

            var estudiante = grupo.Estudiantes.FirstOrDefault(e => e.Matricula == matricula);

            if (estudiante == null)
            {
                Console.WriteLine("Estudiante no encontrado.");
            }
            else
            {
                Console.Write("Nota del examen: ");
                estudiante.NotaExamen = double.Parse(Console.ReadLine());

                Console.Write("Nota de la práctica: ");
                estudiante.NotaPractica = double.Parse(Console.ReadLine());

                Console.WriteLine("Notas registradas con éxito.");
            }

            Console.ReadLine();
        }




    }
}
