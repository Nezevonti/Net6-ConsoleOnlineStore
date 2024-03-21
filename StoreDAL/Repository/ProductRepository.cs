using StoreDAL.Data.InitDataFactory;
using StoreDAL.Data;
using StoreDAL.Entities;
using StoreDAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace StoreDAL.Repository
{
    public class ProductRepository : IProductRepository
    {
        
        private readonly StoreDbContext shopContext;

        public ProductRepository()
        {
            var factory = new StoreDbFactory(new TestDataFactory());
            this.shopContext = factory.CreateContext();
        }

        public void Add(Product entity)
        {
            try
            {
                using(this.shopContext)
                {
                    this.shopContext.Products.Add(entity);
                    this.shopContext.SaveChanges();
                }
            }
            catch(Exception e)
            {
                throw e;
            }

        }

        public void Delete(Product entity)
        {
            try
            {
                using (this.shopContext)
                {
                    this.shopContext.Products.Remove(entity);
                    this.shopContext.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void DeleteById(int id)
        {
            try
            {
                using (this.shopContext)
                {
                    var entity = new Product();
                    entity.Id = id;
                    this.shopContext.Products.Remove(entity);
                    this.shopContext.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public IEnumerable<Product> GetAll()
        {
            List<Product> products = new List<Product>();

            this.shopContext.Products.Load();
            this.shopContext.Manufacturers.Load();
            this.shopContext.ProductTitles.Load();
            this.shopContext.Categories.Load();
            try
            {
                using (this.shopContext)
                {
                    var all_products= this.shopContext.Products.OrderBy(t => t.Id);

                    foreach (var product in all_products)
                    {
                        products.Add(product);  
                    }
                }
            }
            catch (Exception e)
            {
                throw e;
            }

            return products;
        }

        public IEnumerable<Product> GetAll(int pageNumber, int rowCount)
        {
            List<Product> products = new List<Product>();

            this.shopContext.Products.Load();
            this.shopContext.Manufacturers.Load();
            this.shopContext.ProductTitles.Load();
            this.shopContext.Categories.Load();
            try
            {
                using (this.shopContext)
                {
                    var all_products = this.shopContext.Products.OrderBy(t => t.Id);

                    foreach (var product in all_products)
                    {
                        products.Add(product);
                    }
                }
            }
            catch (Exception e)
            {
                throw e;
            }

            return products;
        }

        public Product GetById(int id)
        {
            Product product;

            this.shopContext.Products.Load();
            this.shopContext.Manufacturers.Load();
            this.shopContext.ProductTitles.Load();
            this.shopContext.Categories.Load();
            try
            {
                using (this.shopContext)
                {
                    product = this.shopContext.Products.Where(t => t.Id == id).First();

                    
                }
            }
            catch (Exception e)
            {
                throw e;
            }

            return product;
        }

        public void Update(Product entity)
        {
            try
            {
                using (this.shopContext)
                {
                    this.shopContext.Products.Update(entity);
                    this.shopContext.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}