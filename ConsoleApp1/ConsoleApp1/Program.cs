int Max(ref int a, ref int b)
{
    a = 200;
    if (a < b)
        return b;

    return a;
}




void PrintMas(int[] arr)
{
    for(int i=0; i<arr.Length; i++)
    {
        Console.WriteLine(arr[i]);
    }
}


int k = 100, l = 105;

var x = Max(ref k, ref l);
Console.WriteLine($"k = {k}   l = {l}    max = {x}");



//Max(55, 56);
PrintMas(new int[]{1,2,3,4,5,6 });



//Console.WriteLine(Max(4, 7));


