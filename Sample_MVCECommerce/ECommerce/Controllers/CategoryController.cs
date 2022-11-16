using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using EntityLayer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using System.Linq;

namespace ECommerce.Controllers
{
    public class CategoryController : Controller
    {
        CategoryManager cm = new CategoryManager(new CategoryDal());
        [Authorize(Roles = "Admin")]
        public IActionResult Index()
        {
            var values = cm.GetAllCategory();
            return View(values);
        }
        [HttpGet]
        public IActionResult Ekle()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Ekle(Category category)
        {
            cm.AddCategory(category);
            return RedirectToAction("Index");
        }
        [Authorize(Roles = "Admin")]
        [HttpGet]
        public IActionResult Guncelle(int id)
        {
            using (Context c = new Context())
            {
                var result = c.Categories.FirstOrDefault(o => o.category_Id == id);
                return View(result);
            }
        }
        [HttpPost]
        public IActionResult Guncelle(Category category)
        {
            var result = cm.UpdateCategory(category);

            return RedirectToAction("Index");
        }
        [Authorize(Roles = "Admin")]
        [HttpGet]
        public IActionResult Sil(int id)
        {
            using (Context db = new Context())
            {
                var result = db.Categories.FirstOrDefault(o => o.category_Id == id);
                db.Categories.Remove(result);
                db.SaveChanges();
            }

            return RedirectToAction("Index");

        }
















        public IActionResult KategoriEkle()
        {
            return View();
        }
    }
}
