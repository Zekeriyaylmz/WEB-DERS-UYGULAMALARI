// Hasta model sınıfı. Formdan gelen bilgileri temsil eder.
namespace HastaKayitApp.Models
{
    public class Hasta
    {
        public int Id { get; set; } // Hasta ID (veritabanı için genellikle kullanılır)

        public string? Ad { get; set; } // Hastanın adı

        public string? Soyad { get; set; } // Hastanın soyadı

        public DateTime DogumTarihi { get; set; } // Hastanın doğum tarihi

        public string? Cinsiyet { get; set; } // Hastanın cinsiyeti (Erkek/Kadın)
    }
}
