﻿Random r = new Random();
int n = 10;
int[] arr = new int[n];

int[] b = {-10, 8, 2, 8, 4, 5, 8, 7, 8 };

for(int i =0; i < b.Length; i++)
{
    Console.WriteLine($"b[{i}] = {b[i]}");
}


arr[1] = 67;


for (int i = 0; i < n; i++)
{
    //   arr[i] = int.Parse(Console.ReadLine());
    arr[i] = r.Next(-100,100);
    Console.WriteLine($"arr[{i}] = {arr[i]}");
}


int count = 0, sum = 0, positsum = 0;
int max = int.MinValue;
//max = arr[0];
//Console.WriteLine(int.MinValue);


bool exPos = false;
bool allPos = true;



for (int i = 0; i < n; i++)
{
    if (arr[i] > 0)
        exPos = true;
    
    if (arr[i] < 0)
        allPos = false;


    if (arr[i] > max)
        max = arr[i];

    sum += arr[i];
    if (arr[i] > 0)
    {
        count++;
        positsum += arr[i];
    }
}

Console.WriteLine(count);

Console.WriteLine($"sum = {sum}");

Console.WriteLine($"sred = {sum/n}");

Console.WriteLine($"sred posit = {positsum / count}");

Console.WriteLine($"max = {max}");



