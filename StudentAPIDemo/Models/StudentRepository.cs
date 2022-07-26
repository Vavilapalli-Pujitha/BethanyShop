using StudentAPIDemo.Models;

namespace StudentAPIDemo.Models
{
    public class StudentRepository : IStudentRepository
    {
        private readonly AppDbContext appDbContext;
        public StudentRepository(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }

        public IEnumerable<Student> GetAllStudents()
        {
            var students = appDbContext.Students;
            return students;
        }

        public IEnumerable<Student> GetFemaleStudents()
        {
            var students = appDbContext.Students
                .Where(student => student.Gender.ToUpper() == "F");
            return students;
        }

        public IEnumerable<Student> GetMaleStudents()
        {
            var students = appDbContext.Students
                .Where(student => student.Gender.ToUpper() == "M");
            return students;
        }

        public IEnumerable<Student> GetStudentsWithS()
        {
            var students = appDbContext.Students
                .Where(student => student.FirstName.ToUpper().StartsWith('S'));
            return students;
        }

        public IEnumerable<Student> GetTeamAStudents()
        {
            var students = appDbContext.Students
                .Where(student => student.TeamName.ToUpper() == "A");
            return students;
        }

        public IEnumerable<Student> GetTeamBStudents()
        {
            var students = appDbContext.Students
                .Where(student => student.TeamName.ToUpper() == "B");
            return students;
        }

        public IEnumerable<Student> GetTeamCStudents()
        {
            var students = appDbContext.Students
                .Where(student => student.TeamName.ToUpper() == "C");
            return students;
        }

        public IEnumerable<Student> GetTeamDStudents()
        {
            var students = appDbContext.Students
                .Where(student => student.TeamName.ToUpper() == "D");
            return students;
        }

        public Student InsertStudent(Student student)
        {
           var entry = this.appDbContext.Students.Add(student);
            this.appDbContext.SaveChanges();
            return entry.Entity;
        }

        public Student UpdateStudent( Student student)
        {
            var entry = this.appDbContext.Students.Update(student);
            this.appDbContext.SaveChanges();
            return entry.Entity;
        }
        public Student DeleteStudent(int studentID)
        {
            var student = GetAllStudents().FirstOrDefault(student => student.StudentID == studentID);
            var entry = this.appDbContext.Students.Remove(student);
            this.appDbContext.SaveChanges();
            return entry.Entity;
        }

    }
}