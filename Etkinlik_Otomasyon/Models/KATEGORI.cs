using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Etkinlik_Otomasyon.Models
{
    public class KATEGORI
    {
        public KATEGORI()
        {
            ETKINLIKs = new HashSet<ETKINLIK>();
        }
        public int KATEGORI_REFNO { get; set; }

        [Required(ErrorMessage = "{0} giriniz.")]
        [DisplayName("Kategori Adı"), MaxLength(50)]
        [StringLength(50)]
        public string KATEGORI_ADI { get; set; }

        public virtual ICollection<ETKINLIK> ETKINLIKs { get; set; }
    }
}
