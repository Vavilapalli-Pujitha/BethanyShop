using BethanyWorkShop.Models;
using BethanyWorkShop.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace BethanyWorkShop.Controllers
{
    public class TeamAController : Controller
    {

        private readonly IStudentRepository studentRepository;

        public TeamAController(IStudentRepository studentRepository)
        {
            this.studentRepository = studentRepository;
        }
        public ViewResult ListA()
        {
            var studentsA = studentRepository.GetTeamAStudents();
            ViewBag.TeamACount = studentsA.Count();
            StudentsWithCount studentsWithCount = new StudentsWithCount();
            studentsWithCount.students = studentsA;
            studentsWithCount.count = studentsA.Count();



            return View(studentsWithCount);


        }

    }
}

