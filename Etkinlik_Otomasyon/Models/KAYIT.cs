using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Etkinlik_Otomasyon.Models
{
    public class KAYIT
    {
        public KAYIT()
        {
        }

        public int KAYIT_REFNO { get; set; }

        public int ETKINLIK_GRUP_REFNO { get; set; }

        public int KULLANICI_REFNO { get; set; }

        public string ACIKLAMA { get; set; }

        public virtual ETKINLIK_GRUP ETKINLIK_GRUP { get; set; }

        public virtual ETKINLIK_GRUP ETKINLIK_GRUP1 { get; set; }

        public virtual KULLANICI KULLANICI { get; set; }

        public virtual KULLANICI KULLANICI1 { get; set; }
    }
}
