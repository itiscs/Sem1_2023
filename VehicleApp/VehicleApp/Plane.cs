using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleApp
{
    public class Plane:Vehicle
    {
        public string CityFrom { get; set; }
        public string CityTo { get; set; }

        public Plane(string cFrom, string cTo, int maxSpeed,
            int curSpeed):base(curSpeed,maxSpeed)
        {
            CityFrom = cFrom;
            CityTo = cTo;
        }


        public override void SpeedDown()
        {
            throw new NotImplementedException();
        }

        public override void SpeedUp()
        {
            throw new NotImplementedException(); 
        }

        public override string ToString()
        {
            return "";
        }
    }
}
