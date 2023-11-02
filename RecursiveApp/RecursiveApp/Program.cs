int Fact(int k)
{
    if (k == 0)
        return 1;

    return k * Fact(k - 1);
}

long Fibb(long k)
{
    if (k < 3)
        return 1;

    return Fibb(k-2) + Fibb(k - 1);
}


void PrintMas(int[] arr, int k)
{
    if (k >= arr.Length)
        return;

    Console.WriteLine(arr[k]);

    PrintMas(arr, k + 1);
}


Fact(10);

int[] a = new int[] { 1,2,3,4,5,6,7,8,9};

PrintMas(a, 0);

Console.WriteLine(Fibb(4));
