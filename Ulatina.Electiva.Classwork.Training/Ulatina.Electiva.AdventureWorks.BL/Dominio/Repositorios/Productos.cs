using System;
using System.Linq;
using System.Collections.Generic;
using System.Data.Entity;
using Ulatina.Electiva.AdventureWorks.Model;
using Ulatina.Topicos.GenericRepository;

namespace Repositorio
{
    internal class Productos
    {
        // contexto
 //       private static AdventureWorks2014Entities miContexto = new AdventureWorks2014Entities();
        private static DbContext miContexto;

        private readonly EntityFrameworkRepository<DbContext> _Repository;

        private readonly string _includeTables = "ProductSubCategory, ProductModel, ProductSubCategory.ProductCategory";
        private readonly string _noIncludeTables = string.Empty;

        public Productos()
        {
            miContexto = new AdventureWorks2014Entities();
            _Repository = new EntityFrameworkRepository<DbContext>(miContexto);
        }

        public Productos(DbContext elContexto)
        {
            miContexto = elContexto;
            _Repository = new EntityFrameworkRepository<DbContext>(miContexto);
        }

        internal IList<Product> ConsultaPorNombreDeProducto(string elNombreDelProducto)
        {
            // para usar el .ToList(), se requiere haber incluido el System.Linq;
            var losProductos = _Repository.Get<Product>(p => p.Name.Contains(elNombreDelProducto), null, _includeTables, null, null).ToList();
            return losProductos;
        }

        internal Product ConsultaProductosPorNumero(string miNumeroDeProducto)
        {
            var elProducto = _Repository.GetOne<Product>(p => p.ProductNumber.Equals(miNumeroDeProducto), _includeTables);
            return elProducto;
        }

        internal IList<Product> ListarProductos()
        {
            // para usar el .ToList(), se requiere haber incluido el System.Linq;
            var losProductos = _Repository.GetAll<Product>(null, _includeTables, null, null).ToList();
            return losProductos;
        }
    }
}