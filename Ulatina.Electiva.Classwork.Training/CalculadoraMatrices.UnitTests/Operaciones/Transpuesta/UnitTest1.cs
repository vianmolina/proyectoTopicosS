using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculadoraMatrices.UnitTests.Operaciones.Transpuesta
{
    [TestClass]
    public class MatrizTranspuesta
    {
        private bool DeterminarSiDosMatricesSonIguales (
                double [,] laPrimeraMatriz, double[,] laSegundaMatriz)
        {
            bool siguenSiendoIguales = 
                (laPrimeraMatriz.GetLength(0) == laSegundaMatriz.GetLength(0) &&
                laPrimeraMatriz.GetLength(1) == laSegundaMatriz.GetLength(1));
            if (siguenSiendoIguales)
            { 
                var cantidadDeFilas = laSegundaMatriz.GetLength(0);
                var cantidadDeColumnas = laSegundaMatriz.GetLength(1);
                for (int j = 0; siguenSiendoIguales && 
                        j < cantidadDeColumnas; j++)
                    for (int i = 0; siguenSiendoIguales && 
                            i < cantidadDeFilas; i++)
                    {
                        siguenSiendoIguales = 
                            laPrimeraMatriz [i, j] == laSegundaMatriz [i, j];
                    }
            }
            return siguenSiendoIguales;
        }

        WcfOperaciones.Dominio.Acciones.Transponer laAccion = new WcfOperaciones.Dominio.Acciones.Transponer();
        double[,] laMatrizDePrueba, elResultadoObtenido, elResultadoEsperado;

        [TestMethod]
        public void DosMatricesDeTresPorTresSonIguales ()
        {
            laMatrizDePrueba = new double[3, 3];
            laMatrizDePrueba[0, 0] = 35.93;
            laMatrizDePrueba[0, 1] = 783.2;
            laMatrizDePrueba[0, 2] = 10.0;
            laMatrizDePrueba[1, 0] = 5.93;
            laMatrizDePrueba[1, 1] = 3.2;
            laMatrizDePrueba[1, 2] = 15.0;
            laMatrizDePrueba[2, 0] = 3.93;
            laMatrizDePrueba[2, 1] = 78.2;
            laMatrizDePrueba[2, 2] = 1.0;

            double [,] laOtraMatriz = new double[3, 3];
            laOtraMatriz[0, 0] = 35.93;
            laOtraMatriz[0, 1] = 783.2;
            laOtraMatriz[0, 2] = 10.0;
            laOtraMatriz[1, 0] = 5.93;
            laOtraMatriz[1, 1] = 3.2;
            laOtraMatriz[1, 2] = 15.0;
            laOtraMatriz[2, 0] = 3.93;
            laOtraMatriz[2, 1] = 78.2;
            laOtraMatriz[2, 2] = 1.0;

            bool elResultadoEsperado = true;
            bool lasMatricesSonIguales = DeterminarSiDosMatricesSonIguales(laMatrizDePrueba, laOtraMatriz);

            Assert.AreEqual(elResultadoEsperado, lasMatricesSonIguales);


        }

        [TestMethod]
        public void DosMatricesDeDosPorTresSonDiferentes()
        {
            laMatrizDePrueba = new double[2, 3];
            laMatrizDePrueba[0, 0] = 35.93;
            laMatrizDePrueba[0, 1] = 783.2;
            laMatrizDePrueba[0, 2] = 10.0;
            laMatrizDePrueba[1, 0] = 5.93;
            laMatrizDePrueba[1, 1] = 3.2;
            laMatrizDePrueba[1, 2] = 15.0;

            double[,] laOtraMatriz = new double[2, 3];
            laOtraMatriz[0, 0] = 35.93;
            laOtraMatriz[0, 1] = 783.2;
            laOtraMatriz[0, 2] = 10.0;
            laOtraMatriz[1, 0] = 5.93;
            laOtraMatriz[1, 1] = 3.2;
            laOtraMatriz[1, 2] = 15.001;

            bool elResultadoEsperado = false;
            bool lasMatricesSonIguales = DeterminarSiDosMatricesSonIguales(laMatrizDePrueba, laOtraMatriz);

            Assert.AreEqual(elResultadoEsperado, lasMatricesSonIguales);


        }

        [TestMethod]
        public void TransponerMatrizUnoPorUno()
        {
            // fijar el escenario de la prueba
            laMatrizDePrueba = new double[1, 1];
            laMatrizDePrueba[0, 0] = 35.93;
            elResultadoEsperado = new double[1, 1];
            elResultadoEsperado[0, 0] = 35.93;

            // invocar al método que se desea probar
            elResultadoObtenido = laAccion.Transpuesta(laMatrizDePrueba);

            // verificar el resultado obtenido
            Assert.IsTrue(
                DeterminarSiDosMatricesSonIguales(
                            elResultadoEsperado, elResultadoObtenido));
        }

        [TestMethod]
        public void TransponerMatrizCuatroPorUno()
        {
            // fijar el escenario de la prueba
            laMatrizDePrueba = new double[4, 1];
            laMatrizDePrueba[0, 0] = 35.93;
            laMatrizDePrueba[1, 0] = 3.93;
            laMatrizDePrueba[2, 0] = 5.93;
            laMatrizDePrueba[3, 0] = 35.3;

            elResultadoEsperado = new double[1, 4];
            elResultadoEsperado[0, 0] = 35.93;
            elResultadoEsperado[0, 1] = 3.93;
            elResultadoEsperado[0, 2] = 5.93;
            elResultadoEsperado[0, 3] = 35.3;

            // invocar al método que se desea probar
            elResultadoObtenido = laAccion.Transpuesta(laMatrizDePrueba);

            // verificar el resultado obtenido
            Assert.IsTrue(
                DeterminarSiDosMatricesSonIguales(
                            elResultadoEsperado, elResultadoObtenido));
        }

        [TestMethod]
        public void TransponerMatrizUnoPorCinco()
        {
        }

        [TestMethod]
        public void TransponerMatrizTresPorTres()
        {
        }

    }
}
