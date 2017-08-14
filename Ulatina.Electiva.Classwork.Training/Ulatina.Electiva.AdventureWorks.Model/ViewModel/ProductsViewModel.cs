using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Ulatina.Electiva.AdventureWorks.Model
{
    [DataContract]
    public class ProductsViewModel
    {
        [DataMember]
        public int ProductID { get; set; }
        [DataMember]
        public string ProductName { get; set; }
        [DataMember]
        public string ProductNumber { get; set; }
        [DataMember]
        public string Color { get; set; }
        [DataMember]
        public decimal ListPrice { get; set; }
        [DataMember]
        public string ProductSubCategoryName { get; set; }
        [DataMember]
        public string ProductCategoryName { get; set; }
        [DataMember]
        public string ProductModelName { get; set; }
    }
}