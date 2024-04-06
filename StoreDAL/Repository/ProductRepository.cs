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
    public class ProductRepository : AbstractRepository,IProductRepository
    {

        //private readonly StoreDbContext shopContext;
        private readonly DbSet<Product> dbSet;

        public ProductRepository(StoreDbContext context):base(context)
        {
            this.dbSet = context.Set<Product>();
        }

        public void Add(Product entity)
        {
            try
            {
                this.dbSet.Add(entity);
                context.SaveChanges();
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
                this.dbSet.Remove(entity);
                context.SaveChanges();
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
                var entity = new Product();
                entity.Id = id;
                this.Delete(entity);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public IEnumerable<Product> GetAll()
        {
            return dbSet.ToList();
        }

        public IEnumerable<Product> GetAll(int pageNumber, int rowCount)
        {
            return this.GetAll().Skip(pageNumber*rowCount).Take(rowCount);
        }

        public Product GetById(int id)
        {
            return dbSet.Find(id);
        }

        public void Update(Product entity)
        {
            dbSet.Update(entity);
            context.SaveChanges();
        }
    }
}