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
    public class HomeService : BaseService<Home>, IHomeService
    {
        public HomeService(ApplicationDbContext context) : base(context)
        {
        }
    }
}
