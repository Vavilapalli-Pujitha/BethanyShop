using BethanyWorkShop.Models;
namespace BethanyWorkShop.Models.ViewModels
{
    public class StudentsWithCount
    {

        public IEnumerable<Student> students { get; set; }
        public int count { get; set; }
        

    }
}