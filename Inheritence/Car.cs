using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritence
{
    internal sealed class Car : FourWheeler
    {
        public Car(string modelNo, int yearMake, int engineCapacity, VehicleType type, int numberOfSeat, int numberOfGear, int numberOfDoor) : base(modelNo, yearMake, engineCapacity, type, numberOfSeat, numberOfGear, numberOfDoor)
        {
        }

        public override void GetDetails()
        {
            Console.WriteLine(value: $"Model No: {ModelNo}\n Year Make: {YearMake}\n Engine Capacity: {EngineCapacity}\n Vehicle Type: {Type1}\n Total Seat: {NumberOfSeat}\n Number Of Gear: {NumberOfGear} \n Number OfDoor: {NumberOfDoor}");
        }
    }
}
