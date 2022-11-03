using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal interface IVehicle
    {
        public bool HasHeadLights { get; set; }
        public int Tires { get; set; }    
        public string color { get; set; }   
        public bool IsRunning { get; set; } 

    }
}
