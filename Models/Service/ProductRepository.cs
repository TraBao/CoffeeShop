﻿using Coffee.Models.Interface;
using Coffee.Models;
namespace coffeeshop.Models.Services
{
    public class ProductRepository : IProductRepository
    {
        private List<Product> ProductsList = new List<Product>()
 {
 new Product{ Id = 1, Name = "America", Price= 25, Detail="Name product",
ImageUrl="https://index.com"},
 new Product{ Id = 2, Name = "Vietnam", Price= 20, Detail="Vietnamese product",
ImageUrl="https://index.com"},
 new Product{ Id = 3, Name = "United Kingdom", Price= 15, Detail="Name product",
ImageUrl="https://index.com"}
 };
        public IEnumerable<Product> GetAllProducts()
        {
            return ProductsList;
        }
        public Product GetProductDetail(int id)
        {
            return ProductsList.FirstOrDefault(p => p.Id == id);
        }
        public IEnumerable<Product> GetTrendingProducts()
        {
            return ProductsList.Where(p => p.IsTrendingProduct);
        }
    }
}
