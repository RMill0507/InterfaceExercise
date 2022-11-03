using System;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany

            //Create 3 classes called Car , Truck , & SUV

            //In your IVehicle
            
                /* Create 4 members that Car, Truck, & SUV all have in common.
                 * Example: All vehicles have a number of wheels... for now..
                 */
            

            //In ICompany
            
                /*Create 2 members that are specific to each every company
                 * regardless of vehicle type.
                 *
                 *
                 * Example: public string Logo { get; set; }
                 */

            //In each of your car, truck, and suv classes

                /*Create 2 members that are specific to each class
                 * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
                 *
                 * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
                 * 
                 */

            //Now, create objects of your 3 classes and give their members values;
            //Creatively display and organize their values
            var myCar = new Car();
            myCar.color = "black";
            myCar.Logo = "Chevy Logo";
            myCar.SeatCap = 5;
            myCar.Tires = 5;
            myCar.TrunkSize = 16;
            myCar.isUSA = true;
            myCar.HasHeadLights = true;
            myCar.IsRunning = true;
            Console.WriteLine($"The color of my car is {myCar.color}.");
            Console.WriteLine($"It has the {myCar.Logo}.");
            Console.WriteLine($"It has {myCar.Tires} tires and a trunk size of {myCar.TrunkSize} cubic feet");
            Console.WriteLine($"It can seat up to {myCar.SeatCap} passengers");
            Console.WriteLine($"Made in USA: {myCar.isUSA}");
            Console.WriteLine($"Has headlights: {myCar.HasHeadLights}");
            Console.WriteLine($"Does it run: {myCar.IsRunning}");
            Console.WriteLine();
            
            var myTruck = new Truck();
            myTruck.HasHeadLights = true;
            myTruck.Logo = "Chevy Logo";
            myTruck.Tires = 5;
            myTruck.color = "blue";
            myTruck.BedLength = 6;
            myTruck.IsRunning = true;
            myTruck.TowCap = 9;
            myTruck.isUSA = true;
            Console.WriteLine($"The color of my truck is {myTruck.color}.");
            Console.WriteLine($"It has the {myTruck.Logo}.");
            Console.WriteLine($"It has {myTruck.Tires} tires and a bed length of {myTruck.BedLength} feet");
            Console.WriteLine($"It can tow up to {myTruck.TowCap} thousand pounds");
            Console.WriteLine($"Made in USA: {myTruck.isUSA}");
            Console.WriteLine($"Has headlights: {myTruck.HasHeadLights}");
            Console.WriteLine($"Does it run: {myTruck.IsRunning}");
            Console.WriteLine();
            var mySUV = new SUV();
            mySUV.isUSA = false;
            mySUV.color = "white";
            mySUV.Logo = "Nissian logo";
            mySUV.SeatSpace = 7;
            mySUV.IsRunning = true;
            mySUV.GoodForRoadTrips = true;
            mySUV.HasHeadLights = true;
            mySUV.Tires = 5;
            Console.WriteLine($"The color of my SUV is {mySUV.color}.");
            Console.WriteLine($"It has the {mySUV.Logo}.");
            Console.WriteLine($"It has {mySUV.Tires} tires and has a seat space of {mySUV.SeatSpace} passengers");
            Console.WriteLine($"Good for roadtrips?: {mySUV.GoodForRoadTrips}");
            Console.WriteLine($"Made in USA: {mySUV.isUSA}");
            Console.WriteLine($"Has headlights: {mySUV.HasHeadLights}");
            Console.WriteLine($"Does it run: {mySUV.IsRunning}");







        }
    }
}
