using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CastingTask
{
    public class RentCar
    {
        Vehicle[] _vehicles = { }
        Car[] _cars = { };
        Track[] _track = { };
        public int CarLimit { get; set; }
        public int TrackLimit { get; set; }

        public void AddVehicle ( Vehicle vehicle)
        {
            if (vehicle is  Car && _cars.Length < CarLimit)
            {
                Array.Resize(ref _cars, _cars.Length + 1);
                _cars[_cars.Length - 1] = (Car) vehicle;

            }
            else if (vehicle is Track && _track.Length < TrackLimit)
            {

                Array.Resize(ref _track, _track.Length + 1);
                _track[_track.Length - 1] = (Track)vehicle;
            }
             else
             {
                Console.WriteLine( Limit ashilib );
             }
            
        }
        public void ShowAllVehicles()
        {
            foreach ( Vehicle vehicle in _vehicles )
            {
                if ( vehicle != null )
                {
                    Console.WriteLine(ShowInfo);
                }
            }

        }


    }
}
