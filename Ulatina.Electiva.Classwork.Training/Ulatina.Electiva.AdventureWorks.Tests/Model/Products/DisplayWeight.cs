using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//tarea moral
/// <summary>
/// complete los métodos de esta clase
/// cree una clase hermana de la propiedad DisplayWeight que se llame DisplaySize que funcione similar a ella, sólo que utilizando los campos de medida.
/// cree una clase de unit testing similar a este archivo para automatizar las pruebas sobre la propiedad DisplaySize
/// cree dos propiedades adicionales, hermanasd de DisplayWeight y DisplaySize, que desplieguen las medidas del artículo en pulgadas (para el caso del tamaño) o en kilos (en el caso del peso) y créeles pruebas unitarias similares.
/// </summary>

namespace Ulatina.Electiva.AdventureWorks.Tests
{
    [TestClass]
    public class DisplayWeight
    {
        [TestMethod]
        public void NuloYNulo()
        {

        }
        [TestMethod]
        public void TreintaYOchoYMedioNulo()
        {

        }
        [TestMethod]
        public void VeinticincoKilos ()
        {
            var elProducto = new Model.Product();
            elProducto.Weight = 25;
            elProducto.WeightUnitMeasureCode = "kg";

            string elResultadoEsperado = "25 kg";
            string elResultadoReal = elProducto.DisplayWeight;

            Assert.AreEqual(elResultadoEsperado, elResultadoReal);
        }
    }
}
