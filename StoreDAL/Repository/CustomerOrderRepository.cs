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
    public class CustomerOrderRepository : AbstractRepository,ICustomerOrderRepository
    {
        private readonly DbSet<CustomerOrder> dbSet;

        public CustomerOrderRepository(StoreDbContext context): base(context)
        {
            this.dbSet = context.Set<CustomerOrder>();
        }
        public void Add(CustomerOrder entity)
        {
            this.dbSet.Add(entity);
            context.SaveChanges();
        }

        public void Delete(CustomerOrder entity)
        {
            this.dbSet.Remove(entity);
            context.SaveChanges();
        }

        public void DeleteById(int id)
        {
            var entity = GetById(id);

            this.Delete(entity);
        }

        public IEnumerable<CustomerOrder> GetAll()
        {
            return dbSet.ToList();
        }

        public IEnumerable<CustomerOrder> GetAll(int pageNumber, int rowCount)
        {
            return this.GetAll().Skip(pageNumber * rowCount).Take(rowCount);
        }

        public CustomerOrder GetById(int id)
        {
            return this.dbSet.First(x => x.Id == id);
        }

        public void Update(CustomerOrder entity)
        {
            dbSet.Update(entity);
            context.SaveChanges();
        }
    }
}
