using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace APIs.Model
{
    public class User 
    {

        public int Id { get; set; }
        [Required]
        [MaxLength(20, ErrorMessage = "First name cannot be longer than 20 characters.")]
        [RegularExpression(@"^[a-zA-Z\u0600-\u06FF\s]+$", ErrorMessage = "First name can only contain Arabic or English letters and spaces.")]
        public string FirstName { get; set; }


        [MaxLength(40, ErrorMessage = "Middle name cannot be longer than 40 characters.")]
        [RegularExpression(@"^[a-zA-Z\u0600-\u06FF\s]+$", ErrorMessage = "Middle name can only contain Arabic or English letters and spaces.")]
        public string MiddleName { get; set; }


          [Required]
        [MaxLength(20, ErrorMessage = "Last name cannot be longer than 20 characters.")]
        [RegularExpression(@"^[a-zA-Z\u0600-\u06FF\s]+$", ErrorMessage = "Last name can only contain Arabic or English letters and spaces.")]
        public string LastName { get; set; }





        [Required]
        public string password { get; set; }


        [Required]
        [DataType(DataType.Date)]
        [Range(typeof(DateTime) , "", "2004-11-27" , ErrorMessage = "You must be at least 20 years old.")]

        //[CustomValidation(typeof(UserModel), "ValidateBirthDate", ErrorMessage = "You must be at least 20 years old.")]
        public DateTime BirthDate { get; set; }





        [Required]
        [Phone]
        [RegularExpression("^01[0125][0-9]{8}$", ErrorMessage = "Mobile number must be in the format +021006158123.")]
        public string MobileNumber { get; set; }



       [Required]
        [EmailAddress(ErrorMessage = "Invalid email address.")]
        public string Email { get; set; }


       public virtual List<UserAddress>? Addresses { get; set; }





        //public static ValidationResult ValidateBirthDate(DateTime birthDate, ValidationContext context)
        //{
        //    var age = DateTime.Today.Year - birthDate.Year;
          //  if (birthDate > DateTime.Today.AddYears(-age)) age--;
           // return age >= 20 ? ValidationResult.Success : new ValidationResult("You must be at least 20 years old.");
        //}
    }
}
