using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CastingTask
{
     public class Truck:Vehicle 
     {
        public int  CarryingCapacity { get; set; }

        public override string ShowInfo()

        {
            base.ShowInfo();
            Console.WriteLiine($"CarryingCapacity:{CarryingCapacity}");

        }
     }
}
