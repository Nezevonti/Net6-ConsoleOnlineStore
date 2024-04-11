using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreBLL.Models
{
    public class CustomerOrderModel : AbstractModel
    {
        public int id { get; set; }

        public int customer_id { get; set; }

        public string operation_time { get; set; }

        public int order_state_id { get; set; }

        public CustomerOrderModel(int id, int customer_id, string operation_time, int order_state_id) : base(id)
        {
            this.id = id;
            this.customer_id = customer_id;
            this.operation_time = operation_time;
            this.order_state_id = order_state_id;
        }

        public override string ToString()
        {
            return $"{this.id} {this.customer_id} {this.operation_time} {this.order_state_id}";
        }
    }
}
