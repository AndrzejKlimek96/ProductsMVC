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
    [ApiController]
    [Route("api/")]


    public class ProductControllerAPI : ControllerBase
    {
        ProductsDAO repository;
        public ProductControllerAPI()
        {
            repository = new ProductsDAO();
        }

        [HttpGet]
        public ActionResult<IEnumerable<ProductModelDTO>> Index()
        {


            List<ProductModel> products = repository.GetAllProducts();
            List<ProductModelDTO> productDTOs = new List<ProductModelDTO>();
            foreach (var p in products)
            {
                productDTOs.Add(new ProductModelDTO(p));
            }

            return productDTOs;
        }

        [HttpGet("searchproducts/{searchTerm}")]
        public ActionResult<IEnumerable<ProductModel>> SearchProducts(string searchTerm)
        {

            return repository.SearchProducts(searchTerm);
        }

        [HttpGet("ShowOneProduct/{Id}")]
        public ActionResult<ProductModelDTO> ShowOneProduct(int Id)
        {
            ProductModel prod = repository.GetProductById(Id);
            ProductModelDTO pDTO = new ProductModelDTO(prod);

            return pDTO;

        }

        [HttpPost("InsertOne")]
        public ActionResult<int> InsertOne(ProductModel product)
        {

            int newId = repository.Insert(product);
            return newId;

        }

        [HttpPut("ProcessEdit")]
        public ActionResult<ProductModel> ProcessEdit(ProductModel product)
        {

            repository.Update(product);
            return repository.GetProductById(product.Id);

        }

        [HttpDelete("DeleteOne/{Id}")]
        public ActionResult <bool> DeleteOne(int Id)
        {

            ProductModel toDelete = repository.GetProductById(Id);
            bool success = repository.Delete(toDelete);
            return success;

        }

    }
}
