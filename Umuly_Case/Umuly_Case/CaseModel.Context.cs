//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Umuly_Case
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class DbCaseEntities : DbContext
    {
        public DbCaseEntities()
            : base("name=DbCaseEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Teklif> Teklif { get; set; }
    
        public virtual ObjectResult<sp_teklif_Result> sp_teklif(Nullable<int> iD, string firma, string modu, string hareket_Sekli, string incoterm, string ulke, string sehir, Nullable<int> urun_Sayisi, string paket_Tipi, Nullable<int> uzunluk, string uzunluk_Birimi, Nullable<int> agirlik, string agirlik_Birimi, Nullable<int> ucret, string para_Birimi, string secenek)
        {
            var iDParameter = iD.HasValue ?
                new ObjectParameter("ID", iD) :
                new ObjectParameter("ID", typeof(int));
    
            var firmaParameter = firma != null ?
                new ObjectParameter("Firma", firma) :
                new ObjectParameter("Firma", typeof(string));
    
            var moduParameter = modu != null ?
                new ObjectParameter("Modu", modu) :
                new ObjectParameter("Modu", typeof(string));
    
            var hareket_SekliParameter = hareket_Sekli != null ?
                new ObjectParameter("Hareket_Sekli", hareket_Sekli) :
                new ObjectParameter("Hareket_Sekli", typeof(string));
    
            var incotermParameter = incoterm != null ?
                new ObjectParameter("Incoterm", incoterm) :
                new ObjectParameter("Incoterm", typeof(string));
    
            var ulkeParameter = ulke != null ?
                new ObjectParameter("Ulke", ulke) :
                new ObjectParameter("Ulke", typeof(string));
    
            var sehirParameter = sehir != null ?
                new ObjectParameter("Sehir", sehir) :
                new ObjectParameter("Sehir", typeof(string));
    
            var urun_SayisiParameter = urun_Sayisi.HasValue ?
                new ObjectParameter("Urun_Sayisi", urun_Sayisi) :
                new ObjectParameter("Urun_Sayisi", typeof(int));
    
            var paket_TipiParameter = paket_Tipi != null ?
                new ObjectParameter("Paket_Tipi", paket_Tipi) :
                new ObjectParameter("Paket_Tipi", typeof(string));
    
            var uzunlukParameter = uzunluk.HasValue ?
                new ObjectParameter("Uzunluk", uzunluk) :
                new ObjectParameter("Uzunluk", typeof(int));
    
            var uzunluk_BirimiParameter = uzunluk_Birimi != null ?
                new ObjectParameter("Uzunluk_Birimi", uzunluk_Birimi) :
                new ObjectParameter("Uzunluk_Birimi", typeof(string));
    
            var agirlikParameter = agirlik.HasValue ?
                new ObjectParameter("Agirlik", agirlik) :
                new ObjectParameter("Agirlik", typeof(int));
    
            var agirlik_BirimiParameter = agirlik_Birimi != null ?
                new ObjectParameter("Agirlik_Birimi", agirlik_Birimi) :
                new ObjectParameter("Agirlik_Birimi", typeof(string));
    
            var ucretParameter = ucret.HasValue ?
                new ObjectParameter("Ucret", ucret) :
                new ObjectParameter("Ucret", typeof(int));
    
            var para_BirimiParameter = para_Birimi != null ?
                new ObjectParameter("Para_Birimi", para_Birimi) :
                new ObjectParameter("Para_Birimi", typeof(string));
    
            var secenekParameter = secenek != null ?
                new ObjectParameter("Secenek", secenek) :
                new ObjectParameter("Secenek", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_teklif_Result>("sp_teklif", iDParameter, firmaParameter, moduParameter, hareket_SekliParameter, incotermParameter, ulkeParameter, sehirParameter, urun_SayisiParameter, paket_TipiParameter, uzunlukParameter, uzunluk_BirimiParameter, agirlikParameter, agirlik_BirimiParameter, ucretParameter, para_BirimiParameter, secenekParameter);
        }
    }
}
