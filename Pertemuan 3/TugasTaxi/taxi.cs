using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TugasTaxi
{
    public class taxi
    {
        public String DriverName { get; set; }
        public bool onDuty { get; set; }
        public int NumPassenger { get; set; }

        public void TaxiInfo()
        {
            String duty;
            if (onDuty)
            {
                duty = "Yess";
            }
            else
            {
                duty = "No";
            }

            Console.WriteLine("Driver Name\t\t: {0}", DriverName);
            Console.WriteLine("Status OnDuty\t\t: {0}", duty);
            Console.WriteLine("Number of Passenger\t: {0}", NumPassenger);
        }

        public void PickUpPassenger()
        {
            Console.WriteLine("{0} In Order", DriverName);
        }
        public void DropOffPassenger()
        {
            Console.WriteLine("{0} Out of Order", DriverName);
        }
    }
}
