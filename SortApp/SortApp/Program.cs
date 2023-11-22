void MergeSortRec(int[] arr, int k, int l)
{
    if (k >= l)
        return;

    int m = (k + l) / 2;
    MergeSortRec(arr, k, m);
    MergeSortRec(arr, m + 1, l);

    var temp = new int[l-k+1];

    int i1 = k, i2 = m + 1, i = 0;
    while(i1 <= m && i2 <= l)
    { 
        if(arr[i1] < arr[i2])
            temp[i++] = arr[i1++];
        else
            temp[i++] = arr[i2++];
    }
    if (i1 > m)
        for (i1 = i2; i1 <= l; i1++)
            temp[i++] = arr[i1];
    else
        for (i2 = i1; i2 <= m; i2++)
            temp[i++] = arr[i2];

    for(i=0; i < temp.Length; i++)
    { 
        arr[k+i] = temp[i];
    }


    //   Console.WriteLine($"{k} {m} {l}");
}


void MergeSort(int[] arr)
{
    MergeSortRec(arr, 0, arr.Length - 1);
}



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
MergeSort(a);
//BubbleSort(a);
PrintArr(a);
Console.WriteLine(CheckSort(a));