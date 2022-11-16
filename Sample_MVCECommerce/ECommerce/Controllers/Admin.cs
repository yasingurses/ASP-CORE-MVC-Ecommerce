using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using EntityLayer;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace ECommerce.Controllers
{
    public class Admin : Controller
    {
        
        ProductManager pm = new ProductManager(new ProductDal());


        [Authorize(Roles ="Admin")]
        public IActionResult Index()
        {
            var values = pm.GetAllProduct();
            return View(values);
        }
        [HttpGet]
        public IActionResult Ekle()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Ekle(Product product)
        {
            pm.AddProduct(product);
            return RedirectToAction("Index");
        }
        [Authorize(Roles = "Admin")]
        [HttpGet]
        public IActionResult Guncelle(int id)
        {
            using (Context c = new Context())
            {
                var result = c.Products.FirstOrDefault(o => o.product_Id == id);
             
                return View(result);
            }
        }
        [HttpPost]
        public IActionResult Guncelle(Product product)
        {
            var result = pm.UpdateProduct(product);
         
            return RedirectToAction("Index");
        }

        [Authorize(Roles = "Admin")]
        [HttpGet]
        public IActionResult Sil(int id)
        {
            using (Context db = new Context())
            {
                var result = db.Products.FirstOrDefault(o => o.product_Id == id);
                db.Products.Remove(result);
                db.SaveChanges();
            }

            return RedirectToAction("Index");

        }
        
        [HttpGet]
        public IActionResult Login(string returnUrl)
        {
            TempData["returnUrl"] = returnUrl;
            return View();

        }

        [HttpPost]
        public async Task<IActionResult> Login(User use)
        {
            Context c = new Context();
            var admin = c.users.FirstOrDefault(x => x.Username == use.Username && x.UserPassword == use.UserPassword);
            if (admin != null) 
            {
                var claims = new List<Claim>  
                { new Claim(ClaimTypes.Name,admin.Username),
                 new Claim(ClaimTypes.Role, admin.UserRole)
                };


                var useridentity = new ClaimsIdentity(claims, "Login"); 
                ClaimsPrincipal principal = new ClaimsPrincipal(useridentity); 
                                                                               
                await HttpContext.SignInAsync(principal); 
                
                if (TempData["returnUrl"] != null)
                {
                    if (Url.IsLocalUrl(TempData["returnUrl"].ToString()))
                    {
                        return Redirect(TempData["returnUrl"].ToString());
                    }
                }
                else
                {
                    return RedirectToAction("Index", "Admin");
                }

            }
            
            return View();

        }
        public async Task<IActionResult> Logout()
        {

            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Login", "Admin");
        }
        
    }
}
