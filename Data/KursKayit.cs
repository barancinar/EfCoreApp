using System.ComponentModel.DataAnnotations;

namespace EfCoreApp.Data
{
    public class KursKayit
    {
        [Key]
        public int KayitId { get; set; }
        public int OgrenciId { get; set; }
        // Navigation Property
        public Ogrenci Ogrenci { get; set; } = null!;
        public int KursId { get; set; }
        public Kurs Kurs { get; set; } = null!;
        public DateTime KayitTarihi { get; set; }
    }
}