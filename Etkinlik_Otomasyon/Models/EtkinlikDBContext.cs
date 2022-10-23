using System.Data.Entity;

namespace Etkinlik_Otomasyon.Models
{
    public class EtkinlikDBContext: DbContext
    {
        public EtkinlikDBContext() : base("EtkinlikDBConString")
        { 
        }

        public virtual DbSet<ETKINLIK> ETKINLIKs { get; set; }
        public virtual DbSet<YETKI> YETKIs { get; set; }
        public virtual DbSet<KULLANICI> KULLANICIs { get; set; }


    }
}
