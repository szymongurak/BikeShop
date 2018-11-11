using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using BikeShop_DAL.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BikeShop_MVC.Areas.Identity.Pages.Account.Manage
{
    public partial class IndexModel : PageModel
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        private readonly IEmailSender _emailSender;

        public IndexModel(
            UserManager<User> userManager,
            SignInManager<User> signInManager,
            IEmailSender emailSender)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _emailSender = emailSender;
        }

        public string Username { get; set; }

        [TempData]
        public string StatusMessage { get; set; }

        [BindProperty]
        public InputModel Input { get; set; }

        public class InputModel
        {   
            [Required]
            [EmailAddress]
            public string Email { get; set; }

            [Display(Name = "FirstName")]
            [RegularExpression(@"^[a-zA-ZąćęłńóśźżĄĆĘŁŃÓŚŹŻ]+$", ErrorMessage = "You should use letters only")]
            public string FirstName { get; set; }

            [Display(Name = "LastName")]
            [RegularExpression(@"^[a-zA-ZąćęłńóśźżĄĆĘŁŃÓŚŹŻ]+$", ErrorMessage = "You should use letters only")]
            public string LastName { get; set; }

            [Display(Name = "Address")]
            [StringLength(50, MinimumLength = 5, ErrorMessage ="Phrase length must be between 5 and 50 characters")]
            public string Address { get; set; }
            
            [Display(Name = "City")]
            [RegularExpression(@"^[a-zA-Z]+(?:[\s-][a-zA-Z]+)*$", ErrorMessage = "City name has incorrect format")]
            public string City { get; set; }

            [Display(Name = "Country")]
            [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "You should use letters only")]
            public string Country { get; set; }

            [Display(Name = "Phone number")]
            [RegularExpression(@"(?<!\w)(\(?(\+|00)?48\)?)?[ -]?\d{3}[ -]?\d{3}[ -]?\d{3}(?!\w)", ErrorMessage = "You enetred wrong number")]
            public string PhoneNumber { get; set; }
        }

        public async Task<IActionResult> OnGetAsync()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return NotFound($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
            }

            var userName = await _userManager.GetUserNameAsync(user);
            var email = await _userManager.GetEmailAsync(user);
            var phoneNumber = await _userManager.GetPhoneNumberAsync(user);
            var firstName = user.FirstName;
            var lastName = user.LastName;
            var address = user.Address;
            var city = user.City;
            var country = user.Country;


            Username = userName;

            Input = new InputModel
            {
                
                Email = email,
                PhoneNumber = phoneNumber,
                Address = address,
                City = city, 
                FirstName = firstName,
                LastName = lastName,
                Country = country
            };

            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return NotFound($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
            }

            var email = await _userManager.GetEmailAsync(user);
            if (Input.Email != email)
            {
                var setEmailResult = await _userManager.SetEmailAsync(user, Input.Email);
                if (!setEmailResult.Succeeded)
                {
                    var userId = await _userManager.GetUserIdAsync(user);
                    throw new InvalidOperationException($"Unexpected error occurred setting email for user with ID '{userId}'.");
                }
            }

            var phoneNumber = await _userManager.GetPhoneNumberAsync(user);
            if (Input.PhoneNumber != phoneNumber)
            {
                var setPhoneResult = await _userManager.SetPhoneNumberAsync(user, Input.PhoneNumber);
                if (!setPhoneResult.Succeeded)
                {
                    var userId = await _userManager.GetUserIdAsync(user);
                    throw new InvalidOperationException($"Unexpected error occurred setting phone number for user with ID '{userId}'.");
                }
            }

            var firstName = user.FirstName;
            if (Input.FirstName != firstName)
            {
                user.FirstName = Input.FirstName;
                await _userManager.UpdateAsync(user);
            }

            var lastName = user.LastName;
            if (Input.LastName != lastName)
            {
                user.LastName = Input.LastName;
                await _userManager.UpdateAsync(user);
            }

            var address = user.Address;
            if(Input.Address != address)
            {
                user.Address = Input.Address;
                await _userManager.UpdateAsync(user);
            }

            var city = user.City;
            if (Input.City != city)
            {
                user.City = Input.City;
                await _userManager.UpdateAsync(user);
            }

            var country = user.Country;
            if (Input.Country != country)
            {
                user.Country = Input.Country;
                await _userManager.UpdateAsync(user);
            }


            await _signInManager.RefreshSignInAsync(user);
            StatusMessage = "Your profile has been updated";
            return RedirectToPage();
        }
    }
}
