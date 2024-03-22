using StoreBLL.Interfaces;
using StoreBLL.Models;
using StoreDAL.Data;
using StoreDAL.Entities;
using StoreDAL.Interfaces;
using StoreDAL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreBLL.Services
{
    public class ProductService : ICrud
    {
        public IProductRepository ProductRepository { get; set; }
        public ProductService(StoreDbContext context)
        {
            ProductRepository = new ProductRepository(context);
        }

        public void Add(AbstractModel model)
        {
            var x = (ProductModel)model;
            ProductRepository.Add(new Product(x.id,x.product_title_id,x.manufacturer_id,x.comment,x.unit_price));

        }
        public void Delete(int modelId)
        {
            ProductRepository.DeleteById(modelId);
        }
        public IEnumerable<AbstractModel> GetAll()
        {
            return ProductRepository.GetAll().Select(x => new ProductModel(x.Id,x.TitleId,x.ManufacturerId,x.UnitPrice,x.Description));
        }
        public AbstractModel GetById(int id)
        {
            var x = ProductRepository.GetById(id);
            return new ProductModel(x.Id, x.TitleId, x.ManufacturerId, x.UnitPrice, x.Description);
        }
        public void Update(AbstractModel model)
        {
            var x = (ProductModel)model;
            ProductRepository.Update(new Product(x.id, x.product_title_id, x.manufacturer_id, x.comment, x.unit_price));
        }
    }
}
