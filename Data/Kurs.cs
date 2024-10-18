using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace EfCoreApp.Data
{
    public class Kurs
    {
        [Key]
        [DisplayName("Kurs Id")]
        public int KursId { get; set; }
        [DisplayName("Kurs Adı")]
        public string? Baslik { get; set; }
        public int OgretmenId { get; set; }
        public Ogretmen Ogretmen { get; set; } = null!;

        public ICollection<KursKayit> KursKayitlari { get; set; } = new List<KursKayit>();
    }
}