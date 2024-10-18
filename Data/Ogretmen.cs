using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace EfCoreApp.Data
{
    public class Ogretmen
    {
        [Key]
        public int OgretmenId { get; set; }
        public string? Ad { get; set; }
        public string? Soyad { get; set; }
        public string AdSoyad
        {
            get
            {
                return this.Ad + " " + this.Soyad;
            }
        }
        public string? Eposta { get; set; }
        public string? Telefon { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd.MM.yyyy}", ApplyFormatInEditMode = false)]
        [DisplayName("Başlama Tarihi")]
        public DateTime StartDate { get; set; }
        public ICollection<Kurs> Kurslar { get; set; } = new List<Kurs>();
    }
}