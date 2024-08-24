using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AYS.Models
{
    public class Device : BaseModel
    {
       
        public string Name { get; set; }
        public string Brand { get; set; } //Cihaz markası
        public int Consumption { get; set; } //Cihaz tüketim miktarı (watt)
        public int CategoryId { get; set; } //Cihazın kategorisi
        public Category Category { get; set; } //Kategori referansı 
        public int RoomId { get; set; }//Cihazın bulunduğu oda
        public Room Room { get; set; }
        public DateTime? WarrantyExpiryDate { get; set; } // Cihazın garanti bitiş tarihi (opsiyonel)
        public bool IsOn {  get; set; } //Cihaz açık mı kapalı mı
        public ICollection<DevicePhoto>DevicePhotos { get; set; } //Bir cihazın birden çok fotoğrafı olabilir 
    }
}
