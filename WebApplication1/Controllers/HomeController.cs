using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication1.Data;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private Unit UnitOfWork;
        public HomeController(ILogger<HomeController> logger)
        {
            this.UnitOfWork=new Unit();
            _logger = logger;
        }

        public IActionResult courses()
        { 
            return View(this.UnitOfWork.student.GetCourses());
        }

        public IActionResult course(String cours)
        {
            ViewData["Title"] = cours;
            return View(this.UnitOfWork.student.Find(x=>x.course==cours));
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}