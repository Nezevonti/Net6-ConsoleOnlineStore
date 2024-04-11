using StoreBLL.Models;
using StoreDAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Helpers
{
    internal static class InputHelper
    {
        public static ProductModel ReadProductModel()
        {
            Console.WriteLine("Input Product Id");
            var id = int.Parse(Console.ReadLine());
            Console.WriteLine("Input Product Title Id");
            var title_id = Console.ReadLine();
            Console.WriteLine("Input manufacturer Id");
            var manufacturer_id = Console.ReadLine();
            Console.WriteLine("Input unit price");
            var unit_price = Console.ReadLine();
            Console.WriteLine("Input comment");
            var comment = Console.ReadLine();
            return new ProductModel(id, Int16.Parse(title_id), Int16.Parse(manufacturer_id), decimal.Parse(unit_price), comment);
        }

        public static CustomerOrderModel ReadCustomerOrderModel()
        {
            Console.WriteLine("Input order Id");
            var id = int.Parse(Console.ReadLine());
            Console.WriteLine("Input customer Id");
            var customerId = int.Parse(Console.ReadLine());
            Console.WriteLine("Input operation time");
            var operationTime = Console.ReadLine();
            Console.WriteLine("Input order state Id");
            var stateId = int.Parse(Console.ReadLine());

            return new CustomerOrderModel(id, customerId, operationTime, stateId);
        }

        public static CategoryModel ReadCategoryiModel()
        {
            throw new NotImplementedException();
        }

        public static ManufacturerModel ReadManufacturerModel()
        {
            throw new NotImplementedException();
        }

        public static OrderStateModel ReadOrderStateModel()
        {
            Console.WriteLine("Input State Id");
            var id=int.Parse(Console.ReadLine());
            Console.WriteLine("Input State Name");
            var name = Console.ReadLine();
            return new OrderStateModel(id,name);
            //throw new NotImplementedException();
        }

        public static UserRoleModel ReadUserRoleModel()
        {
            Console.WriteLine("Input User Role Id");
            var id = int.Parse(Console.ReadLine());
            Console.WriteLine("Input User Role Name");
            var name = Console.ReadLine();
            return new UserRoleModel(id, name);
            //throw new NotImplementedException();
        }
    }
}
