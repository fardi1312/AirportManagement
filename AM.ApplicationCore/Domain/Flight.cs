﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Flight
    {
        public string Destination { get; set; }
        public string Departure { get; set; }
        public DateTime FlightDate { get; set; }
        public int FlightId { get; set; }
        public DateTime EffectiveArrival { get; set; }
        public int EstimatedDuration { get; set; }
        public Plane MyPlane { get; set; }

        public ICollection<Passenger> passengers { get; set; }


        public override string ToString()
                {
                    return "FlightId: " + FlightId + " Destination: " + Destination + " Departure: " + Departure + " FlightDate: " + FlightDate + " EffectiveArrival: " + EffectiveArrival + " EstimatedDuration: " + EstimatedDuration + " Plane: " + MyPlane;
                }

    }
}
