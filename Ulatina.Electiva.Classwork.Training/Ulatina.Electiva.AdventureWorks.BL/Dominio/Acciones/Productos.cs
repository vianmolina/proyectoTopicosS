using System;
using System.Collections.Generic;
using System.Data.Entity;
using Ulatina.Electiva.AdventureWorks.Model;

namespace Ulatina.Electiva.AdventureWorks.BL.Acciones
{
    public class Productos
    {
        public DbContext miContexto;

        public Productos()
        {
        }

        public Productos(DbContext elContexto)
        {
            miContexto = elContexto;
        }

        public Product BuscarProductoPorNumero(string miNumeroDeProducto)
        {
            Product elResultado;
            Especificaciones.Productos laEspecificacion;
            if (miContexto == null)
                laEspecificacion = new Especificaciones.Productos();
            else
                laEspecificacion = new Especificaciones.Productos(miContexto);

            elResultado = laEspecificacion.BusqueProductoPorNumero(miNumeroDeProducto);

            return elResultado;
        }

        internal IList<Product> ListarProductos()
        {
            Especificaciones.Productos laEspecificacion;
            if (miContexto == null)
                laEspecificacion = new Especificaciones.Productos();
            else
                laEspecificacion = new Especificaciones.Productos(miContexto);

            var elResultado = laEspecificacion.ListarProductos();

            return elResultado;
        }

        public IList<Product> ConsultarPorNombreDeProducto(string elNombreDelProducto)
        {
            Especificaciones.Productos laEspecificacion;
            if (miContexto == null)
                laEspecificacion = new Especificaciones.Productos();
            else
                laEspecificacion = new Especificaciones.Productos(miContexto);

            var elResultado = laEspecificacion.ConsultePorNombreDeProducto(elNombreDelProducto);

            return elResultado;
        }
    }
}