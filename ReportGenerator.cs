using System;
using System.Collections.Generic;
using System.Text;

namespace Assign1
{
    internal class ReportGenerator
    {
        internal Garage Garage;

        public ReportGenerator(Garage garage)
        {
            this.Garage = garage;
        }

        internal void GenerateGarageReport(Garage garage)
        {
            Garage.DisplayGarageInfo();
        }
    }

}
