using System.ComponentModel.DataAnnotations;

namespace ModelValidationExample.Models
{
public class Person
    {
        [Required(ErrorMessage ="Person Name can't be emplty or null")]
        public string? PersonName { get; set; }

        public string? Email { get; set; }
        public string? Phone { get; set; }
        public string? Password { get; set; }
        public string? ConfrimPassword { get; set; }
        public string? Price { get; set; }

        public override string ToString()
        {
            return $"Person Object-person name:{PersonName} ,email:{Email},phone:{Phone},password:{Password},confirm Password :{ConfrimPassword},price:{Price}  ";
        }
    }

}
