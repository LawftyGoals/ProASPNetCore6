namespace LanguageFeatures.Controllers {
    public class HomeController : Controller {
        public ViewResult Index() {
            //Product?[] products = Product.GetProducts();


            // Null forgiving operator assures is not null
            //return View(new string[] { products[0]!.Name });
            //return View(new string[] { $"Name: {products[0]?.Name}, Price: {products[0]?.Price:C2}" });

            //return View("Index", new string[] { "bob", "joe", "Alice" });

            //Dictionary<string, Product> products = new Dictionary<string, Product> { { "Kayak", new Product { Name = "Kayak", Price = 275M } }, { "Lifejacket", new Product { Name = "Lifejacket", Price = 48.95M } } };
            //Dictionary<string, Product> products = new Dictionary<string, Product> { ["Kayak"] = new Product { Name = "Kayak", Price = 275M }, ["Lifejacket"] = new Product { Name = "Lifejacket", Price = 48.95M } };

            //Target Typed
            //Dictionary<string, Product> products = new () { ["Kayak"] = new Product { Name = "Kayak", Price = 275M }, ["Lifejacket"] = new Product { Name = "Lifejacket", Price = 48.95M } };
            //
            //return View("Index", products.Keys);

            //object[] data = new object[] { 275M, 29.95M, "apple", "orange", 100, 10 };
            //decimal total = 0;
            //for (int i = 0; i < data.Length; i++)
            //{
            //    if (data[i] is decimal d)
            //    {
            //        total += d;
            //    }
            //}
            //
            //total = 0;
            //foreach (var dat in data)
            //{
            //    if (dat is decimal d)
            //    {
            //        total += d;
            //    }
            //}
            //
            //total = 0;
            //
            //foreach (var dat in data)
            //{
            //    switch (dat)
            //    {
            //        case decimal dv:
            //            total += dv;
            //            break;
            //        case int iv when iv > 50:
            //            total += iv;
            //            break;
            //    };
            //}

            ShoppingCart cart = new() { Products = Product.GetProducts() };
            //decimal cartTotal = cart.TotalPrices();
            //
            //return View("Index", new string[] { $"Total: {cartTotal:C2}" });

            Product[] productArray = { new Product { Name = "Kayak", Price = 265M }, new Product { Name = "Lifejacket", Price = 48.95M } };

            decimal cartTotal = cart.TotalPrices();
            decimal arrayTotal = productArray.TotalPrices();

            return View("Index", new string[] { $"Cart: {cartTotal:C2}", $"Array: {arrayTotal:C2}" });
        }
    }
}
