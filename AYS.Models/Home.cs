using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AYS.Models
{
    public class Home : BaseModel
    {
       
        public string Name { get; set; }
        public int UserId { get; set; } //Evin sahibi olan kullanıcının kimlik numarası
        public User User { get; set; } // Kullanıcı referansı
        public ICollection<Room> Rooms { get; set; } //bir evde birden fazla oda olabilir
    }
}
