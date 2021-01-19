using System;
using System.Collections;
using System.Collections.Generic;

namespace Colonize.Models
{

    public class Voyage

    {


        public int Id { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }

        public string Destination { get; set; }

        public DateTime DepartureAt { get; set; }

        public DateTime ArrivalAt { get; set; }

        public Ship Ship { get; set; }

        public IList<Passenger> Passengers { get; set; } = new List<Passenger>();


        public Voyage(string name, string description, string destination, DateTime DepartureAt, DateTime ArrivalAt, Ship ship)
        {
            Name = name;
            Description = description;
            Destination = destination;
            this.DepartureAt = DepartureAt;
            this.ArrivalAt = ArrivalAt;
            Ship = ship;
        }

        public Voyage(string name, string description, string destination, DateTime DepartureAt, DateTime ArrivalAt)
        {
            Name = name;
            Description = description;
            Destination = destination;
            this.DepartureAt = DepartureAt;
            this.ArrivalAt = ArrivalAt;

        }


    }

}