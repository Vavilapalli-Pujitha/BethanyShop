using Microsoft.AspNetCore.Mvc;
using StudentAPIDemo.Models;

namespace StudentAPIDemo.Controllers
{
    [ApiController]
    [Route("api/Student")]
    public class StudentController : ControllerBase
    {
        private readonly IStudentRepository studentRepository;
        public StudentController(IStudentRepository studentRepository)
        {
            this.studentRepository = studentRepository;
        }

        [HttpGet]
        [Route("GetAllStudents")]
        public IActionResult GetAllStudents()
        {
            var students = this
                .studentRepository.GetAllStudents();
            return Ok(students);
        }
        [HttpGet]
        [Route("GetStudent")]
        public IActionResult GetStudent(int id)
        {
            var student = this.studentRepository.GetAllStudents().FirstOrDefault(student => student.StudentID == id);
            if(student == null)
            {
                return NotFound("student not found for this id");
            }
            return Ok(student);
        }

        [HttpGet]
        [Route("GetTeamAStudents")]
        public IActionResult GetTeamAStudents()
        {
            var studentsA = this
                .studentRepository
                .GetTeamAStudents();
            return Ok(studentsA);
        }
        [HttpGet]
        [Route("GetTeamBStudents")]
        public IActionResult GetTeamBStudents()
        {
            var studentsB = this
                .studentRepository
                .GetTeamBStudents();
            return Ok(studentsB);
        }
        [HttpGet]
        [Route("GetTeamCStudents")]
        public IActionResult GetTeamCStudents()
        {
            var studentsC = this
                .studentRepository
                .GetTeamCStudents();
            return Ok(studentsC);
        }
        [HttpGet]
        [Route("GetTeamDStudents")]
        public IActionResult GetTeamDStudents()
        {
            var studentsD = this
                .studentRepository
                .GetTeamDStudents();
            return Ok(studentsD);
        }
        [HttpGet]
        [Route("GetMaleStudents")]
        public IActionResult GetMaleStudents()
        {
            var MaleStudents = this
                .studentRepository
                .GetMaleStudents();
            return Ok(MaleStudents);
        }
        [HttpGet]
        [Route("GetFemaleStudents")]
        public IActionResult GetFemaleStudents()
        {
            var FemaleStudents = this
                .studentRepository
                .GetFemaleStudents();
            return Ok(FemaleStudents);
        }
        [HttpGet]
        [Route("GetSNameStudents")]
        public IActionResult GetSNameStudents()
        {
            var GetSNameStudents = this
                .studentRepository
                .GetStudentsWithS();
            return Ok(GetSNameStudents);
        }
        [HttpPost]
        [Route("InsertStudent")]
        public IActionResult InsertStudent(Student student)
        {
            var insertedStudent = this
                .studentRepository
                .InsertStudent(student);
            return Ok(insertedStudent);
        }
        [HttpPut]
        [Route("UpdateStudent")]
        public IActionResult UpdateStudent(Student student)
        {
            var updatedStudent = this
                .studentRepository
                .UpdateStudent(student);
            return Ok(updatedStudent);
        }
        [HttpPost]
        [Route("DeleteStudent")]
        public IActionResult DeleteStudent(int studentID)
        {
            var student = this.studentRepository.GetAllStudents().FirstOrDefault(student => student.StudentID == studentID);
            if (student == null)
            {
                return BadRequest("student not found, try some other valid id");
            }
            var deletedStudent = this.studentRepository.DeleteStudent(studentID);
            return Ok(deletedStudent);
        }
    }
}
