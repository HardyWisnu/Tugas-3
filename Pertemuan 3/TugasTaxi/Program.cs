using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TugasTaxi
{
    class Program
    {
        static void Main(String[] args)
        {
            taxi taxi = new taxi();

            taxi.DriverName = "Jono";
            taxi.onDuty = true;
            taxi.NumPassenger = 10;

            taxi.TaxiInfo();
            Console.WriteLine();
            taxi.PickUpPassenger();
            taxi.DropOffPassenger();

            Console.ReadKey();
        }
    }
}