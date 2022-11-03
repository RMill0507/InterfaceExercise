using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal class Car : ICompany, IVehicle
    {
        public Car()
        {

        }
        public int TrunkSize { get; set; }
        public int SeatCap { get; set; }
        public string Logo { get; set; }
        public bool isUSA { get; set; }
        public bool HasHeadLights { get; set; }
        public int Tires { get; set; }
        public string color { get; set; }
        public bool IsRunning { get; set; }
    }

}
