

void BubbleSort(int[] arr)
{
    var size = arr.Length;
    //for(int k = size; k > 1; k--)
    //{
    //    for(int i = 0; i < k-1; i++)
    //        if (arr[i] > arr[i+1])
    //        {
    //            var t = arr[i];
    //            arr[i] = arr[i+1];
    //            arr[i+1] = t;   
    //        }
    //}

    while(true)
    {
        bool finish = true;
        for (int i = 0; i < size - 1; i++)
            if (arr[i] > arr[i + 1])
            {
                var t = arr[i];
                arr[i] = arr[i + 1];
                arr[i + 1] = t;
                finish = false;
            }

        if (finish)
            break;
    }
}

bool CheckSort(int[] arr)
{
    for(int i = 0; i < arr.Length - 1; i++)
        if (arr[i] > arr[i+1])
            return false;
    return true;
}


int[] GenerateArr(int size)
{
    Random r = new Random();
    int[] arr = new int[size];
    for(int i = 0; i < size; i++)
    {
        arr[i] = r.Next(-100,100);
    }
    return arr;
}

void PrintArr(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}


var a = GenerateArr(100);
PrintArr(a);
BubbleSort(a);
PrintArr(a);
Console.WriteLine(CheckSort(a));    