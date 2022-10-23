using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace Etkinlik_Otomasyon.Models
{
    public class KULLANICI
    {
        public string Name { get; set; }
        public string EMail { get; set; }

        [MinLength(8, ErrorMessage = "Şifre en az 8 karakter olmalıdır")]
        public string Sifre { get; set; }

        [MinLength(8, ErrorMessage = "Şifre en az 8 karakter olmalıdır")]
        public string TekrarSifre { get; set; }

    }
}
