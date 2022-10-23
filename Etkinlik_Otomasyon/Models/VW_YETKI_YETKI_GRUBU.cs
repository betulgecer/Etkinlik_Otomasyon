using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Etkinlik_Otomasyon.Models
{
    public class VW_YETKI_YETKI_GRUBU
    {
        public int YETKI_REFNO { get; set; }

        public int YETKI_GRUBU_REFNO { get; set; }

        public bool OKUMA { get; set; }

        public bool KAYDET { get; set; }

        public bool SIL { get; set; }

        public bool ARAMA { get; set; }

        public bool YENI { get; set; }

        public string GRUP_ADI { get; set; }

    }
}
