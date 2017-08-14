using System;
using System.Collections.Generic;
using Ulatina.PruebaProyecto.Model;

namespace Especificaciones
{
    internal class Estudiantes
    {
        public Estudiantes()
        {
        }

        internal IList<Estudiante> ListarTodos()
        {
            IList<Estudiante> resultado;
            var miRepositorio = new Repositorio.Estudiantes();
            resultado = miRepositorio.ListarTodos();
            return resultado;
        }

        internal IList<EstudianteCurso> ListarCursosPorEstudiante(int IdEstudiante)
        {
            IList<EstudianteCurso> resultado;
            var miRepositorio = new Repositorio.Estudiantes();
            resultado = miRepositorio.ListarCursosPorEstudiante(IdEstudiante);
            return resultado;
        }

        internal IList<EstudianteCurso> ListarEstudiantesPorCurso(int IdCurso, int Ano, byte Unidad)
        {
            IList<EstudianteCurso> resultado;
            var miRepositorio = new Repositorio.Estudiantes();
            resultado = miRepositorio.ListarEstudiantesPorCurso(IdCurso, Ano, Unidad);
            return resultado;
        }
    }
}