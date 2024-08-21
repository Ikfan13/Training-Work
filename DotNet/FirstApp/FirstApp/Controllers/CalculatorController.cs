using FirstApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace FirstApp.Controllers
{
    public class CalculatorController : Controller
    {
        public IActionResult info()
        {
            Person p=new Person();
            p.Name = "Sanjai";
            p.Basic_Salary = 2000000;
            p.age = 200;
            return View(p);
        }
        public IActionResult Index()
        {
            ViewBag.Heading = "Calculator Application";
            return View() ;
        }

        public string add()
        {
            int a = 6;
            int b = 8;
            int c = a + b;
            return  c.ToString();
        }
        public IActionResult greetings()
        {
            return View();
        }
    }
}
