using System.Diagnostics;
using IT_Elective_2_Pre_final_exam_Bulandus.Models;
using Microsoft.AspNetCore.Mvc;

namespace IT_Elective_2_Pre_final_exam_Bulandus.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
