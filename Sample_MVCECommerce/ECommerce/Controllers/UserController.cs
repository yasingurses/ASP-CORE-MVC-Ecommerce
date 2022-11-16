using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using EntityLayer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using System.Linq;

namespace ECommerce.Controllers
{
    public class UserController : Controller
    {
        UserMan um = new UserMan(new UserRepo());
        [Authorize(Roles = "Admin")]
        public IActionResult Index()
        {
            var values = um.GetAllUser();
            return View(values);
        }
        [HttpGet]
        public IActionResult Ekle()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Ekle(User user)
        {
            um.AddUser(user);
            return RedirectToAction("Index");
        }
        [Authorize(Roles = "Admin")]
        [HttpGet]
        public IActionResult Guncelle(int id)
        {
            using (Context c = new Context())
            {
                var result = c.users.FirstOrDefault(o => o.UserID == id);

                return View(result);
            }
        }
        [HttpPost]
        public IActionResult Guncelle(User user)
        {
            var result = um.UpdateUser(user);

            return RedirectToAction("Index");
        }

        [Authorize(Roles = "Admin")]
        [HttpGet]
        public IActionResult Sil(int id)
        {
            using (Context db = new Context())
            {
                var result = db.users.FirstOrDefault(o => o.UserID == id);
                db.users.Remove(result);
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
