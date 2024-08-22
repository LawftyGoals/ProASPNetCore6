using System.Text.Json;

namespace LanguageFeatures.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            Product?[] products = Product.GetProducts();


            // Null forgiving operator assures is not null
            //return View(new string[] { products[0]!.Name });
            //return View(new string[] { $"Name: {products[0]?.Name}, Price: {products[0]?.Price:C2}" });

            return View("Index", new string[] { "bob", "joe", "Alice" });
        }
    }
}
