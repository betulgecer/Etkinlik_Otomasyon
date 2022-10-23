namespace Etkinlik_Otomasyon.Models
{
    using System;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using System.Collections.Generic;
    using Microsoft.EntityFrameworkCore;
    using System.Data.Entity;

    //public  class Model1 : DbContext
    //{
    //    //public Model1(): base("Model1")
    //    //{
    //    //}

    //    //public virtual DbSet<ETKINLIK> ETKINLIKs { get; set; }
    //    //public virtual DbSet<ETKINLIK_GRUP> ETKINLIK_GRUP { get; set; }
    //    //public virtual DbSet<ORGANIZATOR> ORGANIZATORS { get; set; }
    //    //public virtual DbSet<KATEGORI> KATEGORIs { get; set; }
    //    //public virtual DbSet<KAYIT> KAYITs { get; set; }
    //    //public virtual DbSet<KULLANICI> KULLANICIs { get; set; }
    //    //public virtual DbSet<YETKI> YETKIs { get; set; }
    //    //public virtual DbSet<YETKI_GRUBU> YETKI_GRUBU { get; set; }
    //    //public virtual DbSet<YONETICI> YONETICIs { get; set; }
    //    ////  public virtual DbSet<VW_ETKINLIK_GRUP_ORGANIZATOR_ETKINLIK> VW_ETKINLIK_GRUP_ORGANIZATOR_ETKINLIK { get; set; }
    //    //public virtual DbSet<VW_ETKINLIK_KATEGORI> VW_ETKINLIK_KATEGORI { get; set; }
    //    ////   public virtual DbSet<VW_KAYIT_KULLANICI_ETKINLIKGRUP> VW_KAYIT_KULLANICI_ETKINLIKGRUP { get; set; }
    //    ////   public virtual DbSet<VW_ONKAYIT_EGITIMGRUP_KATILMADURUMU> VW_ONKAYIT_EGITIMGRUP_KATILMADURUMU { get; set; }
    //    //public virtual DbSet<VW_YETKI_YETKI_GRUBU> VW_YETKI_YETKI_GRUBU { get; set; }

    //    //protected override void OnModelCreating(DbModelBuilder modelBuilder)
    //    //{
    //    //    modelBuilder.Entity<ETKINLIK>()
    //    //        .Property(e => e.ETKINLIK_ADI)
    //    //        .IsUnicode(false);

    //    //    modelBuilder.Entity<ETKINLIK>()
    //    //        .Property(e => e.ICERIK)
    //    //        .IsUnicode(false);

    //    //    modelBuilder.Entity<ETKINLIK>()
    //    //        .HasMany(e => e.ETKINLIK_GRUP)
    //    //        .WithRequired(e => e.ETKINLIK)
    //    //        .WillCascadeOnDelete(false);

    //    //    modelBuilder.Entity<ETKINLIK_GRUP>()
    //    //        .Property(e => e.BASLANGIC_SAAT)
    //    //        .IsUnicode(false);

    //    //    modelBuilder.Entity<ETKINLIK_GRUP>()
    //    //        .Property(e => e.BITIS_SAAT)
    //    //        .IsUnicode(false);

    //    //    modelBuilder.Entity<ETKINLIK_GRUP>()
    //    //        .Property(e => e.GUNLER)
    //    //        .IsUnicode(false);

    //    //    modelBuilder.Entity<ETKINLIK_GRUP>()
    //    //        .Property(e => e.ETKINLIK_GRUP_ADI)
    //    //        .IsUnicode(false);

    //    //    modelBuilder.Entity<ETKINLIK_GRUP>()
    //    //        .HasMany(e => e.KAYITs)
    //    //        .WithRequired(e => e.ETKINLIK_GRUP)
    //    //        .HasForeignKey(e => e.ETKINLIK_GRUP_REFNO)
    //    //        .WillCascadeOnDelete(false);

    //    //    modelBuilder.Entity<ETKINLIK_GRUP>()
    //    //        .HasMany(e => e.KAYITs1)
    //    //        .WithRequired(e => e.ETKINLIK_GRUP1)
    //    //        .HasForeignKey(e => e.ETKINLIK_GRUP_REFNO)
    //    //        .WillCascadeOnDelete(false);

    //    //    modelBuilder.Entity<ETKINLIK_GRUP>()
    //    //        .HasMany(e => e.ON_KAYIT)
    //    //        .WithRequired(e => e.ETKINLIK_GRUP)
    //    //        .WillCascadeOnDelete(false);

    //    //    modelBuilder.Entity<EGITMan>()
    //    //        .Property(e => e.ADI_SOYADI)
    //    //        .IsUnicode(false);

    //    //    modelBuilder.Entity<EGITMan>()
    //    //        .Property(e => e.TC)
    //    //        .IsUnicode(false);

    //    //    modelBuilder.Entity<EGITMan>()
    //    //        .Property(e => e.PAROLA)
    //    //        .IsUnicode(false);

    //    //    modelBuilder.Entity<EGITMan>()
    //    //        .Property(e => e.TELEFON)
    //    //        .IsUnicode(false);

    //    //    modelBuilder.Entity<EGITMan>()
    //    //        .Property(e => e.EMAIL)
    //    //        .IsUnicode(false);

    //    //    modelBuilder.Entity<EGITMan>()
    //    //        .Property(e => e.ADRES)
    //    //        .IsUnicode(false);

    //    //    modelBuilder.Entity<EGITMan>()
    //    //        .Property(e => e.ACIKLAMA)
    //    //        .IsUnicode(false);

    //    //    modelBuilder.Entity<EGITMan>()
    //    //        .HasMany(e => e.ETKINLIK_GRUP)
    //    //        .WithRequired(e => e.EGITMan)
    //    //        .WillCascadeOnDelete(false);

    //    //    modelBuilder.Entity<EGITMan>()
    //    //        .HasMany(e => e.EGITMEN_HAREKET)
    //    //        .WithRequired(e => e.EGITMan)
    //    //        .HasForeignKey(e => e.EGITMEN_REFNO)
    //    //        .WillCascadeOnDelete(false);

    //    //    modelBuilder.Entity<EGITMan>()
    //    //        .HasMany(e => e.EGITMEN_HAREKET1)
    //    //        .WithRequired(e => e.EGITMan1)
    //    //        .HasForeignKey(e => e.EGITMEN_REFNO)
    //    //        .WillCascadeOnDelete(false);

    //    //    modelBuilder.Entity<EGITMEN_HAREKET>()
    //    //        .Property(e => e.ACIKLAMA)
    //    //        .IsUnicode(false);

    //    //    modelBuilder.Entity<KATEGORI>()
    //    //        .Property(e => e.KATEGORI_ADI)
    //    //        .IsUnicode(false);

    //    //    modelBuilder.Entity<KATEGORI>()
    //    //        .HasMany(e => e.ETKINLIKs)
    //    //        .WithRequired(e => e.KATEGORI)
    //    //        .WillCascadeOnDelete(false);

    //    //    modelBuilder.Entity<KATILMA_DURUMU>()
    //    //        .Property(e => e.KATILMA_DURUMU1)
    //    //        .IsUnicode(false);

    //    //    modelBuilder.Entity<KATILMA_DURUMU>()
    //    //        .HasMany(e => e.ON_KAYIT)
    //    //        .WithRequired(e => e.KATILMA_DURUMU)
    //    //        .WillCascadeOnDelete(false);

    //    //    modelBuilder.Entity<KAYIT>()
    //    //        .Property(e => e.ACIKLAMA)
    //    //        .IsUnicode(false);

    //    //    modelBuilder.Entity<KAYIT>()
    //    //        .HasMany(e => e.KURSIYER_HAREKET)
    //    //        .WithRequired(e => e.KAYIT)
    //    //        .HasForeignKey(e => e.KAYIT_REFNO)
    //    //        .WillCascadeOnDelete(false);

    //    //    modelBuilder.Entity<KAYIT>()
    //    //        .HasMany(e => e.KURSIYER_HAREKET1)
    //    //        .WithRequired(e => e.KAYIT1)
    //    //        .HasForeignKey(e => e.KAYIT_REFNO)
    //    //        .WillCascadeOnDelete(false);

    //    //    modelBuilder.Entity<KAYIT>()
    //    //        .HasMany(e => e.TAKSITs)
    //    //        .WithRequired(e => e.KAYIT)
    //    //        .WillCascadeOnDelete(false);

    //    //    modelBuilder.Entity<KURSIYER>()
    //    //        .Property(e => e.ADI_SOYADI)
    //    //        .IsUnicode(false);

    //    //    modelBuilder.Entity<KURSIYER>()
    //    //        .Property(e => e.TC)
    //    //        .IsUnicode(false);

    //    //    modelBuilder.Entity<KURSIYER>()
    //    //        .Property(e => e.ADRES)
    //    //        .IsUnicode(false);

    //    //    modelBuilder.Entity<KURSIYER>()
    //    //        .Property(e => e.TELEFON)
    //    //        .IsUnicode(false);

    //    //    modelBuilder.Entity<KURSIYER>()
    //    //        .Property(e => e.PAROLA)
    //    //        .IsUnicode(false);

    //    //    modelBuilder.Entity<KURSIYER>()
    //    //        .Property(e => e.EMAIL)
    //    //        .IsUnicode(false);

    //    //    modelBuilder.Entity<KURSIYER>()
    //    //        .HasMany(e => e.KAYITs)
    //    //        .WithRequired(e => e.KURSIYER)
    //    //        .HasForeignKey(e => e.KURSIYER_REFNO)
    //    //        .WillCascadeOnDelete(false);

    //    //    modelBuilder.Entity<KURSIYER>()
    //    //        .HasMany(e => e.KAYITs1)
    //    //        .WithRequired(e => e.KURSIYER1)
    //    //        .HasForeignKey(e => e.KURSIYER_REFNO)
    //    //        .WillCascadeOnDelete(false);

    //    //    modelBuilder.Entity<KURSIYER>()
    //    //        .HasMany(e => e.YOKLAMAs)
    //    //        .WithRequired(e => e.KURSIYER)
    //    //        .WillCascadeOnDelete(false);

    //    //    modelBuilder.Entity<ON_KAYIT>()
    //    //        .Property(e => e.ADI_SOYADI)
    //    //        .IsUnicode(false);

    //    //    modelBuilder.Entity<ON_KAYIT>()
    //    //        .Property(e => e.TELEFON)
    //    //        .IsUnicode(false);

    //    //    modelBuilder.Entity<ON_KAYIT>()
    //    //        .Property(e => e.ADRES)
    //    //        .IsUnicode(false);

    //    //    modelBuilder.Entity<ON_KAYIT>()
    //    //        .Property(e => e.EMAIL)
    //    //        .IsUnicode(false);

    //    //    modelBuilder.Entity<ON_KAYIT>()
    //    //        .Property(e => e.ACIKLAMA)
    //    //        .IsUnicode(false);

    //    //    modelBuilder.Entity<SAYFA>()
    //    //        .Property(e => e.SAYFA_ADI)
    //    //        .IsUnicode(false);

    //    //    modelBuilder.Entity<SAYFA>()
    //    //        .HasMany(e => e.YETKIs)
    //    //        .WithRequired(e => e.SAYFA)
    //    //        .WillCascadeOnDelete(false);

    //    //    modelBuilder.Entity<TAKSIT>()
    //    //        .Property(e => e.ACIKLAMA)
    //    //        .IsUnicode(false);

    //    //    modelBuilder.Entity<YETKI_GRUBU>()
    //    //        .Property(e => e.GRUP_ADI)
    //    //        .IsUnicode(false);

    //    //    modelBuilder.Entity<YETKI_GRUBU>()
    //    //        .HasMany(e => e.YETKIs)
    //    //        .WithRequired(e => e.YETKI_GRUBU)
    //    //        .WillCascadeOnDelete(false);

    //    //    modelBuilder.Entity<YETKI_GRUBU>()
    //    //        .HasMany(e => e.YONETICIs)
    //    //        .WithRequired(e => e.YETKI_GRUBU)
    //    //        .WillCascadeOnDelete(false);

    //    //    modelBuilder.Entity<YOKLAMA>()
    //    //        .Property(e => e.ACIKLAMA)
    //    //        .IsUnicode(false);

    //    //    modelBuilder.Entity<YONETICI>()
    //    //        .Property(e => e.YONETICI_ADI)
    //    //        .IsUnicode(false);

    //    //    modelBuilder.Entity<YONETICI>()
    //    //        .Property(e => e.PAROLA)
    //    //        .IsUnicode(false);

    //    //    modelBuilder.Entity<YONETICI>()
    //    //        .Property(e => e.EMAIL)
    //    //        .IsUnicode(false);

    //    //    modelBuilder.Entity<VW_EGITIM_GRUP_EGITMEN_EGITIM>()
    //    //        .Property(e => e.ADI_SOYADI)
    //    //        .IsUnicode(false);

    //    //    modelBuilder.Entity<VW_EGITIM_GRUP_EGITMEN_EGITIM>()
    //    //        .Property(e => e.BASLANGIC_SAAT)
    //    //        .IsUnicode(false);

    //    //    modelBuilder.Entity<VW_EGITIM_GRUP_EGITMEN_EGITIM>()
    //    //        .Property(e => e.BITIS_SAAT)
    //    //        .IsUnicode(false);

    //    //    modelBuilder.Entity<VW_EGITIM_GRUP_EGITMEN_EGITIM>()
    //    //        .Property(e => e.GUNLER)
    //    //        .IsUnicode(false);

    //    //    modelBuilder.Entity<VW_EGITIM_GRUP_EGITMEN_EGITIM>()
    //    //        .Property(e => e.EGITIM_ADI)
    //    //        .IsUnicode(false);

    //    //    modelBuilder.Entity<VW_EGITIM_GRUP_EGITMEN_EGITIM>()
    //    //        .Property(e => e.EGITIM_GRUP_ADI)
    //    //        .IsUnicode(false);

    //    //    modelBuilder.Entity<VW_EGITIM_KATEGORI>()
    //    //        .Property(e => e.KATEGORI_ADI)
    //    //        .IsUnicode(false);

    //    //    modelBuilder.Entity<VW_EGITIM_KATEGORI>()
    //    //        .Property(e => e.ICERIK)
    //    //        .IsUnicode(false);

    //    //    modelBuilder.Entity<VW_EGITIM_KATEGORI>()
    //    //        .Property(e => e.EGITIM_ADI)
    //    //        .IsUnicode(false);

    //    //    modelBuilder.Entity<VW_EGITMEN_HAREKET_EGITMEN>()
    //    //        .Property(e => e.ADI_SOYADI)
    //    //        .IsUnicode(false);

    //    //    modelBuilder.Entity<VW_EGITMEN_HAREKET_EGITMEN>()
    //    //        .Property(e => e.ACIKLAMA)
    //    //        .IsUnicode(false);

    //    //    modelBuilder.Entity<VW_EGITMEN_HAREKET_EGITMEN>()
    //    //        .Property(e => e.TC)
    //    //        .IsUnicode(false);

    //    //    modelBuilder.Entity<VW_KAYIT_KURSIYER_EGITIMGRUP>()
    //    //        .Property(e => e.ACIKLAMA)
    //    //        .IsUnicode(false);

    //    //    modelBuilder.Entity<VW_KAYIT_KURSIYER_EGITIMGRUP>()
    //    //        .Property(e => e.Expr2)
    //    //        .IsUnicode(false);

    //    //    modelBuilder.Entity<VW_KAYIT_KURSIYER_EGITIMGRUP>()
    //    //        .Property(e => e.EGITIM_ADI)
    //    //        .IsUnicode(false);

    //    //    modelBuilder.Entity<VW_KAYIT_KURSIYER_EGITIMGRUP>()
    //    //        .Property(e => e.ADI_SOYADI)
    //    //        .IsUnicode(false);

    //    //    modelBuilder.Entity<VW_KAYIT_KURSIYER_EGITIMGRUP>()
    //    //        .Property(e => e.EGITIM_GRUP_ADI)
    //    //        .IsUnicode(false);

    //    //    modelBuilder.Entity<VW_KAYIT_KURSIYER_EGITIMGRUP>()
    //    //        .Property(e => e.TC)
    //    //        .IsUnicode(false);

    //    //    modelBuilder.Entity<VW_KURSIYER_HAREKET_KAYIT_KURSIYER>()
    //    //        .Property(e => e.ADI_SOYADI)
    //    //        .IsUnicode(false);

    //    //    modelBuilder.Entity<VW_ONKAYIT_EGITIMGRUP_KATILMADURUMU>()
    //    //        .Property(e => e.KATILMA_DURUMU)
    //    //        .IsUnicode(false);

    //    //    modelBuilder.Entity<VW_ONKAYIT_EGITIMGRUP_KATILMADURUMU>()
    //    //        .Property(e => e.ACIKLAMA)
    //    //        .IsUnicode(false);

    //    //    modelBuilder.Entity<VW_ONKAYIT_EGITIMGRUP_KATILMADURUMU>()
    //    //        .Property(e => e.EMAIL)
    //    //        .IsUnicode(false);

    //    //    modelBuilder.Entity<VW_ONKAYIT_EGITIMGRUP_KATILMADURUMU>()
    //    //        .Property(e => e.ADRES)
    //    //        .IsUnicode(false);

    //    //    modelBuilder.Entity<VW_ONKAYIT_EGITIMGRUP_KATILMADURUMU>()
    //    //        .Property(e => e.TELEFON)
    //    //        .IsUnicode(false);

    //    //    modelBuilder.Entity<VW_ONKAYIT_EGITIMGRUP_KATILMADURUMU>()
    //    //        .Property(e => e.ADI_SOYADI)
    //    //        .IsUnicode(false);

    //    //    modelBuilder.Entity<VW_ONKAYIT_EGITIMGRUP_KATILMADURUMU>()
    //    //        .Property(e => e.EGITIM_GRUP_ADI)
    //    //        .IsUnicode(false);

    //    //    modelBuilder.Entity<VW_TAKSIT_KAYIT_KURSIYER>()
    //    //        .Property(e => e.ACIKLAMA)
    //    //        .IsUnicode(false);

    //    //    modelBuilder.Entity<VW_TAKSIT_KAYIT_KURSIYER>()
    //    //        .Property(e => e.ADI_SOYADI)
    //    //        .IsUnicode(false);

    //    //    modelBuilder.Entity<VW_TAKSIT_KAYIT_KURSIYER>()
    //    //        .Property(e => e.EGITIM_GRUP_ADI)
    //    //        .IsUnicode(false);

    //    //    modelBuilder.Entity<VW_YETKI_YETKI_GRUBU>()
    //    //        .Property(e => e.GRUP_ADI)
    //    //        .IsUnicode(false);

    //    //    modelBuilder.Entity<VW_YETKI_YETKI_GRUBU>()
    //    //        .Property(e => e.SAYFA_ADI)
    //    //        .IsUnicode(false);
    //    //}
    //}
}


