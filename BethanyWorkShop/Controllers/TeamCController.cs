using BethanyWorkShop.Models;
using BethanyWorkShop.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace BethanyWorkShop.Controllers
{
    public class TeamCController : Controller
    {

        private readonly IStudentRepository studentRepository;
        
        public TeamCController(IStudentRepository studentRepository)
        {
            this.studentRepository = studentRepository;
        }
        public ViewResult ListC()
        {
            var studentsC = studentRepository.GetTeamCStudents();

            ViewBag.TeamCCount = studentsC.Count();
            StudentsWithCount studentsWithCount = new StudentsWithCount();
            studentsWithCount.students = studentsC;
            studentsWithCount.count = studentsC.Count();



            return View(studentsWithCount);
           
        }

    }
}
