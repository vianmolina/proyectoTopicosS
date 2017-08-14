using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CalculadoraMatrices.WcfOperaciones.Dominio.Acciones
{
    public class Transponer
    {
        public double[,] Transpuesta(double[,] laMatriz)
        {
            double[,] elResultado;
            //CalculadoraMatrices.WcfOperaciones.Dominio.Especificaciones.CalculeLaTranspuesta laEspecificacion = new CalculadoraMatrices.WcfOperaciones.Dominio.Especificaciones.CalculeLaTranspuesta();
            //Especificaciones.CalculeLaTranspuesta laEspecificacion = new Especificaciones.CalculeLaTranspuesta();
            var laEspecificacion = new Especificaciones.CalculeLaTranspuesta();
            elResultado = laEspecificacion.Transpuesta(laMatriz);
            return elResultado;
        }
    }
}