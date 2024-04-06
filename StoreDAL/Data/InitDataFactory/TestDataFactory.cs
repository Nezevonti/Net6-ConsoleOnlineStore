using StoreDAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreDAL.Data.InitDataFactory
{
    public class TestDataFactory : AbstractDataFactory
    {
        public override Category[] GetCategoryData()
        {
            return new[]
            {
                new Category(1,"fruits"),
                new Category(2,"water"),
                new Category(3,"vegetables"),
                new Category(4,"seafood"),
                new Category(5,"meet"),
                new Category(6,"grocery"),
                new Category(7,"milk food"),
                new Category(8,"smartphones"),
                new Category(9,"laptop"),
                new Category(10,"photocameras"),
                new Category(11,"kitchen accesories"),
                new Category(12,"spices"),
                new Category(13,"Juice"),
                new Category(14,"alcohol drinks"),
            };
        }
        public override CustomerOrder[] GetCustomerOrderData()
        {
            return new[]
            {
                new CustomerOrder(1, "2022-01-15", 1, 1),
                new CustomerOrder(2, "2022-03-22", 2, 2),
                new CustomerOrder(3, "2022-05-10", 3, 3),
                new CustomerOrder(4, "2022-07-05", 4, 4),
                new CustomerOrder(5, "2022-09-30", 5, 5),
                new CustomerOrder(6, "2022-11-18", 1, 6),
                new CustomerOrder(7, "2023-02-25", 2, 7),
                new CustomerOrder(8, "2023-04-12", 3, 8),
                new CustomerOrder(9, "2023-06-28", 4, 1),
                new CustomerOrder(10, "2023-08-14", 5, 2),
                new CustomerOrder(11, "2023-10-21", 1, 3),
                new CustomerOrder(12, "2023-12-30", 2, 4),
                new CustomerOrder(13, "2022-01-05", 3, 5),
                new CustomerOrder(14, "2022-03-16", 4, 6),
                new CustomerOrder(15, "2022-05-27", 5, 7),
                new CustomerOrder(16, "2022-08-08", 1, 8),
                new CustomerOrder(17, "2022-10-19", 2, 1),
                new CustomerOrder(18, "2022-12-30", 3, 2),
                new CustomerOrder(19, "2023-03-10", 4, 3),
                new CustomerOrder(20, "2023-05-21", 5, 4)
            };
        }

        public override Manufacturer[] GetManufacturerData()
        {
            return new[]
            {
                new Manufacturer(1, "Manufacturer 1"), //agriculture
                new Manufacturer(2, "Manufacturer 2"), //drinks
                new Manufacturer(3, "Manufacturer 3"), //meat
                new Manufacturer(4, "Manufacturer 4"),
                new Manufacturer(5, "Manufacturer 5")
            };
        }
        public override OrderDetail[] GetOrderDetailData()
        {
            return new[]
            {
                new OrderDetail(1, 1, 1,(decimal) 17.5, 5),
                new OrderDetail(2, 2, 2,(decimal) 32.5, 10),
                new OrderDetail(3, 3, 3, (decimal) 13.5, 3),
                new OrderDetail(4, 4, 4, (decimal) 32.0, 8),
                new OrderDetail(5, 5, 5, (decimal) 30, 12),
                new OrderDetail(6, 6, 6, (decimal) 22.75, 7),
                new OrderDetail(7, 7, 7, (decimal) 9.0, 2),
                new OrderDetail(8, 8, 8, (decimal) 45.0, 9),
                new OrderDetail(9, 9, 9, (decimal) 18.0, 6),
                new OrderDetail(10, 10, 10, (decimal) 48.0, 4),
                new OrderDetail(11, 11, 11, (decimal) 88.0, 11),
                new OrderDetail(12, 12, 12, (decimal) 97.5, 13),
                new OrderDetail(13, 13, 13, (decimal) 123.5, 15),
                new OrderDetail(14, 14, 14, (decimal) 37.5, 5),
                new OrderDetail(15, 15, 15, (decimal) 28.0, 8),
                new OrderDetail(16, 16, 16, (decimal) 75.0, 10),
                new OrderDetail(17, 17, 17, (decimal) 9.5, 1),
                new OrderDetail(18, 18, 18, (decimal) 10.5, 3),
                new OrderDetail(19, 19, 19, (decimal) 78.0, 12),
                new OrderDetail(20, 20, 20, (decimal) 44.0, 8),
                new OrderDetail(21, 1, 21, (decimal) 19.5, 1),
                new OrderDetail(22, 2, 1, (decimal) 21, 6),
                new OrderDetail(23, 3, 2, (decimal) 26, 8),
                new OrderDetail(24, 4, 3, (decimal) 49.5, 11),
                new OrderDetail(25, 5, 4, (decimal) 12.0, 3),
                new OrderDetail(26, 6, 5, (decimal) 22.5, 9),
                new OrderDetail(27, 7, 6, (decimal) 16.25, 5),
                new OrderDetail(28, 8, 7, (decimal) 54.0, 12),
                new OrderDetail(29, 9, 8, (decimal) 35.0, 7),
                new OrderDetail(30, 10, 9, (decimal) 30.0, 10),
                new OrderDetail(31, 11, 10, (decimal) 24.0, 2),
                new OrderDetail(32, 12, 11, (decimal) 32.0, 4),
                new OrderDetail(33, 13, 12, (decimal) 112.5, 15),
                new OrderDetail(34, 14, 13, (decimal) 57, 6),
                new OrderDetail(35, 15, 14, (decimal) 60, 8),
                new OrderDetail(36, 16, 15, (decimal) 38.5, 11),
                new OrderDetail(37, 17, 16, (decimal) 37.5, 5),
                new OrderDetail(38, 18, 17, (decimal) 28.5, 3),
                new OrderDetail(39, 19, 18, (decimal) 21.0, 6),
                new OrderDetail(40, 20, 19, (decimal) 26.0, 4),
                new OrderDetail(41, 1, 20, (decimal) 33.0, 6),
                new OrderDetail(42, 2, 21, (decimal) 58.5, 3),
                new OrderDetail(43, 3, 1, (decimal) 10.5, 3),
                new OrderDetail(44, 4, 2, (decimal) 26, 8),
                new OrderDetail(45, 5, 3, (decimal) 54, 12),
                new OrderDetail(46, 6, 4, (decimal) 28.0, 7),
                new OrderDetail(47, 7, 5, (decimal) 5, 2),
                new OrderDetail(48, 8, 6, (decimal) 29.25, 9),
                new OrderDetail(49, 9, 7, (decimal) 27.0, 6),
                new OrderDetail(50, 10, 8, (decimal) 20.0, 4)
            };
        }

        public override OrderState[] GetOrderStateData()
        {
            return new[]
            {
                new OrderState(1,"New Order"),
                new OrderState(2,"Cancelled by user"),
                new OrderState(3,"Cancelled by administrator"),
                new OrderState(4,"Confirmed"),
                new OrderState(5,"Moved to delivery company"),
                new OrderState(6,"In delivery"),
                new OrderState(7,"Delivered to client"),
                new OrderState(8,"Delivery confirmed by client")
            };
        }
        public override Product[] GetProductData()
        {
            return new[]
            {
                new Product(1,1,1,"Jonagold",(decimal)3.5),
                new Product(2,1,1,"Reneta",(decimal)3.25),
                new Product(3,2,1,"Peleponesian",(decimal)4.5),
                new Product(4,2,1,"Iberian",(decimal)4.0),
                new Product(5,3,2,"still water",(decimal)2.5),
                new Product(6,4,2,"sparkling water",(decimal)3.25),
                new Product(7,3,2,"mineral water",(decimal)4.5),
                new Product(8,5,1,"red tomato",(decimal)5.0),
                new Product(9,6,1,"dirty potato",(decimal)3.0),
                new Product(10,7,3,"ocean shrimp",(decimal)12.0),
                new Product(11,8,3,"norvegian salomon",(decimal)8.0),
                new Product(12,9,3,"bacon",(decimal)7.5),
                new Product(13,10,3,"steak",(decimal)9.5),
                new Product(14,11,1,"Honey loops",(decimal)7.5),
                new Product(15,12,1,"Rolled Oats",(decimal)3.5),
                new Product(16,13,1,"Milk 3.2% UHT 1L",(decimal)7.5),
                new Product(17,14,1,"Gouda 500g",(decimal)9.5),
                new Product(18,25,2,"apple juice",(decimal)3.5),
                new Product(19,26,2,"orange juice",(decimal)6.5),
                new Product(20,27,2,"lager",(decimal)5.5),
                new Product(21,28,2,"bordoux",(decimal)19.5)
            };
        }
        public override ProductTitle[] GetProductTitleData()
        {
            return new[]
            {
                new ProductTitle(1,"Apple",1),
                new ProductTitle(2,"Orange",1),
                new ProductTitle(3,"Still water",2),
                new ProductTitle(4,"Sparkling water",2),
                new ProductTitle(5,"Tomato",3),
                new ProductTitle(6,"Potato",3),
                new ProductTitle(7,"Shrimp",4),
                new ProductTitle(8,"Salomon",4),
                new ProductTitle(9,"Pork",5),
                new ProductTitle(10,"Beef",5),
                new ProductTitle(11,"Cerial",6),
                new ProductTitle(12,"Oats",6),
                new ProductTitle(13,"Milk",7),
                new ProductTitle(14,"Cheese",7),
                new ProductTitle(15,"smartphone",8),
                new ProductTitle(16,"dumbphone",8),
                new ProductTitle(17,"gaming laptop",9),
                new ProductTitle(18,"ultrabook",9),
                new ProductTitle(19,"digital camera",10),
                new ProductTitle(20,"analog camera",10),
                new ProductTitle(21,"knife",11),
                new ProductTitle(22,"kitchen robot",11),
                new ProductTitle(23,"Cinnamon",12),
                new ProductTitle(24,"Peper",12),
                new ProductTitle(25,"Orange juice",13),
                new ProductTitle(26,"Apple juice",13),
                new ProductTitle(27,"Beer",14),
                new ProductTitle(28,"Wine",14)
            };
        }
        public override User[] GetUserData()
        {
            return new[]
            {
                new User(1, "Admin", "Admin", "Admin", "admin123", 1),
                new User(2, "Guest", "Guest", "guest", "guest", 3),
                new User(3, "Jane", "Smith", "janesmith456", "mypassword", 2),
                new User(4, "Michael", "Johnson", "mikej88", "secretword", 2),
                new User(5, "Emily", "Williams", "emilyw", "pass1234", 2),
                new User(6, "David", "Brown", "dbrown", "brownie123", 2)
            };
        }
        public override UserRole[] GetUserRoleData()
        {
            return new[]
            {
                new UserRole(1,"Admin"),
                new UserRole(2,"Registered"),
                new UserRole(3,"Guest"),
            };
        }
    }
}
