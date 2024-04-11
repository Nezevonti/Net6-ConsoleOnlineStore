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
    public class CustomerOrderService : ICrud
    {
        private ICustomerOrderRepository _customerOrderRepository {  get; set; }
        public CustomerOrderService(StoreDbContext context)
        { 
            _customerOrderRepository = new CustomerOrderRepository(context);
        }
        public void Add(AbstractModel model)
        {
            var order = (CustomerOrderModel)model;
            _customerOrderRepository.Add(new CustomerOrder(order.Id, order.operation_time, order.customer_id, order.order_state_id));
        }
        public void Delete(int modelId)
        {
            _customerOrderRepository.DeleteById(modelId);
        }
        public IEnumerable<AbstractModel> GetAll()
        {
            return _customerOrderRepository.GetAll().Select(x => new CustomerOrderModel(x.Id,x.UserId, x.OperationTime, x.OrderStateId));
        }
        public AbstractModel GetById(int id)
        {
            var model = _customerOrderRepository.GetById(id);
            return new CustomerOrderModel(model.Id, model.UserId, model.OperationTime, model.OrderStateId);
        }
        public void Update(AbstractModel model)
        {
            var localModel = (CustomerOrderModel)model;
            _customerOrderRepository.Update(new CustomerOrder(localModel.Id, localModel.operation_time, localModel.customer_id, localModel.order_state_id));
        }
    }
}
