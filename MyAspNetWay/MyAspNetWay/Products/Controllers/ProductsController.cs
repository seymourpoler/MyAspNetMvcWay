using System.Web.Mvc;

namespace MyAspNetWay.Products.Controllers
{
    public class ProductsController : Controller
    {
        public ActionResult Index()
        {
            return View("Index.cshtml");
        }
    }
}
