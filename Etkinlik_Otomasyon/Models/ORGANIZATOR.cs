namespace Etkinlik_Otomasyon.Models
{
    public class ORGANIZATOR
    {
        public ORGANIZATOR()
            {
                ETKINLIK_GRUP = new HashSet<ETKINLIK_GRUP>();
            }

            public int ORGANIZATOR_REFNO { get; set; }
            public string ADI_SOYADI { get; set; }
            public string PAROLA { get; set; }
            public string TELEFON { get; set; }
            public string EMAIL { get; set; }

            public virtual ICollection<ETKINLIK_GRUP> ETKINLIK_GRUP { get; set; }

        }
    }


