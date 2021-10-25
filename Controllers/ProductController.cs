using Bogus;
using Microsoft.AspNetCore.Mvc;
using Products.Models;
using Products.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Products.Controllers
{
    public class ProductController : Controller
    {
        ProductsDAO repository;
        public ProductController()
        {
            repository = new ProductsDAO();
        }


       public IActionResult Index()
        {
            return View(repository.GetAllProducts());
        }
        
        public IActionResult SearchResult(string searchTerm)
        {

            List<ProductModel> prodcutList = repository.SearchProducts(searchTerm);


            return View("index", prodcutList);
        }
        public IActionResult SearchForm()
        {

            return View();
        }
        
        public IActionResult ShowDetails(int id)
        {

            ProductModel foundProduct = repository.GetProductById(id);
            return View(foundProduct);

        }
        public IActionResult Edit(int id)
        {

            ProductModel foundProduct = repository.GetProductById(id);
            return View("ShowEdit",foundProduct);

        }
        public IActionResult ProcessEdit(ProductModel product)
        {

            repository.Update(product);
            return View("Index", repository.GetAllProducts());

        }
        public IActionResult Delete(int id)
        {

            ProductModel product = repository.GetProductById(id);
            repository.Delete(product);
            return View("Index", repository.GetAllProducts());

        }
        public IActionResult Create(int id)
        {
            return View("ProcessCreate");

        }
        public IActionResult ProcessCreate(ProductModel product)
        {

            repository.Insert(product);
            return View("Index", repository.GetAllProducts());

        }

        public IActionResult ShowOneProductJSON(int id)
        {

            return Json(repository.GetProductById(id));
        }
        public IActionResult ProcessEditReturnPartial(ProductModel product)
        {

            repository.Update(product);
            return PartialView("_productCard", product);

        }



    }
}
