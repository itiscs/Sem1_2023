using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleApp
{
    abstract public class Vehicle
    {
        public int MaxSpeed { get; set; }
        public int CurSpeed { get; set; }

        public Vehicle(int curSp, int mSp)
        {
            CurSpeed = curSp;
            MaxSpeed = mSp;
        }

        abstract public void SpeedUp();
        abstract public void SpeedDown();

    }
}
