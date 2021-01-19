namespace Colonize.Models
{

    public class Ship
    {

        public int Id { get; set; }

        public string Name { get; set; }

        public int PassengerCapacity { get; set; }

        public string Description { get; set; }

        public string ImageUrl { get; set; }

        public string Drive { get; set; }

        public Ship(string name, string description, int passengerCapacity, string drive)
        {
            Name = name;
            PassengerCapacity = passengerCapacity;
            Description = description;
            Drive = drive;

        }

    }

}
