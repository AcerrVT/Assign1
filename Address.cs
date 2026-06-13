using System;
using System.Collections.Generic;
using System.Text;

namespace Assign1
{
    internal class Address
    {
        // Atributes
        internal string Street;
        internal string City;
        internal string PostalCode;

        // Constructor
        internal Address(string street, string city, string postalcode)
        {
            this.Street = street;
            this.City = city;
            this.PostalCode = postalcode;
        }

        public override string ToString()
        {
            return $"{Street}, {City}, {PostalCode}";
        }
    }

}
