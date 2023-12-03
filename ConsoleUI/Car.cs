using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public class Car : Vehicle
    {
        public Car() { }
        
        public bool HasTruck { get; set; }
        
        public override void DriveAbstract()
        {
            Console.WriteLine("This car is currently in drive");
        }
    }

    
}
