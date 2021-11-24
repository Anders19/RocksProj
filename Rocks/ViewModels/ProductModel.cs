using Rockstore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rockstore.ViewModels
{
    public class ProductModel
    {
        public List<Product> _products { get; set; }

        public List<Product> findAll()
        {
            _products = new List<Product>{new Product()
            {
                Id = "1", Name = "Jagged Rocks", Photo = "thumb1.jpg", Price = 3.99
            },
            new Product()
            {
                Id = "2",Name="Round Rocks",Photo="thumb2.jpg", Price=4.99
            },
            new Product()
            {
                Id = "3",Name="Smooth Flat Rocks",Photo="thumb3.jpg", Price=7.99
            },
              new Product()
            {
                Id = "4",Name="Small Rocks",Photo="thumb4.jpg", Price=1.99
            },
            new Product()
            {
                Id = "5",Name="Large Rock",Photo="thumb5.jpg", Price=16.99
            },
            new Product()
            {
                Id = "6",Name="Huge Rock",Photo="thumb6.jpg", Price=399.99
            },
              new Product()
            {
                Id = "7",Name="Medium Rock",Photo="thumb7.jpg", Price=6.99
            },
              new Product()
            {
                Id = "8",Name="Jagged Flat Rocks",Photo="thumb8.jpg", Price=5.99
            },
            new Product()
            {
                Id = "8",Name="Single Rock",Photo="thumb9.jpg", Price=2.99
            },
              new Product()
            {
                Id = "10",Name="Multiple Rocks",Photo="thumb10.jpg", Price=14.99
            }



            };

            return _products;
        }


        public Product find(string id)
        {
            // var returnedObj = SessionHelper.GetObjectFromJson<List<Product>>(HttpContext.Session, "ProductList");

            List<Product> products = findAll();

            var prod = products.Where(a => a.Id == id).FirstOrDefault();
            return prod;


        }
    }
}
