using EntitiesLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace ProjectUI.Controllers
{
    public class ProductController : Controller
    {
        public ActionResult Index()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:5006/");
                var getTask = client.GetAsync($"api/Products/");
                getTask.Wait();

                var result = getTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readJsonTask = result.Content.ReadAsAsync<IEnumerable<Product>>();
                    readJsonTask.Wait();
                    return View(readJsonTask.Result);

                }

                else
                {
                    return Content("Aranan kayıt bulunamadı");
                }
            }
        }
        // GET: ProductController/Details/5
        public ActionResult Details(int id)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:5006/");
                var getTask = client.GetAsync($"api/Products/{id}");
                getTask.Wait();

                var result = getTask.Result;
                var readJsonTask = result.Content.ReadAsAsync<Product>();

                readJsonTask.Wait();
                Product _product = readJsonTask.Result;
                return View(_product);
            }
        }
        // GET: ProductController/Create
        public ActionResult Create()
        {
            return View(new Product());
        }

        // POST: ProductController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Product newProduct)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:5006/");
                var postTask = client.PostAsJsonAsync("api/products/", newProduct);
                postTask.Wait();
                var result = postTask.Result;

                if (result.IsSuccessStatusCode)
                {
                    return RedirectToAction("Index");
                }

                else
                {
                    ViewBag.ErrorMessage = "Hata Oluştu";
                    return View(newProduct);
                }
            }
        }
        // GET: ProductController/Edit/5
        public ActionResult Edit(int id)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:5006/");
                var getTask = client.GetAsync($"api/products/{id}");
                getTask.Wait();

                var result = getTask.Result;
                var readJsonTask = result.Content.ReadAsAsync<Product>();

                readJsonTask.Wait();
                Product _product = readJsonTask.Result;
                return View(_product);

            }
        }
    }
}
