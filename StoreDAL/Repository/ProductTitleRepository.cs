using Microsoft.EntityFrameworkCore;
using StoreDAL.Data;
using StoreDAL.Entities;
using StoreDAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreDAL.Repository
{
    public class ProductTitleRepository : AbstractRepository,IProductTitleRepository
    {
        private readonly DbSet<ProductTitle> dbSet;

        public ProductTitleRepository(StoreDbContext context) : base(context)
        {
            dbSet = context.Set<ProductTitle>();
        }

        public void Add(ProductTitle entity)
        {
            dbSet.Add(entity);
            context.SaveChanges();
        }

        public void Delete(ProductTitle entity)
        {
            dbSet.Remove(entity);
            context.SaveChanges();
        }

        public void DeleteById(int id)
        {
            var entity = dbSet.Find(id);
            if (entity != null)
            {
                Delete(entity);
            }
        }

        public IEnumerable<ProductTitle> GetAll()
        {
            return dbSet.ToList();
        }

        public IEnumerable<ProductTitle> GetAll(int pageNumber, int rowCount)
        {
            return dbSet.OrderByDescending(x => x.Id).Where(x => x.Id >= ((pageNumber - 1) * rowCount)).Take(rowCount).ToList();
        }

        public ProductTitle GetById(int id)
        {
            return dbSet.Find(id);
        }

        public void Update(ProductTitle entity)
        {
            dbSet.Update(entity);
            context.SaveChanges();
        }
    }
}
