using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            var vehicleCreator1 = new VehicleCreator(new HeroBuilder());
            vehicleCreator1.CreateVehicle();
            var vehicle1 = vehicleCreator1.GetVehicle();
            vehicle1.ShowInfo();

            Console.WriteLine("--------------------------------------");

            var vehicleCreator2 = new VehicleCreator(new HondaBuilder());
            vehicleCreator2.CreateVehicle();
            var vehicle2 = vehicleCreator2.GetVehicle();
            vehicle2.ShowInfo();

            Console.WriteLine("--------------------------------------");

            var vehicleCreator3 = new VehicleCreator(new DaciaBuilder());
            vehicleCreator3.CreateVehicle();
            var vehicle3 = vehicleCreator3.GetVehicle();
            vehicle3.ShowInfo();

            Console.ReadLine();
        }
    }
}
