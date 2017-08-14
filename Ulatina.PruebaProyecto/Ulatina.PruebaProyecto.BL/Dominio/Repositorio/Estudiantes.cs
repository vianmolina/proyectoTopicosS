using System;
using System.Collections.Generic;
using Ulatina.PruebaProyecto.Model;
using System.Linq;

namespace Repositorio
{
    internal class Estudiantes
    {
        private MyDbEntities _context = new MyDbEntities();

        public Estudiantes()
        {
        }

        internal IList<Estudiante> ListarTodos()
        {
            IList<Estudiante> resultado = _context.Estudiantes.Include("EstudianteCursoes").Include("EstudianteCursoes.Curso").ToList();
            return (resultado);

        }

        internal IList<EstudianteCurso> ListarCursosPorEstudiante(int IdEstudiante)
        {
            IList<EstudianteCurso> resultado = _context.EstudianteCursoes.Include("Curso").Include("Estudiante").Where(ec => ec.IdEstudiante == IdEstudiante).ToList();
            return (resultado);

        }

        internal IList<EstudianteCurso> ListarEstudiantesPorCurso(int IdCurso, int Ano, byte Unidad)
        {
            IList<EstudianteCurso> resultado = _context.EstudianteCursoes.Include("Curso").Include("Estudiante").Where(ec => ec.IdCurso == IdCurso && 
                        ec.Ano == Ano && ec.Unidad == Unidad).ToList();
            return (resultado);
        }

    }
}