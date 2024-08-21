using FirstApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace FirstApp.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            Product p=new Product();
            p.Product_Id = 1;
            p.Product_Name = "Acer Nitro";
            p.Product_price = 50000;
            p.Product_Description = "This laptop has i7-13thgen intel processor with 1tb ssd and 6gb graphics nvidia gtx4060 ";
            return View(p);
        }
    }
}
