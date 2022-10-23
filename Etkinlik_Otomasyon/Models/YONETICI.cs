using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Etkinlik_Otomasyon.Models
{
        public  class YONETICI
        {
            public string YONETICI_ADI { get; set; }

            public string PAROLA { get; set; }

            public string EMAIL { get; set; }

            public virtual YETKI_GRUBU YETKI_GRUBU { get; set; }
        }
}
