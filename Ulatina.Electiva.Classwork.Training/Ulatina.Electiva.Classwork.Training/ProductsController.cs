using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Ulatina.Electiva.AdventureWorks.Model;
using Ulatina.Electiva.Classwork.Training.Models;

namespace Ulatina.Electiva.Classwork.Training
{
    public class ProductsController : Controller
    {
        private IList<AdventureWorks.Model.ProductsViewModel> ConvertirProductEnViewModel(IList<Product> losProductos)
        {
            var elResultado = new List<AdventureWorks.Model.ProductsViewModel>();
            foreach (var elProducto in losProductos)
            {
                var elNodo = new AdventureWorks.Model.ProductsViewModel();
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


        private MyAdventureWorksContext db = new MyAdventureWorksContext();

        // GET: Products
        public ActionResult IndexViewModel()
        {
            var elCliente = new SI.AdventureWorks.AdventureWorksWcfClient();
            var products = elCliente.ListarProductosParaViewModel();
            var elResultado = ConvertirProductEnViewModel(products);
            //var products = db.Products.Include(p => p.ProductModel).Include(p => p.ProductSubcategory);
            return View(elResultado.ToList());
        }

        public ActionResult Index()
        {
            var elCliente = new SI.AdventureWorks.AdventureWorksWcfClient();
            var products = elCliente.ListarProductos();
            //var products = db.Products.Include(p => p.ProductModel).Include(p => p.ProductSubcategory);
            return View(products.ToList());
        }

        // GET: Products/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Product product = db.Products.Find(id);
            if (product == null)
            {
                return HttpNotFound();
            }
            return View(product);
        }

        // GET: Products/Create
        public ActionResult Create()
        {
            ViewBag.ProductModelID = new SelectList(db.ProductModels, "ProductModelID", "Name");
            ViewBag.ProductSubcategoryID = new SelectList(db.ProductSubcategories, "ProductSubcategoryID", "Name");
            return View();
        }

        // POST: Products/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ProductID,Name,ProductNumber,MakeFlag,FinishedGoodsFlag,Color,SafetyStockLevel,ReorderPoint,StandardCost,ListPrice,Size,SizeUnitMeasureCode,WeightUnitMeasureCode,Weight,DaysToManufacture,ProductLine,Class,Style,ProductSubcategoryID,ProductModelID,SellStartDate,SellEndDate,DiscontinuedDate,rowguid,ModifiedDate,_Name,_CreatedDate,_ModifiedDate,_CreatedBy,_ModifiedBy,_Version")] Product product)
        {
            if (ModelState.IsValid)
            {
                db.Products.Add(product);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ProductModelID = new SelectList(db.ProductModels, "ProductModelID", "Name", product.ProductModelID);
            ViewBag.ProductSubcategoryID = new SelectList(db.ProductSubcategories, "ProductSubcategoryID", "Name", product.ProductSubcategoryID);
            return View(product);
        }

        // GET: Products/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Product product = db.Products.Find(id);
            if (product == null)
            {
                return HttpNotFound();
            }
            ViewBag.ProductModelID = new SelectList(db.ProductModels, "ProductModelID", "Name", product.ProductModelID);
            ViewBag.ProductSubcategoryID = new SelectList(db.ProductSubcategories, "ProductSubcategoryID", "Name", product.ProductSubcategoryID);
            return View(product);
        }

        // POST: Products/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ProductID,Name,ProductNumber,MakeFlag,FinishedGoodsFlag,Color,SafetyStockLevel,ReorderPoint,StandardCost,ListPrice,Size,SizeUnitMeasureCode,WeightUnitMeasureCode,Weight,DaysToManufacture,ProductLine,Class,Style,ProductSubcategoryID,ProductModelID,SellStartDate,SellEndDate,DiscontinuedDate,rowguid,ModifiedDate,_Name,_CreatedDate,_ModifiedDate,_CreatedBy,_ModifiedBy,_Version")] Product product)
        {
            if (ModelState.IsValid)
            {
                db.Entry(product).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ProductModelID = new SelectList(db.ProductModels, "ProductModelID", "Name", product.ProductModelID);
            ViewBag.ProductSubcategoryID = new SelectList(db.ProductSubcategories, "ProductSubcategoryID", "Name", product.ProductSubcategoryID);
            return View(product);
        }

        // GET: Products/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Product product = db.Products.Find(id);
            if (product == null)
            {
                return HttpNotFound();
            }
            return View(product);
        }

        // POST: Products/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Product product = db.Products.Find(id);
            db.Products.Remove(product);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
