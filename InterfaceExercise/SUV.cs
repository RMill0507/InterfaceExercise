using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal class SUV : ICompany, IVehicle
    {
        public SUV()
        {

        }
        public int SeatSpace { get; set; }  
        public bool GoodForRoadTrips { get; set; }
        public string Logo { get; set; }
        public bool isUSA { get; set; }
        public bool HasHeadLights { get; set; }
        public int Tires { get; set; }
        public string color { get; set; }
        public bool IsRunning { get; set; }
    }

}
