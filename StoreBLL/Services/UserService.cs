using StoreDAL.Entities;
using StoreDAL.Interfaces;
using StoreBLL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StoreBLL.Models;
using StoreDAL.Data;
using StoreDAL.Repository;

namespace StoreBLL.Services
{
    public class UserService : ICrud
    {
        public IUserRepository Repository { get; set; }

        public UserService(StoreDbContext context)
        {
            Repository = new UserRepository(context);
        }
        public void Add(AbstractModel model)
        {
            var entity = (UserModel)model;
            Repository.Add(new User(entity.Id, entity.FirstName, entity.LastName, entity.Login, entity.Password, entity.User_role_id));
        }
        public void Delete(int modelId)
        {
            Repository.DeleteById(modelId);
        }
        public IEnumerable<AbstractModel> GetAll()
        {
            return Repository.GetAll().Select(x => new UserModel(x.Id,x.Name,x.LastName,x.Login,x.Password,x.RoleId));
        }
        public AbstractModel GetById(int id)
        {
            var entity = Repository.GetById(id);
            return new UserModel(entity.Id, entity.Name, entity.LastName, entity.Login, entity.Password, entity.RoleId);
        }
        public void Update(AbstractModel model)
        {
            var entity = (UserModel)model;
            Repository.Update(new User(entity.Id, entity.FirstName, entity.LastName, entity.Login, entity.Password, entity.User_role_id));
        }
    }
}
