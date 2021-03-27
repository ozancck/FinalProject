using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products;
        public InMemoryProductDal()
        {
            _products = new List<Product>
            {
              new Product{ProductId=1, CategoryId=1, ProductName="Çatal", UnitPrice=15, UnitsInStock=15 },
              new Product{ProductId=2, CategoryId=1, ProductName="Telefon", UnitPrice=1000, UnitsInStock=15 },
              new Product{ProductId=3, CategoryId=2, ProductName="Bardak", UnitPrice=15, UnitsInStock=30 },
              new Product{ProductId=4, CategoryId=2, ProductName="kitap", UnitPrice=1, UnitsInStock=42 },
              new Product{ProductId=5, CategoryId=2, ProductName="defter", UnitPrice=2, UnitsInStock=10 },
              new Product{ProductId=6, CategoryId=3, ProductName="ataç", UnitPrice=3, UnitsInStock=16 },
            };
        }
        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            Product productToDelete = _products.SingleOrDefault(p => p.ProductId == product.ProductId);

            _products.Remove(productToDelete);
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public void Update(Product product)
        {
            Product productToUpdate = _products.SingleOrDefault(p => p.ProductId == product.ProductId);

            productToUpdate.ProductName = product.ProductName;
            productToUpdate.CategoryId = product.CategoryId;
            productToUpdate.UnitPrice = product.UnitPrice;
            productToUpdate.UnitsInStock = productToUpdate.UnitsInStock;
        }

        public List<Product> GetByCategory(int categoryId)
        {
          return  _products.Where(p => p.CategoryId == categoryId).ToList();
        }
    }

    
    }

