using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreBLL.Models
{
    public class ProductModel : AbstractModel
    {
        public int id { get; set; }
        public int product_title_id { get; set; }
        public int manufacturer_id { get; set; }
        public decimal unit_price { get; set; }
        public string comment { get; set; }

        public ProductModel(int id, int product_title_id, int manufacturer_id, decimal unit_price, string comment) : base(id)
        {
            this.id = id;
            this.product_title_id = product_title_id;
            this.manufacturer_id = manufacturer_id;
            this.unit_price = unit_price;
            this.comment = comment;
        }
        public override string ToString()
        {
            return $"Id:{Id} {product_title_id} {manufacturer_id} {unit_price} {comment}";
        }
    }
}
