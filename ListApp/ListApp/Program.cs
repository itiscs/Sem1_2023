bool IsOrdered(List<int> lst)
{
    //bool fl = true;
    for(int i=0; i < lst.Count - 1; i++)
    {
        if (lst[i] > lst[i+1])
            return false;
    }
    return true;

}



List<int> lst = new List<int>();





int[] mas = new int[20];

lst.Add(5);
lst.Add(12);
lst.Add(11);
lst.Add(45);

lst.Add(67);

Console.WriteLine(IsOrdered(lst));

Console.WriteLine($"Count - {lst.Count}   Cap - {lst.Capacity}");

foreach (var item in lst)
{
    Console.WriteLine(item);
}




