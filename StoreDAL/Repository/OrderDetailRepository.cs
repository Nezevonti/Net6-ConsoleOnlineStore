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
    public class OrderDetailRepository : AbstractRepository,IOrderDetailRepository
    {

        private readonly DbSet<OrderDetail> dbSet;

        public OrderDetailRepository(StoreDbContext context) : base(context)
        {
            this.dbSet = context.Set<OrderDetail>();
        }

        public void Add(OrderDetail entity)
        {
            this.dbSet.Add(entity);
            context.SaveChanges();
        }

        public void Delete(OrderDetail entity)
        {
            this.dbSet.Remove(entity);
            context.SaveChanges();
        }

        public void DeleteById(int id)
        {
            var entity = GetById(id);

            this.Delete(entity);
        }

        public IEnumerable<OrderDetail> GetAll()
        {
            return dbSet.ToList();
        }

        public IEnumerable<OrderDetail> GetAll(int pageNumber, int rowCount)
        {
            return this.GetAll().Skip(pageNumber * rowCount).Take(rowCount);
        }

        public OrderDetail GetById(int id)
        {
            return this.dbSet.First(x => x.Id == id);
        }

        public void Update(OrderDetail entity)
        {
            dbSet.Update(entity);
            context.SaveChanges();
        }
    }
}
