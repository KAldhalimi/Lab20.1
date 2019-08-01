using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCoreCoffeeShop.CoffeeShop
{
    public class UserInfo
    {
        public int UserInfoId { get; set; }
        public String UserName { get; set; }

        public string Email { get; set; }
        public string Password { get; set; }

        public virtual ICollection<Product> Product { get; set; }
    }
}
