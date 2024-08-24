using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AYS.Models
{
    public class Category:BaseModel
    {
        
        public string Name { get; set; }
        public ICollection<Device>Devices { get; set; } //Bir kategoride birçok cihaz olabilir 
    }
}
