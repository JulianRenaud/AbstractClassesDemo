using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    internal class Motorcycle : Vehicle
    {


        public bool HasStorageBasket { get; set; }
        

        public override void DriveAbstract()
        {
            Console.WriteLine("Im cool with sunglasses riding on my dream bike....");
        }
        public virtual void DriveVirtual()
        {
            Console.WriteLine("I be biking to the end of the road...");
        }
    }
}
