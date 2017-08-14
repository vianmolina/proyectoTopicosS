using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Ulatina.Electiva.AdventureWorks.Tests.Acciones
{
    [TestClass]
    public class Productos
    {
        [TestMethod]
        public void BuscarArticulosConNombreBike()
        {
            // fijar el escenario inicial
            var elNombreDeProductoBuscado = "bike";
            IList<Model.Product> losProductosEncontrados;
            int cantidadDeProductosEsperados = 5;
            int cantidadDeProductosReal = 0;

            // invocar al método correspondiente
            var laAccion = new BL.Acciones.Productos();
            losProductosEncontrados = laAccion.ConsultarPorNombreDeProducto(elNombreDeProductoBuscado);
            cantidadDeProductosReal = losProductosEncontrados.Count;

            // comparar los resultados
            Assert.AreEqual(cantidadDeProductosEsperados, cantidadDeProductosReal);
        }
        [TestMethod]
        public void BuscarProductoExistente()
        {
            // fijar el escenario inicial
            var elCodigoDeProductoBuscado = "BL-2036";
            Model.Product elProductoEncontrado;
            Model.Product elProductoEsperado = new Model.Product();
            elProductoEsperado.Name = "Blade";

            // invocar al método correspondiente
            var laAccion = new BL.Acciones.Productos();
            elProductoEncontrado = laAccion.BuscarProductoPorNumero(elCodigoDeProductoBuscado);

            // comparar los resultados
            Assert.IsNotNull(elProductoEncontrado); 
            Assert.AreEqual(elProductoEsperado.Name, elProductoEncontrado.Name);
        }
    }
}
