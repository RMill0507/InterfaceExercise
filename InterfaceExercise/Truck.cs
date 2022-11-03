using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal class Truck : ICompany, IVehicle
    {
        public Truck()
        {
                
        }
        public int BedLength { get; set; }
        public int TowCap { get; set; }
        public bool HasHeadLights { get; set; }
        public int Tires { get; set; }
        public string color { get; set; }
        public bool IsRunning { get; set; }
        public string Logo { get; set; }
        public bool isUSA { get; set; }
    }

}
