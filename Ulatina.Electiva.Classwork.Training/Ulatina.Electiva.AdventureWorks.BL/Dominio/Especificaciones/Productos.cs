using System;
using System.Collections.Generic;
using System.Data.Entity;
using Ulatina.Electiva.AdventureWorks.Model;

namespace Especificaciones
{
    internal class Productos
    {
        public DbContext miContexto;

        public Productos()
        {
        }

        public Productos(DbContext elContexto)
        {
            miContexto = elContexto;
        }


        public Product BusqueProductoPorNumero(string miNumeroDeProducto)
        {
            Repositorio.Productos elRepositorio;
            if (miContexto == null)
                elRepositorio = new Repositorio.Productos();
            else
                elRepositorio = new Repositorio.Productos(miContexto);
            var elResultado = elRepositorio.ConsultaProductosPorNumero(miNumeroDeProducto);
            return elResultado;
        }

        internal IList<Product> ConsultePorNombreDeProducto(string elNombreDelProducto)
        {
            Repositorio.Productos elRepositorio;
            if (miContexto == null)
                elRepositorio = new Repositorio.Productos();
            else
                elRepositorio = new Repositorio.Productos(miContexto);
            var elResultado = elRepositorio.ConsultaPorNombreDeProducto(elNombreDelProducto);
            return elResultado;
        }

        internal IList<Product> ListarProductos()
        {
            Repositorio.Productos elRepositorio;
            if (miContexto == null)
                elRepositorio = new Repositorio.Productos();
            else
                elRepositorio = new Repositorio.Productos(miContexto);
            var elResultado = elRepositorio.ListarProductos();
            return elResultado;
        }
    }
}