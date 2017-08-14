using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CalculadoraMatrices.WcfOperaciones.Dominio.Especificaciones
{
    public class CalculeLaTranspuesta
    {
        public double[,] Transpuesta(double[,] laMatriz)
        {
            var cantidadDeFilas = laMatriz.GetLength(0);
            var cantidadDeColumnas = laMatriz.GetLength(1);
            var cantidadDeFilasTranspuesta = cantidadDeColumnas;
            var cantidadDeColumnasTranspuesta = cantidadDeFilas;
            double[,] elResultado = new double[cantidadDeFilasTranspuesta, cantidadDeColumnasTranspuesta];
            for (int j = 0; j < laMatriz.GetLength(1); j++)
                for (int i = 0; i < laMatriz.GetLength(0); i++)
                {
                    elResultado[j, i] = laMatriz[i, j];
                }
            return elResultado;
        }
    }
}