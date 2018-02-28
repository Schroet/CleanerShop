using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanerShop.Domain.Concrete
{
    class FormsAuthenticationProvider
    {
        private readonly EFDbContext context = new EFDbContext();
        public bool Authenticate(string username, string password)
        {
            var result = context.Users.FirstOrDefault(u => u.UserId == username && u.Password == password);

            if (result == null)
                return false;
            return true;
        }

        public bool Logout()
        {
            return true;
        }
    }
}
