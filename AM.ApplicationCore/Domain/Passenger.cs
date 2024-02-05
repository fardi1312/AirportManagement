using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Passenger
    {
        public DateTime BirthDate { get; set; }
        public string PassportNumber { get; set; }
        public string EmailAddress { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string TelNumber { get; set; }

        public ICollection<Flight> flights { get; set; }

        public override string ToString()
        {
            return "BirthDate: " + BirthDate + " PassportNumber: " + PassportNumber + " EmailAddress: " + EmailAddress + " FirstName: " + FirstName + " LastName: " + LastName + " TelNumber: " + TelNumber;
        }
       /* public bool CheckProfile(string FirstName, string LastName)
        {
            return (this.FirstName == FirstName && this.LastName == LastName);
        }

        public bool CheckProfile(string FirstName, string LastName, string email)
        {
            return (this.FirstName == FirstName && this.LastName == LastName && this.EmailAddress == email);
     
        }*/

        public bool CheckProfile(string FirstName, string LastName, string? email = null)
        {
            return (this.FirstName == FirstName && this.LastName == LastName && (email == null || this.EmailAddress == email));
        }

        public void PassengerType()
        {
            Console.WriteLine("I am a passenger");
        }



    }
}
