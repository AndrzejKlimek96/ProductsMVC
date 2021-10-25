using Bogus;
using Products.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Products.Services
{
    public class HardCodedMovieData : IMovieDataInterface
    {

        static List<MovieModel> moviesList = new List<MovieModel>();
        public int Delete(MovieModel product)
        {
            throw new NotImplementedException();
        }

        public List<MovieModel> GetAllProducts()
        {
            if (moviesList.Count == 0)
            {

           
                for (int i = 0; i < 100; i++)
                {
                    moviesList.Add(new Faker<MovieModel>()
                        .RuleFor(p => p.Id, i)
                        .RuleFor(p => p.Name, f => f.Commerce.ProductName())
                        .RuleFor(p => p.CreationDate, f => f.Date.Past())
                        .RuleFor(p => p.Category, f => f.Commerce.Department())

                        );
                }


            }






            return moviesList;
        }

        public MovieModel GetProductById(int id)
        {
            throw new NotImplementedException();
        }

        public int Insert(MovieModel product)
        {
            throw new NotImplementedException();
        }

        public List<MovieModel> SearchProducts(string searchTerm)
        {
            throw new NotImplementedException();
        }

        public int Update(MovieModel product)
        {
            throw new NotImplementedException();
        }
    }
}
