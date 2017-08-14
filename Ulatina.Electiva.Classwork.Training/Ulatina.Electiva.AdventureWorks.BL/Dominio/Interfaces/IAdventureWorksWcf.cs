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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IAdventureWorksWcf
    {

        [OperationContract]
        string GetData(int value);

        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);

        // TODO: Add your service operations here

        [OperationContract]
        IList<Model.ProductsViewModel> ListarProductosParaViewModel();
        [OperationContract]
        IList<Product> ListarProductos();
        [OperationContract]
        Product BuscarProductoPorNumero(string miNumeroDeProducto);
        [OperationContract]
        IList<Product> ConsultarPorNombreDeProducto(string elNombreDelProducto);
        [OperationContract]
        IList<Product> ConsultarPorColor(string elColor);
        [OperationContract]
        IList<Product> ConsultarPorPrecio(decimal elPrecioMinimo, decimal elPrecioMaximo);
        [OperationContract]
        IList<Product> ConsultarPorTamano(string elTamano, bool incluirNulos);
        IList<Product> ConsultarPorNombreDeCategoria(string elNombreDeLaCategoria);
        [OperationContract]
        IList<Product> ConsultarPorNombreDeSubcategoria(string elNombreDeLaSubcategoria);
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
}
