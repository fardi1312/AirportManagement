using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Plane
    {
        public int capacity { get; set; }
        public DateTime ManufactureDate { get; set; }
        public int PlaneId { get; set; }
        public PlaneType PlaneType { get; set; }

        public ICollection<Flight> flights { get; set; }

        /*
        public Plane()
        {
        }
        public Plane(PlaneType pt, int capacity, DateTime date)
        {
            this.PlaneType = pt;
            this.capacity = capacity;
            this.ManufactureDate = date;
        }*/



        public override string ToString() { 
            return "PlaneId: " + PlaneId + " ManufactureDate: " + ManufactureDate + " PlaneType: " + PlaneType + " Capacity: " + capacity;
        }


    }

    public enum PlaneType { Boing , Airbus  }

}
