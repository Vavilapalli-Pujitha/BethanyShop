using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.ComponentModel.DataAnnotations;

namespace BethanyWorkShop.Models
{
    public class Student
    {
        public int StudentID { get; set; }
        /*[Display(Name = "First Name")]
        [StringLength(10)]
        [Required(ErrorMessage = " Please Enter First Name")]*/
        public string FirstName { get; set; }
       /* [Display(Name = "Last Name")]
        [StringLength(10)]*/
        public string LastName { get; set; }
       /* [Range(15,40)]
        [BindNever] */  
        public int Age { get; set; }
        public string Gender { get; set; }
        /*[Display(Name = "Team Name")]
        [StringLength(10)]*/
        public string TeamName { get; set; }
       /* [RegularExpression("")]
        public string EmailID { get; set; }
        [CreditCard]
        [Compare("Age",ErrorMessage = "")]
        public string CreditCardNumber { get; set; }
        [Phone()]
        public string Password { get; set; }
        public override string ToString()
        {
            return "First Name: " + this.FirstName + " Last Name: " + this.LastName + "Age:" + this.Age + "Gender:" + this.Gender + " Team Name: " + this.TeamName;
        } */

    }
}
