using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
// created by Dani Luensman, Donna Quach, & Victor Ortiz  11/21/2019  Team Project

// Followed Week 6 & 7 Labs (Microsoft) to create the form for creating/managing a user 
namespace finalGroupProject.Models
{
    public class CarSupply
    {
        // used regular expressions from http://regexlib.com
        public int ID { get; set; }

        [Required(ErrorMessage = "Please enter a first name.")]
        [RegularExpression(@"^[a-zA-Z]{2,25}", 
            ErrorMessage ="First name must be at least 2 letters and no more than 25 letters.")]
        [Display(Name = "First Name:")]
        public string fName { get; set; }

        [Required(ErrorMessage = "Please enter a last name.")]
        [RegularExpression(@"^[a-zA-Z]{2,25}", 
            ErrorMessage = "Last name must be at least 2 letters and no more than 25 letters.")]
        [Display(Name = "Last Name:")]
        public string lName { get; set; }

        [Required(ErrorMessage = "Please enter a street address.")]
        [RegularExpression(@"^[a-zA-Z0-9 ]{8,75}", 
            ErrorMessage ="Street address must be a valid address with at least 8 characters.")]
        [Display(Name = "Street Address:")]
        public string address { get; set; }

        [Required(ErrorMessage = "Please enter a city.")]
        [RegularExpression(@"^[a-zA-Z-]{2,20}", 
            ErrorMessage ="City name must be at least 2 letters and no more than 20 letters.")]
        [Display(Name = "City:")]
        public string city { get; set; }

        [Required(ErrorMessage = "Please enter a state abbreviation.")]
        [RegularExpression(@"^[A-Z]{2}", 
            ErrorMessage ="State must be a 2 letter abbreviation.")]
        [Display(Name = "State:")]
        public string state { get; set; }

        [Required(ErrorMessage = "Please enter a zip code.")]
        [RegularExpression(@"^\d{5}(-\d{4})?$",
            ErrorMessage ="Zip code must be 5 or 9 digits.")]
        //[DataType(DataType.PostalCode)]
        [Display(Name = "Zip Code:")]
        public string zip { get; set; }

        [Required(ErrorMessage = "Please enter a phone number.")]
        [RegularExpression(@"^\D?(\d{3})\D?\D?(\d{3})\D?(\d{4})$",
            ErrorMessage ="Phone number must include a 3 digit area code and a 5 digit phone number.")]
        //[DataType(DataType.PhoneNumber)]
        [Display(Name = "Phone Number:")]
        public string phone { get; set; }

        [Required(ErrorMessage = "Please enter a user name.")]
        [RegularExpression(@"^[a-zA-Z0-9]{8,20}",
            ErrorMessage = "User name must be between 8 and 20 characters.")]
        [Display(Name = "User Name:")]
        public string userName { get; set; }

        [Required(ErrorMessage = "Please enter a password.")]
        [RegularExpression(@"^(?=.{8,})(?=.*[1-9])(?=.*[a-z])(?=.*[A-Z])(?=.*[(!@#$%^&*()_+|~\- =\`{}[\]:”;'<>?,.\/, )])(?!.*(.)\1{2,}).+$",
            ErrorMessage = "Password must be at least 8 characters with at least 1 uppercase letter, 1 digit and 1 special character.")]
        [DataType(DataType.Password)]
        [Display(Name = "Password:")]
        public string password { get; set; }
    }
}
