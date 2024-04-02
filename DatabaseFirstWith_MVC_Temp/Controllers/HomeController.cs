using DatabaseFirstWith_MVC_Temp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DatabaseFirstWith_MVC_Temp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly CfstudentDbContext context;

        public HomeController(ILogger<HomeController> logger, CfstudentDbContext context)
        {
            _logger = logger;
            this.context = context;
        }

        public IActionResult Index()
        {
            var data = context.Students.ToList();
            return View(data);
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
