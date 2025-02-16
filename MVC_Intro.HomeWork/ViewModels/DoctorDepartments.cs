using MVC_Intro.HomeWork.Models;

namespace MVC_Intro.HomeWork.ViewModels
{
    public class DoctorDepartments
    {
        public Department Department { get; set; }
        public List<Doctor> Doctors { get; set; }
    }
}
