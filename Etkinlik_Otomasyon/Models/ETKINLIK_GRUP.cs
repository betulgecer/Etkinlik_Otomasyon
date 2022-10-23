using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Etkinlik_Otomasyon.Models
{
    public class ETKINLIK_GRUP
    {
        public ETKINLIK_GRUP()
        {
            KAYITs = new HashSet<KAYIT>();
            KAYITs1 = new HashSet<KAYIT>();
        }

        [Key]
        public int ETKINLIK_GRUP_REFNO { get; set; }

        public int ETKINLIK_REFNO { get; set; }

        public int ORGANIZATOR_REFNO { get; set; }

        [DisplayName("Ücret")]
        [Range(1, 99999)]
        public int UCRET { get; set; }

        //[Column(TypeName = "date")]
        [DataType(DataType.Date)]
        public DateTime BASLANGIC_TARIH { get; set; }

        //[Column(TypeName = "date")]
        [DataType(DataType.Date)]
        public DateTime BITIS_TARIH { get; set; }

        [Required(ErrorMessage = "{0} giriniz."), MaxLength(5)]
        [DisplayName("Başlangıç Saati")]
        [StringLength(5)]
        public string BASLANGIC_SAAT { get; set; }

        [Required(ErrorMessage = "{0} giriniz."), MaxLength(5)]
        [DisplayName("Bitiş Saati")]
        [StringLength(5)]
        public string BITIS_SAAT { get; set; }


        [Required(ErrorMessage = "{0} ekleyiniz."), MaxLength(150)]
        [DisplayName("Günler")]
        [StringLength(150)]
        public string GUNLER { get; set; }

        [Required(ErrorMessage = "{0} giriniz.")]
        [DisplayName("Etkinlik grup adı")]
        [StringLength(150)]
        public string ETKINLIK_GRUP_ADI { get; set; }


        public virtual ETKINLIK ETKINLIK { get; set; }

        public virtual ORGANIZATOR ORGANIZATOR { get; set; }

        public virtual ICollection<KAYIT> KAYITs { get; set; }

        public virtual ICollection<KAYIT> KAYITs1 { get; set; }
    }
}

