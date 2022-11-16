using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.Controllers
{
    public class ECO : Controller
    {
        private readonly IProductService prosev;

        public ECO(IProductService prosev)
        {
            this.prosev = prosev;
        }

        public IActionResult Index()
        {
            return View();
        }
         
        public IActionResult List()
        {
            var result = prosev.GetAllProduct();
            return View(result);
        }
        
    }
}
