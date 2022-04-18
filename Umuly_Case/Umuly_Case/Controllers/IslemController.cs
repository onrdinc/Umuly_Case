using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Umuly_Case.Models;

namespace Umuly_Case.Controllers
{
	public class IslemController : ApiController
	{
		DbCaseEntities ce = new DbCaseEntities();
		public IHttpActionResult getcase()
		{
			var sonuc = ce.sp_teklif(0, "", "", "", "", "", "", 0, "", 0, "", 0, "", 0, "", "Get").ToList();
			return Ok(sonuc);
		}

		public IHttpActionResult teklif_ver(Teklif ekle)
		{
			if (ekle.Firma == null || ekle.Modu == null || ekle.Hareket_Sekli == null || ekle.Incoterm == null ||
			ekle.Ulke == null || ekle.Sehir == null || ekle.Urun_Sayisi == null || ekle.Paket_Tipi == null || ekle.Uzunluk == null || ekle.Uzunluk_Birimi == null ||
			ekle.Agirlik == null || ekle.Agirlik_Birimi == null || ekle.Ucret == null || ekle.Para_Birimi == null)
			{

				string msg = "";
				if (ekle.Firma == null)
				{
					msg += "Firma alanı boş olamaz!";
				}
				if (ekle.Modu == null)
				{
					msg += "Modu alanı boş olamaz!";
				}

				return BadRequest(msg);
			}
			else
			{

				bool isTeklif = ce.Teklif.Where(k => k.Firma == ekle.Firma).Any();
				if (isTeklif)
				{
					return BadRequest("Firma kayıtlı lütfen bilgililerinizi kontrol edip tekrar deneyiniz!");
				}

				var ekleme_sonuc = ce.sp_teklif(0, ekle.Firma, ekle.Modu, ekle.Hareket_Sekli, ekle.Incoterm,
				ekle.Ulke, ekle.Sehir, ekle.Urun_Sayisi, ekle.Paket_Tipi, ekle.Uzunluk, ekle.Uzunluk_Birimi,
				ekle.Agirlik, ekle.Agirlik_Birimi, ekle.Ucret, ekle.Para_Birimi, "Ekle");

				return Ok(ekleme_sonuc);
			}


		}
		public IHttpActionResult getid(int id)
		{
			var veri_detay = ce.sp_teklif(id, "", "", "", "", "", "", 0, "", 0, "", 0, "", 0, "", "Getid").Select(x => new CaseClass()
			{
				ID = x.ID,
				Firma = x.Firma,
				Modu = x.Modu,
				Hareket_Sekli = x.Hareket_Sekli,
				Incoterm = x.Incoterm,
				Ulke = x.Ulke,
				Sehir = x.Sehir,
				Urun_Sayisi = Convert.ToInt32(x.Urun_Sayisi),
				Paket_Tipi = x.Paket_Tipi,
				Uzunluk = Convert.ToInt32(x.Uzunluk),
				Uzunluk_Birimi = x.Uzunluk_Birimi,
				Agirlik = Convert.ToInt32(x.Agirlik),
				Agirlik_Birimi = x.Agirlik_Birimi,
				Ucret = Convert.ToInt32(x.Ucret),
				Para_Birimi = x.Para_Birimi
			}).FirstOrDefault<CaseClass>();
			return Ok(veri_detay);
		}
	}
}
