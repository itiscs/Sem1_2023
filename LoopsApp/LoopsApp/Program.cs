int n = 5;
int i;
double x = 6, p = 1, s = 0;

//i = i + 1;
//for(i = 0; i < n; i++)
//{
//    s = s + x;
//    p = p * x;
//}

//i = 0;
//while(i<n)
//{
//    s = s + x;
//    p = p * x;
//    i++;
//}

i = 0;
do
{
    s += x;
    p = p * x;
    i++;
} while (i < n);


Console.WriteLine($"s = {s}");

Console.WriteLine($"p = {p}");

int k = 0;
int a = int.Parse( Console.ReadLine() );
int b = Math.Abs(a);

do
{
    k++;
    b /= 10;
} while (b > 0);

Console.WriteLine($"k = {k}");






