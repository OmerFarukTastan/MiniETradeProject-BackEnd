﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products;
        public InMemoryProductDal()
        {
            //Sql server data simulation
            _products = new List<Product> 
            {
                new Product{ProductId=1 , CategoryId=1 , ProductName="Bardak" , UnitPrice=15 ,UnitsInStock=15  },
                new Product{ProductId=2 , CategoryId=1 , ProductName="Kamera" , UnitPrice=500 ,UnitsInStock=3   },
                new Product{ProductId=3 , CategoryId=2 , ProductName="Telefon" , UnitPrice=1500 ,UnitsInStock=2  },
                new Product{ProductId=4 , CategoryId=2 , ProductName="Klavye" , UnitPrice=150 ,UnitsInStock=65   },
                new Product{ProductId=5 , CategoryId=2 , ProductName="Fare" , UnitPrice=85 , UnitsInStock=1  }

            };    
        }
        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            //without linq
            /*
            Product produectToDelete;
            foreach (var p in _products)
            {
                if (product.ProductId == p.ProductId)
                {
                    produectToDelete = p;
                }
            }
            */

            //with linq/lambda
            Product produectToDelete = _products.SingleOrDefault(p => p.ProductId == product.ProductId); 

            _products.Remove(product);  

        }

        public List<Product> GetAll()
        {
            return _products;   
        }

        

        public void Update(Product product)
        {
            // Find item from list that assigned to the id that has been send.
            Product produectToUpdate = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            produectToUpdate.ProductName = product.ProductName;
            produectToUpdate.CategoryId = product.CategoryId;   
            produectToUpdate.UnitPrice = product.UnitPrice; 
            produectToUpdate.UnitsInStock = product.UnitsInStock; 
        }
        public List<Product> GetAllByCategory(int CategoryId)

        {
           return _products.Where(p => p.CategoryId == CategoryId).ToList();
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filder = null)
        {
            throw new NotImplementedException();
        }

        public Product Get(Expression<Func<Product, bool>> filder)
        {
            throw new NotImplementedException();
        }

        public List<ProductDetailDto> GetProductDetails()
        {
            throw new NotImplementedException();
        }
    }
}
