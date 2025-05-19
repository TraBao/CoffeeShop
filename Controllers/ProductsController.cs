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
        public IActionResult Detail(int id)
        {
            var product = _productRepository.GetProductDetail(id);
            if (product != null)
            {
                return View(product);
            }
            return NotFound();
        }
    }
}
