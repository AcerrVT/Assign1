using System;
using System.Collections.Generic;
using System.Text;

namespace Assign1
{
    internal class Motorcycle : Vehicle
    {
        internal bool HasSideCar;
        internal Motorcycle(string Brand, string Model, int Year, bool HasSideCar) : base(Brand, Model, Year)
        {
            this.HasSideCar = HasSideCar;
        }
    }

}
