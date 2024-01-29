using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    internal class Passenger
    {
        public DateTime BirthDate { get; set; }
        public string PassportNumber { get; set; }
        public string EmailAddress { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string TelNumber { get; set; }

        ICollection<Plane> planes { get; set; }

        public override string ToString()
        {
            return "BirthDate: " + BirthDate + " PassportNumber: " + PassportNumber + " EmailAddress: " + EmailAddress + " FirstName: " + FirstName + " LastName: " + LastName + " TelNumber: " + TelNumber;
        }
        

    }
}
