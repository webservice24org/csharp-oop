using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritence
{
    public class TwoWheeler:Vehicle, IExteriorDesign
    {
        int numberOfGear;
        string startingMethod;
        string frontBrake;
        string rearBrake;

        public TwoWheeler(string modelNo, int yearMake, int engineCapacity, VehicleType type, int numberOfGear, string startingMethod, string frontBrake, string rearBrake) : base(modelNo, yearMake, engineCapacity, type)
        {
            this.numberOfGear=numberOfGear;
            this.startingMethod=startingMethod;
            this.frontBrake=frontBrake;
            this.rearBrake=rearBrake;
        }

        public int NumberOfGear { get => numberOfGear; set => numberOfGear = value; }
        public string StartingMethod { get => startingMethod; set => startingMethod = value; }
        public string FrontBrake { get => frontBrake; set => frontBrake = value; }
        public string RearBrake { get => rearBrake; set => rearBrake=value; }
        public override string ModelNo { get; set; }
        public override int YearMake { get; set; }
        public override int EngineCapacity { get; set; }
        public override VehicleType Type1 { get; set; }

        public string[] ExteriorDesign(string design)
        {
            string[] myArray = design.Split(',');
            return myArray;
        }

        public override void GetDetails()
        {
            Console.WriteLine("The method overridden");
        }
        public virtual void GetTwoWheelerVirtualData()
        {
            Console.WriteLine("This is first implementation of this method");
        }
    }
}
