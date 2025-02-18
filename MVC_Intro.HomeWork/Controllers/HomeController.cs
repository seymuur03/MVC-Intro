using Microsoft.AspNetCore.Mvc;
using MVC_Intro.HomeWork.Models;

namespace MVC_Intro.HomeWork.Controllers
{
    public class HomeController : Controller
    {
        public List<Department> Deps { get; set; } = new List<Department>()
        {
            new(){Id = 1,Name="Dep1"},
            new(){Id = 2,Name="Dep2"},
            new(){Id = 3,Name="Dep3"}
        };
        public IActionResult Index()
        {

            return View(Deps);
        }
    }
}
