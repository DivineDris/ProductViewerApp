using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using ProductViewerApp.Models;

namespace ProductViewerApp.Pages
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Product()

        {

            var products = GetProducts();

            return View(products);

        }

        private List<Product> GetProducts()

        {

            var json = System.IO.File.ReadAllText("wwwroot/products.json");

            return JsonConvert.DeserializeObject<List<Product>>(json);

        }
    }
}
