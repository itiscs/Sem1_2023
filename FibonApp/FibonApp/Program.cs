//long f, f1, f2;

//f = f1 = f2 = 1;

//Console.WriteLine("Enter k:");
//int k = int.Parse(Console.ReadLine());

//for (int i = 2; i < k; i++)
//{
//    f = f1 + f2;
//    f2 = f1;
//    f1 = f;
//}
//Console.WriteLine(f);


double y0, y = 0, eps = 0.0000000001;

double x = double.Parse(Console.ReadLine());

if (x >= 1)
    y = x / 3;
else
    y = x;

int k = 0;
do
{
    y0 = y;// старое
    y = y0 - (y0 - x / (y0 * y0)) / 3;//новое
    k++;
    
} while (Math.Abs(y0 - y) > eps);

Console.WriteLine(y);
Console.WriteLine($"k = {k}");

