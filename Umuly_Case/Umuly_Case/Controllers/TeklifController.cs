using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Umuly_Case.Models;
using System.Net.Http;

namespace Umuly_Case.Controllers
{
    public class TeklifController : Controller
    {
        // GET: Teklif
        public ActionResult Index()
        {
            IEnumerable<Teklif> obj = null;
            HttpClient hc = new HttpClient();
            hc.BaseAddress = new Uri(" https://localhost:44343/api/Islem");

            var calis = hc.GetAsync("Islem");
            calis.Wait();

            var veri_oku = calis.Result;
            if (veri_oku.IsSuccessStatusCode)
            {
                var veri_goster = veri_oku.Content.ReadAsAsync<IList<Teklif>>();
                veri_goster.Wait();
                obj = veri_goster.Result;
            }
            return View(obj); 
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Teklif yeni_teklif)
        {
            HttpClient hc = new HttpClient();
            hc.BaseAddress = new Uri("https://localhost:44343/api/Islem");

            var ekle = hc.PostAsJsonAsync<Teklif>("Islem", yeni_teklif);
            ekle.Wait();

            var kaydet = ekle.Result;
            if (kaydet.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
			
            return View("Create");
        }
        public ActionResult Details(int id)
        {
            CaseClass obj = null;
            HttpClient hc = new HttpClient();
            hc.BaseAddress = new Uri("https://localhost:44343/api/Islem");

            var detay = hc.GetAsync("Islem?id=" + id.ToString());
            detay.Wait();

            var veri_oku = detay.Result;
            if (veri_oku.IsSuccessStatusCode)
            {
                var detay_goster = veri_oku.Content.ReadAsAsync<CaseClass>();
                detay_goster.Wait();
                obj = detay_goster.Result;
            }
            return View(obj);

        }
    }
}