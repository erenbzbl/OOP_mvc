using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using YeniProje_OOP.Entity;
using YeniProje_OOP.ProjeContext;

namespace YeniProje_OOP.Controllers
{
    public class ProductController1 : Controller
    {
        Context context = new Context();
        public IActionResult Index()
        {
            var values = context.Products.ToList();
            return View(values);
        }
        [HttpGet] // Aşadağı ki metodun sayfa açıldığında çalışmasını istediğimiz zaman Httpget kullanırlır. 
        public IActionResult AddProduct()
        {
            return View();
        }
        [HttpPost] // Gönderme işlemi yapmak istediğimiz zaman kullanılır.
        public IActionResult AddProduct(Product p)
        {
            context.Add(p); // Parametreden gelen değerleri eklemek için kullandık.
            context.SaveChanges(); // ekleme işlemi yaptıktan sonra değişiklikleri kaydediyoruz
            return RedirectToAction("Index"); // Index actionuna yönlendirdik, ekleme işlemi yaptık buradan da index'e yönlendirdik. 
        }
        public IActionResult DeleteProduct(int id)
        {
            var value = context.Products.Where(x => x.ID == id).FirstOrDefault();
            context.Remove(value);
            context.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}
