using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CastingTask
{
     public class Vehicle
    {
        public string Marka { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

         
        public virtual string ShowInfo()
        {
            Console.WriteLine($"Marka:{Marka }\n + $Model:{Model}\n + $Year: {Year}");       
        }
    }
}
