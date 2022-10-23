using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Etkinlik_Otomasyon.Models
{
    public class ETKINLIK
    {
        public ETKINLIK()
        {
            ETKINLIK_GRUP = new HashSet<ETKINLIK_GRUP>();
        }
        public int ETKINLIK_REFNO { get; set; }

        [Required(ErrorMessage = "{0} giriniz.")]
        [DisplayName("Etkinlik Adı"), MaxLength(50)]
        [StringLength(50)]
        public string ETKINLIK_ADI { get; set; }

        public int KATEGORI_REFNO { get; set; }

        [Required(ErrorMessage = "{0} alanı ekleyiniz.")]
        [DisplayName("İçerik"), MaxLength(500)]
        [StringLength(500)]
        public string ICERIK { get; set; }

        [Range(1, 99999)]
        public int UCRET { get; set; }

        [DisplayName("Saat")]
        [Range(1, 99999)]
        public int SAAT { get; set; }


        public virtual ICollection<ETKINLIK_GRUP> ETKINLIK_GRUP { get; set; }

        public virtual KATEGORI KATEGORI { get; set; }
    }
}

