namespace FraqApp
{

    public class Fraq
    {
        //поля
        private int chis;
        private int znam;

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

        //конструкторы
        public Fraq(int ch, int zn)
        {
            CheckZero(zn);
            chis = ch;
            znam = zn;
        }
        public Fraq(int ch):this(ch,1)
        {
            //chis = ch;
            //znam = 1;
        }
        public Fraq():this(0,1)
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
            if(znam == 1)
                return $"{chis}";

            return $"{chis}/{znam}";
        }

    }




    internal class Program
    {
        static void Main(string[] args)
        {
            Fraq f = new Fraq(5,7);
            Fraq f1 = new Fraq(-4);
            Fraq f2 = new Fraq();

            //f.SetChisl(5);
            //f.SetZnam(8);
            f.Chis = f.Chis + 9;
            f.Znam = 8;

            //f1 = f;

            //Console.WriteLine(f);

            Console.WriteLine(f.FraqToString());
            Console.WriteLine(f1.FraqToString());
            Console.WriteLine(f2.FraqToString());

        }
    }
}
