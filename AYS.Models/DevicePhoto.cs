using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AYS.Models
{
    public class DevicePhoto
    {
        public int DevicePhotoId { get; set; }
        public string PhotoUrl { get; set; }
        public int DeviceId { get; set; } //Fotoğrafın ait olduğu cihaz
        public Device Device { get; set; }
    }
}
