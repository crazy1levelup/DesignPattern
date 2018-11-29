using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class HeroBuilder : IVehicleBuilder
    {
        Vehicle objVehicle = new Vehicle();

        public void SetAccessories()
        {
            objVehicle.Accessories.Add("Seat Cover");
            objVehicle.Accessories.Add("Rear Mirror");
        }

        public void SetBody()
        {
            objVehicle.Body = "Plastic";
        }

        public void SetEngine()
        {
            objVehicle.Engine = "4 Stroke";
        }

        public void SetModel()
        {
            objVehicle.Model = "Hero";
        }

        public void SetTransmission()
        {
            objVehicle.Transmission = "120km/h"; 
        }

        public Vehicle GetVehicle()
        {
            return objVehicle;
        }
    }
}
