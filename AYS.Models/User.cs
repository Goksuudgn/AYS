using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AYS.Models
{
    public class User : BaseModel
    {
        
        public string Name { get; set; }    
        public string Email { get; set; }
        public string Password { get; set; }
        public ICollection<Home>Homes { get; set; } //bir kullanıcı birden fazla eve sahip olabilir
    }
}
