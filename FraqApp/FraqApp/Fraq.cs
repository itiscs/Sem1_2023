using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace FraqApp
{
    public class Fraq
    {
        //поля
        private int chis;
        private int znam;

        private static int procent;

        //свойства

        public int Chis
        {
            get { return chis; }
            set { chis = value; }
        }

        public int Znam
        {
            get { return znam; }
            set
            {
                CheckZero(value);
                znam = value;
            }
        }

        public static int Procent
        {
            get { return procent; }
            set { procent = value; }
        }

        //конструкторы
        public Fraq(int ch, int zn)
        {
            CheckZero(zn);
            chis = ch;
            znam = zn;
        }
        public Fraq(int ch) : this(ch, 1)
        {
            //chis = ch;
            //znam = 1;
        }
        public Fraq() : this(0, 1)
        {
            //chis = 0;
            //znam = 1;
        }


       
        // методы

        private void CheckZero(int k)
        {
            if (k == 0)
                throw new ArgumentException("Нельзя делить на ноль");
        }

        public int GetChisl()
        {
            return chis;
        }
        public int GetZnam()
        {
            return znam;
        }

        public void SetChisl(int ch)
        {
            chis = ch;
        }
        public void SetZnam(int zn)
        {
            //if (zn == 0)
            //    throw new ArgumentException("Нельзя делить на ноль");
            CheckZero(zn);
            znam = zn;
        }


        public string FraqToString()
        {
            if (znam == 1)
                return $"{chis}";

            return $"{chis}/{znam}";
        }

        public override string ToString()
        {
            if (znam == 1)
                return $"{chis}";

            return $"{chis}/{znam}";
        }


        public static Fraq operator+(Fraq f1, Fraq f2)
        {
            return new Fraq(f1.Chis * f2.Znam + f2.Chis * f1.Znam, 
                f1.Znam * f2.Znam);
        }

        public static Fraq operator +(Fraq f1, int a)
        {
            return new Fraq(f1.Chis + a * f1.Znam, f1.Znam);
        }
        public static Fraq operator +(int a, Fraq f1)
        {
            return f1 + a;
        }

        public static Fraq operator++(Fraq f)
        {
            return new Fraq(f.Chis+f.Znam,f.Znam);
        }

        public static bool operator>(Fraq f1, Fraq f2)
        {

            return f1.Chis*f2.Znam > f2.Chis*f1.Znam;
        }

        public static bool operator <(Fraq f1, Fraq f2)
        {
            return f1.Chis * f2.Znam < f2.Chis * f1.Znam;
        }

       


    }
}
