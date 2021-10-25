using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Products.Models
{
    public class ProductModelDTO
    {


        [DisplayName("Id number")]
        public int Id { get; set; }


        [DisplayName("Product Name")]
        public string Name { get; set; }

        [DisplayName("Cost of a unit")]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }

        public string PriceString { get; set; }

        [DisplayName("What it is:")]
        public string Description { get; set; }

        public string ShortDescription { get; set; }


        public decimal Tax { get; set; }


        public ProductModelDTO(int id, string name, decimal price, string description)
        {
            Id = id;
            Name = name;
            Price = price;
            Description = description;

            PriceString = string.Format("{0:C}", price);
            ShortDescription = description.Length <= 25 ? description : description.Substring(0, 25);
            Tax = price * 0.08M;
        }

        //alternative
        public ProductModelDTO(ProductModel prod)
        {
            Id = prod.Id;
            Name = prod.Name;
            Price = prod.Price;
            Description = prod.Description;

            PriceString = string.Format("{0:C}", prod.Price);
            ShortDescription = prod.Description.Length <= 25 ? prod.Description : prod.Description.Substring(0, 25);
            Tax = prod.Price * 0.08M;
        }


    }
}
