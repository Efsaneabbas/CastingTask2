using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CastingTask
{
     public  class Car:Vehicle 
     {
        public int PassengerCapacity { get; set; }

        public override void ShowInfo()
        {
            base.ShowInfo();
            
        }
     }
}
