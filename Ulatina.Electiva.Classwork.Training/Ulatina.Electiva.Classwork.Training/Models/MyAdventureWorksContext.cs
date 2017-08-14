using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Ulatina.Electiva.Classwork.Training.Models
{
    public class MyAdventureWorksContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public MyAdventureWorksContext() : base("name=MyAdventureWorksContext")
        {
        }

        public System.Data.Entity.DbSet<Ulatina.Electiva.AdventureWorks.Model.Product> Products { get; set; }

        public System.Data.Entity.DbSet<Ulatina.Electiva.AdventureWorks.Model.ProductModel> ProductModels { get; set; }

        public System.Data.Entity.DbSet<Ulatina.Electiva.AdventureWorks.Model.ProductSubcategory> ProductSubcategories { get; set; }
    }
}
