using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Umuly_Case.Models
{
	public class CaseClass
	{
		public int ID { get; set; }
		public string Firma { get; set; }
		public string Modu { get; set; }
		public string Hareket_Sekli { get; set; }
		public string Incoterm { get; set; }
		public string Ulke { get; set; }
		public string Sehir { get; set; }
		public int Urun_Sayisi { get; set; }
		public string Paket_Tipi { get; set; }
		public int Uzunluk { get; set; }
		public string Uzunluk_Birimi { get; set; }
		public int Agirlik { get; set; }
		public string Agirlik_Birimi { get; set; }
		public int Ucret { get; set; }
		public string Para_Birimi { get; set; }
	}
}