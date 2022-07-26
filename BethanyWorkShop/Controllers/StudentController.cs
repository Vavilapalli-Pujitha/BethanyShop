using BethanyWorkShop.Models;
using BethanyWorkShop.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace BethanyWorkShop.Controllers
{
    public class StudentController : Controller
    {
        //declaring object for your interface IstudentRepository
        private readonly IStudentRepository studentRepository;
        private int id;

        public StudentController(IStudentRepository studentRepository)
        {
            this.studentRepository = studentRepository;
        }

        public ViewResult List()
        {

            var students = studentRepository.GetAllStudents(); 
            ViewBag.AllStudentsCount = students.Count();
            StudentsWithCount studentsWithCount = new StudentsWithCount();
            studentsWithCount.students = students;
            studentsWithCount.count = students.Count();



            return View(studentsWithCount);

        }
        public ViewResult Details(int id)
        {
            var student = studentRepository.GetAllStudents().FirstOrDefault(student => student.StudentID == id);
            return View(student);
        }
        public ViewResult Edit(int id)
        {
            var student = studentRepository.GetAllStudents().FirstOrDefault(student => student.StudentID == id);
            return View(student);
        }
        [HttpPost]
        public IActionResult UpdateStudent(Student student)
        {
            studentRepository.UpdateStudent(student);
            return RedirectToAction("List");
        }
        public ViewResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateStudent(Student student)
        {
            
                int result = studentRepository.CreateStudent(student);
                return RedirectToAction("List");
            
            

        }
        public IActionResult Remove(int id)
        {

            var student = studentRepository.GetAllStudents().FirstOrDefault(student => student.StudentID == id);
            studentRepository.RemoveStudent(student);
            return RedirectToAction("List");

        }

        public ViewResult GetMaleStudents()
        {

            var students = studentRepository.GetMaleStudents();
            ViewBag.MaleCount = students.Count();
            StudentsWithCount studentsWithCount = new StudentsWithCount();
            studentsWithCount.students = students;
            studentsWithCount.count = students.Count();


            return View(studentsWithCount);
        }
        public ViewResult GetFemaleStudents()
        {

            var students = studentRepository.GetFemaleStudents();
            ViewBag.FemaleCount = students.Count();
            StudentsWithCount studentsWithCount = new StudentsWithCount();
            studentsWithCount.students = students;
            studentsWithCount.count = students.Count();


            return View(studentsWithCount);
        }
        public ViewResult SStudents()
        {
            var students = studentRepository.SStudents();
            ViewBag.SStudentsCount = students.Count();
            StudentsWithCount studentsWithCount = new StudentsWithCount();
            studentsWithCount.students = students;
            studentsWithCount.count = students.Count();
            return View(studentsWithCount);
    }
       

    }



}

