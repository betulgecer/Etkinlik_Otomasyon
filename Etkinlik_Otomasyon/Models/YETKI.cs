namespace Etkinlik_Otomasyon.Models
{
    public class YETKI
    {
        public int YETKI_REFNO { get; set; }

        public int YETKI_GRUBU_REFNO { get; set; }

        public bool OKUMA { get; set; }

        public bool KAYDET { get; set; }

        public bool SIL { get; set; }

        public bool YENI { get; set; }

        public bool ARAMA { get; set; }

        public virtual YETKI_GRUBU YETKI_GRUBU { get; set; }
    }
}
