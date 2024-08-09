using AYS.Business.Abstract;
using AYS.Business.Shared.Concrete;
using AYS.Data;
using AYS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AYS.Business.Concrete
{
    public class UserService : BaseService<User>, IUserService
    {
        public UserService(ApplicationDbContext context) : base(context)
        {
        }
    }
}
