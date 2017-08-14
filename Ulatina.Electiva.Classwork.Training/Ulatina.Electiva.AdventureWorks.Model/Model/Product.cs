using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ulatina.Topicos.GenericRepository.Model;

namespace Ulatina.Electiva.AdventureWorks.Model
{
    public partial class Product : Entity <Product>
    {
        public string DisplayWeight
        {
            get {
                string elResultado = string.Format("{0} {1}", Weight.ToString(), WeightUnitMeasureCode);

                return elResultado; }
        }

    }
}
