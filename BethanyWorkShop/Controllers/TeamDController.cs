using BethanyWorkShop.Models;
using BethanyWorkShop.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace BethanyWorkShop.Controllers
{
    public class TeamDController : Controller
    {

        private readonly IStudentRepository studentRepository;
        

        public TeamDController(IStudentRepository studentRepository)
        {
            this.studentRepository = studentRepository;
        }
        public ViewResult ListD()
        {
            var studentsD = studentRepository.GetTeamDStudents();
            ViewBag.TeamDCount = studentsD.Count();
            StudentsWithCount studentsWithCount = new StudentsWithCount();
            studentsWithCount.students = studentsD;
            studentsWithCount.count = studentsD.Count();



            return View(studentsWithCount);


        }
    }
}
