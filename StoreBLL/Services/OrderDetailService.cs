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
    public class OrderDetailService : ICrud
    {
        private IOrderDetailRepository _orderDetailRepository {  get; set; }

        public OrderDetailService(StoreDbContext context)
        {
            this._orderDetailRepository = new OrderDetailRepository(context);
        }

        public void Add(AbstractModel model)
        {
            var castModel = (OrderDetailModel)model;
            _orderDetailRepository.Add(new OrderDetail(castModel.id, castModel.customer_order_id, castModel.product_id, castModel.price, castModel.product_amount));
        }
        public void Delete(int modelId)
        {
            _orderDetailRepository.DeleteById(modelId);
        }
        public IEnumerable<AbstractModel> GetAll()
        {
            return _orderDetailRepository.GetAll().Select(x => new OrderDetailModel(x.Id, x.OrderId, x.ProductId, x.Price, x.ProductAmount));
        }
        public AbstractModel GetById(int id)
        {
            var model = _orderDetailRepository.GetById(id);
            return new OrderDetailModel(model.Id, model.OrderId, model.ProductId, model.Price, model.ProductAmount);
        }
        public void Update(AbstractModel model)
        {
            var castModel = (OrderDetailModel)model;
            _orderDetailRepository.Update(new OrderDetail(castModel.id, castModel.customer_order_id, castModel.product_id, castModel.price, castModel.product_amount));
        }
    }
}
