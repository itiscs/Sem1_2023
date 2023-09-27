var x = 2.5; //double.Parse(Console.ReadLine());

double s = 0;
double m = 1;// x^k
double l = 1;// k!



for(int k = 1; k < 50; k++)
{
    s = s + (m / l);
    m = m * x;
    l = l * k;
}

Math.C

//Math.Sinh(x)
Console.WriteLine(s);

Console.WriteLine(Math.Exp(x));
