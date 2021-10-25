using Products.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Products.Services
{
    interface IProdctDataService
    {
        List<ProductModel> GetAllProducts();
        List<ProductModel> SearchProducts(string searchTerm);

        ProductModel GetProductById(int id);

        int Insert(ProductModel product);

        bool Delete(ProductModel product);

        int Update(ProductModel product);
    
    
    
    
    }

}
