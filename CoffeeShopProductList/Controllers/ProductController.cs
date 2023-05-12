using CoffeeShopProductList.Models;
using Microsoft.AspNetCore.Mvc;

namespace CoffeeShopProductList.Controllers
{
    public class ProductController : Controller
    {
        private readonly ILogger<ProductController> _logger;
        private readonly CoffeeShopDbContext _coffeeShopDBContext;
        public ProductController(ILogger<ProductController> logger, CoffeeShopDbContext context)
        {
            _logger = logger;
            _coffeeShopDBContext = context;
        }

        public IActionResult Index()
        {
            List<Product> products = _coffeeShopDBContext.Products.ToList();
            return View(products);
        }

        public IActionResult OrderedProducts(Product P)
        {
            List<Product> products = _coffeeShopDBContext.Products.ToList();
            return View(products[P.Id-1]);
        }
    }
}
