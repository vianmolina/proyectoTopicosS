using System;
using System.Collections.Generic;
using Ulatina.PruebaProyecto.Model;

namespace Acciones
{
    internal class Estudiantes
    {
        public Estudiantes()
        {
        }

        public IList<Estudiante> ListarTodos()
        {
            IList<Estudiante> resultado;
            var miEspecificacion = new Especificaciones.Estudiantes();
            resultado = miEspecificacion.ListarTodos();
            return resultado;
        }

        public IList<EstudianteCurso> ListarCursosPorEstudiante(int IdEstudiante)
        {
            IList<EstudianteCurso> resultado;
            var miEspecificacion = new Especificaciones.Estudiantes();
            resultado = miEspecificacion.ListarCursosPorEstudiante(IdEstudiante);
            return resultado;
        }

        public IList<EstudianteCurso> ListarEstudiantesPorCurso(int IdCurso, int Ano, byte Unidad)
        {
            IList<EstudianteCurso> resultado;
            var miEspecificacion = new Especificaciones.Estudiantes();
            resultado = miEspecificacion.ListarEstudiantesPorCurso(IdCurso, Ano, Unidad);
            return resultado;
        }
    }
}