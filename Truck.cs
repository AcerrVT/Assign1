using System;
using System.Collections.Generic;
using System.Text;

namespace Assign1
{
    internal class Truck : Vehicle
    {
        internal double LoadCapacity;
        internal Truck(string Brand, string Model, int Year, double LoadCapacity) : base(Brand, Model, Year)
        {
            this.LoadCapacity = LoadCapacity;
        }
    }

}
