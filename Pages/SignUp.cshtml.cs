using System.ComponentModel.DataAnnotations;
using System.Linq;
using Colonize.Data;
using Colonize.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Colonize.Pages

{

    public class SignUpModel : PageModel

    {

        private readonly ColonizeContext _context;


        public SignUpModel(ColonizeContext context)
        {

            _context = context;
        }




        public IActionResult OnPost(SignUp signup)
        {

            if (!ModelState.IsValid)
            {
                return Page();

            }
            var passenger = new Passenger(signup.FirstName, signup.LastName, signup.SocialSecurityNumber, signup.Email);

            var voyage = _context.Voyage.FirstOrDefault();

            voyage.Passengers.Add(passenger);

            _context.SaveChanges();

            return RedirectToPage("ThankYou");


        }

        public class SignUp
        {

            [Required]
            [MaxLength(25)]
            public string FirstName { get; set; }
            [Required]
            [MaxLength(25)]
            public string LastName { get; set; }
            [Required]
            [RegularExpression(@"[0-9]{2}-[0-9]{2}-[0-9]{2}-[0-9]{4}",
         ErrorMessage = "Social security number is in the wrong format.")]
            public string SocialSecurityNumber { get; set; }
            [Required]
            [MaxLength(100)]
            [EmailAddress]
            public string Email { get; set; }

        }

    }

}