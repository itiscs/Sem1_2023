using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleApp
{
    public class Car:Vehicle
    {
        public Car(int curSp, int mSp ):base(curSp,mSp) 
        {
        }

        public override void SpeedUp()
        {
            CurSpeed += 5;
            if(CurSpeed > MaxSpeed )
                CurSpeed = MaxSpeed;    
        }

        public override void SpeedDown()
        {
            CurSpeed -= 5; 
            if(CurSpeed < 0 ) 
                CurSpeed = 0;
        }

        public override string ToString()
        {
            return $"Car: curSpeed={CurSpeed}   maxSpeed={MaxSpeed}";
        }

    }
}
