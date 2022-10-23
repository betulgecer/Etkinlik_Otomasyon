using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Etkinlik_Otomasyon.Models
{
    public class VW_ETKINLIK_KATEGORI
    {
        public string KATEGORI_ADI { get; set; }
        public int ETKINLIK_REFNO { get; set; }
        public int KATEGORI_REFNO { get; set; }
        public string ICERIK { get; set; }
        public int UCRET { get; set; }
        public int SAAT { get; set; }
        public string ETKINLIK_ADI { get; set; }
    }
}
