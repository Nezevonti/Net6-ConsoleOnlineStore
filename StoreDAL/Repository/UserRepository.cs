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
    public class UserRepository : AbstractRepository,IUserRepository
    {
        private readonly DbSet<User> dbSet;

        public UserRepository(StoreDbContext context) : base(context)
        {
            dbSet = context.Set<User>();
        }

        public void Add(User entity)
        {
            entity.Password = entity.Password.ToArray().Reverse().ToString();//Not SRP, add encryptor class
            dbSet.Add(entity);
            context.SaveChanges();
        }

        public void Delete(User entity)
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

        public IEnumerable<User> GetAll()
        {
            return dbSet.ToList();
        }

        public IEnumerable<User> GetAll(int pageNumber, int rowCount)
        {
            return dbSet.OrderByDescending(x => x.Id).Where(x => x.Id >= ((pageNumber - 1) * rowCount)).Take(rowCount).ToList();
        }

        public User GetById(int id)
        {
            return dbSet.Find(id);
        }

        public void Update(User entity)
        {
            entity.Password = entity.Password.ToArray().Reverse().ToString(); //Not SRP, add encryptor class
            dbSet.Update(entity);
            context.SaveChanges();
        }
    }
}
