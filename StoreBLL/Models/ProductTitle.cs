using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreBLL.Models
{
    public class ProductTitle : AbstractModel
    {
        public string TitleName { get; set; }
        public int category_id { get; set; }
        //public string category_name { get; set; }
        public ProductTitle(int id, string name, int category_id) : base(id)
        {
            this.Id = id;
            this.TitleName = name;
            this.category_id = category_id;
            //this.category_name = 
        }
        public override string ToString()
        {
            return $"Id:{Id} {TitleName} {category_id}";
        }
    }
}
