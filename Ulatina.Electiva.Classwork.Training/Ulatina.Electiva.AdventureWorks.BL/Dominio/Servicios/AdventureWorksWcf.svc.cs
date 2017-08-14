using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using Ulatina.Electiva.AdventureWorks.Model;

namespace Ulatina.Electiva.AdventureWorks.BL
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class AdventureWorksWcf : IAdventureWorksWcf
    {

        private IList<Model.ProductsViewModel> ConvertirProductEnViewModel (IList<Product> losProductos)
        {
            var elResultado = new List<Model.ProductsViewModel>();
            foreach (var elProducto in losProductos)
            {
                var elNodo = new ProductsViewModel();
                elNodo.Color = elProducto.Color;
                elNodo.ListPrice = elProducto.ListPrice;
                elNodo.ProductID = elProducto.ProductID;
                elNodo.ProductName = elProducto.Name;
                elNodo.ProductNumber = elProducto.ProductNumber;
                elNodo.ProductModelName = (elProducto.ProductModel != null) ? elProducto.ProductModel.Name : string.Empty;
                elNodo.ProductSubCategoryName = (elProducto.ProductSubcategory != null) ? elProducto.ProductSubcategory.Name : string.Empty;
                elNodo.ProductCategoryName = (elProducto.ProductSubcategory != null && elProducto.ProductSubcategory.ProductCategory != null) ? elProducto.ProductSubcategory.ProductCategory.Name : string.Empty;
                elNodo.ProductModelName = (elProducto.ProductModel != null) ? elProducto.ProductModel.Name : string.Empty;
                elResultado.Add(elNodo);
            }
            return elResultado;
        }

        public IList<Model.ProductsViewModel> ListarProductosParaViewModel()
        {
            IList<Product> losProductos;
            var laAccion = new Acciones.Productos();
            losProductos = laAccion.ListarProductos();
            var elResultado = ConvertirProductEnViewModel(losProductos);
            return elResultado;

        }

        public IList<Product> ListarProductos()
        {
            IList<Product> elResultado;
            var laAccion = new Acciones.Productos();
            elResultado = laAccion.ListarProductos();
            return elResultado;

        }
        public Product BuscarProductoPorNumero(string miNumeroDeProducto)
        {
            Product elResultado ;
            var laAccion = new Acciones.Productos();
            elResultado = laAccion.BuscarProductoPorNumero(miNumeroDeProducto);
            return elResultado;
        }

        public IList<Product> ConsultarPorNombreDeProducto(string elNombreDelProducto)
        {
            IList<Product> elResultado;
            var laAccion = new Acciones.Productos();
            elResultado = laAccion.ConsultarPorNombreDeProducto(elNombreDelProducto);
            return elResultado;
        }

        public IList<Product> ConsultarPorColor(string elColor)
        {
            return null;
        }

        public IList<Product> ConsultarPorPrecio(decimal elPrecioMinimo, decimal elPrecioMaximo)
        {
            return null;
        }
        public IList<Product> ConsultarPorTamano(string elTamano, bool incluirNulos)
        {
            return null;
        }

        public IList<Product> ConsultarPorNombreDeCategoria(string elNombreDeLaCategoria)
        {
            return null;
        }

        public IList<Product> ConsultarPorNombreDeSubcategoria(string elNombreDeLaSubcategoria)
        {
            return null;
        }


        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }
    }
}
