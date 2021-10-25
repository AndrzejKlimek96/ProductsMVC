using Products.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Products.Services
{
    interface IMovieDataInterface
    {
        List<MovieModel> GetAllProducts();
        List<MovieModel> SearchProducts(string searchTerm);

        MovieModel GetProductById(int id);

        int Insert(MovieModel product);

        int Delete(MovieModel product);

        int Update(MovieModel product);


    }
}
