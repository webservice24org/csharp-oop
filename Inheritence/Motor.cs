using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritence
{
    internal sealed class Motor : TwoWheeler
    {
        int MaximumPowerBPH;
        int MaximumTorqueNM;
        int MileageKMPL;
        string Cooling;

        public Motor(string modelNo, int yearMake, int engineCapacity, VehicleType type, int numberOfGear, string startingMethod, string frontBrake, string rearBrake, int maximumPowerBPH, int maximumTorqueNM, int mileageKMPL, string cooling) : base(modelNo, yearMake, engineCapacity, type, numberOfGear, startingMethod, frontBrake, rearBrake)
        {
            this.MaximumPowerBPH1=maximumPowerBPH;
            this.MaximumTorqueNM1=maximumTorqueNM;
            this.MileageKMPL1=mileageKMPL;
            this.Cooling1=cooling;
        }

        public int MaximumPowerBPH1 { get => MaximumPowerBPH; set => MaximumPowerBPH = value; }
        public int MaximumTorqueNM1 { get => MaximumTorqueNM; set => MaximumTorqueNM = value; }
        public int MileageKMPL1 { get => MileageKMPL; set => MileageKMPL = value; }
        public string Cooling1 { get => Cooling; set => Cooling=value; }

        public override void GetDetails()
        {
            Console.WriteLine($"Model No: {ModelNo}\n Year Make: {YearMake}\n Engine Capacity: {EngineCapacity}\n Vehicle Type: {Type1}\n Number Of Gear: {NumberOfGear}\n Starting Method: {StartingMethod}\n Front Break: {FrontBrake}\n Rear Breake: {RearBrake}\n Maximum Power: {MaximumPowerBPH1}\n Maximum Torque {MaximumTorqueNM}\n Mileage: {MileageKMPL1}\n Cooling: {Cooling1}");
        }
    }
}
