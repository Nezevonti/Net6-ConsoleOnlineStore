﻿using Microsoft.EntityFrameworkCore;
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
    public class UserRoleRepository : AbstractRepository, IUserRoleRepository
    {
        private readonly DbSet<UserRole> dbSet;
        public UserRoleRepository(StoreDbContext context) : base(context)
        {
            dbSet = context.Set<UserRole>();
        }
        public void Add(UserRole entity)
        {
            dbSet.Add(entity);
            context.SaveChanges();
        }

        public void Delete(UserRole entity)
        {
            dbSet.Remove(entity);
        }

        public void DeleteById(int id)
        {
            var entity = dbSet.Find(id);
            if (entity != null)
            {
                dbSet.Remove(entity);
                context.SaveChanges();
            }
        }

        public IEnumerable<UserRole> GetAll()
        {
            return dbSet.ToList();
        }

        public IEnumerable<UserRole> GetAll(int pageNumber, int RowCount)
        {
            return dbSet.OrderByDescending(x => x.Id).Where(x => x.Id >= ((pageNumber-1)*RowCount)).Take(RowCount).ToList();
        }

        public UserRole GetById(int id)
        {
            return dbSet.Find(id);
        }

        public void Update(UserRole entity)
        {
            dbSet.Update(entity);
            context.SaveChanges();
        }
    }
}
