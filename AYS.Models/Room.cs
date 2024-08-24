using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AYS.Models
{
    public class Room : BaseModel
    {
        
        public string Name { get; set; }
        public int HomeId { get; set; } //Odanın bulunduğu evin kimlik numarası
        public Home Home { get; set; } // Ev referasnı
        public ICollection<Device> Devices { get; set; } //Bir odada birden fazla cihaz olabilir 

    }
}
