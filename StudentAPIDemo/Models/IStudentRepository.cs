using StudentAPIDemo.Models;

namespace StudentAPIDemo.Models
{
    public interface IStudentRepository
    {
        public IEnumerable<Student> GetAllStudents();

       public IEnumerable<Student> GetTeamAStudents();

        public IEnumerable<Student> GetTeamBStudents();

        public IEnumerable<Student> GetTeamCStudents();

        public IEnumerable<Student> GetTeamDStudents();

        public IEnumerable<Student> GetMaleStudents();

        public IEnumerable<Student> GetFemaleStudents();

        public IEnumerable<Student> GetStudentsWithS();
        Student InsertStudent(Student student);
        Student UpdateStudent( Student student);
        Student DeleteStudent(int studentID);

    }
}
