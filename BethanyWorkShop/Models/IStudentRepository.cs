namespace BethanyWorkShop.Models
{
    public interface IStudentRepository
    {
        IEnumerable<Student> GetAllStudents();
        IEnumerable<Student> GetTeamAStudents();

        IEnumerable<Student> GetTeamBStudents();
        IEnumerable<Student> GetTeamCStudents();
        IEnumerable<Student> GetTeamDStudents();
        IEnumerable<Student> GetMaleStudents();
        IEnumerable<Student> GetFemaleStudents();
        IEnumerable<Student> SStudents();
        int UpdateStudent(Student student);
        int CreateStudent(Student student);
        int RemoveStudent(Student student);


    }
}
