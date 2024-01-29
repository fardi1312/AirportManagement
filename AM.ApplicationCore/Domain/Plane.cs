using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    internal class Plane
    {
        private int capacity { get; set; }
        public DateTime ManufactureDate { get; set; }
        public int PlaneId { get; set; }
        public PlaneType PlaneType { get; set; }

        ICollection<Flight> flights { get; set; }

        ICollection<Passenger> passengers { get; set; }


        public override string ToString() { 
            return "PlaneId: " + PlaneId + " ManufactureDate: " + ManufactureDate + " PlaneType: " + PlaneType + " Capacity: " + capacity;
        }

    }

    public enum PlaneType { Boing , Airbus  }

}
