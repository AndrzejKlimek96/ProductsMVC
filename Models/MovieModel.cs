using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Products.Models
{
    public class MovieModel
    {


        [DisplayName("Id")]
        public int Id { get; set; }


        [DisplayName("Name of the movie.")]
        public string Name { get; set; }


        [DataType(DataType.Date)]
        [DisplayName("Date of creation")]
        public DateTime CreationDate { get; set; }


        [DisplayName("Movie category")]
        public string Category { get; set; }


    }
}
