using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class DaciaBuilder : IVehicleBuilder
    {

        Vehicle objBuilder = new Vehicle();

        public void SetAccessories()
        {
            objBuilder.Accessories.Add("MaybeBreaks");
            objBuilder.Accessories.Add("MaybeAirBags");
        }

        public void SetBody()
        {
            objBuilder.Body = "Metal";
        }

        public void SetEngine()
        {
            objBuilder.Engine = "Existent";
        }

        public void SetModel()
        {
            objBuilder.Model = "1310";
        }

        public void SetTransmission()
        {
            objBuilder.Transmission = "30km/h";
        }

        public Vehicle GetVehicle()
        {
            return objBuilder;
        }
    }
}
