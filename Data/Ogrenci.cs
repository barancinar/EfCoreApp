using System.Collections;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace EfCoreApp.Data
{
    public class Ogrenci
    {
        [Key]
        [DisplayName("Öğrenci No")]
        public int OgrenciId { get; set; }
        [DisplayName("Öğrenci Ad")]
        public string? OgrenciAd { get; set; }
        [DisplayName("Öğrenci Soyad")]
        public string? OgrenciSoya { get; set; }
        [DisplayName("Ad Soyad")]
        public string AdSoyad
        {
            get
            {
                return this.OgrenciAd + " " + this.OgrenciSoya;
            }
        }
        public string? Eposta { get; set; }
        public string? Telefon { get; set; }

        public ICollection<KursKayit> KursKayitlari { get; set; } = new List<KursKayit>();
    }
}
