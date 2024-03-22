using StoreDAL.Entities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StoreBLL.Models
{
    public class UserModel : AbstractModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public int User_role_id { get; set; }

        public UserModel(int id, string first_name, string last_name, string login, string password, int user_role_id) : base(id)
        {
            this.Id = id;
            this.FirstName = first_name;
            this.LastName = last_name;
            this.Login = login;
            this.Password = password;
            this.User_role_id = user_role_id;
        }
        public override string ToString()
        {
            return $"Id:{Id} {FirstName} {LastName} {Login} {Password} {User_role_id}";
        }
    }
}
