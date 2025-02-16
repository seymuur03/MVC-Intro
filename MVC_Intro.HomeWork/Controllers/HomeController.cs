using Microsoft.AspNetCore.Mvc;
using MVC_Intro.HomeWork.Models;

namespace MVC_Intro.HomeWork.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            Doctor doctor = new Doctor()
            {
                Id=1,
                Name="Seymur"
            };
            return View(doctor);
        }
    }
}
