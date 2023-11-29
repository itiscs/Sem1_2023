namespace FraqApp
{

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

            //Fraq.Procent = 8;

            //f1 = f;

            //Console.WriteLine(f);

            var f4 = f + f1;
            
            Console.WriteLine(f.FraqToString());
            Console.WriteLine(f1);
            Console.WriteLine(f2);
            Console.WriteLine(f4);
            f1++;
            Console.WriteLine(3 + f1);

            Console.WriteLine(f1);

            Console.WriteLine(new Fraq(2,3) < new Fraq(3,4));

        }
    }
}
