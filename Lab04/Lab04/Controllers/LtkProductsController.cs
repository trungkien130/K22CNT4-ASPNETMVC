using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Lab04.Models;

namespace Lab04.Controllers
{
    public class LtkProductsController : Controller
    {
        private readonly IProductRepository _productRepository;

        public LtkProductsController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public ActionResult Index()
        {
            {
                IEnumerable<Lab04.Models.Products> products = _productRepository.GetAllProducts(); // Using the repository to get products
                return View(products);
            }
        }
        public ActionResult Details(string id)
        {
            var product = _productRepository.GetProductById(id);
            if (product == null)
            {
                return HttpNotFound();
            }
            return View(product);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Products product)
        {
            if (ModelState.IsValid)
            {
                _productRepository.AddProduct(product);
                return RedirectToAction("Index");
            }
            return View(product);
        }

        public ActionResult LTK_Edit(string id)
        {
            var product = _productRepository.GetProductById(id);
            if (product == null)
            {
                return HttpNotFound();
            }
            return View(product);
        }

        [HttpPost]
        public ActionResult Edit(Products product)
        {
            if (ModelState.IsValid)
            {
                _productRepository.UpdateProduct(product);
                return RedirectToAction("Index");
            }
            return View(product);
        }

        public ActionResult Delete(string id)
        {
            var product = _productRepository.GetProductById(id);
            if (product == null)
            {
                return HttpNotFound();
            }
            return View(product);
        }

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(string id)
        {
            _productRepository.DeleteProduct(id);
            return RedirectToAction("Index");
        }
    }
}
