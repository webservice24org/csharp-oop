using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                DoTask();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadLine();
            }
        }

        private static void DoTask()
        {
            BuildCar();
            BuildMotor();
        }

        private static void BuildMotor()
        {
            Console.WriteLine();
            Console.WriteLine("This is Details of MotorCycle");
            Motor motor = new Motor("Mh-0934", 2011, 400, VehicleType.twoWheeler, 4, "Bhroom Bhroom....", "Yes", "No", 800, 150, 360, "Air");   
            motor.GetDetails();

            string design = "Sporty, Aggressive, Sleek";
            string[] designs = motor.ExteriorDesign(design);

            Console.WriteLine("Exterior Designs:");
            for (int i = 0; i < designs.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {designs[i].Trim()}");
            }
            
        }

        private static void BuildCar()
        {

            Console.WriteLine("This is Details of Car");
            Car car = new Car("Bhm-2345", 2002, 2000, VehicleType.fourWheeler, 8, 5, 3);
            car.GetDetails();

            string carDesign = "Luxury cover, AC, Window";
            string[] carDesigns = car.InteriorDesign(carDesign);
            Console.WriteLine("Car's Interior Designs:");
            for (int x = 0; x < carDesigns.Length; x++)
            {
                Console.WriteLine($"{x + 1}. {carDesigns[x].Trim()}");
            }



        }
    }
}
