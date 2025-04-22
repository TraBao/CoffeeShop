using Coffee.Models.Interface;
using coffeeshop.Models.Services;
using Microsoft.AspNetCore.Mvc;

namespace Coffee.Controllers
{
        public class ProductsController : Controller
        {
          private readonly IProductRepository _productRepository;
    
          public ProductsController(IProductRepository productRepository)
          {
                _productRepository = productRepository;
          }
    
          public IActionResult Shop()
          {
                return View();
          }
        }
}
