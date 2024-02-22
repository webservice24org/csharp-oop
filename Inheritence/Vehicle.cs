using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritence
{
    public abstract class Vehicle
    {
        string modelNo;
        int yearMake;
        int engineCapacity;
        VehicleType Type;

        public Vehicle() { }

        public Vehicle(string modelNo, int yearMake, int engineCapacity, VehicleType type)
        {
            this.ModelNo = modelNo;
            this.YearMake = yearMake;
            this.EngineCapacity = engineCapacity;
            Type1 = type;
        }

        public abstract string ModelNo { get; set; }
        public abstract int YearMake { get; set; }
        public abstract int EngineCapacity { get; set; }
        public abstract VehicleType Type1 { get; set; }

        public abstract void GetDetails();
    }
}
