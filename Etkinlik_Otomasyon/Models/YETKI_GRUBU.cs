using System.ComponentModel.DataAnnotations;

namespace Etkinlik_Otomasyon.Models
{
    public class YETKI_GRUBU
    {
        public YETKI_GRUBU()
        {
            YETKIs = new HashSet<YETKI>();
            YONETICIs = new HashSet<YONETICI>();
        }

        public int YETKI_GRUBU_REFNO { get; set; }

        [Required]
        public string GRUP_ADI { get; set; }

        public virtual ICollection<YETKI> YETKIs { get; set; }

        public virtual ICollection<YONETICI> YONETICIs { get; set; }
    }
}
