using System;
using System.Collections.Generic;
using System.Text;

namespace Assign1
{
    internal class Car : Vehicle
    {
        internal int NumberOfDoors;

        internal Car(string Brand, string Model, int Year, int NumberOfDoors) : base(Brand, Model, Year)
        {
            this.NumberOfDoors = NumberOfDoors;
        }
    }

}
