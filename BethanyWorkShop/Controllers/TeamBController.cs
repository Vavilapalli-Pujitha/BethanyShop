using BethanyWorkShop.Models;
using BethanyWorkShop.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace BethanyWorkShop.Controllers
{
    public class TeamBController : Controller
    {

        private readonly IStudentRepository studentRepository;
        
        public TeamBController(IStudentRepository studentRepository)
        {
            this.studentRepository = studentRepository;
        }
        public ViewResult ListB()
        {
            var studentsB = studentRepository.GetTeamBStudents();
            ViewBag.TeamBCount = studentsB.Count();
            StudentsWithCount studentsWithCount = new StudentsWithCount();
            studentsWithCount.students = studentsB;
            studentsWithCount.count = studentsB.Count();



            return View(studentsWithCount);

            
        }

    }
}
