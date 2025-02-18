using Microsoft.AspNetCore.Mvc;
using MVC_Intro.HomeWork.Models;

namespace MVC_Intro.HomeWork.Controllers
{
    public class DoctorController : Controller
    {
        public List<Doctor> docs { get; set; } = new List<Doctor>()
        {
            new(){Id = 1,Name="Seymur",DepartmentId=1},
            new(){Id = 2,Name="Lorem",DepartmentId=1},
            new(){Id = 3,Name="Ipsum",DepartmentId=2},
            new(){Id = 4,Name="Filankes",DepartmentId=2},
            new(){Id = 5,Name="Filan",DepartmentId=2},
            new(){Id = 6,Name="Kes",DepartmentId=3},
            new(){Id = 7,Name="Doler",DepartmentId=3},
            new(){Id = 8,Name="Doc",DepartmentId=4},
            new(){Id = 9,Name="Mrs",DepartmentId=5}
        };
        public IActionResult Index(int? _departmentId)
        {
            if (_departmentId is null )
            {
                return View(docs);
            }
            if(docs.Any(d=>d.DepartmentId==_departmentId))
                return View(docs.Where(d=>d.DepartmentId==_departmentId).ToList());
            return NotFound();
        }
    }
}
