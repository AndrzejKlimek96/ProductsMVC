using Microsoft.AspNetCore.Mvc;
using Products.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Products.Controllers
{
    public class MovieController : Controller
    {
        public IActionResult Index()
        {

            HardCodedMovieData hardCodedMovieData = new HardCodedMovieData();

            return View(hardCodedMovieData.GetAllProducts());
        }

    }
}
