using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritence
{
    public class FourWheeler : Vehicle, IInteriorDesign
    {
        int numberOfSeat;
        int numberOfGear;
        int numberOfDoor;

        public FourWheeler(string modelNo, int yearMake, int engineCapacity, VehicleType type, int numberOfSeat, int numberOfGear, int numberOfDoor) : base(modelNo, yearMake, engineCapacity, type)
        {
            this.numberOfSeat=numberOfSeat;
            this.numberOfGear=numberOfGear;
            this.NumberOfDoor=numberOfDoor;
        }

        public int NumberOfSeat { get => numberOfSeat; set => numberOfSeat = value; }
        public int NumberOfGear { get => numberOfGear; set => numberOfGear = value; }
        public int NumberOfDoor { get => numberOfDoor; set => numberOfDoor=value; }
        public override string ModelNo { get; set; }
        public override int YearMake { get; set; }
        public override int EngineCapacity { get; set; }
        public override VehicleType Type1 { get; set; }

        public override void GetDetails()
        {
            Console.WriteLine("the method overridden");
        }

        public virtual void GetVirtualData()
        {
            Console.WriteLine("This is first implementation of this method");
        }

        public string[] InteriorDesign(string design)
        {
            string[] myArray = design.Split(',');
            return myArray;
        }
    }
}
