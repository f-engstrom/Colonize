namespace Colonize.Models
{

    public class Passenger
    {

        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string SocialSecurityNumber { get; set; }

        public string Email { get; set; }


        public Passenger(string firstName, string lastName, string socialSecurityNumber, string email)
        {
            FirstName = firstName;
            LastName = lastName;
            SocialSecurityNumber = socialSecurityNumber;
            Email = email;
        }

    }

}
