using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BikeShop_Services.Orders
{
    public class UserViewModel
    {
        [Required]
        [Display(Name = "First Name")]
        [RegularExpression(@"^[a-zA-ZąćęłńóśźżĄĆĘŁŃÓŚŹŻ]+$", ErrorMessage = "You should use letters only")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        [RegularExpression(@"^[a-zA-ZąćęłńóśźżĄĆĘŁŃÓŚŹŻ]+$", ErrorMessage = "You should use letters only")]
        public string LastName { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [Display(Name = "Phone number")]
        [RegularExpression(@"(?<!\w)(\(?(\+|00)?48\)?)?[ -]?\d{3}[ -]?\d{3}[ -]?\d{3}(?!\w)", ErrorMessage = "You enetred wrong number")]
        public string PhoneNumber { get; set; }

        [Required]
        [Display(Name = "Address")]
        [StringLength(50, MinimumLength = 5, ErrorMessage = "Phrase length must be between 5 and 50 characters")]
        public string Address { get; set; }

        [Required]
        [Display(Name = "City")]
        [RegularExpression(@"^[a-zA-Z]+(?:[\s-][a-zA-Z]+)*$", ErrorMessage = "City name has incorrect format")]
        public string City { get; set; }

        [Required]
        [Display(Name = "Country")]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "You should use letters only")]
        public string Country { get; set; }
    }
}
