using StoreDAL.Entities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StoreBLL.Models
{
    public class CategoryModel : AbstractModel
    {
        public string CategoryName { get; set; }
        public CategoryModel(int id, string name):base(id) 
        {
            this.Id = id;
            this.CategoryName = name;
        }
        public override string ToString()
        {
            return $"Id:{Id} {CategoryName}";
        }
    }
}
