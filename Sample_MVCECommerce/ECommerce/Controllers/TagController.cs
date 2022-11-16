using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using EntityLayer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using System.Linq;

namespace ECommerce.Controllers
{
    public class TagController : Controller
    {
        TagManager tm = new TagManager(new TagDal());
        [Authorize(Roles = "Admin")]
        public IActionResult Index()
        {
            var values = tm.GetAllTag();
            return View(values);
        }
        [HttpGet]
        public IActionResult Ekle()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Ekle(Tag tag)
        {
            tm.AddTag(tag);
            return RedirectToAction("Index");
        }
        [Authorize(Roles = "Admin")]
        [HttpGet]
        public IActionResult Guncelle(int id)
        {
            using (Context c = new Context())
            {
                var result = c.Tags.FirstOrDefault(o => o.tag_ID == id);
                return View(result);
            }
        }
        [HttpPost]
        public IActionResult Guncelle(Tag tag)
        {
            var result = tm.UpdateTag(tag);

            return RedirectToAction("Index");
        }
        [Authorize(Roles = "Admin")]
        [HttpGet]
        public IActionResult Sil(int id)
        {
            using (Context db = new Context())
            {
                var result = db.Tags.FirstOrDefault(o => o.tag_ID == id);
                db.Tags.Remove(result);
                db.SaveChanges();
            }

            return RedirectToAction("Index");

        }



























        /*public IActionResult Index()
        {
            return View();
        }
        */
    }
}
