using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreBLL.Models
{
    internal class OrderDetailModel : AbstractModel
    {
        public int id { get; set; }
        public int customer_order_id { get; set; }

        public int product_id { get; set; }

        public decimal price { get; set; }

        public int product_amount { get; set; }

        public OrderDetailModel(int id, int customer_order_id, int product_id, decimal price, int amount) : base(id)
        {
            this.id = id;
            this.customer_order_id = customer_order_id;
            this.product_id = product_id;
            this.price = price;
            this.product_amount = amount;
        }

        public override string ToString()
        {
            return $"{this.id} {this.customer_order_id} {this.product_id} {this.price} {this.product_amount}";
        }
    }
}
