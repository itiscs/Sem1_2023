int Max(int a, int b)
{
    a = 200;
    if (a < b)
        return b;

    return a;
}


int[] GenMas(int size)
{
    Random r = new Random();
    int[] mas = new int[size];

    for (int i = 0; i < size; i++)
    {
        mas[i] = r.Next(100);
    }
    return mas;
}


void PrintMas(int[] arr)
{
    for(int i=0; i<arr.Length; i++)
    {
        Console.WriteLine(arr[i]);
    }
}

int MaxMas(int[] arr)
{
    int max = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > max)    
            max = arr[i];
    }
    return max;
}


int k = 100, l = 105;

//var x = Max(ref k, ref l);
var x = Max(k, l);

Console.WriteLine($"k = {k}   l = {l}    max = {x}");


var arr = GenMas(20);
//Max(55, 56);
PrintMas(arr);



Console.WriteLine(Max(4, 7));


