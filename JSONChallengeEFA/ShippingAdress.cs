using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSONChallengeEFA
{
    public class ShippingAdress
    {
        public string AdressLine1 { get; set; }
        public string AdressLine2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int Zip { get; set; }

        public ShippingAdress() { }

        public ShippingAdress(string adressLine1, string adressLine2, string city, string state, int zip)
        {
            AdressLine1 = adressLine1;
            AdressLine2 = adressLine2;
            City = city;
            State = state;
            Zip = zip;
        }
    }
}
