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
    public class DeviceService : BaseService<Device>, IDeviceService
    //DeviceService sınıfı, BaseService sınıfından türetilmiş ve IDeviceService interface'ini implemente eden bir sınıftır. 

    {
        public DeviceService(ApplicationDbContext context) : base(context)
        {
        }

        //Bu, Entity Framework Core kullanarak veri tabanına erişim sağlayan DbContext sınıfıdır. AppDbContext, veritabanı bağlantısını ve veri setlerini temsil eder.
        //base(context): Bu ifade, DeviceService sınıfının BaseService<Device> sınıfının constructor'ını çağırır ve context parametresini ona iletir. Bu sayede, BaseService sınıfında tanımlanan veri tabanı erişim işlemleri context ile yapılır
    }
}
